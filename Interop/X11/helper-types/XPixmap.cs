// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XPixmap : IEquatable<XPixmap>, IFormattable
{
    public readonly void* Value;

    public XPixmap(void* value)
    {
        Value = value;
    }

    public static XPixmap NULL => new XPixmap(null);


    public static explicit operator XPixmap(void* value) => new XPixmap(value);

    public static implicit operator void*(XPixmap value) => value.Value;

    public static explicit operator XPixmap(nint value) => new XPixmap(unchecked((void*)(value)));

    public static implicit operator nint(XPixmap value) => (nint)(value.Value);

    public static explicit operator XPixmap(nuint value) => new XPixmap(unchecked((void*)(value)));

    public static implicit operator nuint(XPixmap value) => (nuint)(value.Value);


    public override bool Equals(object? obj) => (obj is XPixmap other) && Equals(other);

    public bool Equals(XPixmap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
