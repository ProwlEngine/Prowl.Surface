using Prowl.Surface.Platform;

namespace Prowl.Surface.Native;

internal partial class WindowImpl
{
    public override IPopupImpl CreatePopup() =>
        _opts.OverlayPopups ? null : new PopupImpl(_factory, _opts, this);

    public void ShowDialog(IWindowImpl window)
    {
        _native.Show(true.AsComBool(), true.AsComBool());
    }

    public void SetIcon(IconBitmap? icon)
    {
        // NO OP on OSX
    }

    public void SetSystemDecorations(SystemDecorations enabled)
    {
        _native.SetDecorations((Prowl.Surface.Mac.Interop.SystemDecorations)enabled);
    }
}
