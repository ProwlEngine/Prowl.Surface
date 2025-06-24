
using System;


namespace Prowl.Surface.Platforms;


internal enum PlatformType
{
    Win32, // Windows
    Wayland, // Linux wayland compositor
    X11, // Linux X11 server
    AppKit, // MacOS AppKit
    UIKit, // iOS UIKit
    Android,
    Browser
}


internal static class WindowPlatform
{
    public static PlatformType GetBestPlatform()
    {
        if (OperatingSystem.IsWindows())
            return PlatformType.Win32;

        if (OperatingSystem.IsAndroid())
            return PlatformType.Android;

        if (OperatingSystem.IsIOS() || OperatingSystem.IsTvOS())
            return PlatformType.UIKit;

        if (OperatingSystem.IsMacOS())
            return PlatformType.AppKit;

        if (OperatingSystem.IsBrowser())
            return PlatformType.Browser;

        if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
        {
            string? sessionType = Environment.GetEnvironmentVariable("XDG_SESSION_TYPE");

            if (!string.IsNullOrEmpty(sessionType))
            {
                if (sessionType.Equals("wayland", StringComparison.OrdinalIgnoreCase))
                    return PlatformType.Wayland;

                if (sessionType.Equals("x11", StringComparison.OrdinalIgnoreCase))
                    return PlatformType.X11;

                throw new ApplicationException($"Could not determine XDG_SESSION_TYPE {sessionType}");
            }

            string? waylandDisplay = Environment.GetEnvironmentVariable("WAYLAND_DISPLAY");

            if (!string.IsNullOrEmpty(waylandDisplay))
                return PlatformType.Wayland;

            string? x11Display = Environment.GetEnvironmentVariable("DISPLAY");

            if (!string.IsNullOrEmpty(x11Display))
                return PlatformType.X11;

            throw new ApplicationException($"Could not determine Linux display server");
        }

        throw new PlatformNotSupportedException();
    }
}
