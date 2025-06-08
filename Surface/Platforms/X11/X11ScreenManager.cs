// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Versioning;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal sealed unsafe class X11ScreenManager : ScreenManager
{
    private X11Screen[] _items;
    private X11Screen? _primaryScreen;
    private Point _virtualScreenPosition;
    private Size _virtualScreenSize;


    internal X11ScreenManager()
    {
        _items = [];
        _ = TryUpdateScreens();
    }


    public override ReadOnlySpan<Screen> GetAllScreens() => _items;

    public override Screen? GetPrimaryScreen() => _primaryScreen;

    public override Point GetVirtualScreenPosition() => _virtualScreenPosition;

    public override Size GetVirtualScreenSizeInPixels() => _virtualScreenSize;


    public override bool TryUpdateScreens()
    {
        bool updated = false;

        X11Screen[] newScreens = [];

        if (Xlib.QueryXRandr(X11Globals.Display, out _, out _))
        {
            XRRMonitorInfo* monitors = Xlib.XRRGetMonitors(X11Globals.Display, X11Globals.RootWindow, true, out int monitorCount);
            XRRScreenResources* resources = Xlib.XRRGetScreenResources(X11Globals.Display, X11Globals.RootWindow);

            newScreens = new X11Screen[monitorCount];

            for (int i = 0; i < monitorCount; i++)
                newScreens[i] = new(monitors[i], resources);

            Xlib.XRRFreeScreenResources(resources);
            Xlib.XRRFreeMonitors(monitors);
        }
        else
        {
            newScreens = [new()];
        }


        int left = int.MaxValue, top = int.MaxValue;
        int right = int.MinValue, bottom = int.MinValue;

        X11Screen? primary = null;
        foreach (X11Screen screen in newScreens)
        {
            if (screen.IsPrimary)
                primary = screen;

            if (!Array.Exists(_items, x => x.Equals(screen)))
                updated = true;

            left = Math.Min(left, screen.Position.X);
            top = Math.Min(top, screen.Position.Y);
            right = Math.Max(right, screen.Position.X + screen.SizeInPixels.Width);
            bottom = Math.Max(bottom, screen.Position.Y + screen.SizeInPixels.Height);
        }

        var virtualScreenPosition = new Point(left, top);
        var virtualScreenSize = new Size(right - left, bottom - top);

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

        if (updated)
            _items = newScreens;

        return updated;
    }
}
