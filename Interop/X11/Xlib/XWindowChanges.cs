// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XWindowChanges
{
    public int x;

    public int y;

    public int width;

    public int height;

    public int border_width;

    public XWindow sibling;

    public int stack_mode;
}
