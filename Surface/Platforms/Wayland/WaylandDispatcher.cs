// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Runtime.Versioning;
using System.Threading;

using Prowl.Surface.Input;
using Prowl.Surface.Threading;

namespace Prowl.Surface.Platforms.Wayland;


/// <summary>
/// Implementation of the Dispatcher for Wayland
/// </summary>
[SupportedOSPlatform("linux")]
internal unsafe class WaylandDispatcher : Dispatcher
{
    public WaylandDispatcher(Thread thread) : base(thread)
    {
    }

    internal override ScreenManager ScreenManager => throw new NotImplementedException();

    internal override InputManager InputManager => throw new NotImplementedException();

    internal override void CreateOrResetTimer(DispatcherTimer timer, int millis) => throw new NotImplementedException();

    internal override void DestroyTimer(DispatcherTimer timer) => throw new NotImplementedException();

    internal override void NotifyJobQueue() => throw new NotImplementedException();

    internal override void PostQuitToMessageLoop() => throw new NotImplementedException();

    internal override void ResetImpl() => throw new NotImplementedException();

    internal override void WaitAndDispatchMessage(bool blockOnWait) => throw new NotImplementedException();
}
