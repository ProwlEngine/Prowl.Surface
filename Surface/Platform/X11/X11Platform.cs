﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
//using Prowl.Surface.FreeDesktop;
//using Prowl.Surface.FreeDesktop.DBusIme;
using Prowl.Surface.Input;
//using Prowl.Surface.OpenGL;
//using Prowl.Surface.OpenGL.Egl;
using Prowl.Surface.Platform;
//using Prowl.Surface.Rendering;
//using Prowl.Surface.Rendering.Composition;
using Prowl.Surface.X11;
//using Prowl.Surface.X11.Glx;
using static Prowl.Surface.X11.XLib;

namespace Prowl.Surface.X11
{
    internal class AvaloniaX11Platform : IWindowingPlatform
    {
        private Lazy<KeyboardDevice> _keyboardDevice = new Lazy<KeyboardDevice>(() => new KeyboardDevice());
        public KeyboardDevice KeyboardDevice => _keyboardDevice.Value;
        public Dictionary<IntPtr, X11PlatformThreading.EventHandler> Windows =
            new Dictionary<IntPtr, X11PlatformThreading.EventHandler>();
        public XI2Manager XI2;
        public X11Info Info { get; private set; }
        public IX11Screens X11Screens { get; private set; }
        //public Compositor Compositor { get; private set; }
        public IScreenImpl Screens { get; private set; }
        public X11PlatformOptions Options { get; private set; }
        public IntPtr OrphanedWindow { get; private set; }
        public X11Globals Globals { get; private set; }
        public ManualRawEventGrouperDispatchQueue EventGrouperDispatchQueue { get; } = new();
        [DllImport("libc")]
        private static extern void setlocale(int type, string s);
        public void Initialize(X11PlatformOptions options)
        {
            Options = options;

            bool useXim = false;
            //if (EnableIme(options))
            //{
            //    // Attempt to configure DBus-based input method and check if we can fall back to XIM
            //    if (!X11DBusImeHelper.DetectAndRegister() && ShouldUseXim())
            //        useXim = true;
            //}

            // We have problems with text input otherwise
            setlocale(0, "");

            XInitThreads();
            Display = XOpenDisplay(IntPtr.Zero);
            if (Display == IntPtr.Zero)
                throw new Exception("XOpenDisplay failed");
            DeferredDisplay = XOpenDisplay(IntPtr.Zero);
            if (DeferredDisplay == IntPtr.Zero)
                throw new Exception("XOpenDisplay failed");

            OrphanedWindow = XCreateSimpleWindow(Display, XDefaultRootWindow(Display), 0, 0, 1, 1, 0, IntPtr.Zero,
                IntPtr.Zero);
            XError.Init();

            Info = new X11Info(Display, DeferredDisplay, useXim);
            Globals = new X11Globals(this);
            //TODO: log
            //if (options.UseDBusMenu)
            //    DBusHelper.TryInitialize();

            //AvaloniaLocator.CurrentMutable.BindToSelf(this)
            //    .Bind<IWindowingPlatform>().ToConstant(this)
            //    .Bind<IDispatcherImpl>().ToConstant(new X11PlatformThreading(this))
            //    .Bind<IRenderTimer>().ToConstant(new SleepLoopRenderTimer(60))
            //    .Bind<PlatformHotkeyConfiguration>().ToConstant(new PlatformHotkeyConfiguration(KeyModifiers.Control))
            //    .Bind<IKeyboardDevice>().ToFunc(() => KeyboardDevice)
            //    .Bind<ICursorFactory>().ToConstant(new X11CursorFactory(Display))
            //    .Bind<IClipboard>().ToConstant(new X11Clipboard(this))
            //    .Bind<IPlatformSettings>().ToSingleton<DBusPlatformSettings>()
            //    .Bind<IPlatformIconLoader>().ToConstant(new X11IconLoader())
            //    .Bind<IMountedVolumeInfoProvider>().ToConstant(new LinuxMountedVolumeInfoProvider())
            //    .Bind<IPlatformLifetimeEventsImpl>().ToConstant(new X11PlatformLifetimeEvents(this));

            X11Screens = X11.X11Screens.Init(this);
            Screens = new X11Screens(X11Screens);
            if (Info.XInputVersion != null)
            {
                var xi2 = new XI2Manager();
                if (xi2.Init(this))
                    XI2 = xi2;
            }

            //if (options.UseGpu)
            //{
            //    if (options.UseEGL)
            //        EglPlatformGraphics.TryInitialize();
            //    else
            //        GlxPlatformGraphics.TryInitialize(Info, Options.GlProfiles);
            //}

            //var gl = AvaloniaLocator.Current.GetService<IPlatformGraphics>();

            //Compositor = new Compositor(gl);
        }

        public IntPtr DeferredDisplay { get; set; }
        public IntPtr Display { get; set; }

        //private static uint[] X11IconConverter(IWindowIconImpl icon)
        //{
        //    if (!(icon is X11IconData x11icon))
        //        return Array.Empty<uint>();

        //    return x11icon.Data.Select(x => x.ToUInt32()).ToArray();
        //}

        //public ITrayIconImpl CreateTrayIcon()
        //{
        //    var dbusTrayIcon = new DBusTrayIconImpl();

        //    if (!dbusTrayIcon.IsActive) return new XEmbedTrayIconImpl();

        //    dbusTrayIcon.IconConverterDelegate = X11IconConverter;

        //    return dbusTrayIcon;
        //}

        public IWindowImpl CreateWindow()
        {
            return new X11Window(this, null);
        }

        public IWindowImpl CreateEmbeddableWindow()
        {
            throw new NotSupportedException();
        }

        private static bool EnableIme(X11PlatformOptions options)
        {
            // Disable if explicitly asked by user
            var avaloniaImModule = Environment.GetEnvironmentVariable("AVALONIA_IM_MODULE");
            if (avaloniaImModule == "none")
                return false;

            // Use value from options when specified
            if (options.EnableIme.HasValue)
                return options.EnableIme.Value;

            // Automatically enable for CJK locales
            var lang = Environment.GetEnvironmentVariable("LANG");
            var isCjkLocale = lang != null &&
                              (lang.Contains("zh")
                               || lang.Contains("ja")
                               || lang.Contains("vi")
                               || lang.Contains("ko"));

            return isCjkLocale;
        }

        private static bool ShouldUseXim()
        {
            // Check if we are forbidden from using IME
            if (Environment.GetEnvironmentVariable("AVALONIA_IM_MODULE") == "none"
                || Environment.GetEnvironmentVariable("GTK_IM_MODULE") == "none"
                || Environment.GetEnvironmentVariable("QT_IM_MODULE") == "none")
                return true;

            // Check if XIM is configured
            var modifiers = Environment.GetEnvironmentVariable("XMODIFIERS");
            if (modifiers == null)
                return false;
            if (modifiers.Contains("@im=none") || modifiers.Contains("@im=null"))
                return false;
            if (!modifiers.Contains("@im="))
                return false;

            // Check if we are configured to use it
            if (Environment.GetEnvironmentVariable("GTK_IM_MODULE") == "xim"
                || Environment.GetEnvironmentVariable("QT_IM_MODULE") == "xim"
                || Environment.GetEnvironmentVariable("AVALONIA_IM_MODULE") == "xim")
                return true;

            return false;
        }
    }
}

namespace Prowl.Surface
{
    /// <summary>
    /// Platform-specific options which apply to Linux.
    /// </summary>
    public class X11PlatformOptions
    {
        /// <summary>
        /// Enables native Linux EGL when set to true. The default value is false.
        /// </summary>
        public bool UseEGL { get; set; }

        /// <summary>
        /// Determines whether to use GPU for rendering in your project. The default value is true.
        /// </summary>
        public bool UseGpu { get; set; } = true;

        /// <summary>
        /// Embeds popups to the window when set to true. The default value is false.
        /// </summary>
        public bool OverlayPopups { get; set; }

        /// <summary>
        /// Enables global menu support on Linux desktop environments where it's supported (e. g. XFCE and MATE with plugin, KDE, etc).
        /// The default value is true.
        /// </summary>
        public bool UseDBusMenu { get; set; } = true;

        /// <summary>
        /// Enables DBus file picker instead of GTK.
        /// The default value is true.
        /// </summary>
        public bool UseDBusFilePicker { get; set; } = true;

        /// <summary>
        /// Determines whether to use IME.
        /// IME would be enabled by default if the current user input language is one of the following: Mandarin, Japanese, Vietnamese or Korean.
        /// </summary>
        /// <remarks>
        /// Input method editor is a component that enables users to generate characters not natively available
        /// on their input devices by using sequences of characters or mouse operations that are natively available on their input devices.
        /// </remarks>
        public bool? EnableIme { get; set; }

        /// <summary>
        /// Determines whether to enable support for the
        /// X Session Management Protocol.
        /// </summary>
        /// <remarks>
        /// X Session Management Protocol is a standard implemented on most
        /// Linux systems that uses Xorg. This enables apps to control how they
        /// can control and/or cancel the pending shutdown requested by the user.
        /// </remarks>
        public bool EnableSessionManagement { get; set; } =
            Environment.GetEnvironmentVariable("AVALONIA_X11_USE_SESSION_MANAGEMENT") != "0";

        //public IList<GlVersion> GlProfiles { get; set; } = new List<GlVersion>
        //{
        //    new GlVersion(GlProfileType.OpenGL, 4, 0),
        //    new GlVersion(GlProfileType.OpenGL, 3, 2),
        //    new GlVersion(GlProfileType.OpenGL, 3, 0),
        //    new GlVersion(GlProfileType.OpenGLES, 3, 2),
        //    new GlVersion(GlProfileType.OpenGLES, 3, 0),
        //    new GlVersion(GlProfileType.OpenGLES, 2, 0)
        //};

        public IList<string> GlxRendererBlacklist { get; set; } = new List<string>
        {
            // llvmpipe is a software GL rasterizer. If it's returned by glGetString,
            // that usually means that something in the system is horribly misconfigured
            // and sometimes attempts to use GLX might cause a segfault
            "llvmpipe"
        };


        public string WmClass { get; set; }

        /// <summary>
        /// Enables multitouch support. The default value is true.
        /// </summary>
        /// <remarks>
        /// Multitouch allows a surface (a touchpad or touchscreen) to recognize the presence of more than one point of contact with the surface at the same time.
        /// </remarks>
        public bool? EnableMultiTouch { get; set; } = true;

        public X11PlatformOptions()
        {
            try
            {
                WmClass = Assembly.GetEntryAssembly()?.GetName()?.Name;
            }
            catch
            {
                //
            }
        }
    }
    public static class AvaloniaX11PlatformExtensions
    {
        //public static AppBuilder UseX11(this AppBuilder builder)
        //{
        //    builder.UseWindowingSubsystem(() =>
        //        new AvaloniaX11Platform().Initialize(AvaloniaLocator.Current.GetService<X11PlatformOptions>() ??
        //                                             new X11PlatformOptions()));
        //    return builder;
        //}

        public static void InitializeX11Platform(X11PlatformOptions options = null) =>
            new AvaloniaX11Platform().Initialize(options ?? new X11PlatformOptions());
    }

}
