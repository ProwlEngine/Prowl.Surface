// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;

using Prowl.Surface.Events;
using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Wayland;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;

namespace Prowl.Surface;

/// <summary>
/// The Window class associated with a native Window.
/// </summary>
public abstract class Window : INativeWindow
{
    /// <summary>
    /// Gets the native handle associated to this window. This is platform dependent (see remarks).
    /// </summary>
    /// <remarks>
    /// - On Windows: This handle is a HWND.
    /// </remarks>
    public abstract IntPtr Handle { get; protected set; }

    /// <summary>
    /// Gets the kind of this window.
    /// </summary>
    public abstract WindowKind Kind { get; protected set; }

    /// <summary>
    /// Gets or sets a boolean indicating if the window has default decorations (title caption, resize grips, minimize/maximize/close buttons).
    /// </summary>
    public abstract bool Decorations { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    public abstract Color BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating that this window is enabled or disabled.
    /// </summary>
    public abstract bool Enable { get; set; }

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
    public abstract Size Size { get; set; }

    /// <summary>
    /// Gets or sets the logical client size (without the decorations).
    /// </summary>
    /// <remarks>
    /// If the window does not have decoration, the client size is equal to the <see cref="Size"/> of this window.
    /// </remarks>
    public abstract Size ClientSize { get; set; }

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
    /// Gets or sets a boolean indicating if this window can be resized.
    /// </summary>
    public abstract bool Resizeable { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window can be maximized.
    /// </summary>
    public abstract bool Maximizeable { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window can be minimized.
    /// </summary>
    public abstract bool Minimizeable { get; set; }

    /// <summary>
    /// Gets the parent window. Is not null if <see cref="Kind"/> is <see cref="WindowKind.TopLevel"/>.
    /// </summary>
    public abstract INativeWindow? Parent { get; }

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
    /// Activates this window.
    /// </summary>
    public abstract void Activate();

    /// <summary>
    /// Closes this window.
    /// </summary>
    /// <returns>If the window was successfully closed.</returns>
    public abstract bool Close();

    /// <summary>
    /// Gets or sets the logical maximum size of this window.
    /// </summary>
    public abstract SizeF MinimumSize { get; set; }

    /// <summary>
    /// Gets or sets the logical minimum size of this window.
    /// </summary>
    public abstract SizeF MaximumSize { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this window is modal or not.
    /// </summary>
    public abstract bool Modal { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if the icon of window is visible on the task bar.
    /// </summary>
    public abstract bool ShowInTaskBar { get; set; }

    /// <summary>
    /// Converts a screen position to a position within the client area of the window.
    /// </summary>
    /// <param name="position">A screen position.</param>
    /// <returns>A logical position in the client area.</returns>
    public abstract PointF ScreenToClient(Point position);

    /// <summary>
    /// Converts a logical position in the client area to a pixel position on the screen.
    /// </summary>
    /// <param name="position">A logical position in the client area.</param>
    /// <returns>The equivalent screen position.</returns>
    public abstract Point ClientToScreen(PointF position);

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

    /// <summary>
    /// Creates a window with the specified options.
    /// </summary>
    /// <param name="options">The options of the window.</param>
    /// <returns>The window created.</returns>
    /// <exception cref="PlatformNotSupportedException">If the platform is not supported.</exception>
    public static Window Create(WindowCreateOptions options)
    {
        options.Verify();

        switch (WindowPlatform.GetBestPlatform())
        {
            case PlatformType.Win32:
                return new Win32Window(options);
            case PlatformType.Wayland:
                return new WaylandWindow(options);
            case PlatformType.X11:
                return new X11Window(options);
        }

        throw new PlatformNotSupportedException();
    }

    internal void VerifyPopup()
    {
        if (Kind != WindowKind.Popup) throw new InvalidOperationException("Window is not a Popup. Expecting the window to be a Popup for this operation.");
    }

    internal void VerifyResizeable()
    {
        if (!Resizeable) throw new InvalidOperationException("Window is not resizable");
    }

    internal void VerifyTopLevel()
    {
        if (Kind != WindowKind.TopLevel) throw new InvalidOperationException("Window is not a TopLevel. Expecting the window to be a TopLevel for this operation.");
    }

    internal void CenterPositionFromBounds(Rectangle bounds)
    {
        var position = bounds.Location;
        var size = bounds.Size;

        var currentSize = Size;
        if (currentSize.IsEmpty) return;

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

    /// <summary>
    /// Indicates if there is a pending event that needs to get processed, and returns a <see cref="WindowEvent"/> with window event information.
    /// </summary>
    /// <param name="ev">Event information.</param>
    /// <returns>True if an event is avaliable, false otherwise.</returns>
    public static bool PollEvent(out WindowEvent ev) => PlatformImpl.EventHandler.PollEvent(out ev);
}
