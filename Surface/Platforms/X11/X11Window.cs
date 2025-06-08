// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal unsafe class X11Window : Window
{
    public X11Window(WindowCreateOptions options) : base(options)
    {
    }


    public override bool Decorations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Dpi Dpi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override DpiMode DpiMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Color BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Enable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool IsDisposed => throw new NotImplementedException();

    public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF ClientSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
