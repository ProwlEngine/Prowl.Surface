// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct XEvent
{
    [FieldOffset(0)]
    public XEventName type;

    [FieldOffset(0)]
    public XAnyEvent xany;

    [FieldOffset(0)]
    public XKeyEvent xkey;

    [FieldOffset(0)]
    public XButtonEvent xbutton;

    [FieldOffset(0)]
    public XMotionEvent xmotion;

    [FieldOffset(0)]
    public XCrossingEvent xcrossing;

    [FieldOffset(0)]
    public XFocusChangeEvent xfocus;

    [FieldOffset(0)]
    public XExposeEvent xexpose;

    [FieldOffset(0)]
    public XGraphicsExposeEvent xgraphicsexpose;

    [FieldOffset(0)]
    public XNoExposeEvent xnoexpose;

    [FieldOffset(0)]
    public XVisibilityEvent xvisibility;

    [FieldOffset(0)]
    public XCreateWindowEvent xcreatewindow;

    [FieldOffset(0)]
    public XDestroyWindowEvent xdestroywindow;

    [FieldOffset(0)]
    public XUnmapEvent xunmap;

    [FieldOffset(0)]
    public XMapEvent xmap;

    [FieldOffset(0)]
    public XMapRequestEvent xmaprequest;

    [FieldOffset(0)]
    public XReparentEvent xreparent;

    [FieldOffset(0)]
    public XConfigureEvent xconfigure;

    [FieldOffset(0)]
    public XGravityEvent xgravity;

    [FieldOffset(0)]
    public XResizeRequestEvent xresizerequest;

    [FieldOffset(0)]
    public XConfigureRequestEvent xconfigurerequest;

    [FieldOffset(0)]
    public XCirculateEvent xcirculate;

    [FieldOffset(0)]
    public XCirculateRequestEvent xcirculaterequest;

    [FieldOffset(0)]
    public XPropertyEvent xproperty;

    [FieldOffset(0)]
    public XSelectionClearEvent xselectionclear;

    [FieldOffset(0)]
    public XSelectionRequestEvent xselectionrequest;

    [FieldOffset(0)]
    public XSelectionEvent xselection;

    [FieldOffset(0)]
    public XColormapEvent xcolormap;

    [FieldOffset(0)]
    public XClientMessageEvent xclient;

    [FieldOffset(0)]
    public XMappingEvent xmapping;

    [FieldOffset(0)]
    public XErrorEvent xerror;

    [FieldOffset(0)]
    public XKeymapEvent xkeymap;

    [FieldOffset(0)]
    public XGenericEvent xgeneric;

    [FieldOffset(0)]
    public XGenericEventCookie xcookie;

    [FieldOffset(0)]
    public fixed long pad[24];
}
