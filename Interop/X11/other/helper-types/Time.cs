// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Time : IComparable, IComparable<Time>, IEquatable<Time>, IFormattable
{
    public readonly ulong Value;

    public Time(ulong value)
    {
        Value = value;
    }


    public static bool operator ==(Time left, Time right) => left.Value == right.Value;

    public static bool operator !=(Time left, Time right) => left.Value != right.Value;

    public static bool operator <(Time left, Time right) => left.Value < right.Value;

    public static bool operator <=(Time left, Time right) => left.Value <= right.Value;

    public static bool operator >(Time left, Time right) => left.Value > right.Value;

    public static bool operator >=(Time left, Time right) => left.Value >= right.Value;

    public static explicit operator Time(ulong value) => new Time(value);

    public static explicit operator ulong(Time value) => (ulong)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Time other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Time.");
    }

    public int CompareTo(Time other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Time other) && Equals(other);

    public bool Equals(Time other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
