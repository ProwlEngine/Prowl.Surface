using Prowl.Surface.Mac.Interop;

using Prowl.Vector;

namespace Prowl.Surface.Native;

internal static class Helpers
{
    public static Vector2 ToAvaloniaPoint(this AvnPoint pt)
    {
        return new Vector2(pt.X, pt.Y);
    }

    public static PixelPoint ToAvaloniaPixelPoint(this AvnPoint pt)
    {
        return new PixelPoint((int)pt.X, (int)pt.Y);
    }

    public static AvnPoint ToAvnPoint(this Vector2 pt)
    {
        return new AvnPoint { X = pt.x, Y = pt.y };
    }

    public static AvnPoint ToAvnPoint(this PixelPoint pt)
    {
        return new AvnPoint { X = pt.X, Y = pt.Y };
    }

    public static AvnRect ToAvnRect(this Rect rect)
    {
        return new AvnRect() { X = rect.x, Y = rect.y, Height = rect.height, Width = rect.width };
    }

    public static AvnSize ToAvnSize(this Vector2 size)
    {
        return new AvnSize { Height = size.y, Width = size.x };
    }

    //public static IAvnString ToAvnString(this string s)
    //{
    //    return s != null ? new AvnString(s) : null;
    //}

    public static Vector2 ToAvaloniaSize(this AvnSize size)
    {
        return new Vector2(size.Width, size.Height);
    }

    public static Rect ToAvaloniaRect(this AvnRect rect)
    {
        return new Rect(rect.X, rect.Y, rect.Width, rect.Height);
    }

    public static PixelRect ToAvaloniaPixelRect(this AvnRect rect)
    {
        return new PixelRect((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
    }
}
