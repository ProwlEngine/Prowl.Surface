using static Prowl.Surface.Win32.Interop.UnmanagedMethods;

namespace Prowl.Surface.Win32;

internal static class Win32TypeExtensions
{
    public static PixelRect ToPixelRect(this RECT rect)
    {
        return new PixelRect(rect.left, rect.top, rect.right - rect.left,
                rect.bottom - rect.top);
    }
}
