﻿namespace Prowl.Surface;

/// <summary>
/// Determines system decorations (title bar, border, etc) for a <see cref="Window"/>
/// </summary>
public enum SystemDecorations
{
    /// <summary>
    /// No decorations
    /// </summary>
    None = 0,

    /// <summary>
    /// Window border without titlebar
    /// </summary>
    BorderOnly = 1,

    /// <summary>
    /// Fully decorated (default)
    /// </summary>
    Full = 2
}
