// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XClientMessageEvent
{
    public XEventName type;

    [NativeTypeName("unsigned long")]
    public nuint serial;

    public int send_event;

    public XDisplay* display;

    public XWindow window;

    public Atom message_type;

    public int format;

    [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:905:2)")]
    public _data_e__Union data;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _data_e__Union
    {
        [FieldOffset(0)]
        public fixed sbyte b[20];

        [FieldOffset(0)]
        public fixed short s[10];

        [FieldOffset(0)]
        public fixed long l[5];
    }
}
