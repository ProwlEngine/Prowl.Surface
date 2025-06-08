// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

using TerraFX.Interop.Windows;

using static TerraFX.Interop.Windows.Windows;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("windows10.0.14393.0")]
internal sealed class Win32Screen : Screen, IEquatable<Win32Screen>
{
    internal HMONITOR _monitorHandle;

    internal unsafe Win32Screen(HMONITOR monitor)
    {
        _monitorHandle = monitor;

        MONITORINFOEXW monitorInfo;
        monitorInfo.Base.cbSize = (uint)sizeof(MONITORINFOEXW);

        Name = "";
        IsValid = GetMonitorInfoW(monitor, (MONITORINFO*)&monitorInfo);

        if (!IsValid)
            return;

        IsPrimary = (monitorInfo.Base.dwFlags & MONITORINFOF_PRIMARY) != 0;

        // Fetch the DPI
        int dpiX;
        int dpiY;
        if (GetDpiForMonitor(monitor, MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI, (uint*)&dpiX, (uint*)&dpiY) != 0)
        {
            dpiX = 96;
            dpiY = 96;
        }

        _dpi = new Dpi(dpiX, dpiY);

        var span = new ReadOnlySpan<char>((char*)monitorInfo.szDevice, 32);
        int index = span.IndexOf((char)0);
        if (index >= 0)
        {
            span = span.Slice(0, index);
        }

        Name = new string(span);
        Position = new(monitorInfo.Base.rcMonitor.left, monitorInfo.Base.rcMonitor.top);

        Size sizeInPixels = new();
        sizeInPixels.Width = monitorInfo.Base.rcMonitor.right - monitorInfo.Base.rcMonitor.left;
        sizeInPixels.Height = monitorInfo.Base.rcMonitor.bottom - monitorInfo.Base.rcMonitor.top;
        SizeInPixels = sizeInPixels;

        SizeF size = new();
        size.Width = _dpi.ScalePixelToLogical.X * sizeInPixels.Width;
        size.Height = _dpi.ScalePixelToLogical.Y * sizeInPixels.Height;
        Size = size;

        // Query all supported display mode
        DEVMODEW devModeW = default;
        devModeW.dmSize = (ushort)sizeof(DEVMODEW);

        // Query the current display mode
        RefreshRate = 0;
        DisplayOrientation = DisplayOrientation.Default;

        if (EnumDisplaySettingsExW(monitorInfo.szDevice, ENUM.ENUM_CURRENT_SETTINGS, &devModeW, 0))
        {
            RefreshRate = (int)devModeW.dmDisplayFrequency;
            DisplayOrientation = devModeW.dmOrientation switch
            {
                DMDO_DEFAULT => DisplayOrientation.Default,
                DMDO_90 => DisplayOrientation.Rotate90,
                DMDO_180 => DisplayOrientation.Rotate180,
                DMDO_270 => DisplayOrientation.Rotate270,
                _ => DisplayOrientation.Default,
            };
        }
    }

    public override bool IsValid { get; }
    public override bool IsPrimary { get; }
    public override string Name { get; }
    public override Point Position { get; }
    public override SizeF Size { get; }
    public override Size SizeInPixels { get; }

    private Dpi _dpi;
    public override ref readonly Dpi Dpi => ref _dpi;

    public override int RefreshRate { get; }
    public override DisplayOrientation DisplayOrientation { get; }


    public bool Equals(Win32Screen? other)
    {
        return other != null &&
            IsValid == other.IsValid &&
            Name == other.Name &&
            IsPrimary == other.IsPrimary &&
            Position.Equals(other.Position) &&
            Size.Equals(other.Size) &&
            Dpi.Equals(other.Dpi) &&
            RefreshRate.Equals(other.RefreshRate) &&
            DisplayOrientation == other.DisplayOrientation;
    }
}
