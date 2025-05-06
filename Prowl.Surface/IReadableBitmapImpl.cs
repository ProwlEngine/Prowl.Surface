namespace Prowl.Surface.Platform;

public interface IReadableBitmapImpl
{
    PixelFormat? Format { get; }
    ILockedFramebuffer Lock();
}
