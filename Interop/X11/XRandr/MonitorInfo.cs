using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct MonitorInfo
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
