// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;

namespace Prowl.Surface;

/// <summary>
/// Options for creating a window.
/// </summary>
public sealed record WindowCreateOptions
{
    /// <summary>
    /// Sets a kind of window. Default is <see cref="WindowKind.TopLevel"/>
    /// </summary>
    public WindowKind Kind { get; init; } = WindowKind.TopLevel;

    /// <summary>
    /// Sets a desired default position for the window.
    /// </summary>
    /// <remarks>
    /// If this is not set, some platform-specific position will be chosen.
    /// </remarks>
    public Point? Position { get; init; } = null;

    /// <summary>
    /// Sets a desired default size for the window.
    /// </summary>
    /// <remarks>
    /// If this is not set, some platform-specific dimensions will be used.
    /// </remarks>
    public Size? Size { get; init; } = null;

    /// <summary>
    /// Sets a minimum size for the window.
    /// </summary>
    /// <remarks>
    /// If this is not set, the window will have no minimum dimensions (aside from reserved).
    /// </remarks>
    public SizeF? MinimumSize { get; init; } = null;

    /// <summary>
    /// Sets a the maximum size for the window.
    /// </summary>
    /// <remarks>
    /// If this is not set, the window will have no maximum or will be set to the primary monitor’s dimensions by the platform.
    /// </remarks>
    public SizeF? MaximumSize { get; init; } = null;

    /// <summary>
    /// Sets the initial title of the window in the title bar. The default is "Surface Window".
    /// </summary>
    public string Title { get; init; } = "Surface Window";

    /// <summary>
    /// Sets whether the window should go fullscreen upon creation. Default is <c>false</c>.
    /// </summary>
    public WindowState WindowState { get; init; } = WindowState.Normal;

    /// <summary>
    /// Sets whether the window should be visible upon creation. Default is <c>true</c>.
    /// </summary>
    public bool Visible { get; init; } = true;

    /// <summary>
    /// Sets whether the window input should be enabled upon creation. Default is <c>true</c>
    /// </summary>
    public bool Enabled { get; init; } = true;

    /// <summary>
    /// Sets how transparent the background of the window is. Default is fully opaque <c>1</c>.
    /// </summary>
    public float Opacity { get; init; } = 1;

    /// <summary>
    /// Sets whether the window should have a border, a title bar, etc. Default is <c>true</c>.
    /// </summary>
    public bool Decorations { get; init; } = true;

    /// <summary>
    /// Sets whether the window can be maximizable. Default is <c>true</c>.
    /// </summary>
    public WindowCapabilities Capabilities { get; init; } = WindowCapabilities.All;

    /// <summary>
    /// Sets the icon of the window. The default is the default application icon.
    /// </summary>
    public Icon? Icon { get; init; } = null;

    /// <summary>
    /// Sets the native parent window handle. Required for a popup window.
    /// </summary>
    public Window? Parent { get; init; } = null;

    /// <summary>
    /// Only valid for a top level window, the window will be shown in the task bar when created. Default is <c>true</c>.
    /// </summary>
    public bool ShowInTaskBar { get; init; } = true;

    /// <summary>
    /// Sets whether drag and drop for files is supported for the window. Default is <c>false</c>.
    /// </summary>
    public bool DragDrop { get; init; } = false;

    /// <summary>
    /// Sets the window start position (default, center parent, center screen)
    /// </summary>
    public WindowStartPosition StartPosition { get; init; } = WindowStartPosition.Default;

    /// <summary>
    /// Verify options and throw an exception if an invalid setup is provided.
    /// </summary>
    public void Verify()
    {
        if ((Kind == WindowKind.Popup) && Parent is null)
        {
            throw new InvalidOperationException("Invalid options. A non TopLevel window must have a Parent window.");
        }
    }
}
