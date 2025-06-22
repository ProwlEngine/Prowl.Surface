using System;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Events;
using Prowl.Surface.Input;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


internal unsafe class X11EventHandler : EventHandler
{
    internal static WindowEvent XEventToEvent(XEvent ev)
    {
        if (ev.type == XEventName.ClientMessage)
        {
            if (ev.xclient.message_type == XUtility.WmProtocols && ev.xclient.data.l[0] == XUtility.WmDeleteWindow)
            {
                return new CloseEvent();
            }
        }

        return null;
    }


    public override bool PollEvent(out WindowEvent windowEvent)
    {
        bool hasEvent = Xlib.XPending(X11Globals.Display) != 0;

        windowEvent = null;

        if (hasEvent)
        {
            Xlib.XNextEvent(X11Globals.Display, out XEvent xevent);
            windowEvent = XEventToEvent(xevent);
        }

        return hasEvent;
    }
}
