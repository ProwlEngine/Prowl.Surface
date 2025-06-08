// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using TerraFX.Interop.Windows;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("windows10.0.14393.0")]
internal sealed unsafe class Win32ScreenManager : ScreenManager
{
    private bool _screenAddedOrUpdated;
    private readonly GCHandle _thisGcHandle;

    private List<Win32Screen> _itemBuilder;
    private Win32Screen[] _items;

    private Win32Screen? _primaryScreen;
    private Point _virtualScreenPosition;
    private Size _virtualScreenSize;

    public Win32ScreenManager()
    {
        _thisGcHandle = GCHandle.Alloc(this);
        _itemBuilder = new(4);
        _items = [];

        _ = TryUpdateScreens();
    }

    public override ReadOnlySpan<Screen> GetAllScreens() => _items;

    public override Screen? GetPrimaryScreen() => _primaryScreen;

    public override Point GetVirtualScreenPosition() => _virtualScreenPosition;

    public override Size GetVirtualScreenSizeInPixels() => _virtualScreenSize;

    public bool TryGetScreen(HMONITOR monitorHandle, [NotNullWhen(true)] out Win32Screen? screen)
    {
        screen = Array.Find(_items, x => x._monitorHandle == monitorHandle);
        return screen != null;
    }

    public override bool TryUpdateScreens()
    {
        bool updated = false;

        _itemBuilder.Clear();
        _ = Windows.EnumDisplayMonitors(HDC.NULL, (RECT*)null, &EnumDisplayMonitorProc, GCHandle.ToIntPtr(_thisGcHandle));

        Win32Screen? primary = null;
        foreach (Win32Screen item in _itemBuilder)
        {
            if (item.IsPrimary)
                primary = item;

            // No matching item exists - value is either new or updated.
            if (!Array.Exists(_items, x => x.Equals(item)))
                updated = true;
        }

        var virtualScreenPosition = new Point(Windows.GetSystemMetrics(SM.SM_XVIRTUALSCREEN), Windows.GetSystemMetrics(SM.SM_YVIRTUALSCREEN));
        var virtualScreenSize = new Size(Windows.GetSystemMetrics(SM.SM_CXVIRTUALSCREEN), Windows.GetSystemMetrics(SM.SM_CYVIRTUALSCREEN));

        // Null state check then equality check
        if ((_primaryScreen == null) != (primary == null) || (!_primaryScreen?.Equals(primary) ?? false))
        {
            _primaryScreen = primary;
            updated = true;
        }

        if (!_virtualScreenPosition.Equals(virtualScreenPosition))
        {
            _virtualScreenPosition = virtualScreenPosition;
            updated = true;
        }

        if (!_virtualScreenSize.Equals(virtualScreenSize))
        {
            _virtualScreenSize = virtualScreenSize;
            updated = true;
        }

        _items = [.. _itemBuilder];

        return updated;
    }

    [UnmanagedCallersOnly]
    private static BOOL EnumDisplayMonitorProc(HMONITOR monitor, HDC hdc, RECT* lpRect, LPARAM lParam)
    {
        var manager = (Win32ScreenManager)GCHandle.FromIntPtr((nint)lParam).Target!;

        Win32Screen screen = new(monitor);
        manager._itemBuilder.Add(screen);

        return true;
    }
}
