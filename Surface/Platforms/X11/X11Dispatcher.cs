// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Threading;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;

/// <summary>
/// Implementation of the Dispatcher for Windows.
/// </summary>
[SupportedOSPlatform("linux")]
internal unsafe class X11Dispatcher
{
    internal void WaitAndDispatchMessage(bool blockOnWait)
    {
        XEvent xevent = default;

        while (true)
        {
            if (blockOnWait)
                Xlib.XNextEvent(X11Globals.Display, out xevent);

            bool hasEvent = Xlib.XPending(X11Globals.Display) != 0;

            if (hasEvent || blockOnWait)
            {
                if (!blockOnWait)
                    Xlib.XNextEvent(X11Globals.Display, out xevent);

                HandleEvent(xevent);

                if (blockOnWait)
                {
                    hasEvent = Xlib.XPending(X11Globals.Display) != 0;

                    if (!hasEvent)
                        break;
                }
            }
            else
            {
                break;
            }
        }
    }


    private void HandleEvent(XEvent e)
    {
        if (e.type == XEventName.ClientMessage)
        {
            if (e.xclient.message_type == XUtility.WmProtocols && e.xclient.data.l[0] == XUtility.WmDeleteWindow)
            {
                // _createdWindows[e.xclient.window].Close();
                return;
            }
        }
    }
}
