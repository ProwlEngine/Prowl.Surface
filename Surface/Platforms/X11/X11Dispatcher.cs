// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Runtime.Versioning;
using System.Threading;

using Prowl.Surface.Input;
using Prowl.Surface.Threading;

namespace Prowl.Surface.Platforms.X11;

/// <summary>
/// Implementation of the Dispatcher for Windows.
/// </summary>
[SupportedOSPlatform("linux")]
internal unsafe class X11Dispatcher : Dispatcher
{
    public X11Dispatcher(Thread thread) : base(thread)
    {
        ScreenManager = new X11ScreenManager();
        InputManager = new X11InputManager(this);
    }


    internal override ScreenManager ScreenManager { get; }

    internal override InputManager InputManager { get; }


    internal override void CreateOrResetTimer(DispatcherTimer timer, int millis) => throw new NotImplementedException();

    internal override void DestroyTimer(DispatcherTimer timer) => throw new NotImplementedException();

    internal override void NotifyJobQueue() => throw new NotImplementedException();

    internal override void PostQuitToMessageLoop() => throw new NotImplementedException();

    internal override void ResetImpl() => throw new NotImplementedException();

    internal override void WaitAndDispatchMessage(bool blockOnWait) => throw new NotImplementedException();
}
