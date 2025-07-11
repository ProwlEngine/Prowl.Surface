// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XGraphicsExposeEvent
{
    public XEventName type;

    [NativeTypeName("unsigned long")]
    public nuint serial;

    public int send_event;

    public XDisplay* display;

    public XDrawable drawable;

    public int x;

    public int y;

    public int width;

    public int height;

    public int count;

    public int major_code;

    public int minor_code;
}
