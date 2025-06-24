using System;
using System.Drawing;

using Prowl.Surface.Input;

using TerraFX.Interop.Xlib;

using static Prowl.Surface.Platforms.X11.X11PlatformImpl;

namespace Prowl.Surface.Platforms.X11;


internal unsafe static class XUtility
{
    internal static Atom WmDeleteWindow = Xlib.XInternAtom(Display, "WM_DELETE_WINDOW", false);
    internal static Atom WmProtocols = Xlib.XInternAtom(Display, "WM_PROTOCOLS", false);

    internal static Atom WmIcon = Xlib.XInternAtom(Display, "_NET_WM_ICON", true);


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

        lock (Lock)
        {
            if (Xlib.XAllocColor(Display, DefaultColormap, ref xcolor) == 0)
                throw new Exception("Failed to allocate color");
        }

        return xcolor;
    }
}
