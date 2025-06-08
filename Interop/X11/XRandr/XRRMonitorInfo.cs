using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRRMonitorInfo
{
    public Atom name;
    public int primary;
    public int automatic;
    public int noutput;
    public int x;
    public int y;
    public int width;
    public int height;
    public int mwidth;
    public int mheight;
    public nuint* outputs;
}
