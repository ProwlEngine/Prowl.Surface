// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface;

/// <summary>
/// The kind of a window.
/// </summary>
public enum WindowKind
{
    /// <summary>
    /// A top-level window.
    /// </summary>
    TopLevel,

    /// <summary>
    /// A popup window.
    /// </summary>
    Popup,

    /// <summary>
    /// A child window of another window.
    /// </summary>
    Child,
}
