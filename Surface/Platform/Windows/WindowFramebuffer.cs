﻿#nullable disable

using System;

using Prowl.Surface.Platform;
using Prowl.Surface.Win32.Interop;

using Prowl.Vector;

using PixelFormat = Prowl.Surface.Platform.PixelFormat;

namespace Prowl.Surface.Win32;

internal class WindowFramebuffer : ILockedFramebuffer
{
    private readonly IntPtr _handle;
    private IUnmanagedBlob _bitmapBlob;
    private UnmanagedMethods.BITMAPINFOHEADER _bmpInfo;

    public WindowFramebuffer(IntPtr handle, PixelSize size)
    {

        if (size.Width <= 0)
            throw new ArgumentException("Width is less than zero");
        if (size.Height <= 0)
            throw new ArgumentException("Height is less than zero");
        _handle = handle;
        _bmpInfo.Init();
        _bmpInfo.biPlanes = 1;
        _bmpInfo.biBitCount = 32;
        _bmpInfo.Init();
        _bmpInfo.biWidth = size.Width;
        _bmpInfo.biHeight = -size.Height;
        _bitmapBlob = AvaloniaGlobals.GetRequiredService<IRuntimePlatform>().AllocBlob(size.Width * size.Height * 4);
    }

    ~WindowFramebuffer()
    {
        Deallocate();
    }

    public IntPtr Address => _bitmapBlob.Address;
    public int RowBytes => Size.Width * 4;
    public PixelFormat Format => PixelFormat.Bgra8888;

    public Vector2 Dpi
    {
        get
        {
            if (UnmanagedMethods.ShCoreAvailable)
            {
                uint dpix, dpiy;

                var monitor = UnmanagedMethods.MonitorFromWindow(_handle,
                    UnmanagedMethods.MONITOR.MONITOR_DEFAULTTONEAREST);

                if (UnmanagedMethods.GetDpiForMonitor(
                        monitor,
                        UnmanagedMethods.MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI,
                        out dpix,
                        out dpiy) == 0)
                {
                    return new Vector2(dpix, dpiy);
                }
            }
            return new Vector2(96, 96);
        }
    }

    public PixelSize Size => new PixelSize(_bmpInfo.biWidth, -_bmpInfo.biHeight);

    public void DrawToDevice(IntPtr hDC, int destX = 0, int destY = 0, int srcX = 0, int srcY = 0, int width = -1,
        int height = -1)
    {
        if (width == -1)
            width = Size.Width;
        if (height == -1)
            height = Size.Height;
        UnmanagedMethods.SetDIBitsToDevice(hDC, destX, destY, (uint)width, (uint)height, srcX, srcY,
            0, (uint)Size.Height, _bitmapBlob.Address, ref _bmpInfo, 0);
    }

    public bool DrawToWindow(IntPtr hWnd, int destX = 0, int destY = 0, int srcX = 0, int srcY = 0, int width = -1,
        int height = -1)
    {
        if (_bitmapBlob.IsDisposed)
            throw new ObjectDisposedException("Framebuffer");
        if (hWnd == IntPtr.Zero)
            return false;
        IntPtr hDC = UnmanagedMethods.GetDC(hWnd);
        if (hDC == IntPtr.Zero)
            return false;
        DrawToDevice(hDC, destX, destY, srcX, srcY, width, height);
        UnmanagedMethods.ReleaseDC(hWnd, hDC);
        return true;
    }

    public void Dispose()
    {
        //It's not an *actual* dispose. This call means "We are done drawing"
        DrawToWindow(_handle);
    }

    public void Deallocate() => _bitmapBlob.Dispose();
}
