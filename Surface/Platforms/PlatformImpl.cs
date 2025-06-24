
using System;

using Prowl.Surface.Input;
using Prowl.Surface.Platforms;

namespace Prowl.Surface;

internal abstract class PlatformImpl
{
    public abstract nint NativeDisplayHandle { get; }
    public abstract ScreenManager ScreenManager { get; protected set; }
    public abstract EventHandler EventHandler { get; protected set; }
    public abstract ClipboardImpl ClipboardImpl { get; protected set; }
    public abstract IconImpl IconImpl { get; protected set; }
    public abstract CursorImpl CursorImpl { get; protected set; }

    public abstract Window CreateWindow(WindowCreateOptions options);
}
