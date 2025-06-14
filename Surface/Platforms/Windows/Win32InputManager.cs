// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.Versioning;

using Prowl.Surface.Input;
using Prowl.Surface.Threading;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("windows")]
internal class Win32InputManager : InputManager
{
    public Win32InputManager(Dispatcher dispatcher) : base(dispatcher)
    {
        PrimaryKeyboardDevice = new Win32KeyboardDevice(this);
        PrimaryMouseDevice = new Win32MouseDevice(this);
    }
    public override KeyboardDevice PrimaryKeyboardDevice { get; }
    public override MouseDevice PrimaryMouseDevice { get; }
}
