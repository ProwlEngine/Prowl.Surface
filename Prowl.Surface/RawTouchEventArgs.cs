using Prowl.Surface.Metadata;

using Prowl.Vector;

namespace Prowl.Surface.Input.Raw;

[PrivateApi]
public class RawTouchEventArgs : RawPointerEventArgs
{
    public RawTouchEventArgs(IInputDevice device, ulong timestamp, IInputRoot root,
        RawPointerEventType type, Vector2 position, RawInputModifiers inputModifiers,
        long rawPointerId)
        : base(device, timestamp, root, type, position, inputModifiers)
    {
        RawPointerId = rawPointerId;
    }

    public RawTouchEventArgs(IInputDevice device, ulong timestamp, IInputRoot root,
        RawPointerEventType type, RawPointerPoint point, RawInputModifiers inputModifiers,
        long rawPointerId)
        : base(device, timestamp, root, type, point, inputModifiers)
    {
        RawPointerId = rawPointerId;
    }
}
