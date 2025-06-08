// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Wayland;


[SupportedOSPlatform("linux")]
internal sealed unsafe class WaylandScreenManager : ScreenManager
{
    public override ReadOnlySpan<Screen> GetAllScreens() => throw new NotImplementedException();
    public override Screen? GetPrimaryScreen() => throw new NotImplementedException();
    public override Point GetVirtualScreenPosition() => throw new NotImplementedException();
    public override Size GetVirtualScreenSizeInPixels() => throw new NotImplementedException();
    public override bool TryUpdateScreens() => throw new NotImplementedException();
}
