using System;
using System.Collections.Generic;
using System.Drawing;

using Prowl.Surface.Win32.Interop;

namespace Prowl.Surface.Win32;

internal partial class WindowImpl
{
    public IEnumerable<object> Surfaces => new object[] { Handle, /* _gl, */ _framebuffer };

    public unsafe void SetIcon(IconBitmap? icon)
    {
        if (icon == null)
        {
            UnmanagedMethods.PostMessage(_hwnd, (int)UnmanagedMethods.WindowsMessage.WM_SETICON,
                new IntPtr((int)UnmanagedMethods.Icons.ICON_BIG), IntPtr.Zero);

            return;
        }

        using Bitmap bitmap = new Bitmap(icon.Width, icon.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, bitmap.PixelFormat);

        // copy
        fixed (byte* dataPtr = icon.Data)
            Buffer.MemoryCopy(dataPtr, (void*)data.Scan0, icon.Data.Length, icon.Data.Length);

        bitmap.UnlockBits(data);

        UnmanagedMethods.PostMessage(_hwnd, (int)UnmanagedMethods.WindowsMessage.WM_SETICON,
            new IntPtr((int)UnmanagedMethods.Icons.ICON_BIG), bitmap.GetHicon());
    }
}
