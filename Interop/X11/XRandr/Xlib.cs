

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRRMonitorInfo
{
    public int name;             // Atom (not string)
    public int primary;          // Bool
    public int automatic;        // Bool
    public short x;              // position
    public short y;
    public short width;          // dimensions
    public short height;
    public short mwidth;         // physical size (mm)
    public short mheight;
    public int noutput;
    public nuint* outputs;       // RROutput* (array of outputs)
}


public static partial class Xlib
{
    [LibraryImport("libXrandr")]
    public static unsafe partial MonitorInfo* XRRGetMonitors(XDisplay* display, XWindow window, [MarshalAs(UnmanagedType.Bool)] bool getActive, out int count);

    [LibraryImport("libXrandr")]
    public static unsafe partial void XRRFreeMonitors(MonitorInfo* monitors);
}
