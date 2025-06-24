// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace Prowl.Surface;

/// <summary>
/// The titlebar decorations of a window.
/// </summary>
[Flags]
public enum WindowCapabilities : uint
{
    /// <summary>
    /// No capabilities.
    /// </summary>
    None = 0,

    /// <summary>
    /// All capabilities
    /// </summary>
    All = Resize | Minimize | Maximize | Move,

    /// <summary>
    /// Allow resizing.
    /// </summary>
    Resize = 1 << 0,

    /// <summary>
    /// Allow minimizing.
    /// </summary>
    Minimize = 1 << 1,

    /// <summary>
    /// Allow maximizing.
    /// </summary>
    Maximize = 1 << 2,

    /// <summary>
    /// Allow moving.
    /// </summary>
    Move = 1 << 3,

    /// <summary>
    /// Allow closing the window.
    /// </summary>
    Close = 1 << 4,
}
