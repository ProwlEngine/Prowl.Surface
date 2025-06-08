// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.Versioning;

using Prowl.Surface.Input;

namespace Prowl.Surface.Platforms.Wayland;


[SupportedOSPlatform("linux")]
internal class WaylandKeyboardDevice : KeyboardDevice
{
    public WaylandKeyboardDevice(InputManager manager) : base(manager)
    {
    }

    public override bool IsActive => throw new System.NotImplementedException();

    internal override KeyStates GetKeyStatesFromSystem(Key key) => throw new System.NotImplementedException();
}
