// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Wayland;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;

// ReSharper disable InconsistentNaming

namespace Prowl.Surface.Input;

/// <summary>
/// The cursor class allows to get cursors that can be set by <see cref="Mouse.SetCursor"/>.
/// </summary>
public sealed class Cursor
{
    private static readonly CursorImpl Impl = GetCursorManager();

    internal Cursor(CursorType cursorType, nint handle)
    {
        CursorType = cursorType;
        Handle = handle;
        FileName = string.Empty;
    }

    /// <summary>
    /// Gets the type of cursor.
    /// </summary>
    public CursorType CursorType { get; }

    /// <summary>
    /// Gets the filename associated to a cursor.
    /// </summary>
    public string FileName { get; }

    /// <summary>
    /// Gets the native handle associated to this cursor.
    /// </summary>
    /// <remarks>
    /// - On Windows: This is a HCURSOR.
    /// - On X11: This is a Cursor pointer.
    /// </remarks>
    public nint Handle { get; }

    /// <summary>
    /// Gets a cursor that should not be displayed at all.
    /// </summary>
    public static Cursor None => s_none ??= Impl.GetCursor(CursorType.None);
    private static Cursor? s_none;

    /// <summary>
    /// Gets the default platform cursor.
    /// </summary>
    public static Cursor Default => s_default ??= Impl.GetCursor(CursorType.Default);
    private static Cursor? s_default;

    /// <summary>
    /// Gets the Standard arrow cursor.
    /// </summary>
    public static Cursor Arrow => s_arrow ??= Impl.GetCursor(CursorType.Arrow);
    private static Cursor? s_arrow;

    /// <summary>
    /// Gets the Text I-Beam cursor.
    /// </summary>
    public static Cursor IBeam => s_ibeam ??= Impl.GetCursor(CursorType.IBeam);
    private static Cursor? s_ibeam;

    /// <summary>
    /// Gets the Hourglass cursor.
    /// </summary>
    public static Cursor Wait => s_wait ??= Impl.GetCursor(CursorType.Wait);
    private static Cursor? s_wait;

    /// <summary>
    /// Gets the CrossHair cursor.
    /// </summary>
    public static Cursor Cross => s_cross ??= Impl.GetCursor(CursorType.Cross);
    private static Cursor? s_cross;

    /// <summary>
    /// Gets the Double arrow pointing NW and SE.
    /// </summary>
    public static Cursor SizeNWSE => s_sizenwse ??= Impl.GetCursor(CursorType.SizeNWSE);
    private static Cursor? s_sizenwse;

    /// <summary>
    /// Gets the Double arrow pointing NE and SW.
    /// </summary>
    public static Cursor SizeNESW => s_sizenesw ??= Impl.GetCursor(CursorType.SizeNESW);
    private static Cursor? s_sizenesw;

    /// <summary>
    /// Gets the Double arrow pointing W and E.
    /// </summary>
    public static Cursor SizeWE => s_sizewe ??= Impl.GetCursor(CursorType.SizeWE);
    private static Cursor? s_sizewe;

    /// <summary>
    /// Gets the Double arrow pointing N and S.
    /// </summary>
    public static Cursor SizeNS => s_sizens ??= Impl.GetCursor(CursorType.SizeNS);
    private static Cursor? s_sizens;

    /// <summary>
    /// Gets the Four-way pointing cursor.
    /// </summary>
    public static Cursor SizeAll => s_sizeall ??= Impl.GetCursor(CursorType.SizeAll);
    private static Cursor? s_sizeall;

    /// <summary>
    /// Gets the Standard No Cursor.
    /// </summary>
    public static Cursor No => s_no ??= Impl.GetCursor(CursorType.No);
    private static Cursor? s_no;

    /// <summary>
    /// Gets the Hand cursor.
    /// </summary>
    public static Cursor Hand => s_hand ??= Impl.GetCursor(CursorType.Hand);
    private static Cursor? s_hand;

    /// <summary>
    /// Loads the specified cursor from a file.
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    /// TODO: Not implemented yet.
    private static Cursor LoadFromImage(string fileName) => Impl.LoadFromFile(fileName);

    private static CursorImpl GetCursorManager()
    {
        switch (WindowPlatform.GetBestPlatform())
        {
            case PlatformType.Win32:
                return new Win32Cursor();
            case PlatformType.Wayland:
                return new WaylandCursor();
            case PlatformType.X11:
                return new X11Cursor();
        }

        throw new PlatformNotSupportedException();
    }
}
