// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XWindow : IEquatable<XWindow>, IFormattable
{
    public readonly void* Value;

    public XWindow(void* value)
    {
        Value = value;
    }

    public static XWindow NULL => new XWindow(null);


    public static explicit operator XWindow(void* value) => new XWindow(value);

    public static implicit operator void*(XWindow value) => value.Value;

    public static explicit operator XWindow(nint value) => new XWindow(unchecked((void*)(value)));

    public static implicit operator nint(XWindow value) => (nint)(value.Value);

    public static explicit operator XWindow(nuint value) => new XWindow(unchecked((void*)(value)));

    public static implicit operator nuint(XWindow value) => (nuint)(value.Value);


    public static implicit operator XDrawable(XWindow value) => (XDrawable)value.Value;


    public override bool Equals(object? obj) => (obj is XWindow other) && Equals(other);

    public bool Equals(XWindow other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
