
using System;

using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;

namespace Prowl.Surface;


/// <summary>
/// Represents a native OS windowing platform.
/// </summary>
public static class Platform
{
    internal static PlatformImpl PlatformImpl { get; private set; }


    /// <summary>
    /// Gets the native display or instance handle associated to this process. This is platform dependent (see remarks).
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item>
    /// <description>On Windows: This handle is a HINSTANCE.</description>
    /// </item>
    /// <item>
    /// <description>On Linux/Gdk: This handle is a Gdk Display</description>
    /// </item>
    /// </list>
    /// </remarks>
    public static nint NativeDisplayHandle => PlatformImpl.NativeDisplayHandle;


    /// <summary>
    /// Creates a window with the specified options.
    /// </summary>
    /// <param name="options">The options of the window.</param>
    /// <returns>The window created.</returns>
    /// <exception cref="PlatformNotSupportedException">If the platform is not supported.</exception>
    public static Window CreateWindow(WindowCreateOptions options)
    {
        return PlatformImpl.CreateWindow(options);
    }


    static Platform()
    {
        switch (WindowPlatform.GetBestPlatform())
        {
            case PlatformType.Win32:
                PlatformImpl = new Win32PlatformImpl();
                return;

            case PlatformType.X11:
                PlatformImpl = new X11PlatformImpl();
                return;
        }

        throw new PlatformNotSupportedException();
    }
}
