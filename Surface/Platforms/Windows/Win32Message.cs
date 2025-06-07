// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.Versioning;

using TerraFX.Interop.Windows;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("windows10.0.14393.0")]
internal readonly record struct Win32Message(HWND HWnd, uint Message, WPARAM WParam, LPARAM LParam)
{
    public override string ToString()
    {
        return $"HWND: 0x{(nint)HWnd:X16} Message: {Win32Helper.GetMessageName(Message)} WPARAM: 0x{WParam.Value:x16} LPARAM: 0x{LParam.Value:x16}";
    }
}
