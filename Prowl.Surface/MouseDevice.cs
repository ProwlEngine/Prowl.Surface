using System;

using Prowl.Surface.Input.Raw;
//using Prowl.Surface.Interactivity;
using Prowl.Surface.Metadata;
//using Prowl.Surface.VisualTree;
//using Prowl.Surface.Input.GestureRecognizers;
#pragma warning disable CS0618

namespace Prowl.Surface.Input;

/// <summary>
/// Represents a mouse device.
/// </summary>
[PrivateApi]
public class MouseDevice : IMouseDevice, IDisposable
{
    //private int _clickCount;
    //private Rect _lastClickRect;
    //private ulong _lastClickTime;

    private readonly Pointer _pointer;
    private bool _disposed;
    private MouseButton _lastMouseDownButton;

    public MouseDevice(Pointer? pointer = null)
    {
        _pointer = pointer ?? new Pointer(Pointer.GetNextFreeId(), PointerType.Mouse, true);
    }

    public void ProcessRawEvent(RawInputEventArgs e)
    {
        if (!e.Handled && e is RawPointerEventArgs margs)
            ProcessRawEvent(margs);
    }

    private void LeaveWindow()
    {

    }

    public void Dispose()
    {
        _disposed = true;
        _pointer?.Dispose();
    }

    public IPointer? TryGetPointer(RawPointerEventArgs ev)
    {
        return _pointer;
    }
}
