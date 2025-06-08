// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Drawing;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Wayland;


[SupportedOSPlatform("linux")]
internal sealed class WaylandScreen : Screen
{
    public override bool IsValid => throw new System.NotImplementedException();

    public override bool IsPrimary => throw new System.NotImplementedException();

    public override string Name => throw new System.NotImplementedException();

    public override Point Position => throw new System.NotImplementedException();

    public override Size SizeInPixels => throw new System.NotImplementedException();

    public override SizeF Size => throw new System.NotImplementedException();

    public override ref readonly Dpi Dpi => throw new System.NotImplementedException();

    public override int RefreshRate => throw new System.NotImplementedException();

    public override DisplayOrientation DisplayOrientation => throw new System.NotImplementedException();
}
