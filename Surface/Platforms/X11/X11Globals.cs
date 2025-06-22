using System;
using System.Runtime.InteropServices;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


internal unsafe static class X11Globals
{
    private static XDisplay* s_display;

    public static XDisplay* Display
    {
        get
        {
            if (s_display == null)
                s_display = Xlib.XOpenDisplay(null);

            Xlib.XSetErrorHandler(&ErrorHandler);

            return s_display;
        }
    }


    private static XWindow s_rootWindow;

    public static XWindow RootWindow
    {
        get
        {
            if (s_rootWindow.Value == null)
                s_rootWindow = Xlib.XRootWindow(Display, Xlib.XDefaultScreen(Display));

            return s_rootWindow;
        }
    }


    private static XColormap s_defaultColormap;
    public static XColormap DefaultColormap
    {
        get
        {
            if (s_defaultColormap.Value == null)
                s_defaultColormap = Xlib.XDefaultColormap(Display, 0);

            return s_defaultColormap;
        }
    }


    public static void Shutdown()
    {
        Xlib.XCloseDisplay(Display);
    }


    [UnmanagedCallersOnly]
    internal static int ErrorHandler(XDisplay* display, XErrorEvent* errEvent)
    {
        byte* data = stackalloc byte[1024];
        Xlib.XGetErrorText(Display, errEvent->error_code, data, 1024);

        Console.WriteLine($"Error in X server: {System.Text.Encoding.UTF8.GetString(data, 1024)}.");

        return 1;
    }
}
