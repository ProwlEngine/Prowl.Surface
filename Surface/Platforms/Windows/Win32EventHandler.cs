using System;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Events;

namespace Prowl.Surface.Platforms.Win32;


internal unsafe class Win32EventHandler : EventHandler
{
    internal override bool PollEvent(out WindowEvent ev) => throw new NotImplementedException();
}
