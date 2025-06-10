// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XCursor : IEquatable<XCursor>, IFormattable
{
    public readonly void* Value;

    public XCursor(void* value)
    {
        Value = value;
    }

    public static XCursor NULL => new XCursor(null);


    public static explicit operator XCursor(void* value) => new XCursor(value);

    public static implicit operator void*(XCursor value) => value.Value;

    public static explicit operator XCursor(nint value) => new XCursor(unchecked((void*)(value)));

    public static implicit operator nint(XCursor value) => (nint)(value.Value);

    public static explicit operator XCursor(nuint value) => new XCursor(unchecked((void*)(value)));

    public static implicit operator nuint(XCursor value) => (nuint)(value.Value);


    public override bool Equals(object? obj) => (obj is XCursor other) && Equals(other);

    public bool Equals(XCursor other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
