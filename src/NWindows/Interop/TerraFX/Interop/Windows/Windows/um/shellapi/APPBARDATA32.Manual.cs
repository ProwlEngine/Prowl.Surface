// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal partial struct APPBARDATA32
{
    public uint cbSize;

    public HWND hWnd;

    public uint uCallbackMessage;

    public uint uEdge;

    public RECT rc;

    public LPARAM lParam;
}
