// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.Versioning;

using Prowl.Surface.Input;
using Prowl.Surface.Threading;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal class X11InputManager : InputManager
{
    public X11InputManager(Dispatcher dispatcher) : base(dispatcher)
    {
    }

    public override KeyboardDevice PrimaryKeyboardDevice => throw new System.NotImplementedException();

    public override MouseDevice PrimaryMouseDevice => throw new System.NotImplementedException();
}
