// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Runtime.Versioning;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;



[SupportedOSPlatform("linux")]
internal unsafe class X11Icon : IconImpl
{
    public override Icon GetApplicationIcon()
    {
        Xlib.XGetWindowProperty(X11Globals.Display, X11Globals.RootWindow, XUtility.WmIcon, 0, int.MaxValue,
            false, Atom.NULL, out Atom actualType, out int actualFormat, out ulong nitems, out ulong bytesAfter, out byte* data);

        if (actualFormat != 32 || data == null)
            return new Icon(0, 0);

        uint width = ((uint*)data)[0];
        uint height = ((uint*)data)[1];

        Icon icon = new Icon((int)width, (int)height);

        for (int i = 0; i < width * height; i++)
        {
            int idx = i * 4;
            byte a = data[idx + 0];
            byte r = data[idx + 1];
            byte g = data[idx + 2];
            byte b = data[idx + 3];

            icon.Buffer[i] = new Rgba32(r, g, b, a);
        }

        return icon;
    }


    internal static void SetWindowIcon(XWindow window, Icon icon)
    {
        int iconDataLength = icon.Buffer.Length + 2;
        nuint* iconData = stackalloc nuint[iconDataLength];

        iconData[0] = (nuint)icon.Width;
        iconData[1] = (nuint)icon.Height;

        for (int x = 0; x < icon.Width; ++x)
        {
            for (int y = 0; y < icon.Height; ++y)
            {
                Rgba32 pixel = icon.Buffer[x + (y * icon.Height)];
                uint data = ((uint)pixel.A << 24) | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | pixel.B;

                iconData[x + ((icon.Height - 1 - y) * icon.Height) + 2] = data;
            }
        }

        Xlib.XChangeProperty(
            X11Globals.Display,
            window,
            XUtility.WmIcon,
            Atom.XA_CARDINAL,
            32,
            Xlib.PropModeReplace,
            (byte*)iconData,
            iconDataLength);
    }
}
