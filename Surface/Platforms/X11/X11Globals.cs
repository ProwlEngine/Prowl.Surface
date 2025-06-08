using System;

using Prowl.Surface.Input;

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


    public static void Shutdown()
    {
        Xlib.XCloseDisplay(Display);
    }
}
