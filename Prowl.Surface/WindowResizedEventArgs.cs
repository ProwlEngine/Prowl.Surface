//using Prowl.Surface.Layout;

namespace Prowl.Surface.Controls;

/// <summary>
/// Describes the reason for a <see cref="WindowBase.Resized"/> event.
/// </summary>
public enum WindowResizeReason
{
    /// <summary>
    /// The resize reason is unknown or unspecified.
    /// </summary>
    Unspecified,

    /// <summary>
    /// The resize was due to the user resizing the window, for example by dragging the
    /// window frame.
    /// </summary>
    User,

    /// <summary>
    /// The resize was initiated by the application, for example by setting one of the sizing-
    /// related properties on <see cref="Window"/> such as <see cref="Layoutable.Width"/> or
    /// <see cref="Layoutable.Height"/>.
    /// </summary>
    Application,

    /// <summary>
    /// The resize was initiated by the layout system.
    /// </summary>
    Layout,

    /// <summary>
    /// The resize was due to a change in DPI.
    /// </summary>
    DpiChange,
}
