using System;
using System.Collections.Generic;
using System.Linq;

using Prowl.Vector;

using Prowl.Surface.Metadata;

namespace Prowl.Surface.Controls.Primitives.PopupPositioning;

[PrivateApi]
public interface IManagedPopupPositionerPopup
{
    IReadOnlyList<ManagedPopupPositionerScreenInfo> Screens { get; }
    Rect ParentClientAreaScreenGeometry { get; }
    double Scaling { get; }
    void MoveAndResize(Vector2 devicePoint, Vector2 virtualSize);
}

[PrivateApi]
public class ManagedPopupPositionerScreenInfo
{
    public Rect Bounds { get; }
    public Rect WorkingArea { get; }

    public ManagedPopupPositionerScreenInfo(Rect bounds, Rect workingArea)
    {
        Bounds = bounds;
        WorkingArea = workingArea;
    }
}

/// <summary>
/// An <see cref="IPopupPositioner"/> implementation for platforms on which a popup can be
/// arbitrarily positioned.
/// </summary>
[PrivateApi]
public class ManagedPopupPositioner : IPopupPositioner
{
    private readonly IManagedPopupPositionerPopup _popup;

    public ManagedPopupPositioner(IManagedPopupPositionerPopup popup)
    {
        _popup = popup;
    }


    private static Vector2 GetAnchorPoint(Rect anchorRect, PopupAnchor edge)
    {
        double x, y;
        if (edge.HasAllFlags(PopupAnchor.Left))
            x = anchorRect.x;
        else if (edge.HasAllFlags(PopupAnchor.Right))
            x = anchorRect.Right;
        else
            x = anchorRect.x + anchorRect.width / 2;

        if (edge.HasAllFlags(PopupAnchor.Top))
            y = anchorRect.y;
        else if (edge.HasAllFlags(PopupAnchor.Bottom))
            y = anchorRect.Bottom;
        else
            y = anchorRect.y + anchorRect.height / 2;
        return new Vector2(x, y);
    }

    private static Vector2 Gravitate(Vector2 anchorPoint, Vector2 size, PopupGravity gravity)
    {
        double x, y;
        if (gravity.HasAllFlags(PopupGravity.Left))
            x = -size.x;
        else if (gravity.HasAllFlags(PopupGravity.Right))
            x = 0;
        else
            x = -size.x / 2;

        if (gravity.HasAllFlags(PopupGravity.Top))
            y = -size.y;
        else if (gravity.HasAllFlags(PopupGravity.Bottom))
            y = 0;
        else
            y = -size.y / 2;
        return anchorPoint + new Vector2(x, y);
    }

    public void Update(PopupPositionerParameters parameters)
    {
        var rect = Calculate(
            parameters.Size * _popup.Scaling,
            new Rect(
                parameters.AnchorRectangle.TopLeft * _popup.Scaling,
                parameters.AnchorRectangle.Size * _popup.Scaling),
            parameters.Anchor,
            parameters.Gravity,
            parameters.ConstraintAdjustment,
            parameters.Offset * _popup.Scaling);

        _popup.MoveAndResize(
            rect.Position,
            rect.Size / _popup.Scaling);
    }


    private Rect Calculate(Vector2 translatedSize,
        Rect anchorRect, PopupAnchor anchor, PopupGravity gravity,
        PopupPositionerConstraintAdjustment constraintAdjustment, Vector2 offset)
    {
        var parentGeometry = _popup.ParentClientAreaScreenGeometry;
        anchorRect.Position += parentGeometry.TopLeft;

        Rect GetBounds()
        {
            var screens = _popup.Screens;

            var targetScreen = screens.FirstOrDefault(s => s.Bounds.Contains(anchorRect.TopLeft))
                               ?? screens.FirstOrDefault(s => s.Bounds.Overlaps(anchorRect))
                               ?? screens.FirstOrDefault(s => s.Bounds.Contains(parentGeometry.TopLeft))
                               ?? screens.FirstOrDefault(s => s.Bounds.Overlaps(parentGeometry))
                               ?? screens.FirstOrDefault();

            if (targetScreen != null &&
                targetScreen.WorkingArea.width == 0 && targetScreen.WorkingArea.height == 0)
            {
                return targetScreen.Bounds;
            }

            return targetScreen?.WorkingArea
                   ?? new Rect(0, 0, double.MaxValue, double.MaxValue);
        }

        var bounds = GetBounds();

        bool FitsInBounds(Rect rc, PopupAnchor edge = PopupAnchor.AllMask)
        {
            if (edge.HasAllFlags(PopupAnchor.Left) && rc.x < bounds.x ||
                edge.HasAllFlags(PopupAnchor.Top) && rc.y < bounds.y ||
                edge.HasAllFlags(PopupAnchor.Right) && rc.Right > bounds.Right ||
                edge.HasAllFlags(PopupAnchor.Bottom) && rc.Bottom > bounds.Bottom)
            {
                return false;
            }

            return true;
        }

        static bool IsValid(in Rect rc) => rc.width > 0 && rc.height > 0;

        Rect GetUnconstrained(PopupAnchor a, PopupGravity g) =>
            new Rect(Gravitate(GetAnchorPoint(anchorRect, a), translatedSize, g) + offset, translatedSize);


        var geo = GetUnconstrained(anchor, gravity);

        // If flipping geometry and anchor is allowed and helps, use the flipped one,
        // otherwise leave it as is
        if (!FitsInBounds(geo, PopupAnchor.HorizontalMask)
            && constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.FlipX))
        {
            var flipped = GetUnconstrained(anchor.FlipX(), gravity.FlipX());
            if (FitsInBounds(flipped, PopupAnchor.HorizontalMask))
                geo.x = flipped.x;
        }

        // If sliding is allowed, try moving the rect into the bounds
        if (constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.SlideX))
        {
            geo.x = Math.Max(geo.x, bounds.x);
            if (geo.Right > bounds.Right)
                geo.x = bounds.Right - geo.width;
        }

        // Resize the rect horizontally if allowed.
        if (constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.ResizeX))
        {
            var unconstrainedRect = geo;

            if (!FitsInBounds(unconstrainedRect, PopupAnchor.Left))
            {
                unconstrainedRect.x = bounds.x;
            }

            if (!FitsInBounds(unconstrainedRect, PopupAnchor.Right))
            {
                unconstrainedRect.width = bounds.width - unconstrainedRect.x;
            }

            if (IsValid(unconstrainedRect))
            {
                geo = unconstrainedRect;
            }
        }

        // If flipping geometry and anchor is allowed and helps, use the flipped one,
        // otherwise leave it as is
        if (!FitsInBounds(geo, PopupAnchor.VerticalMask)
            && constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.FlipY))
        {
            var flipped = GetUnconstrained(anchor.FlipY(), gravity.FlipY());
            if (FitsInBounds(flipped, PopupAnchor.VerticalMask))
                geo.y = flipped.y;
        }

        // If sliding is allowed, try moving the rect into the bounds
        if (constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.SlideY))
        {
            geo.y = Math.Max(geo.y, bounds.y);
            if (geo.Bottom > bounds.Bottom)
                geo.y = bounds.Bottom - geo.height;
        }

        // Resize the rect vertically if allowed.
        if (constraintAdjustment.HasAllFlags(PopupPositionerConstraintAdjustment.ResizeY))
        {
            var unconstrainedRect = geo;

            if (!FitsInBounds(unconstrainedRect, PopupAnchor.Top))
            {
                unconstrainedRect.y = bounds.y;
            }

            if (!FitsInBounds(unconstrainedRect, PopupAnchor.Bottom))
            {
                unconstrainedRect.height = bounds.Bottom - unconstrainedRect.y;
            }

            if (IsValid(unconstrainedRect))
            {
                geo = unconstrainedRect;
            }
        }

        return geo;
    }
}
