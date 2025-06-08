// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    public static readonly nuint AllPlanes = unchecked((nuint)(~0));

    public static int ConnectionNumber(XDisplay* dpy) => dpy->fd;

    public static XWindow RootWindow(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root;

    public static int DefaultScreen(XDisplay* dpy) => dpy->default_screen;

    public static XWindow DefaultRootWindow(XDisplay* dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy))->root;

    public static Visual* DefaultVisual(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_visual;

    [return: NativeTypeName("unsigned long")]
    public static nuint BlackPixel(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->black_pixel;

    [return: NativeTypeName("unsigned long")]
    public static nuint WhitePixel(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->white_pixel;

    public static int QLength(XDisplay* dpy) => dpy->qlen;

    public static int DisplayWidth(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->width;

    public static int DisplayHeight(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->height;

    public static int DisplayWidthMM(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->mwidth;

    public static int DisplayHeightMM(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->mheight;

    public static int DisplayPlanes(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

    public static int DisplayCells(XDisplay* dpy, int scr) => DefaultVisual(dpy, scr)->map_entries;

    public static int ScreenCount(XDisplay* dpy) => dpy->nscreens;

    [return: NativeTypeName("char *")]
    public static sbyte* ServerVendor(XDisplay* dpy) => dpy->vendor;

    public static int ProtocolVersion(XDisplay* dpy) => dpy->proto_major_version;

    public static int ProtocolRevision(XDisplay* dpy) => dpy->proto_minor_version;

    public static int VendorRelease(XDisplay* dpy) => dpy->release;

    public static string DisplayString(XDisplay* dpy) => Marshal.PtrToStringAnsi((nint)dpy->display_name);

    public static int DefaultDepth(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

    public static Colormap DefaultColormap(XDisplay* dpy, int scr) => ScreenOfDisplay(dpy, scr)->cmap;

    public static int BitmapUnit(XDisplay* dpy) => dpy->bitmap_unit;

    public static int BitmapBitOrder(XDisplay* dpy) => dpy->bitmap_bit_order;

    public static int BitmapPad(XDisplay* dpy) => dpy->bitmap_pad;

    public static int ImageByteOrder(XDisplay* dpy) => dpy->byte_order;

    [return: NativeTypeName("unsigned long")]
    public static nuint NextRequest(XDisplay* dpy) => dpy->request + 1;

    [return: NativeTypeName("unsigned long")]
    public static nuint LastKnownRequestProcessed(XDisplay* dpy) => dpy->last_request_read;

    public static XScreen* ScreenOfDisplay(XDisplay* dpy, int scr) => &dpy->screens[scr];

    public static XScreen* DefaultScreenOfDisplay(XDisplay* dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy));

    public static XDisplay* DisplayOfScreen(XScreen* s) => s->display;

    public static XWindow RootWindowOfScreen(XScreen* s) => s->root;

    public static nuint BlackPixelOfScreen(XScreen* s) => s->black_pixel;

    public static nuint WhitePixelOfScreen(XScreen* s) => s->white_pixel;

    public static Colormap DefaultColormapOfScreen(XScreen* s) => s->cmap;

    public static int DefaultDepthOfScreen(XScreen* s) => s->root_depth;

    public static Visual* DefaultVisualOfScreen(XScreen* s) => s->root_visual;

    public static int WidthOfScreen(XScreen* s) => s->width;

    public static int HeightOfScreen(XScreen* s) => s->height;

    public static int WidthMMOfScreen(XScreen* s) => s->mwidth;

    public static int HeightMMOfScreen(XScreen* s) => s->mheight;

    public static int PlanesOfScreen(XScreen* s) => s->root_depth;

    public static int CellsOfScreen(XScreen* s) => DefaultVisualOfScreen(s)->map_entries;

    public static int MinCmapsOfScreen(XScreen* s) => s->min_maps;

    public static int MaxCmapsOfScreen(XScreen* s) => s->max_maps;

    public static int DoesSaveUnders(XScreen* s) => s->save_unders;

    public static int DoesBackingStore(XScreen* s) => s->backing_store;

    [return: NativeTypeName("long")]
    public static IntPtr EventMaskOfScreen(XScreen* s) => s->root_input_mask;
}
