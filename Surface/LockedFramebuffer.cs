using System;

using Prowl.Vector;

namespace Prowl.Surface.Platform;

public class LockedFramebuffer : ILockedFramebuffer
{
    private readonly Action? _onDispose;

    public LockedFramebuffer(IntPtr address, PixelSize size, int rowBytes, Vector2 dpi, PixelFormat format,
        Action? onDispose)
    {
        _onDispose = onDispose;
        Address = address;
        Size = size;
        RowBytes = rowBytes;
        Dpi = dpi;
        Format = format;
    }

    public IntPtr Address { get; }
    public PixelSize Size { get; }
    public int RowBytes { get; }
    public Vector2 Dpi { get; }
    public PixelFormat Format { get; }

    public void Dispose()
    {
        _onDispose?.Invoke();
    }
}
