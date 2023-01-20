// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;
internal partial struct POINT {

    public static bool operator ==(in POINT l, in POINT r)
    {
        return (l.x == r.x)
            && (l.y == r.y);
    }

    public static bool operator !=(in POINT l, in POINT r)
        => !(l == r);

    public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

    public bool Equals(POINT other) => this == other;

    public override int GetHashCode() => HashCode.Combine(x, y);
}
