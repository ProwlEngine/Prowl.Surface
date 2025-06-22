using System;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Events;

namespace Prowl.Surface.Platforms.Win32;


internal unsafe class Win32EventHandler : EventHandler
{
    public override bool PollEvent(out WindowEvent windowEvent)
    {
        windowEvent = default;
        return false;
    }
}
