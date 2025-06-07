// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface.Events;

/// <summary>
/// A frame event change.
/// </summary>
public record FrameEvent() : WindowEvent(WindowEventKind.Frame)
{
    /// <summary>
    /// Gets the kind of frame event change.
    /// </summary>
    public FrameChangeKind ChangeKind { get; set; }
}
