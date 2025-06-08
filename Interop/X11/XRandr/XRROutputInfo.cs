using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRROutputInfo
{
    public Time timestamp;
    public nuint crtc;
    public byte* name;
    public int nameLen;
    public ulong mm_width;
    public ulong mm_height;
    public ushort connection;
    public ushort subpixel_order;
    public int ncrtc;
    public nuint* crtcs;
    public int nclone;
    public nuint* clones;
    public int nmode;
    public int npreferred;
    public nuint* modes;
}