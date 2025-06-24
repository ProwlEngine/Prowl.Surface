using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Events;
using Prowl.Surface.Input;

using TerraFX.Interop.Xlib;

using static Prowl.Surface.Platforms.X11.X11PlatformImpl;

namespace Prowl.Surface.Platforms.X11;


internal unsafe class X11EventHandler : EventHandler
{
    private const int MaxBufferSize = 256;


    private static Dictionary<XWindow, X11Window> s_windowLookup = [];


    internal static void RegisterWindow(X11Window window)
    {
        s_windowLookup.Add(window._xWindow, window);
    }


    internal static void RemoveWindow(X11Window window)
    {
        s_windowLookup.Remove(window._xWindow);
    }


    internal static WindowEvent XEventToEvent(XEvent ev)
    {
        X11Window? window = s_windowLookup.GetValueOrDefault(ev.xany.window);

        if (ev.type == XEventName.ClientMessage)
        {
            if (ev.xclient.message_type == XUtility.WmProtocols && ev.xclient.data.l[0] == XUtility.WmDeleteWindow)
            {
                return new CloseEvent()
                {
                    Window = window
                };
            }
        }

        return new UndefinedEvent()
        {
            Window = window
        };
    }


    internal override bool PollEvent(out WindowEvent windowEvent)
    {
        lock (Lock)
        {
            if (Xlib.XPending(Display) != 0)
            {
                Xlib.XNextEvent(Display, out XEvent xevent);
                windowEvent = XEventToEvent(xevent);
                return true;
            }

            windowEvent = null;
            return false;
        }
    }
}
