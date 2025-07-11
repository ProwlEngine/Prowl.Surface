// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XWMHints
{
    [NativeTypeName("long")]
    public nint flags;

    public int input;

    public int initial_state;

    public XPixmap icon_pixmap;

    public XWindow icon_window;

    public int icon_x;

    public int icon_y;

    public XPixmap icon_mask;

    public nuint window_group;
}
