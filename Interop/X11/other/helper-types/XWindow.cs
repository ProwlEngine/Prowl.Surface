// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XWindow : IComparable, IComparable<XWindow>, IEquatable<XWindow>, IFormattable
{
    public readonly void* Value;

    public XWindow(void* value)
    {
        Value = value;
    }

    public static XWindow NULL => new XWindow(null);

    public static bool operator ==(XWindow left, XWindow right) => left.Value == right.Value;

    public static bool operator !=(XWindow left, XWindow right) => left.Value != right.Value;

    public static bool operator <(XWindow left, XWindow right) => left.Value < right.Value;

    public static bool operator <=(XWindow left, XWindow right) => left.Value <= right.Value;

    public static bool operator >(XWindow left, XWindow right) => left.Value > right.Value;

    public static bool operator >=(XWindow left, XWindow right) => left.Value >= right.Value;

    public static explicit operator XWindow(void* value) => new XWindow(value);

    public static implicit operator void*(XWindow value) => value.Value;

    public static explicit operator XWindow(byte value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator byte(XWindow value) => (byte)(value.Value);

    public static explicit operator XWindow(short value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator short(XWindow value) => (short)(value.Value);

    public static explicit operator XWindow(int value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator int(XWindow value) => (int)(value.Value);

    public static explicit operator XWindow(long value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator long(XWindow value) => (long)(value.Value);

    public static explicit operator XWindow(nint value) => new XWindow(unchecked((void*)(value)));

    public static implicit operator nint(XWindow value) => (nint)(value.Value);

    public static explicit operator XWindow(sbyte value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator sbyte(XWindow value) => (sbyte)(value.Value);

    public static explicit operator XWindow(ushort value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator ushort(XWindow value) => (ushort)(value.Value);

    public static explicit operator XWindow(uint value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator uint(XWindow value) => (uint)(value.Value);

    public static explicit operator XWindow(ulong value) => new XWindow(unchecked((void*)(value)));

    public static explicit operator ulong(XWindow value) => (ulong)(value.Value);

    public static explicit operator XWindow(nuint value) => new XWindow(unchecked((void*)(value)));

    public static implicit operator nuint(XWindow value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XWindow other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Window.");
    }

    public int CompareTo(XWindow other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XWindow other) && Equals(other);

    public bool Equals(XWindow other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
