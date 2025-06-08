using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRRCrtcInfo
{
    public Time timestamp;
    public int x;
    public int y;
    public uint width;
    public uint height;
    public nuint mode;
    public ushort rotation;
    public int noutput;
    public nuint* outputs;
    public ushort rotations;
    public int npossible;
    public nuint* possible;
}