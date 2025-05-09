﻿using System;
using System.Threading.Tasks;

using Prowl.Surface.Input.Raw;
using Prowl.Surface.Platform.Interop;
using Prowl.Surface.Threading;

using Prowl.Vector;

using static Prowl.Surface.X11.XLib;
namespace Prowl.Surface.X11;

internal partial class X11Window
{
    private class XimInputMethod //: ITextInputMethodImpl, IX11InputMethodControl
    {
        private readonly X11Window _parent;
        private bool _windowActive, _imeActive;
        private Rect? _queuedCursorRect;
        //private ITextInputMethodClient? _client;

        public XimInputMethod(X11Window parent)
        {
            _parent = parent;
        }

        //public ITextInputMethodClient? Client => _client;

        //public bool IsActive => _client != null;

        public void SetCursorRect(Rect rect)
        {
            var needEnqueue = _queuedCursorRect == null;
            _queuedCursorRect = rect;
            if (needEnqueue)
                Dispatcher.UIThread.Post(() =>
                {
                    if (_queuedCursorRect == null)
                        return;
                    var rc = _queuedCursorRect.Value;
                    _queuedCursorRect = null;

                    if (_parent._xic == IntPtr.Zero)
                        return;

                    rect.x *= _parent._scaling;
                    rect.y *= _parent._scaling;
                    rect.width *= _parent._scaling;
                    rect.height *= _parent._scaling;

                    var pt = new XPoint
                    {
                        X = (short)Math.Min(Math.Max(rect.x, short.MinValue), short.MaxValue),
                        Y = (short)Math.Min(Math.Max(rect.y + rect.height, short.MinValue), short.MaxValue)
                    };

                    using var spotLoc = new Utf8Buffer(XNames.XNSpotLocation);
                    var list = XVaCreateNestedList(0, spotLoc, ref pt, IntPtr.Zero);
                    XSetICValues(_parent._xic, XNames.XNPreeditAttributes, list, IntPtr.Zero);
                    XFree(list);
                }, DispatcherPriority.Background);
        }

        public void SetWindowActive(bool active)
        {
            _windowActive = active;
            UpdateActive();
        }

        //public void SetClient(ITextInputMethodClient client)
        //{
        //    _client = client;
        //    UpdateActive();
        //}

        private void UpdateActive()
        {
            var active = _windowActive;// && IsActive;
            if (_parent._xic == IntPtr.Zero)
                return;
            if (active != _imeActive)
            {
                _imeActive = active;
                if (active)
                {
                    Reset();
                    XSetICFocus(_parent._xic);
                }
                else
                    XUnsetICFocus(_parent._xic);
            }
        }

        public void UpdateWindowInfo(PixelPoint position, double scaling)
        {
            // No-op
        }

        //public void SetOptions(TextInputOptions options)
        //{
        //    // No-op
        //}

        public void Reset()
        {
            if (_parent._xic == IntPtr.Zero)
                return;

            var data = XmbResetIC(_parent._xic);
            if (data != IntPtr.Zero)
                XFree(data);
        }

        public void Dispose()
        {
            // No-op
        }

        public bool IsEnabled => false;

        public ValueTask<bool> HandleEventAsync(RawKeyEventArgs args, int keyVal, int keyCode) =>
            new ValueTask<bool>(false);

        public event Action<string> Commit { add { } remove { } }
        //public event Action<X11InputMethodForwardedKey> ForwardKey { add { } remove { } }

    }

}
