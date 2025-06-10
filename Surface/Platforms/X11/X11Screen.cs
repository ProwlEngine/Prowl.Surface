// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal unsafe sealed class X11Screen : Screen
{
    // Default constructor - gets values from base Xlib
    internal unsafe X11Screen()
    {
        IsPrimary = true;
        Name = Xlib.DisplayString(X11Globals.Display);
        Position = new();
        SizeInPixels = new(Xlib.DisplayWidth(X11Globals.Display, 0), Xlib.DisplayHeight(X11Globals.Display, 0));

        int mwidth = Xlib.DisplayWidthMM(X11Globals.Display, 0);
        int mheight = Xlib.DisplayHeightMM(X11Globals.Display, 0);

        _dpi = new((int)((SizeInPixels.Width * 25.4) / mwidth), (int)(SizeInPixels.Height * 25.4) / mheight);

        SizeF size = new();
        size.Width = _dpi.ScalePixelToLogical.X * SizeInPixels.Width;
        size.Height = _dpi.ScalePixelToLogical.Y * SizeInPixels.Height;
        Size = size;

        RefreshRate = 0;
        DisplayOrientation = DisplayOrientation.Default;
    }


    // If XRandr is available, gets complex multi-monitor info from here
    internal unsafe X11Screen(XRRMonitorInfo monitorInfo, XRRScreenResources* resources)
    {
        IsPrimary = monitorInfo.primary != 0;
        Name = Xlib.GetAtomName(X11Globals.Display, monitorInfo.name);

        Position = new(monitorInfo.x, monitorInfo.y);
        SizeInPixels = new(monitorInfo.width, monitorInfo.height);

        _dpi = new((int)((SizeInPixels.Width * 25.4) / monitorInfo.mwidth), (int)(SizeInPixels.Height * 25.4) / monitorInfo.mheight);

        SizeF size = new();
        size.Width = _dpi.ScalePixelToLogical.X * SizeInPixels.Width;
        size.Height = _dpi.ScalePixelToLogical.Y * SizeInPixels.Height;
        Size = size;

        double maxRefreshRate = 0.0;
        DisplayOrientation orientation = DisplayOrientation.Default;

        // Refresh rate and orientation BS because some genius didn't want to put a default into monitorinfo for simpletons.
        for (int o = 0; o < monitorInfo.noutput; o++)
        {
            nuint output = monitorInfo.outputs[o];
            XRROutputInfo* outputInfo = Xlib.XRRGetOutputInfo(X11Globals.Display, resources, (nint)output);

            if (outputInfo->crtc == 0)
            {
                Xlib.XRRFreeOutputInfo(outputInfo);
                continue;
            }

            XRRCrtcInfo* crtcInfo = Xlib.XRRGetCrtcInfo(X11Globals.Display, resources, (nint)outputInfo->crtc);

            if (crtcInfo->mode == 0)
            {
                Xlib.XRRFreeCrtcInfo(crtcInfo);
                Xlib.XRRFreeOutputInfo(outputInfo);

                continue;
            }

            // If there's multiple orientations per monitor output idk what we'd do here gng 🥀🥀🥀
            orientation = crtcInfo->rotation switch
            {
                Xlib.RR_Rotate_90 => DisplayOrientation.Rotate90,
                Xlib.RR_Rotate_180 => DisplayOrientation.Rotate180,
                Xlib.RR_Rotate_270 => DisplayOrientation.Rotate270,
                _ => DisplayOrientation.Default,
            };

            for (int m = 0; m < resources->nmode; m++)
            {
                XRRModeInfo mode = resources->modes[m];

                if (mode.id == crtcInfo->mode)
                {
                    // refresh rate = dotClock / (hTotal * vTotal)
                    if (mode.hTotal != 0 && mode.vTotal != 0)
                    {
                        double refreshRate = (double)mode.dotClock / (mode.hTotal * mode.vTotal);

                        // Pick the max refresh rate because why would you want anything lower? Other than for vsync.
                        if (refreshRate > maxRefreshRate)
                            maxRefreshRate = refreshRate;
                    }

                    break;
                }
            }

            Xlib.XRRFreeCrtcInfo(crtcInfo);
            Xlib.XRRFreeOutputInfo(outputInfo);
        }

        RefreshRate = (int)maxRefreshRate;
        DisplayOrientation = orientation;
    }

    public override bool IsValid => true;

    public override bool IsPrimary { get; }

    public override string Name { get; }

    public override Point Position { get; }

    public override Size SizeInPixels { get; }

    public override SizeF Size { get; }

    private Dpi _dpi;
    public override ref readonly Dpi Dpi => ref _dpi;

    public override int RefreshRate { get; }

    public override DisplayOrientation DisplayOrientation { get; }
}
