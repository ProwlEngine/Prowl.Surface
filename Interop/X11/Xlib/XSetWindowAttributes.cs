// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XSetWindowAttributes
{
    public XPixmap background_pixmap;

    public ulong background_pixel;

    public XPixmap border_pixmap;

    public ulong border_pixel;

    public int bit_gravity;

    public int win_gravity;

    public int backing_store;

    public ulong backing_planes;

    public ulong backing_pixel;

    public int save_under;

    public XEventMask event_mask;

    public long do_not_propagate_mask;

    public int override_redirect;

    public XColormap colormap;

    public XCursor cursor;
}
