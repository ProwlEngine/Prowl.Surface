// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface.Threading.Events;


/// <summary>
/// Idle dispatcher event.
/// </summary>
public sealed record IdleEvent() : DispatcherEvent(DispatcherEventKind.Idle)
{
    /// <summary>
    /// Indicates if the dispatcher should skip waiting for the next message in the event queue.
    /// </summary>
    public bool SkipWaitForNextMessage { get; set; }

    /// <summary>
    /// Indicates if this event has been handled.
    /// </summary>
    public bool Handled { get; set; }
}
