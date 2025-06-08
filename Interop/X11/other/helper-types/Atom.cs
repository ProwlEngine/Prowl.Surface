// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Atom : IComparable, IComparable<Atom>, IEquatable<Atom>, IFormattable
{
    public static Atom XA_PRIMARY => (Atom)1;

    public static Atom XA_SECONDARY => (Atom)2;

    public static Atom XA_ARC => (Atom)3;

    public static Atom XA_ATOM => (Atom)4;

    public static Atom XA_BITMAP => (Atom)5;

    public static Atom XA_CARDINAL => (Atom)6;

    public static Atom XA_COLORMAP => (Atom)7;

    public static Atom XA_CURSOR => (Atom)8;

    public static Atom XA_CUT_BUFFER0 => (Atom)9;

    public static Atom XA_CUT_BUFFER1 => (Atom)10;

    public static Atom XA_CUT_BUFFER2 => (Atom)11;

    public static Atom XA_CUT_BUFFER3 => (Atom)12;

    public static Atom XA_CUT_BUFFER4 => (Atom)13;

    public static Atom XA_CUT_BUFFER5 => (Atom)14;

    public static Atom XA_CUT_BUFFER6 => (Atom)15;

    public static Atom XA_CUT_BUFFER7 => (Atom)16;

    public static Atom XA_DRAWABLE => (Atom)17;

    public static Atom XA_FONT => (Atom)18;

    public static Atom XA_INTEGER => (Atom)19;

    public static Atom XA_PIXMAP => (Atom)20;

    public static Atom XA_POINT => (Atom)21;

    public static Atom XA_RECTANGLE => (Atom)22;

    public static Atom XA_RESOURCE_MANAGER => (Atom)23;

    public static Atom XA_RGB_COLOR_MAP => (Atom)24;

    public static Atom XA_RGB_BEST_MAP => (Atom)25;

    public static Atom XA_RGB_BLUE_MAP => (Atom)26;

    public static Atom XA_RGB_DEFAULT_MAP => (Atom)27;

    public static Atom XA_RGB_GRAY_MAP => (Atom)28;

    public static Atom XA_RGB_GREEN_MAP => (Atom)29;

    public static Atom XA_RGB_RED_MAP => (Atom)30;

    public static Atom XA_STRING => (Atom)31;

    public static Atom XA_VISUALID => (Atom)32;

    public static Atom XA_WINDOW => (Atom)33;

    public static Atom XA_WM_COMMAND => (Atom)34;

    public static Atom XA_WM_HINTS => (Atom)35;

    public static Atom XA_WM_CLIENT_MACHINE => (Atom)36;

    public static Atom XA_WM_ICON_NAME => (Atom)37;

    public static Atom XA_WM_ICON_SIZE => (Atom)38;

    public static Atom XA_WM_NAME => (Atom)39;

    public static Atom XA_WM_NORMAL_HINTS => (Atom)40;

    public static Atom XA_WM_SIZE_HINTS => (Atom)41;

    public static Atom XA_WM_ZOOM_HINTS => (Atom)42;

    public static Atom XA_MIN_SPACE => (Atom)43;

    public static Atom XA_NORM_SPACE => (Atom)44;

    public static Atom XA_MAX_SPACE => (Atom)45;

    public static Atom XA_END_SPACE => (Atom)46;

    public static Atom XA_SUPERSCRIPT_X => (Atom)47;

    public static Atom XA_SUPERSCRIPT_Y => (Atom)48;

    public static Atom XA_SUBSCRIPT_X => (Atom)49;

    public static Atom XA_SUBSCRIPT_Y => (Atom)50;

    public static Atom XA_UNDERLINE_POSITION => (Atom)51;

    public static Atom XA_UNDERLINE_THICKNESS => (Atom)52;

    public static Atom XA_STRIKEOUT_ASCENT => (Atom)53;

    public static Atom XA_STRIKEOUT_DESCENT => (Atom)54;

    public static Atom XA_ITALIC_ANGLE => (Atom)55;

    public static Atom XA_X_HEIGHT => (Atom)56;

    public static Atom XA_QUAD_WIDTH => (Atom)57;

    public static Atom XA_WEIGHT => (Atom)58;

    public static Atom XA_POINT_SIZE => (Atom)59;

    public static Atom XA_RESOLUTION => (Atom)60;

    public static Atom XA_COPYRIGHT => (Atom)61;

    public static Atom XA_NOTICE => (Atom)62;

    public static Atom XA_FONT_NAME => (Atom)63;

    public static Atom XA_FAMILY_NAME => (Atom)64;

    public static Atom XA_FULL_NAME => (Atom)65;

    public static Atom XA_CAP_HEIGHT => (Atom)66;

    public static Atom XA_WM_CLASS => (Atom)67;

    public static Atom XA_WM_TRANSIENT_FOR => (Atom)68;

    public static Atom XA_LAST_PREDEFINED => (Atom)68;


    public readonly void* Value;

    public Atom(void* value)
    {
        Value = value;
    }

    public static Atom NULL => new Atom(null);

    public static bool operator ==(Atom left, Atom right) => left.Value == right.Value;

    public static bool operator !=(Atom left, Atom right) => left.Value != right.Value;

    public static bool operator <(Atom left, Atom right) => left.Value < right.Value;

    public static bool operator <=(Atom left, Atom right) => left.Value <= right.Value;

    public static bool operator >(Atom left, Atom right) => left.Value > right.Value;

    public static bool operator >=(Atom left, Atom right) => left.Value >= right.Value;

    public static explicit operator Atom(void* value) => new Atom(value);

    public static implicit operator void*(Atom value) => value.Value;

    public static explicit operator Atom(byte value) => new Atom(unchecked((void*)value));

    public static explicit operator byte(Atom value) => (byte)value.Value;

    public static explicit operator Atom(short value) => new Atom(unchecked((void*)value));

    public static explicit operator short(Atom value) => (short)value.Value;

    public static explicit operator Atom(int value) => new Atom(unchecked((void*)value));

    public static explicit operator int(Atom value) => (int)value.Value;

    public static explicit operator Atom(long value) => new Atom(unchecked((void*)value));

    public static explicit operator long(Atom value) => (long)value.Value;

    public static explicit operator Atom(nint value) => new Atom(unchecked((void*)value));

    public static implicit operator nint(Atom value) => (nint)value.Value;

    public static explicit operator Atom(sbyte value) => new Atom(unchecked((void*)value));

    public static explicit operator sbyte(Atom value) => (sbyte)value.Value;

    public static explicit operator Atom(ushort value) => new Atom(unchecked((void*)value));

    public static explicit operator ushort(Atom value) => (ushort)value.Value;

    public static explicit operator Atom(uint value) => new Atom(unchecked((void*)value));

    public static explicit operator uint(Atom value) => (uint)value.Value;

    public static explicit operator Atom(ulong value) => new Atom(unchecked((void*)value));

    public static explicit operator ulong(Atom value) => (ulong)value.Value;

    public static explicit operator Atom(nuint value) => new Atom(unchecked((void*)value));

    public static implicit operator nuint(Atom value) => (nuint)value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is Atom other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Atom.");
    }

    public int CompareTo(Atom other) => ((nuint)Value).CompareTo((nuint)other.Value);

    public override bool Equals(object? obj) => (obj is Atom other) && Equals(other);

    public bool Equals(Atom other) => ((nuint)Value).Equals((nuint)other.Value);

    public override int GetHashCode() => ((nuint)Value).GetHashCode();

    public override string ToString() => ((nuint)Value).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)Value).ToString(format, formatProvider);
}
