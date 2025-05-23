﻿using System;
//using Prowl.Surface.Input.GestureRecognizers;
//using Prowl.Surface.VisualTree;

namespace Prowl.Surface.Input;

public partial class Pointer : IPointer, IDisposable
{
    private static int s_NextFreePointerId = 1000;
    public static int GetNextFreeId() => s_NextFreePointerId++;

    public Pointer(int id, PointerType type, bool isPrimary)
    {
        Id = id;
        Type = type;
        IsPrimary = isPrimary;
    }

    public int Id { get; }

    //static IInputElement? FindCommonParent(IInputElement? control1, IInputElement? control2)
    //{
    //    if (control1 is not Visual c1 || control2 is not Visual c2)
    //        return null;
    //    var seen = new HashSet<IInputElement>(c1.GetSelfAndVisualAncestors().OfType<IInputElement>());
    //    return c2.GetSelfAndVisualAncestors().OfType<IInputElement>().FirstOrDefault(seen.Contains);
    //}

    //protected virtual void PlatformCapture(IInputElement? element)
    //{

    //}

    //public void Capture(IInputElement? control)
    //{
    //    if (Captured is Visual v1)
    //        v1.DetachedFromVisualTree -= OnCaptureDetached;
    //    var oldCapture = Captured;
    //    Captured = control;
    //    PlatformCapture(control);
    //    if (oldCapture is Visual v2)
    //    {
    //        var commonParent = FindCommonParent(control, oldCapture);
    //        foreach (var notifyTarget in v2.GetSelfAndVisualAncestors().OfType<IInputElement>())
    //        {
    //            if (notifyTarget == commonParent)
    //                break;
    //            notifyTarget.RaiseEvent(new PointerCaptureLostEventArgs(notifyTarget, this));
    //        }
    //    }

    //    if (Captured is Visual v3)
    //        v3.DetachedFromVisualTree += OnCaptureDetached;

    //    if (Captured != null)
    //        CaptureGestureRecognizer(null);
    //}

    //static IInputElement? GetNextCapture(Visual parent)
    //{
    //    return parent as IInputElement ?? parent.FindAncestorOfType<IInputElement>();
    //}

    //private void OnCaptureDetached(object? sender, VisualTreeAttachmentEventArgs e)
    //{
    //    Capture(GetNextCapture(e.Parent));
    //}


    //public IInputElement? Captured { get; private set; }

    public PointerType Type { get; }
    public bool IsPrimary { get; }

    ///// <summary>
    ///// Gets the gesture recognizer that is currently capturing by the pointer, if any.
    ///// </summary>
    //internal GestureRecognizer? CapturedGestureRecognizer { get; private set; }

    public void Dispose()
    {
        //Capture(null);
    }

    ///// <summary>
    ///// Captures pointer input to the specified gesture recognizer.
    ///// </summary>
    ///// <param name="gestureRecognizer">The gesture recognizer.</param>
    ///// </remarks>
    //internal void CaptureGestureRecognizer(GestureRecognizer? gestureRecognizer)
    //{
    //    if (CapturedGestureRecognizer != gestureRecognizer)
    //        CapturedGestureRecognizer?.PointerCaptureLostInternal(this);

    //    if (gestureRecognizer != null)
    //        Capture(null);

    //    CapturedGestureRecognizer = gestureRecognizer;
    //}
}
