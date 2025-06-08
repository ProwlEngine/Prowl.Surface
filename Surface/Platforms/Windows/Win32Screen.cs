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

        _name = "";
        if (GetMonitorInfoW(monitor, (MONITORINFO*)&monitorInfo))
        {
            _isPrimary = (monitorInfo.Base.dwFlags & MONITORINFOF_PRIMARY) != 0;

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

            _name = new string(span);
            _position.X = monitorInfo.Base.rcMonitor.left;
            _position.Y = monitorInfo.Base.rcMonitor.top;

            _sizeInPixels.Width = monitorInfo.Base.rcMonitor.right - monitorInfo.Base.rcMonitor.left;
            _sizeInPixels.Height = monitorInfo.Base.rcMonitor.bottom - monitorInfo.Base.rcMonitor.top;
            _size.Width = _dpi.ScalePixelToLogical.X * _sizeInPixels.Width;
            _size.Height = _dpi.ScalePixelToLogical.Y * _sizeInPixels.Height;

            // Query all supported display mode
            DEVMODEW devModeW = default;
            devModeW.dmSize = (ushort)sizeof(DEVMODEW);

            // Query the current display mode
            _refreshRate = 0;
            _displayOrientation = DisplayOrientation.Default;

            if (EnumDisplaySettingsExW((ushort*)monitorInfo.szDevice, ENUM.ENUM_CURRENT_SETTINGS, &devModeW, 0))
            {
                _refreshRate = (int)devModeW.dmDisplayFrequency;
                _displayOrientation = devModeW.dmOrientation switch
                {
                    DMDO_DEFAULT => DisplayOrientation.Default,
                    DMDO_90 => DisplayOrientation.Rotate90,
                    DMDO_180 => DisplayOrientation.Rotate180,
                    DMDO_270 => DisplayOrientation.Rotate270,
                    _ => DisplayOrientation.Default,
                };
            }
        }
    }

    private bool _isValid;
    public override bool IsValid => _isValid;

    private bool _isPrimary;
    public override bool IsPrimary => _isPrimary;

    private string _name;
    public override string Name => _name;

    private Point _position;
    public override Point Position => _position;

    private SizeF _size;
    public override SizeF Size => _size;

    private Size _sizeInPixels;
    public override Size SizeInPixels => _sizeInPixels;

    private Dpi _dpi;
    public override ref readonly Dpi Dpi => ref _dpi;

    private int _refreshRate;
    public override int RefreshRate => _refreshRate;

    private DisplayOrientation _displayOrientation;
    public override DisplayOrientation DisplayOrientation => _displayOrientation;


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
