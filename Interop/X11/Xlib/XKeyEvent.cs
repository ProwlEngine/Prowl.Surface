// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XKeyEvent
{
    public XEventName type;

    [NativeTypeName("unsigned long")]
    public nuint serial;

    public int send_event;

    public XDisplay* display;

    public XWindow window;

    public XWindow root;

    public XWindow subwindow;

    public Time time;

    public int x;

    public int y;

    public int x_root;

    public int y_root;

    [NativeTypeName("unsigned int")]
    public uint state;

    [NativeTypeName("unsigned int")]
    public uint keycode;

    public int same_screen;
}
