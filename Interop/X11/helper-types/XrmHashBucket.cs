// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XrmHashBucket : IEquatable<XrmHashBucket>, IFormattable
{
    public readonly void* Value;

    public XrmHashBucket(void* value)
    {
        Value = value;
    }

    public static XrmHashBucket NULL => new XrmHashBucket(null);


    public static explicit operator XrmHashBucket(void* value) => new XrmHashBucket(value);

    public static implicit operator void*(XrmHashBucket value) => value.Value;

    public static explicit operator XrmHashBucket(nint value) => new XrmHashBucket(unchecked((void*)(value)));

    public static implicit operator nint(XrmHashBucket value) => (nint)(value.Value);

    public static explicit operator XrmHashBucket(nuint value) => new XrmHashBucket(unchecked((void*)(value)));

    public static implicit operator nuint(XrmHashBucket value) => (nuint)(value.Value);

    public override bool Equals(object? obj) => (obj is XrmHashBucket other) && Equals(other);

    public bool Equals(XrmHashBucket other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
