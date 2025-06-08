

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


public static unsafe partial class Xlib
{
    [LibraryImport("libXrandr")]
    public static partial int XRRQueryVersion(XDisplay* dpy, out int major_version_return, out int minor_version_return);


    public static bool QueryXRandr(XDisplay* display, out int majorVersion, out int minorVersion)
    {
        try
        {
            XRRQueryVersion(display, out majorVersion, out minorVersion);
            return true;
        }
        catch
        {
            majorVersion = 0;
            minorVersion = 0;
            return false;
        }
    }


    [LibraryImport("libXrandr")]
    public static partial XRRMonitorInfo* XRRGetMonitors(XDisplay* display, XWindow window, [MarshalAs(UnmanagedType.Bool)] bool getActive, out int count);

    [LibraryImport("libXrandr")]
    public static partial void XRRFreeMonitors(XRRMonitorInfo* monitors);

    [LibraryImport("libXrandr")]
    public static partial XRRScreenResources* XRRGetScreenResources(XDisplay* display, XWindow window);

    [LibraryImport("libXrandr")]
    public static partial void XRRFreeScreenResources(XRRScreenResources* resources);

    [LibraryImport("libXrandr")]
    public static partial XRROutputInfo* XRRGetOutputInfo(XDisplay* display, XRRScreenResources* resources, nint output);

    [LibraryImport("libXrandr")]
    public static partial void XRRFreeOutputInfo(XRROutputInfo* outputInfo);

    [LibraryImport("libXrandr")]
    public static partial XRRCrtcInfo* XRRGetCrtcInfo(XDisplay* display, XRRScreenResources* resources, nint crtc);

    [LibraryImport("libXrandr")]
    public static partial void XRRFreeCrtcInfo(XRRCrtcInfo* crtcInfo);


    public const ushort RR_Rotate_0 = 1;
    public const ushort RR_Rotate_90 = 2;
    public const ushort RR_Rotate_180 = 4;
    public const ushort RR_Rotate_270 = 8;
}
