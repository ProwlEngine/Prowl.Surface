﻿using System;

namespace Prowl.Surface.Win32;

internal static class PlatformConstants
{
    public const string WindowHandleType = "HWND";
    public const string CursorHandleType = "HCURSOR";

    public static readonly Version Windows10 = new Version(10, 0);
    public static readonly Version Windows8 = new Version(6, 2);
    public static readonly Version Windows7 = new Version(6, 1);
}
