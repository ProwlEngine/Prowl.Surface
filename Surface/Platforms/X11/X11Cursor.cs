// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using Prowl.Surface.Input;
using System.Runtime.Versioning;
using TerraFX.Interop.Xlib;
using System.Linq;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal unsafe class X11Cursor : CursorImpl
{
    public override Cursor GetCursor(CursorType cursorType)
    {
        XCursor xcursor;

        if (cursorType == CursorType.Default)
        {
            xcursor = (XCursor)(nint)0;
        }
        else if (cursorType == CursorType.None)
        {
            xcursor = Create([new Rgba32(0, 0, 0, 0)], 1, 1, 0, 0); // This technically has to be freed, but we'll keep it around for the app's lifetime.
        }
        else
        {
            xcursor = Xlib.XCreateFontCursor(X11Globals.Display, cursorType switch
            {
                CursorType.No => XCursorShape.X_cursor,
                CursorType.Arrow => XCursorShape.left_ptr,
                CursorType.Cross => XCursorShape.crosshair,
                CursorType.IBeam => XCursorShape.xterm,
                CursorType.SizeAll => XCursorShape.fleur,
                CursorType.SizeNESW => XCursorShape.sizing,
                CursorType.SizeNS => XCursorShape.sb_v_double_arrow,
                CursorType.SizeNWSE => XCursorShape.sizing,
                CursorType.SizeWE => XCursorShape.sb_h_double_arrow,
                CursorType.Wait => XCursorShape.watch,
                CursorType.Hand => XCursorShape.hand1,
                _ => throw new ArgumentOutOfRangeException(nameof(cursorType), cursorType, null)
            });
        }

        return new(cursorType, xcursor);
    }


    private XCursor Create(Rgba32[] source, uint width, uint height, uint hotx, uint hoty)
    {
        if (source.Length != width * height)
            throw new ArgumentOutOfRangeException(nameof(source), source.Length, $"Source length does not match provided dimensions");

        fixed (byte* bytes = source.Select(x => x.A != 0 ? (byte)1 : (byte)0).ToArray())
        fixed (byte* maskbytes = source.Select(x => x.R + x.G + x.B != 0 ? (byte)1 : (byte)0).ToArray())
        {
            XPixmap sourcemap = Xlib.XCreateBitmapFromData(X11Globals.Display, X11Globals.RootWindow, bytes, width, height);
            XPixmap maskmap = Xlib.XCreateBitmapFromData(X11Globals.Display, X11Globals.RootWindow, maskbytes, width, height);

            Xlib.XAllocNamedColor(X11Globals.Display, X11Globals.DefaultColormap, "black", out _, out XColor foreground);
            Xlib.XAllocNamedColor(X11Globals.Display, X11Globals.DefaultColormap, "white", out _, out XColor background);

            return Xlib.XCreatePixmapCursor(X11Globals.Display, sourcemap, maskmap, ref foreground, ref background, hotx, hoty);
        }
    }


    public override Cursor LoadFromFile(string fileName) => throw new NotImplementedException();
}
