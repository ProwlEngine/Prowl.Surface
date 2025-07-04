// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XWindowAttributes
{
    public int x;

    public int y;

    public int width;

    public int height;

    public int border_width;

    public int depth;

    public Visual* visual;

    public XWindow root;

    public int c_class;

    public int bit_gravity;

    public int win_gravity;

    public int backing_store;

    public nuint backing_planes;

    public nuint backing_pixel;

    public int save_under;

    public XColormap colormap;

    public int map_installed;

    public int map_state;

    public XEventMask all_event_masks;

    public XEventMask your_event_mask;

    [NativeTypeName("long")]
    public nint do_not_propagate_mask;

    public int override_redirect;

    public XScreen* screen;
}
