// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;

using Prowl.Surface.Events;

namespace Prowl.Surface;

/// <summary>
/// The Window class associated with a native Window.
/// </summary>
public abstract class Window : INativeWindow
{
    internal Window(WindowCreateOptions options)
    {
        if (options.Kind != WindowKind.TopLevel && options.Parent == null)
            throw new InvalidOperationException("Attempted to create a non-top level window without a parent");

        Parent = options.Parent;
    }

    /// <summary>
    /// Gets the native handle associated to this window. This is platform dependent (see remarks).
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item>
    /// <description>On Windows: This handle is a HWND.</description>
    /// </item>
    /// <item>
    /// <description>On Linux/Gdk: This handle is a Gdk Surface</description>
    /// </item>
    /// </list>
    /// </remarks>
    public abstract IntPtr Handle { get; }

    /// <summary>
    /// Gets the kind of this window.
    /// </summary>
    public abstract WindowKind Kind { get; protected set; }

    /// <summary>
    /// Gets or sets a boolean indicating if the window has default decorations (title caption, resize grips, minimize/maximize/close buttons).
    /// </summary>
    public abstract bool Decorations { get; set; }

    /// <summary>
    /// Gets or sets the DPI associated to this window.
    /// </summary>
    /// <remarks>
    /// In order to manually override the system DPI, you must set the <see cref="DpiMode"/> to manual.
    /// </remarks>
    public abstract Dpi Dpi { get; set; }

    /// <summary>
    /// Gets or sets the DPI mode. Default is auto (in sync with the OS).
    /// </summary>
    public abstract DpiMode DpiMode { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating that this window is enabled or disabled.
    /// </summary>
    public abstract bool Enabled { get; set; }

    /// <summary>
    /// Gets a boolean indicating that this Windows has been disposed.
    /// </summary>
    public abstract bool IsDisposed { get; }

    /// <summary>
    /// Gets or sets the title of this window.
    /// </summary>
    public abstract string Title { get; set; }

    /// <summary>
    /// Gets or sets the size of this window. The size is in logical value according to the <see cref="Dpi"/> of this window.
    /// </summary>
    public abstract SizeF Size { get; set; }

    /// <summary>
    /// Gets the size in pixels of this window.
    /// </summary>
    public Size SizeInPixels => Dpi.LogicalToPixel(Size);

    /// <summary>
    /// Gets or sets the logical client size (without the decorations).
    /// </summary>
    /// <remarks>
    /// If the window does not have decoration, the client size is equal to the <see cref="Size"/> of this window.
    /// </remarks>
    public abstract SizeF ClientSize { get; set; }

    /// <summary>
    /// Gets or sets the virtual position in pixels of this window.
    /// </summary>
    public abstract Point Position { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window is visible or not.
    /// </summary>
    public abstract bool Visible { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window accepts drag and drop or not.
    /// </summary>
    public abstract bool DragDrop { get; set; }

    /// <summary>
    /// Gets or sets a flags enum determining what the user can do to the window.
    /// </summary>
    public abstract WindowCapabilities Capabilities { get; set; }

    /// <summary>
    /// Gets the parent window. Is null if <see cref="Kind"/> is <see cref="WindowKind.TopLevel"/>.
    /// </summary>
    public Window? Parent { get; set; }

    /// <summary>
    /// Gets or sets the state of the window (normal, minimized, maximized, fullscreen).
    /// </summary>
    public abstract WindowState State { get; set; }

    /// <summary>
    /// Gets or sets the opacity of this window.
    /// </summary>
    public abstract float Opacity { get; set; }

    /// <summary>
    /// Gets a boolean indicating if this window is a top level window.
    /// </summary>
    public bool TopLevel => Kind == WindowKind.TopLevel;

    /// <summary>
    /// Gets or sets a boolean indicating that this window is top most.
    /// </summary>
    public abstract bool TopMost { get; set; }

    /// <summary>
    /// Brings the focus to this window.
    /// </summary>
    public abstract void Focus();

    /// <summary>
    /// Closes this window.
    /// </summary>
    /// <returns>If the window was successfully closed.</returns>
    public abstract bool Close();

    /// <summary>
    /// Gets or sets the maximum size of this window.
    /// </summary>
    public abstract Size MinimumSize { get; set; }

    /// <summary>
    /// Gets or sets the minimum size of this window.
    /// </summary>
    public abstract Size MaximumSize { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window is modal or not.
    /// </summary>
    public abstract bool Modal { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if the icon of window is visible on the task bar.
    /// </summary>
    public abstract bool ShowInTaskBar { get; set; }

    /// <summary>
    /// Gets the associated screen with this window.
    /// </summary>
    /// <returns></returns>
    public abstract Screen? GetScreen();

    /// <summary>
    /// Gets a screen associated to this window or the primary screen if no screen is associated.
    /// </summary>
    /// <returns></returns>
    public Screen? GetScreenOrPrimary() => GetScreen() ?? Screen.Primary;

    /// <summary>
    /// Centers this window according to its parent window. If this window does not have a parent, it will be centered to the screen.
    /// </summary>
    public abstract void CenterToParent();

    /// <summary>
    /// Centers this window according to the screen.
    /// </summary>
    public abstract void CenterToScreen();

    /// <summary>
    /// Sets the icon of this window.
    /// </summary>
    /// <param name="icon">The icon to set.</param>
    public abstract void SetIcon(Icon icon);

    internal void VerifyNotDisposed()
    {
        if (IsDisposed) throw new InvalidOperationException("Window has been disposed or closed.");
    }

    internal void VerifyPopup()
    {
        if (Kind != WindowKind.Popup) throw new InvalidOperationException("Window is not a Popup. Expecting the window to be a Popup for this operation.");
    }

    internal void VerifyTopLevel()
    {
        if (Kind != WindowKind.TopLevel) throw new InvalidOperationException("Window is not a TopLevel. Expecting the window to be a TopLevel for this operation.");
    }

    internal void VerifyNeedsParent()
    {
        if (Parent == null && Kind != WindowKind.TopLevel)
            throw new InvalidOperationException("Parent is required to create a non-top level window.");
    }

    internal void CenterPositionFromBounds(Rectangle bounds)
    {
        var position = bounds.Location;
        var size = bounds.Size;

        var currentSize = Dpi.LogicalToPixel(Size);
        if (currentSize.IsEmpty) return;

        var dpi = Dpi;
        bool changed = false;
        var currentPosition = Position;
        if (currentSize.Width <= size.Width)
        {
            currentPosition.X = position.X + (size.Width - currentSize.Width) / 2;
            changed = true;
        }

        if (currentSize.Height <= size.Height)
        {
            currentPosition.Y = position.Y + (size.Height - currentSize.Height) / 2;
            changed = true;
        }

        if (changed)
        {
            Position = currentPosition;
        }
    }
}
