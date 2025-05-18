using System;
using System.Runtime.InteropServices;

using Prowl.Surface.Mac.Interop;
using Prowl.Surface.Platform;

using Prowl.Vector;

namespace Prowl.Surface.Native;

internal unsafe class DeferredFramebuffer : ILockedFramebuffer
{
    private readonly Func<Action<IAvnWindowBase>, bool> _lockWindow;

    public DeferredFramebuffer(Func<Action<IAvnWindowBase>, bool> lockWindow,
                               int width, int height, Vector2 dpi)
    {
        _lockWindow = lockWindow;
        Address = Marshal.AllocHGlobal(width * height * 4);
        Size = new PixelSize(width, height);
        RowBytes = width * 4;
        Dpi = dpi;
        Format = PixelFormat.Bgra8888;
    }

    public IntPtr Address { get; set; }
    public PixelSize Size { get; set; }
    public int Height { get; set; }
    public int RowBytes { get; set; }
    public Vector2 Dpi { get; set; }
    public PixelFormat Format { get; set; }

    class Disposer : NativeCallbackBase
    {
        private IntPtr _ptr;

        public Disposer(IntPtr ptr)
        {
            _ptr = ptr;
        }

        protected override void Destroyed()
        {
            if (_ptr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_ptr);
                _ptr = IntPtr.Zero;
            }
        }
    }

    public void Dispose()
    {
        if (Address == IntPtr.Zero)
            return;

        if (!_lockWindow(win =>
        {
            var fb = new AvnFramebuffer
            {
                Data = Address.ToPointer(),
                Dpi = new AvnVector
                {
                    X = Dpi.x,
                    Y = Dpi.y
                },
                Width = Size.Width,
                Height = Size.Height,
                PixelFormat = (AvnPixelFormat)Format.FormatEnum,
                Stride = RowBytes
            };

            using (var d = new Disposer(Address))
            {
                win.ThreadSafeSetSwRenderedFrame(&fb, d);
            }
        }))
        {
            Marshal.FreeHGlobal(Address);
        }

        Address = IntPtr.Zero;
    }
}
