
using System;

using Prowl.Surface.Input;
namespace Prowl.Surface.Platforms.Win32;

internal class Win32PlatformImpl : PlatformImpl
{
    public override nint NativeDisplayHandle { get; }
    public override ScreenManager ScreenManager { get; protected set; }
    public override EventHandler EventHandler { get; protected set; }
    public override ClipboardImpl ClipboardImpl { get; protected set; }
    public override IconImpl IconImpl { get; protected set; }
    public override CursorImpl CursorImpl { get; protected set; }


    public Win32PlatformImpl()
    {
        ScreenManager = new Win32ScreenManager();
        EventHandler = new Win32EventHandler();
        ClipboardImpl = new Win32Clipboard();
        IconImpl = new Win32Icon();
        CursorImpl = new Win32Cursor();
    }


    public override Window CreateWindow(WindowCreateOptions options)
    {
        return new Win32Window(options);
    }
}
