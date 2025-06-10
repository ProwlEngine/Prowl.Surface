// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Versioning;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal unsafe class X11Window : Window
{
    private bool _disposed;

    internal XWindow XWindow => (XWindow)Handle;


    public X11Window(WindowCreateOptions options) : base(options)
    {
        Size primaryScreenSize = Dispatcher.ScreenManager.GetPrimaryScreen()?.SizeInPixels ?? System.Drawing.Size.Empty;
        Point position = options.Position ?? new(primaryScreenSize / 2);
        Size size = options.Size ?? new(400, 300);

        XColor background = XUtility.GetColor(options.BackgroundColor ?? Color.Black);

        // Setup window attributes
        XSetWindowAttributes attr = new()
        {
            background_pixel = background.pixel,
            event_mask = XUtility.GeneralMask
        };

        // Create the window (depth = CopyFromParent = 0)
        Handle = Xlib.XCreateWindow(
            X11Globals.Display,
            X11Globals.RootWindow,
            position.X, position.Y,
            (uint)size.Width, (uint)size.Height,
            0,
            0,
            Xlib.InputOutput,
            null,
            (nuint)(Xlib.CWBackPixel | Xlib.CWEventMask),
            &attr
        );

        if (Handle == IntPtr.Zero)
        {
            Console.WriteLine("Failed to create window");
            return;
        }

        Atom deleteWindow = XUtility.WmDeleteWindow;
        Xlib.XSetWMProtocols(X11Globals.Display, XWindow, &deleteWindow, 1);

        Title = options.Title;

        if (options.Icon != null)
            SetIcon(options.Icon);

        X11Dispatcher.Current.RegisterWindow(this);

        Xlib.XMapWindow(X11Globals.Display, XWindow);
    }


    public override bool Decorations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Dpi Dpi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override DpiMode DpiMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Color BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Enable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool IsDisposed => _disposed;


    private string _windowTitle;
    public override string Title
    {
        get
        {
            VerifyAccess();
            return _windowTitle;
        }

        set
        {
            VerifyAccessAndNotDestroyed();
            if (_windowTitle == value)
                return;

            _windowTitle = value;
            Xlib.XStoreName(X11Globals.Display, XWindow, _windowTitle);

            fixed (byte* strBytes = System.Text.Encoding.UTF8.GetBytes(_windowTitle + '\0'))
            {
                byte** strArray = stackalloc byte*[1];
                strArray[0] = strBytes;

                Xlib.XStringListToTextProperty(strArray, 1, out XTextProperty property);
                Xlib.XSetWMName(X11Globals.Display, XWindow, &property);
                Xlib.XFree(property.value);
            }
        }
    }


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

    private float _opacity;
    public override float Opacity
    {
        get
        {
            VerifyAccess();
            return _opacity;
        }

        set
        {
            VerifyAccessAndNotDestroyed();
            if (_opacity == value)
                return;

            _opacity = value;

            ulong opacity = (ulong)(0xFFFFFFFFul * _opacity);

            Xlib.XChangeProperty(X11Globals.Display, XWindow, XUtility.WmWindowOpacity, Atom.XA_CARDINAL, 32,
                Xlib.PropModeReplace, (byte*)&opacity, 1);
        }
    }

    public override bool TopMost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF MinimumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF MaximumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Modal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool ShowInTaskBar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Activate() => throw new NotImplementedException();
    public override void CenterToParent() => throw new NotImplementedException();
    public override void CenterToScreen() => throw new NotImplementedException();
    public override Point ClientToScreen(PointF position) => throw new NotImplementedException();

    public override bool Close()
    {
        return HandleClose();
    }

    private bool HandleClose()
    {
        _closeEvent.Cancel = false;
        OnWindowEvent(_closeEvent);

        if (!_closeEvent.Cancel)
        {
            Destroy();
            return true;
        }

        return false;
    }

    internal void Destroy()
    {
        Xlib.XDestroyWindow(X11Globals.Display, XWindow);
        X11Dispatcher.Current.RemoveWindow(this);
        _disposed = true;
    }

    public override void Focus() => throw new NotImplementedException();
    public override Screen? GetScreen() => throw new NotImplementedException();
    public override PointF ScreenToClient(Point position) => throw new NotImplementedException();

    public override void SetIcon(Icon icon)
    {
        X11Icon.SetWindowIcon(XWindow, icon);
    }
}
