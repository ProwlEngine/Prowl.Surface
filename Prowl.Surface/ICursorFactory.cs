using Prowl.Surface.Input;
using Prowl.Surface.Metadata;

#nullable enable

namespace Prowl.Surface.Platform;

[PrivateApi]
public interface ICursorFactory
{
    ICursorImpl GetCursor(StandardCursorType cursorType);
    ICursorImpl CreateCursor(IBitmapImpl cursor, PixelPoint hotSpot);
}
