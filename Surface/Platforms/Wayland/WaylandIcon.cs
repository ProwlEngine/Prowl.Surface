// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Wayland;



[SupportedOSPlatform("linux")]
internal unsafe class WaylandIcon : IconImpl
{
    public override Icon GetApplicationIcon() => throw new NotImplementedException();
}
