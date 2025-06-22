// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using Prowl.Surface.Events;
using Prowl.Surface.Input;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.WS;
using static TerraFX.Interop.Windows.HWND;
using static TerraFX.Interop.Windows.MK;
using static TerraFX.Interop.Windows.SWP;
using static TerraFX.Interop.Windows.Windows;
using static TerraFX.Interop.Windows.WM;
using static TerraFX.Interop.Windows.TME;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Win32;

// TODO to handle:
// - WM_POINTERUPDATE https://learn.microsoft.com/en-us/windows/win32/inputmsg/wm-pointerupdate
// - WM_INPUT https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-input


[SupportedOSPlatform("windows10.0.14393.0")]
internal unsafe class Win32Window : Window
{
    public Win32Window(WindowCreateOptions options)
    {

    }

    public override nint Handle { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
    public override WindowKind Kind { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
    public override bool Decorations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Color BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Enable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool IsDisposed => throw new NotImplementedException();

    public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Size ClientSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool DragDrop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Resizeable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Maximizeable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Minimizeable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override INativeWindow? Parent => throw new NotImplementedException();

    public override WindowState State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override float Opacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool TopMost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF MinimumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF MaximumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Modal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool ShowInTaskBar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Activate() => throw new NotImplementedException();
    public override void CenterToParent() => throw new NotImplementedException();
    public override void CenterToScreen() => throw new NotImplementedException();
    public override Point ClientToScreen(PointF position) => throw new NotImplementedException();
    public override bool Close() => throw new NotImplementedException();
    public override void Focus() => throw new NotImplementedException();
    public override Screen? GetScreen() => throw new NotImplementedException();
    public override PointF ScreenToClient(Point position) => throw new NotImplementedException();
    public override void SetIcon(Icon icon) => throw new NotImplementedException();
}
