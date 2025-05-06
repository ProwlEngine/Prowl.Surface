using System;

using Prowl.Surface.Platform;
using Prowl.Surface.Threading;

using Prowl.Vector;

using static Prowl.Surface.X11.XLib;

namespace Prowl.Surface.X11;

unsafe partial class X11Window
{
    private bool _invalidated;
    private object? glfeature = null;

    void DoPaint()
    {
        _invalidated = false;
        Paint?.Invoke(new Rect());
    }

    public void Invalidate(Rect rect)
    {
        if (_invalidated)

            return;
        _invalidated = true;
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            if (_mapped)
                DoPaint();
        });
    }

    public void ShowDialog(IWindowImpl parent)
    {
        Show(true, true);
    }

    public void SetIcon(IconBitmap? icon)
    {
        if (icon == null)
        {
            XDeleteProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON);
            return;
        }

        var data = new uint[icon.Width * icon.Height + 2];
        data[0] = (uint)icon.Width;
        data[1] = (uint)icon.Height;

        fixed (byte* iconDataPtr = icon.Data)
        fixed (uint* dataPtr = &data[2])
            Buffer.MemoryCopy(iconDataPtr, dataPtr, icon.Data.Length, icon.Data.Length);

        fixed (void* pdata = data)
            XChangeProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON,
                new IntPtr((int)Atom.XA_CARDINAL), 32, PropertyMode.Replace,
                pdata, data.Length);
    }
}
