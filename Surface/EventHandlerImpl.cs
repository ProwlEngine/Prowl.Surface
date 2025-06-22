// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;

using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Wayland;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;

namespace Prowl.Surface;

/// <summary>
/// A simple icon class that contains the image representation of an icon for a window.
/// </summary>
internal abstract class EventHandler
{
    public abstract bool PollEvent(out WindowEvent windowEvent);
}
