// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace Prowl.Surface.Threading.Events;

/// <summary>
/// Unhandled exception event.
/// </summary>
public sealed record UnhandledExceptionEvent() : DispatcherEvent(DispatcherEventKind.UnhandledException)
{
    /// <summary>
    /// The exception for this event.
    /// </summary>
    public Exception? Exception { get; internal set; }

    /// <summary>
    /// Indicates if this evnet has been handled.
    /// </summary>
    public bool Handled { get; set; }
}
