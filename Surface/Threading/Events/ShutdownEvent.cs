// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface.Threading.Events;

/// <summary>
/// Shutdown dispatcher event.
/// </summary>
public sealed record ShutdownEvent : DispatcherEvent
{
    /// <summary>
    /// Event for dispatcher shutdown start notification.
    /// </summary>
    public static readonly DispatcherEvent ShutdownStarted = new ShutdownEvent(DispatcherEventKind.ShutdownStarted);

    /// <summary>
    /// Event for dispatcher shutdown end notification.
    /// </summary>
    public static readonly DispatcherEvent ShutdownFinished = new ShutdownEvent(DispatcherEventKind.ShutdownFinished);

    internal ShutdownEvent(DispatcherEventKind kind) : base(kind)
    {
    }
}
