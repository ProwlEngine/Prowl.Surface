// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Drawing;
using System.Runtime.Versioning;

using Prowl.Surface.Input;

using TerraFX.Interop.Windows;

using static TerraFX.Interop.Windows.Windows;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("linux")]
internal sealed class WaylandMouseDevice : MouseDevice
{
    public WaylandMouseDevice(InputManager manager) : base(manager)
    {
    }

    public override Point Position { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override bool IsActive => throw new System.NotImplementedException();

    public override MouseButtonState GetButtonState(MouseButton mouseButton) => throw new System.NotImplementedException();
    public override void SetCursor(Cursor cursor) => throw new System.NotImplementedException();
}
