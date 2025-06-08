using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRRModeInfo
{
    public nuint id; // RRMode
    public uint width;
    public uint height;
    public ulong dotClock;
    public ushort hSyncStart;
    public ushort hSyncEnd;
    public ushort hTotal;
    public ushort hSkew;
    public ushort vSyncStart;
    public ushort vSyncEnd;
    public ushort vTotal;
    public byte* name;
    public uint namelength;
    public byte modeFlags;
}