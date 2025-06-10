// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XColormap : IEquatable<XColormap>, IFormattable
{
    public readonly void* Value;

    public XColormap(void* value)
    {
        Value = value;
    }

    public static XColormap NULL => new XColormap(null);



    public static explicit operator XColormap(void* value) => new XColormap(value);

    public static implicit operator void*(XColormap value) => value.Value;


    public static explicit operator XColormap(nint value) => new XColormap(unchecked((void*)(value)));

    public static implicit operator nint(XColormap value) => (nint)(value.Value);

    public static explicit operator XColormap(nuint value) => new XColormap(unchecked((void*)(value)));

    public static implicit operator nuint(XColormap value) => (nuint)(value.Value);


    public override bool Equals(object? obj) => (obj is XColormap other) && Equals(other);

    public bool Equals(XColormap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
