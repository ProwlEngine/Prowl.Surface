﻿using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using Prowl.Surface.Controls.ApplicationLifetimes;
//using Prowl.Surface.OpenGL;
using Prowl.Surface.Platform;
//using Prowl.Surface.Rendering;
//using Prowl.Surface.Rendering.Composition;
using static Prowl.Surface.Win32.Interop.UnmanagedMethods;

namespace Prowl.Surface
{
    //public static class Win32ApplicationExtensions
    //{
    //    public static AppBuilder UseWin32(this AppBuilder builder)
    //    {
    //        return builder.UseWindowingSubsystem(
    //            () => Win32.Win32Platform.Initialize(
    //                AvaloniaLocator.Current.GetService<Win32PlatformOptions>() ?? new Win32PlatformOptions()),
    //            "Win32");
    //    }
    //}

    /// <summary>
    /// Platform-specific options which apply to Windows.
    /// </summary>
    public class Win32PlatformOptions
    {
        /// <summary>
        /// Enables ANGLE for Windows. For every Windows version that is above Windows 7, the default is true otherwise it's false.
        /// </summary>
        /// <remarks>
        /// GPU rendering will not be enabled if this is set to false.
        /// </remarks>
        public bool? AllowEglInitialization { get; set; }

        /// <summary>
        /// Embeds popups to the window when set to true. The default value is false.
        /// </summary>
        public bool OverlayPopups { get; set; }

        /// <summary>
        /// Avalonia would try to use native Widows OpenGL when set to true. The default value is false.
        /// </summary>
        public bool UseWgl { get; set; }

        //public IList<GlVersion> WglProfiles { get; set; } = new List<GlVersion>
        //{
        //    new GlVersion(GlProfileType.OpenGL, 4, 0),
        //    new GlVersion(GlProfileType.OpenGL, 3, 2),
        //};

        /// <summary>
        /// Render Avalonia to a Texture inside the Windows.UI.Composition tree.
        /// This setting is true by default.
        /// </summary>
        /// <remarks>
        /// Supported on Windows 10 build 16299 and above. Ignored on other versions.
        /// This is recommended if you need to use AcrylicBlur or acrylic in your applications.
        /// </remarks>
        public bool UseWindowsUIComposition { get; set; } = true;

        /// <summary>
        /// When <see cref="UseWindowsUIComposition"/> enabled, create rounded corner blur brushes
        /// If set to null the brushes will be created using default settings (sharp corners)
        /// This can be useful when you need a rounded-corner blurred Windows 10 app, or borderless Windows 11 app
        /// </summary>
        public float? CompositionBackdropCornerRadius { get; set; }

        /// <summary>
        /// When <see cref="UseLowLatencyDxgiSwapChain"/> is active, renders Avalonia through a low-latency Dxgi Swapchain.
        /// Requires Feature Level 11_3 to be active, Windows 8.1+ Any Subversion.
        /// This is only recommended if low input latency is desirable, and there is no need for the transparency
        /// and stylings / blurrings offered by <see cref="UseWindowsUIComposition"/><br/>
        /// This is mutually exclusive with
        /// <see cref="UseWindowsUIComposition"/> which if active will override this setting.
        /// This setting is false by default.
        /// </summary>
        public bool UseLowLatencyDxgiSwapChain { get; set; }

        /// <summary>
        /// Render directly on the UI thread instead of using a dedicated render thread.
        /// Only applicable if both <see cref="UseWindowsUIComposition"/> and <see cref="UseLowLatencyDxgiSwapChain"/>
        /// are false.
        /// This setting is only recommended for interop with systems that must render on the UI thread, such as WPF.
        /// This setting is false by default.
        /// </summary>
        public bool ShouldRenderOnUIThread { get; set; }

        ///// <summary>
        ///// Provides a way to use a custom-implemented graphics context such as a custom ISkiaGpu
        ///// </summary>
        //public IPlatformGraphics? CustomPlatformGraphics { get; set; }
    }
}

namespace Prowl.Surface.Win32
{
    internal class Win32Platform : IWindowingPlatform //, IPlatformIconLoader, IPlatformLifetimeEventsImpl
    {
        private static readonly Win32Platform s_instance = new();
        private static Win32PlatformOptions? s_options;
        //private static Compositor? s_compositor;
        internal const int TIMERID_DISPATCHER = 1;

        private WndProc? _wndProcDelegate;
        private IntPtr _hwnd;
        internal Win32DispatcherImpl _dispatcher;

        public Win32Platform()
        {
            SetDpiAwareness();
            CreateMessageWindow();
            _dispatcher = new Win32DispatcherImpl(_hwnd);
        }

        internal static Win32Platform Instance => s_instance;
        internal static IPlatformSettings PlatformSettings => AvaloniaGlobals.GetRequiredService<IPlatformSettings>();

        internal IntPtr Handle => _hwnd;

        /// <summary>
        /// Gets the actual WindowsVersion. Same as the info returned from RtlGetVersion.
        /// </summary>
        public static Version WindowsVersion { get; } = RtlGetVersion();

        internal static bool UseOverlayPopups => Options.OverlayPopups;

        public static Win32PlatformOptions Options
            => s_options ?? throw new InvalidOperationException($"{nameof(Win32Platform)} hasn't been initialized");

        //internal static Compositor Compositor
        //    => s_compositor ?? throw new InvalidOperationException($"{nameof(Win32Platform)} hasn't been initialized");

        public static void Initialize()
        {
            Initialize(new Win32PlatformOptions());
        }

        public static void Initialize(Win32PlatformOptions options)
        {
            s_options = options;
            //var renderTimer = options.ShouldRenderOnUIThread ? new UiThreadRenderTimer(60) : new DefaultRenderTimer(60);

            //AvaloniaLocator.CurrentMutable
            //    .Bind<IClipboard>().ToSingleton<ClipboardImpl>()
            //    .Bind<ICursorFactory>().ToConstant(CursorFactory.Instance)
            //    .Bind<IKeyboardDevice>().ToConstant(WindowsKeyboardDevice.Instance)
            //    .Bind<IPlatformSettings>().ToSingleton<Win32PlatformSettings>()
            //    .Bind<IDispatcherImpl>().ToConstant(s_instance._dispatcher)
            //    .Bind<IRenderTimer>().ToConstant(renderTimer)
            //    .Bind<IWindowingPlatform>().ToConstant(s_instance)
            //    .Bind<PlatformHotkeyConfiguration>().ToConstant(new PlatformHotkeyConfiguration(KeyModifiers.Control)
            //    {
            //        OpenContextMenu =
            //        {
            //            // Add Shift+F10
            //            new KeyGesture(Key.F10, KeyModifiers.Shift)
            //        }
            //    })
            //    .Bind<IPlatformIconLoader>().ToConstant(s_instance)
            //    .Bind<NonPumpingLockHelper.IHelperImpl>().ToConstant(NonPumpingWaitHelperImpl.Instance)
            //    .Bind<IMountedVolumeInfoProvider>().ToConstant(new WindowsMountedVolumeInfoProvider())
            //    .Bind<IPlatformLifetimeEventsImpl>().ToConstant(s_instance);

            //var platformGraphics = options.CustomPlatformGraphics
            //                       ?? Win32GlManager.Initialize();

            //if (OleContext.Current != null)
            //    AvaloniaLocator.CurrentMutable.Bind<IPlatformDragSource>().ToSingleton<DragSource>();

            //s_compositor = new Compositor( platformGraphics);
        }

        public event EventHandler<ShutdownRequestedEventArgs>? ShutdownRequested;

        [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Using Win32 naming for consistency.")]
        private IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            if (msg == (int)WindowsMessage.WM_DISPATCH_WORK_ITEM
                && wParam.ToInt64() == Win32DispatcherImpl.SignalW
                && lParam.ToInt64() == Win32DispatcherImpl.SignalL)
                _dispatcher?.DispatchWorkItem();

            if (msg == (uint)WindowsMessage.WM_QUERYENDSESSION)
            {
                if (ShutdownRequested != null)
                {
                    var e = new ShutdownRequestedEventArgs();

                    ShutdownRequested(this, e);

                    if (e.Cancel)
                    {
                        return IntPtr.Zero;
                    }
                }
            }

            if (msg == (uint)WindowsMessage.WM_SETTINGCHANGE
                && PlatformSettings is Win32PlatformSettings win32PlatformSettings)
            {
                var changedSetting = Marshal.PtrToStringAuto(lParam);
                if (changedSetting == "ImmersiveColorSet" // dark/light mode
                    || changedSetting == "WindowsThemeElement") // high contrast mode
                {
                    win32PlatformSettings.OnColorValuesChanged();
                }
            }

            if (msg == (uint)WindowsMessage.WM_TIMER)
            {
                if (wParam == (IntPtr)TIMERID_DISPATCHER)
                    _dispatcher?.FireTimer();
            }

            //TrayIconImpl.ProcWnd(hWnd, msg, wParam, lParam);

            return DefWindowProc(hWnd, msg, wParam, lParam);
        }

        private void CreateMessageWindow()
        {
            // Ensure that the delegate doesn't get garbage collected by storing it as a field.
            _wndProcDelegate = WndProc;

            WNDCLASSEX wndClassEx = new WNDCLASSEX
            {
                cbSize = Marshal.SizeOf<WNDCLASSEX>(),
                lpfnWndProc = _wndProcDelegate,
                hInstance = GetModuleHandle(null),
                lpszClassName = "AvaloniaMessageWindow " + Guid.NewGuid(),
            };

            ushort atom = RegisterClassEx(ref wndClassEx);

            if (atom == 0)
            {
                throw new Win32Exception();
            }

            _hwnd = CreateWindowEx(0, atom, null, 0, 0, 0, 0, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);

            if (_hwnd == IntPtr.Zero)
            {
                throw new Win32Exception();
            }
        }

        //public ITrayIconImpl CreateTrayIcon ()
        //{
        //    return new TrayIconImpl();
        //}

        public IWindowImpl CreateWindow()
        {
            return new WindowImpl();
        }

        //public IWindowImpl CreateEmbeddableWindow()
        //{
        //    var embedded = new EmbeddedWindowImpl();
        //    embedded.Show(true, false);
        //    return embedded;
        //}

        //public IWindowIconImpl LoadIcon(string fileName)
        //{
        //    using (var stream = File.OpenRead(fileName))
        //    {
        //        return CreateIconImpl(stream);
        //    }
        //}

        //public IWindowIconImpl LoadIcon(Stream stream)
        //{
        //    return CreateIconImpl(stream);
        //}

        //public IWindowIconImpl LoadIcon(IBitmapImpl bitmap)
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        bitmap.Save(memoryStream);
        //        return CreateIconImpl(memoryStream);
        //    }
        //}

        //private static IconImpl CreateIconImpl(Stream stream)
        //{
        //    try
        //    {
        //        // new Icon() will work only if stream is an "ico" file.
        //        return new IconImpl(new System.Drawing.Icon(stream));
        //    }
        //    catch (ArgumentException)
        //    {
        //        // Fallback to Bitmap creation and converting into a windows icon.
        //        using var icon = new System.Drawing.Bitmap(stream);
        //        var hIcon = icon.GetHicon();
        //        return new IconImpl(System.Drawing.Icon.FromHandle(hIcon));
        //    }
        //}

        private static void SetDpiAwareness()
        {
            // Ideally we'd set DPI awareness in the manifest but this doesn't work for netcoreapp2.0
            // apps as they are actually dlls run by a console loader. Instead we have to do it in code,
            // but there are various ways to do this depending on the OS version.
            var user32 = LoadLibrary("user32.dll");
            var method = GetProcAddress(user32, nameof(SetProcessDpiAwarenessContext));

            if (method != IntPtr.Zero)
            {
                if (SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2) ||
                    SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE))
                {
                    return;
                }
            }

            var shcore = LoadLibrary("shcore.dll");
            method = GetProcAddress(shcore, nameof(SetProcessDpiAwareness));

            if (method != IntPtr.Zero)
            {
                SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE);
                return;
            }

            SetProcessDPIAware();
        }
    }
}
