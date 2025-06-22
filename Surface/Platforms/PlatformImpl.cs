
using System;

using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Wayland;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;

namespace Prowl.Surface;

internal static class PlatformImpl
{
    public static ScreenManager ScreenManager { get; private set; }
    public static EventHandler EventHandler { get; private set; }


    static PlatformImpl()
    {
        switch (WindowPlatform.GetBestPlatform())
        {
            case PlatformType.Win32:
                ScreenManager = new Win32ScreenManager();
                EventHandler = new Win32EventHandler();
                return;

            case PlatformType.Wayland:
                ScreenManager = new WaylandScreenManager();
                EventHandler = new WaylandEventHandler();
                return;

            case PlatformType.X11:
                ScreenManager = new X11ScreenManager();
                EventHandler = new X11EventHandler();
                return;
        }

        throw new PlatformNotSupportedException();
    }
}
