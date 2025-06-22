using System;
using System.Drawing;

using Prowl.Surface.Input;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


internal unsafe static class XUtility
{
    internal static Atom WmDeleteWindow = Xlib.XInternAtom(X11Globals.Display, "WM_DELETE_WINDOW", false);
    internal static Atom WmProtocols = Xlib.XInternAtom(X11Globals.Display, "WM_PROTOCOLS", false);
    internal static Atom WmWindowOpacity = Xlib.XInternAtom(X11Globals.Display, "_NET_WM_WINDOW_OPACITY", false);
    internal static Atom WmIcon = Xlib.XInternAtom(X11Globals.Display, "_NET_WM_ICON", true);


    internal static XEventMask GeneralMask =
        XEventMask.KeyPressMask |
        XEventMask.KeyReleaseMask |
        XEventMask.ButtonPressMask |
        XEventMask.ButtonReleaseMask |
        XEventMask.EnterWindowMask |
        XEventMask.LeaveWindowMask |
        XEventMask.PointerMotionMask |
        XEventMask.PointerMotionHintMask |
        XEventMask.ButtonMotionMask |
        XEventMask.ExposureMask |
        XEventMask.VisibilityChangeMask |
        XEventMask.StructureNotifyMask |
        XEventMask.ResizeRedirectMask |
        XEventMask.SubstructureNotifyMask |
        XEventMask.SubstructureRedirectMask |
        XEventMask.FocusChangeMask |
        XEventMask.PropertyChangeMask |
        XEventMask.OwnerGrabButtonMask;


    internal static XColor GetColor(Color color)
    {
        // Convert to 16-bit for X11 (X uses 0–65535)
        XColor xcolor = default;
        xcolor.flags = 0x07;

        xcolor.red = color.R;
        xcolor.green = color.G;
        xcolor.blue = color.B;

        if (Xlib.XAllocColor(X11Globals.Display, X11Globals.DefaultColormap, ref xcolor) == 0)
            throw new Exception("Failed to allocate color");

        return xcolor;
    }
}
