﻿#nullable disable

// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

using Prowl.Surface.Platform;

namespace Prowl.Surface.Input;

/*
=========================================================================================
    NOTE: Cursors are NOT disposable and are cached in platform implementation.
    To support loading custom cursors some measures about that should be taken beforehand
=========================================================================================
*/

public enum StandardCursorType
{
    Arrow,
    Ibeam,
    Wait,
    Cross,
    UpArrow,
    SizeWestEast,
    SizeNorthSouth,
    SizeAll,
    No,
    Hand,
    AppStarting,
    Help,
    TopSide,
    BottomSide,
    LeftSide,
    RightSide,
    TopLeftCorner,
    TopRightCorner,
    BottomLeftCorner,
    BottomRightCorner,
    DragMove,
    DragCopy,
    DragLink,
    None,

    [Obsolete("Use BottomSide")]
    BottomSize = BottomSide

    // Not available in GTK directly, see http://www.pixelbeat.org/programming/x_cursors/
    // We might enable them later, preferably, by loading pixmax direclty from theme with fallback image
    // SizeNorthWestSouthEast,
    // SizeNorthEastSouthWest,
}

public class Cursor
{
    public static readonly Cursor Default = new Cursor(StandardCursorType.Arrow);

    internal Cursor(ICursorImpl platformCursor)
    {
        PlatformCursor = platformCursor;
    }

    public Cursor(StandardCursorType cursorType)
        : this(GetCursor(cursorType))
    {
    }

    public ICursorImpl PlatformCursor { get; }

    public static Cursor Parse(string s)
    {
        return Enum.TryParse<StandardCursorType>(s, true, out var t) ?
            new Cursor(t) :
            throw new ArgumentException($"Unrecognized cursor type '{s}'.");
    }

    private static ICursorImpl GetCursor(StandardCursorType type)
    {
        var platform = AvaloniaGlobals.GetService<ICursorFactory>();

        if (platform == null)
        {
            throw new Exception("Could not create Cursor: IStandardCursorFactory not registered.");
        }

        return platform.GetCursor(type);
    }
}
