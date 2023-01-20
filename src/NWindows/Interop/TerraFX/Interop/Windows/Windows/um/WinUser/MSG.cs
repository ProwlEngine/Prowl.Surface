// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;
internal partial struct MSG
{
    /// <include file='MSG.xml' path='doc/member[@name="MSG.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='MSG.xml' path='doc/member[@name="MSG.message"]/*' />
    public uint message;

    /// <include file='MSG.xml' path='doc/member[@name="MSG.wParam"]/*' />
    public WPARAM wParam;

    /// <include file='MSG.xml' path='doc/member[@name="MSG.lParam"]/*' />
    public LPARAM lParam;
    public uint time;

    /// <include file='MSG.xml' path='doc/member[@name="MSG.pt"]/*' />
    public POINT pt;
}
