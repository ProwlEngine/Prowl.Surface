using System.Collections.Generic;
using System.Linq;

using Prowl.Surface.Metadata;
using Prowl.Surface.Platform;

using Prowl.Vector;

namespace Prowl.Surface.Controls.Primitives.PopupPositioning;

/// <summary>
/// This class is used to simplify integration of IPopupImpl implementations with popup positioner
/// </summary>
[PrivateApi]
public class ManagedPopupPositionerPopupImplHelper : IManagedPopupPositionerPopup
{
    private readonly IWindowBaseImpl _parent;

    public delegate void MoveResizeDelegate(PixelPoint position, Vector2 size, double scaling);
    private readonly MoveResizeDelegate _moveResize;

    public ManagedPopupPositionerPopupImplHelper(IWindowBaseImpl parent, MoveResizeDelegate moveResize)
    {
        _parent = parent;
        _moveResize = moveResize;
    }

    public IReadOnlyList<ManagedPopupPositionerScreenInfo> Screens =>

        _parent.Screen.AllScreens
            .Select(s => new ManagedPopupPositionerScreenInfo(s.Bounds.ToRect(1), s.WorkingArea.ToRect(1)))
            .ToArray();

    public Rect ParentClientAreaScreenGeometry
    {
        get
        {
            // Popup positioner operates with abstract coordinates, but in our case they are pixel ones
            var point = _parent.PointToScreen(default);
            var size = _parent.ClientSize * Scaling;
            return new Rect(point.X, point.Y, size.x, size.y);

        }
    }

    public void MoveAndResize(Vector2 devicePoint, Vector2 virtualSize)
    {
        _moveResize(new PixelPoint((int)devicePoint.x, (int)devicePoint.y), virtualSize, _parent.RenderScaling);
    }

    public virtual double Scaling => _parent.DesktopScaling;
}
