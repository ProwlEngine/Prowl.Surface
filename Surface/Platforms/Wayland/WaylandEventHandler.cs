using System;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Events;

namespace Prowl.Surface.Platforms.Wayland;


internal unsafe class WaylandEventHandler : EventHandler
{
    public override bool PollEvent(out WindowEvent windowEvent)
    {
        windowEvent = default;
        return false;
    }
}
