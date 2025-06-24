
using System;
using System.Runtime.InteropServices;

using Prowl.Surface.Input;

using TerraFX.Interop.Xlib;
namespace Prowl.Surface.Platforms.X11;

internal unsafe class X11PlatformImpl : PlatformImpl
{
    private static XDisplay* s_display;
    public static XDisplay* Display
    {
        get
        {
            if (s_display == null)
            {
                s_display = Xlib.XOpenDisplay(null);
                Xlib.XSetErrorHandler(&ErrorHandler);
            }

            return s_display;
        }
    }

    private static XWindow? s_rootWindow;
    public static XWindow RootWindow
    {
        get
        {
            if (s_rootWindow == null)
                s_rootWindow = Xlib.XRootWindow(Display, Xlib.XDefaultScreen(Display));

            return s_rootWindow.Value;
        }
    }

    private static XColormap? s_defaultColormap;
    public static XColormap DefaultColormap
    {
        get
        {
            if (s_defaultColormap == null)
                s_defaultColormap = Xlib.XDefaultColormap(Display, 0);

            return s_defaultColormap.Value;
        }
    }

    public static readonly object Lock = new();


    [UnmanagedCallersOnly]
    internal static int ErrorHandler(XDisplay* display, XErrorEvent* errEvent)
    {
        byte* data = stackalloc byte[1024];
        Xlib.XGetErrorText(Display, errEvent->error_code, data, 1024);

        Console.WriteLine($"Error in X server: {System.Text.Encoding.UTF8.GetString(data, 1024)}.");

        return 1;
    }


    public override nint NativeDisplayHandle { get => (nint)Display; }
    public override ScreenManager ScreenManager { get; protected set; }
    public override EventHandler EventHandler { get; protected set; }
    public override ClipboardImpl ClipboardImpl { get; protected set; }
    public override IconImpl IconImpl { get; protected set; }
    public override CursorImpl CursorImpl { get; protected set; }


    public X11PlatformImpl()
    {
        ScreenManager = new X11ScreenManager();
        EventHandler = new X11EventHandler();
        ClipboardImpl = new X11Clipboard();
        IconImpl = new X11Icon();
        CursorImpl = new X11Cursor();
    }


    public override Window CreateWindow(WindowCreateOptions options)
    {
        return new X11Window(options);
    }
}
