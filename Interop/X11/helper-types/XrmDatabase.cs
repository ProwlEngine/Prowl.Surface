// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XrmDatabase : IEquatable<XrmDatabase>, IFormattable
{
    public readonly void* Value;

    public XrmDatabase(void* value)
    {
        Value = value;
    }

    public static XrmDatabase NULL => new XrmDatabase(null);

    public static explicit operator XrmDatabase(void* value) => new XrmDatabase(value);

    public static implicit operator void*(XrmDatabase value) => value.Value;

    public static explicit operator XrmDatabase(nint value) => new XrmDatabase(unchecked((void*)(value)));

    public static implicit operator nint(XrmDatabase value) => (nint)(value.Value);

    public static explicit operator XrmDatabase(nuint value) => new XrmDatabase(unchecked((void*)(value)));

    public static implicit operator nuint(XrmDatabase value) => (nuint)(value.Value);

    public override bool Equals(object? obj) => (obj is XrmDatabase other) && Equals(other);

    public bool Equals(XrmDatabase other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
