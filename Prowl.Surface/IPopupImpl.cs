using Prowl.Surface.Controls.Primitives.PopupPositioning;
using Prowl.Surface.Metadata;

namespace Prowl.Surface.Platform;

/// <summary>
/// Defines a platform-specific popup window implementation.
/// </summary>
[Unstable]
public interface IPopupImpl : IWindowBaseImpl
{
    IPopupPositioner? PopupPositioner { get; }

    void SetWindowManagerAddShadowHint(bool enabled);
}
