// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Wayland;


[SupportedOSPlatform("linux")]
internal unsafe class WaylandWindowSettings : WindowSettingsImpl
{
    public override WindowTheme Theme => throw new NotImplementedException();

    public override Color AccentColor => throw new NotImplementedException();

    public override Color BackgroundColor => throw new NotImplementedException();

    public override Color ForegroundColor => throw new NotImplementedException();
}
