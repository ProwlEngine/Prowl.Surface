// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XCirculateRequestEvent
{
    public XEventName type;

    [NativeTypeName("unsigned long")]
    public nuint serial;

    public int send_event;

    public XDisplay* display;

    public XWindow parent;

    public XWindow window;

    public int place;
}
