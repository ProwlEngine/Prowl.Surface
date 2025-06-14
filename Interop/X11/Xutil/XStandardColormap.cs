// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XStandardColormap
{
    public XColormap colormap;

    [NativeTypeName("unsigned long")]
    public nuint red_max;

    [NativeTypeName("unsigned long")]
    public nuint red_mult;

    [NativeTypeName("unsigned long")]
    public nuint green_max;

    [NativeTypeName("unsigned long")]
    public nuint green_mult;

    [NativeTypeName("unsigned long")]
    public nuint blue_max;

    [NativeTypeName("unsigned long")]
    public nuint blue_mult;

    [NativeTypeName("unsigned long")]
    public nuint base_pixel;

    public VisualID visualid;

    public nuint killid;
}
