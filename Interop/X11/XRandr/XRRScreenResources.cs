using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct XRRScreenResources
{
    public int timestamp;
    public int configTimestamp;
    public int ncrtc;
    public nuint crtcs;  // RRCrtc*
    public int noutput;
    public nuint outputs; // RROutput*
    public int nmode;
    public XRRModeInfo* modes; // XRRModeInfo*
}