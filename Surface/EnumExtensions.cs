using System;
using System.Runtime.CompilerServices;


namespace Prowl.Surface;


internal static class EnumExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TEnum AddFlag<TEnum>(this TEnum lhs, TEnum rhs) where TEnum : unmanaged, Enum
    {
        unsafe
        {
            switch (sizeof(TEnum))
            {
                case 1:
                    {
                        var r = *(byte*)(&lhs) | *(byte*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 2:
                    {
                        var r = *(ushort*)(&lhs) | *(ushort*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 4:
                    {
                        var r = *(uint*)(&lhs) | *(uint*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 8:
                    {
                        var r = *(ulong*)(&lhs) | *(ulong*)(&rhs);
                        return *(TEnum*)&r;
                    }
                default:
                    throw new Exception("Size does not match a known Enum backing type.");
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TEnum RemoveFlag<TEnum>(this TEnum lhs, TEnum rhs) where TEnum : unmanaged, Enum
    {
        unsafe
        {
            switch (sizeof(TEnum))
            {
                case 1:
                    {
                        var r = *(byte*)(&lhs) & ~*(byte*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 2:
                    {
                        var r = *(ushort*)(&lhs) & ~*(ushort*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 4:
                    {
                        var r = *(uint*)(&lhs) & ~*(uint*)(&rhs);
                        return *(TEnum*)&r;
                    }
                case 8:
                    {
                        var r = *(ulong*)(&lhs) & ~*(ulong*)(&rhs);
                        return *(TEnum*)&r;
                    }
                default:
                    throw new Exception("Size does not match a known Enum backing type.");
            }
        }

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TEnum SetFlag<TEnum>(this TEnum lhs, TEnum rhs, bool value) where TEnum : unmanaged, Enum
    {
        return value ? lhs.AddFlag(rhs) : lhs.RemoveFlag(rhs);
    }

    /// <summary>
    /// Checks if the flag value is identical to the provided enum.
    /// </summary>
    public static bool IsIdenticalFlag<T>(this T type, T enumFlag) where T : Enum
    {
        try
        {
            return (int)(object)type == (int)(object)enumFlag;
        }
        catch
        {
            return false;
        }
    }
}
