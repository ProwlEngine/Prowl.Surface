
using Prowl.Surface.Metadata;

using Prowl.Vector;

namespace Prowl.Surface.Input.Raw;

[PrivateApi]
public class RawMouseWheelEventArgs : RawPointerEventArgs
{
    public RawMouseWheelEventArgs(
        IInputDevice device,
        ulong timestamp,
        IInputRoot root,
        Vector2 position,
        Vector2 delta, RawInputModifiers inputModifiers)
        : base(device, timestamp, root, RawPointerEventType.Wheel, position, inputModifiers)
    {
        Delta = delta;
    }

    public Vector2 Delta { get; private set; }
}
