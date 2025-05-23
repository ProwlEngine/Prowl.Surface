﻿using System;
using System.Collections.Generic;

using Prowl.Surface.Controls;
using Prowl.Surface.Input;
using Prowl.Surface.Input.Raw;
using Prowl.Surface.Metadata;

using Prowl.Vector;

namespace Prowl.Surface.Platform;

/// <summary>
/// Defines a platform-specific top-level window implementation.
/// </summary>
/// <remarks>
/// This interface is the common interface to <see cref="IWindowImpl"/> and
/// <see cref="IPopupImpl"/>.
/// </remarks>
[Unstable]
public partial interface ITopLevelImpl : IOptionalFeatureProvider, IDisposable
{
    /// <summary>
    /// Gets the client size of the toplevel.
    /// </summary>
    Vector2 ClientSize { get; }

    /// <summary>
    /// Gets the total size of the toplevel, excluding shadows.
    /// </summary>
    Vector2? FrameSize { get; }

    /// <summary>
    /// Gets the scaling factor for the toplevel. This is used for rendering.
    /// </summary>
    double RenderScaling { get; }

    /// <summary>
    /// The list of native platform's surfaces that can be consumed by rendering subsystems.
    /// </summary>
    /// <remarks>
    /// Rendering platform will check that list and see if it can utilize one of them to output.
    /// It should be enough to expose a native window handle via IPlatformHandle
    /// and add support for framebuffer (even if it's emulated one) via IFramebufferPlatformSurface.
    /// If you have some rendering platform that's tied to your particular windowing platform,
    /// just expose some toolkit-specific object (e. g. Func&lt;Gdk.Drawable&gt; in case of GTK#+Cairo)
    /// </remarks>
    IEnumerable<object> Surfaces { get; }

    /// <summary>
    /// Gets or sets a method called when the toplevel receives input.
    /// </summary>
    Action<RawInputEventArgs>? Input { get; set; }

    /// <summary>
    /// Gets or sets a method called when the toplevel requires painting.
    /// </summary>
    Action<Rect>? Paint { get; set; }

    /// <summary>
    /// Gets or sets a method called when the toplevel is resized.
    /// </summary>
    Action<Vector2, WindowResizeReason>? Resized { get; set; }

    /// <summary>
    /// Gets or sets a method called when the toplevel's scaling changes.
    /// </summary>
    Action<double>? ScalingChanged { get; set; }

    /// <summary>
    /// Gets or sets a method called when the toplevel's TransparencyLevel changes.
    /// </summary>
    Action<WindowTransparencyLevel>? TransparencyLevelChanged { get; set; }

    ///// <summary>
    ///// Gets the compositor that's compatible with the toplevel
    ///// </summary>
    //Compositor Compositor { get; }

    /// <summary>
    /// Sets the <see cref="IInputRoot"/> for the toplevel.
    /// </summary>
    void SetInputRoot(IInputRoot inputRoot);

    /// <summary>
    /// Converts a point from screen to client coordinates.
    /// </summary>
    /// <param name="point">The point in screen coordinates.</param>
    /// <returns>The point in client coordinates.</returns>
    Vector2 PointToClient(PixelPoint point);

    /// <summary>
    /// Converts a point from client to screen coordinates.
    /// </summary>
    /// <param name="point">The point in client coordinates.</param>
    /// <returns>The point in screen coordinates.</returns>
    PixelPoint PointToScreen(Vector2 point);

    /// <summary>
    /// Sets the cursor associated with the toplevel.
    /// </summary>
    /// <param name="cursor">The cursor. Use null for default cursor</param>
    void SetCursor(ICursorImpl? cursor);

    /// <summary>
    /// Gets or sets a method called when the underlying implementation is destroyed.
    /// </summary>
    Action? Closed { get; set; }

    /// <summary>
    /// Gets or sets a method called when the input focus is lost.
    /// </summary>
    Action? LostFocus { get; set; }

    IPopupImpl? CreatePopup();

    /// <summary>
    /// Sets the <see cref="WindowTransparencyLevel"/> hint of the TopLevel.
    /// </summary>
    void SetTransparencyLevelHint(IReadOnlyList<WindowTransparencyLevel> transparencyLevels);

    /// <summary>
    /// Gets the current <see cref="WindowTransparencyLevel"/> of the TopLevel.
    /// </summary>
    WindowTransparencyLevel TransparencyLevel { get; }

    /// <summary>
    /// Sets the <see cref="PlatformThemeVariant"/> on the frame if it should be dark or light.
    /// Also applies for the mobile status bar.
    /// </summary>
    void SetFrameThemeVariant(PlatformThemeVariant themeVariant);

    /// <summary>
    /// Gets the <see cref="AcrylicPlatformCompensationLevels"/> for the platform.
    /// </summary>
    AcrylicPlatformCompensationLevels AcrylicCompensationLevels { get; }
}
