// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.Versioning;

using TerraFX.Interop.Xlib;

using static Prowl.Surface.Platforms.X11.X11PlatformImpl;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal unsafe class X11Window : Window
{
    private volatile bool _isDestroyed;

    public override nint Handle { get => (nint)_xWindow.Value; }
    internal XWindow _xWindow;


    public X11Window(WindowCreateOptions options) : base(options)
    {
        Size primaryScreenSize = Screen.Primary?.SizeInPixels ?? System.Drawing.Size.Empty;

        Point position = options.Position ?? new(primaryScreenSize / 2);
        Size size = options.Size ?? new(400, 300);

        VerifyNeedsParent();

        XWindow parentWindow = options.Kind switch
        {
            WindowKind.TopLevel or WindowKind.Popup => RootWindow,
            WindowKind.Child => ((X11Window)Parent!)._xWindow
        };

        lock (Lock)
        {
            XSetWindowAttributes attr;

            _xWindow = Xlib.XCreateWindow(
                Display,
                parentWindow,
                position.X, position.Y,
                (uint)size.Width, (uint)size.Height,
                0,
                0,
                Xlib.InputOutput,
                null,
                (nuint)(Xlib.CWBackPixel | Xlib.CWEventMask),
                &attr
            );

            if (_xWindow == XWindow.NULL)
            {
                Console.WriteLine("Failed to create window");
                return;
            }

            X11EventHandler.RegisterWindow(this);

            Atom deleteWindow = XUtility.WmDeleteWindow;
            Xlib.XSetWMProtocols(Display, _xWindow, &deleteWindow, 1);
        }

        if (options.Icon != null)
            SetIcon(options.Icon);

        // Title = options.Title;
        Enabled = true;
        Visible = options.Visible;
    }


    private WindowKind _kind;
    public override WindowKind Kind
    {
        get
        {
            VerifyNotDisposed();

            return _kind;
        }

        protected set
        {
            _kind = value;
        }
    }

    public override bool Decorations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Dpi Dpi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override DpiMode DpiMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public override bool Enabled
    {
        get
        {
            VerifyNotDisposed();

            lock (Lock)
            {
                Xlib.XGetWindowAttributes(Display, _xWindow, out XWindowAttributes attribs);

                return (attribs.your_event_mask & XUtility.GeneralMask) == XUtility.GeneralMask;
            }
        }

        set
        {
            VerifyNotDisposed();

            lock (Lock)
            {
                Xlib.XSelectInput(Display, _xWindow, value ? XUtility.GeneralMask : XEventMask.SubstructureNotifyMask);
            }
        }
    }

    public override bool IsDisposed => _isDestroyed || (Parent?.IsDisposed ?? false);

    public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override SizeF ClientSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    private bool _visible;
    public override bool Visible
    {
        get
        {
            VerifyNotDisposed();

            return _visible;
        }

        set
        {
            VerifyNotDisposed();

            if (_visible == value)
                return;

            lock (Lock)
            {
                _visible = value;

                if (_visible)
                    Xlib.XMapWindow(Display, _xWindow);
                else
                    Xlib.XUnmapWindow(Display, _xWindow);
            }
        }
    }


    public override bool DragDrop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override WindowCapabilities Capabilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override WindowState State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override float Opacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool TopMost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Size MinimumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Size MaximumSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool Modal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool ShowInTaskBar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public override void Focus() => throw new NotImplementedException();


    public override bool Close()
    {
        VerifyNotDisposed();

        lock (Lock)
        {
            _isDestroyed = true;

            X11EventHandler.RemoveWindow(this);
            return Xlib.XDestroyWindow(Display, _xWindow) == 1;
        }
    }


    public override Screen? GetScreen() => throw new NotImplementedException();
    public override void CenterToParent() => throw new NotImplementedException();
    public override void CenterToScreen() => throw new NotImplementedException();


    public override void SetIcon(Icon icon)
    {
        VerifyNotDisposed();

        X11Icon.SetWindowIcon(_xWindow, icon);
    }
}
