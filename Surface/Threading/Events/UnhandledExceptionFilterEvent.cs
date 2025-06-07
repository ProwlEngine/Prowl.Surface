// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace Prowl.Surface.Threading.Events;

/// <summary>
/// Unhandled exception filter event.
/// </summary>
public sealed record UnhandledExceptionFilterEvent() : DispatcherEvent(DispatcherEventKind.UnhandledExceptionFilter)
{
    /// <summary>
    /// The exception for this event.
    /// </summary>
    public Exception? Exception { get; internal set; }

    /// <summary>
    /// Indicates if this excpetion should be caught by the dispatcher or propagated back to the render loop.
    /// </summary>
    public bool RequestCatch { get; set; }
}
