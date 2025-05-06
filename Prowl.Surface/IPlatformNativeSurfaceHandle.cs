using Prowl.Surface.Metadata;

namespace Prowl.Surface.Platform;

[Unstable]
public interface INativePlatformHandleSurface : IPlatformHandle
{
    PixelSize Size { get; }
    double Scaling { get; }
}
