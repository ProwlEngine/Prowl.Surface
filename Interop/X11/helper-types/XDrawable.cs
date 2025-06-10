// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XDrawable : IEquatable<XDrawable>, IFormattable
{
    public readonly void* Value;

    public XDrawable(void* value)
    {
        Value = value;
    }

    public static XDrawable NULL => new XDrawable(null);


    public static explicit operator XDrawable(void* value) => new XDrawable(value);

    public static implicit operator void*(XDrawable value) => value.Value;

    public static explicit operator XDrawable(nint value) => new XDrawable(unchecked((void*)(value)));

    public static implicit operator nint(XDrawable value) => (nint)(value.Value);

    public static explicit operator XDrawable(nuint value) => new XDrawable(unchecked((void*)(value)));

    public static implicit operator nuint(XDrawable value) => (nuint)(value.Value);

    public override bool Equals(object? obj) => (obj is XDrawable other) && Equals(other);

    public bool Equals(XDrawable other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
