// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Threading;

using Prowl.Surface.Input;
using Prowl.Surface.Threading;

using TerraFX.Interop.Xlib;

namespace Prowl.Surface.Platforms.X11;

/// <summary>
/// Implementation of the Dispatcher for Windows.
/// </summary>
[SupportedOSPlatform("linux")]
internal unsafe class X11Dispatcher : Dispatcher
{
    private Dictionary<XWindow, X11Window> _createdWindows = new();
    private XWindow _listenerWindow;


    internal void RegisterWindow(X11Window window)
    {
        _createdWindows.Add(window.XWindow, window);
    }


    internal void RemoveWindow(X11Window window)
    {
        _createdWindows.Remove(window.XWindow);
    }


    public X11Dispatcher(Thread thread) : base(thread)
    {
        ScreenManager = new X11ScreenManager();
        InputManager = new X11InputManager(this);

        _listenerWindow = Xlib.XCreateSimpleWindow(X11Globals.Display, X11Globals.RootWindow, 0, 0, 1, 1, 0, 0, 0);
        Xlib.XSelectInput(X11Globals.Display, _listenerWindow, XEventMask.PropertyChangeMask | XEventMask.StructureNotifyMask);
    }


    internal override ScreenManager ScreenManager { get; }
    internal override InputManager InputManager { get; }

    internal static new X11Dispatcher Current => (X11Dispatcher)Dispatcher.Current;


    internal override void CreateOrResetTimer(DispatcherTimer timer, int millis) => throw new NotImplementedException();

    internal override void DestroyTimer(DispatcherTimer timer) => throw new NotImplementedException();

    internal override void NotifyJobQueue()
    {

    }

    internal override void PostQuitToMessageLoop()
    {
        XEvent evt = new XEvent();
        evt.type = XEventName.ClientMessage;
        evt.xclient.message_type = XUtility.AppShutdown;

        Xlib.XSendEvent(X11Globals.Display, _listenerWindow, false, 0, &evt);
    }

    internal override void ResetImpl()
    {

    }


    internal override void WaitAndDispatchMessage(bool blockOnWait)
    {
        XEvent xevent = default;

        while (true)
        {
            if (blockOnWait)
                Xlib.XNextEvent(X11Globals.Display, out xevent);

            bool hasEvent = Xlib.XPending(X11Globals.Display) != 0;

            if (hasEvent || blockOnWait)
            {
                if (!blockOnWait)
                    Xlib.XNextEvent(X11Globals.Display, out xevent);

                HandleEvent(xevent);

                if (blockOnWait)
                {
                    hasEvent = Xlib.XPending(X11Globals.Display) != 0;

                    if (!hasEvent)
                        break;
                }
            }
            else
            {
                break;
            }
        }
    }


    private void HandleEvent(XEvent e)
    {
        if (e.type == XEventName.ClientMessage)
        {
            if (e.xclient.message_type == XUtility.AppShutdown)
            {
                DispatcherFrame? frame = CurrentFrame;
                if (frame != null)
                {
                    frame.Continue = false;
                }

                return;
            }

            if (e.xclient.message_type == XUtility.WmProtocols && e.xclient.data.l[0] == XUtility.WmDeleteWindow)
            {
                _createdWindows[e.xclient.window].Close();
                return;
            }
        }
    }
}
