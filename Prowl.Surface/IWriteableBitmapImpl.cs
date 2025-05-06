using Prowl.Surface.Metadata;

namespace Prowl.Surface.Platform;

/// <summary>
/// Defines the platform-specific interface for a <see cref="Avalonia.Media.Imaging.WriteableBitmap"/>.
/// </summary>
[Unstable]
public interface IWriteableBitmapImpl : IBitmapImpl, IReadableBitmapImpl
{
}
