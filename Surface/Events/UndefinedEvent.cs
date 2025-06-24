// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface.Events;

/// <summary>
/// This close event is triggered when a window requests to be closed. It can be used to cancel the closing event.
/// </summary>
public record UndefinedEvent() : WindowEvent(WindowEventKind.Undefined)
{
}
