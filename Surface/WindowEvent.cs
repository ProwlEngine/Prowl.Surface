// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface;

/// <summary>
/// The base class for all window events.
/// </summary>
public abstract record WindowEvent
{
    internal WindowEvent(WindowEventKind kind)
    {
        Kind = kind;
    }

    /// <summary>
    /// Gets the kind of this event.
    /// </summary>
    public WindowEventKind Kind { get; }

    /// <summary>
    /// Gets the window this event belongs to.
    /// </summary>
    public Window? Window { get; internal set; }
}
