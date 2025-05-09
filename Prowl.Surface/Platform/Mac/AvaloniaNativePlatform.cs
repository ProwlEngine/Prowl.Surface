﻿using System;
using System.Runtime.InteropServices;

using Prowl.Surface.Input;
using Prowl.Surface.Mac.Interop;
using Prowl.Surface.MicroCom;
//using Prowl.Surface.OpenGL;
using Prowl.Surface.Platform;
//using Prowl.Surface.Rendering;
//using Prowl.Surface.Rendering.Composition;
#nullable enable

namespace Prowl.Surface.Native;

partial class AvaloniaNativePlatform : IWindowingPlatform
{
    private readonly IAvaloniaNativeFactory _factory;
    private AvaloniaNativePlatformOptions? _options;
    //private AvaloniaNativeGlPlatformGraphics? _platformGl;

    [DllImport("libAvaloniaNative")]
    static extern IntPtr CreateAvaloniaNative();

    internal static readonly KeyboardDevice KeyboardDevice = new KeyboardDevice();
    //internal static Compositor Compositor { get; private set; } = null!;

    public static AvaloniaNativePlatform Initialize(IntPtr factory, AvaloniaNativePlatformOptions options)
    {
        var result = new AvaloniaNativePlatform(MicroComRuntime.CreateProxyFor<IAvaloniaNativeFactory>(factory, true));
        result.DoInitialize(options);

        return result;
    }

    delegate IntPtr CreateAvaloniaNativeDelegate();

    public static AvaloniaNativePlatform Initialize(AvaloniaNativePlatformOptions options)
    {
        if (options.AvaloniaNativeLibraryPath != null)
        {
            var loader = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                (IDynLoader)new Win32Loader() :
                new UnixLoader();

            var lib = loader.LoadLibrary(options.AvaloniaNativeLibraryPath);
            var proc = loader.GetProcAddress(lib, "CreateAvaloniaNative", false);
            var d = Marshal.GetDelegateForFunctionPointer<CreateAvaloniaNativeDelegate>(proc);


            return Initialize(d(), options);
        }
        else
            return Initialize(CreateAvaloniaNative(), options);
    }

    //public void SetupApplicationMenuExporter()
    //{
    //    var exporter = new AvaloniaNativeMenuExporter(_factory);
    //}

    //public void SetupApplicationName()
    //{
    //    if (!string.IsNullOrWhiteSpace(Application.Current!.Name))
    //    {
    //        _factory.MacOptions.SetApplicationTitle(Application.Current.Name);
    //    }
    //}

    private AvaloniaNativePlatform(IAvaloniaNativeFactory factory)
    {
        _factory = factory;
    }

    class GCHandleDeallocator : NativeCallbackBase, IAvnGCHandleDeallocatorCallback
    {
        public void FreeGCHandle(IntPtr handle)
        {
            GCHandle.FromIntPtr(handle).Free();
        }
    }

    void DoInitialize(AvaloniaNativePlatformOptions options)
    {
        _options = options;

        var applicationPlatform = new AvaloniaNativeApplicationPlatform();

        var macOpts = AvaloniaLocator.Current.GetService<MacOSPlatformOptions>() ?? new MacOSPlatformOptions();

        if (_factory.MacOptions != null)
            _factory.MacOptions.SetDisableAppDelegate(macOpts.DisableAvaloniaAppDelegate ? 1 : 0);

        _factory.Initialize(new GCHandleDeallocator(), applicationPlatform);

        if (_factory.MacOptions != null)
        {
            _factory.MacOptions.SetShowInDock(macOpts.ShowInDock ? 1 : 0);
            _factory.MacOptions.SetDisableSetProcessName(macOpts.DisableSetProcessName ? 1 : 0);
        }

        //AvaloniaLocator.CurrentMutable
        //    .Bind<IDispatcherImpl>()
        //    .ToConstant(new DispatcherImpl(_factory.CreatePlatformThreadingInterface()))
        //    .Bind<ICursorFactory>().ToConstant(new CursorFactory(_factory.CreateCursorFactory()))
        //    .Bind<IPlatformIconLoader>().ToSingleton<IconLoader>()
        //    .Bind<IKeyboardDevice>().ToConstant(KeyboardDevice)
        //    .Bind<IPlatformSettings>().ToConstant(new NativePlatformSettings(_factory.CreatePlatformSettings()))
        //    .Bind<IWindowingPlatform>().ToConstant(this)
        //    .Bind<IClipboard>().ToConstant(new ClipboardImpl(_factory.CreateClipboard()))
        //    .Bind<IRenderTimer>().ToConstant(new DefaultRenderTimer(60))
        //    .Bind<IMountedVolumeInfoProvider>().ToConstant(new MacOSMountedVolumeInfoProvider())
        //    .Bind<IPlatformDragSource>().ToConstant(new AvaloniaNativeDragSource(_factory))
        //    .Bind<IPlatformLifetimeEventsImpl>().ToConstant(applicationPlatform)
        //    .Bind<INativeApplicationCommands>().ToConstant(new MacOSNativeMenuCommands(_factory.CreateApplicationCommands()));

        //var hotkeys = new PlatformHotkeyConfiguration(KeyModifiers.Meta, wholeWordTextActionModifiers: KeyModifiers.Alt);
        //hotkeys.MoveCursorToTheStartOfLine.Add(new KeyGesture(Key.Left, hotkeys.CommandModifiers));
        //hotkeys.MoveCursorToTheStartOfLineWithSelection.Add(new KeyGesture(Key.Left, hotkeys.CommandModifiers | hotkeys.SelectionModifiers));
        //hotkeys.MoveCursorToTheEndOfLine.Add(new KeyGesture(Key.Right, hotkeys.CommandModifiers));
        //hotkeys.MoveCursorToTheEndOfLineWithSelection.Add(new KeyGesture(Key.Right, hotkeys.CommandModifiers | hotkeys.SelectionModifiers));

        //AvaloniaLocator.CurrentMutable.Bind<PlatformHotkeyConfiguration>().ToConstant(hotkeys);

        //if (_options.UseGpu)
        //{
        //    try
        //    {
        //        _platformGl = new AvaloniaNativeGlPlatformGraphics(_factory.ObtainGlDisplay());
        //        AvaloniaLocator.CurrentMutable
        //            .Bind<IPlatformGraphics>().ToConstant(_platformGl);

        //    }
        //    catch (Exception)
        //    {
        //        // ignored
        //    }
        //}

        //Compositor = new Compositor(_platformGl, true);
    }

    //public ITrayIconImpl CreateTrayIcon()
    //{
    //    return new TrayIconImpl(_factory);
    //}

    //public IWindowImpl CreateWindow()
    //{
    //    return new WindowImpl(_factory, _options, _platformGl);
    //}

    public IWindowImpl CreateEmbeddableWindow()
    {
        throw new NotImplementedException();
    }
}
