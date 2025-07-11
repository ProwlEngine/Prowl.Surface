// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;

using Prowl.Surface.Events;

using TerraFX.Interop.Windows;
using TerraFX.Interop.WinRT;

using static TerraFX.Interop.Windows.CS;
using static TerraFX.Interop.Windows.GWLP;
using static TerraFX.Interop.Windows.IDC;
using static TerraFX.Interop.Windows.IDI;
using static TerraFX.Interop.Windows.PM;
using static TerraFX.Interop.Windows.Windows;
using static TerraFX.Interop.Windows.WM;

namespace Prowl.Surface.Platforms.Win32;

/// <summary>
/// Implementation of the Dispatcher for Windows.
/// </summary>
[SupportedOSPlatform("windows10.0.14393.0")]
internal unsafe class Win32Dispatcher
{
    private Win32Message _previousMessage;
    internal HWND Hwnd;

    private readonly List<Win32Window> _windows;
    private readonly Dictionary<HWND, Win32Window> _mapHandleToWindow;

    private readonly uint _uxdDisplayChangeMessage;
    private readonly uint _hotplugDetected;
    private readonly uint WM_DISPATCHER_QUEUE;
    private readonly SystemEvent _systemEvent;

    private static readonly object GlobalLock = new object();


    [ThreadStatic]
    private static HHOOK _keyboardHook;

    /// <summary>
    /// Windows 10 1607 => 10.0.14393
    /// </summary>
    private static readonly Version MinimumWindowsVersion = new Version(10, 0, 14393, 0);
    private const string WindowsVersion = "Windows 10 1607";


    [ThreadStatic] internal static GCHandle CreatedWindowHandle;

    public Win32Dispatcher() : base()
    {
        // Make sure that we are supporting the Windows version
        // This should be guaranteed by .NET 7 OS requirements, but we are still double checking
        if (Environment.OSVersion.Version < MinimumWindowsVersion)
        {
            throw new PlatformNotSupportedException($"The Windows version {Environment.OSVersion.Version} is not supported. Expecting at least {WindowsVersion} ({MinimumWindowsVersion})");
        }

        _windows = new List<Win32Window>();
        _mapHandleToWindow = new Dictionary<HWND, Win32Window>();
        _systemEvent = new SystemEvent();

        // Initialize Ole (for drag&drop)
        // Force to unknown before setting STA to avoid a runtime error
        Win32Ole.Initialize();

        // Initialize WinRT (required for Win32WindowSettings)
        WinRT.Initialize();

        // Initialization of the keyboard hook only on the dispatcher thread
        lock (GlobalLock)
        {
            if (_keyboardHook == 0)
            {
                _keyboardHook = SetWindowsHookExW(WH.WH_KEYBOARD_LL, &LowLevelKeyboardProc, Win32Helper.ModuleHandle, 0);
            }
        }

        // Load the default icon application
        var icon = LoadIconW(Win32Helper.ModuleHandle, IDI_APPLICATION);

        var guidAsString = Guid.NewGuid().ToString("N");
        var className = $"Surface-{guidAsString}";
        fixed (char* lpszClassName = className)
        {
            // Initialize the window class.
            var windowClass = new WNDCLASSEXW
            {
                cbSize = (uint)sizeof(WNDCLASSEXW),
                style = CS_DBLCLKS | CS_HREDRAW | CS_VREDRAW,
                lpfnWndProc = &StaticWindowProc,
                hInstance = Win32Helper.ModuleHandle,
                hIcon = icon,
                hIconSm = icon,
                hCursor = LoadCursorW(HINSTANCE.NULL, IDC_ARROW),
                hbrBackground = (HBRUSH)(COLOR.COLOR_WINDOW + 1), // Default background color, we should not change this but change it in the Window Create options
                lpszClassName = (ushort*)lpszClassName
            };

            ClassAtom = RegisterClassExW(&windowClass);
            if (ClassAtom == 0)
            {
                // This should never happen, but in case.
                throw new InvalidOperationException($"Failed to initialize Windows Dispatcher.");
            }
        }

        // TODO: only valid for Window Creator Update
        var oldContext = SetThreadDpiAwarenessContext((DPI_AWARENESS_CONTEXT)DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2);
        if (oldContext != IntPtr.Zero)
        {
            var newContext = GetThreadDpiAwarenessContext();
            if (newContext == oldContext)
            {
                Debug.WriteLine("Invalid DPI changed");
            }
        }

        fixed (char* lpszClassName = "UxdDisplayChangeMessage")
        {
            _uxdDisplayChangeMessage = RegisterWindowMessageW((ushort*)lpszClassName);
        }

        fixed (char* lpszClassName = "HotplugDetected")
        {
            _hotplugDetected = RegisterWindowMessageW((ushort*)lpszClassName);
        }

        fixed (char* lpszWindowMessage = "Surface.DispatcherProcessQueue")
            WM_DISPATCHER_QUEUE = RegisterWindowMessageW((ushort*)lpszWindowMessage);

        var windowName = $"Surface-Dispatcher-{guidAsString}";
        fixed (char* lpWindowName = windowName)
            Hwnd = CreateWindowEx(0, (ushort*)ClassAtom, (ushort*)lpWindowName, 0, 0, 0, 0, 0, HWND.HWND_MESSAGE, HMENU.NULL, HINSTANCE.NULL, null);
    }

    ~Win32Dispatcher()
    {
        ReleaseUnmanagedResources();
    }

    public ushort ClassAtom { get; }

    internal bool PollEventImpl()
    {
        return false;

        /*
        MSG msg;

        // We process as many messages as we can in a loop
        while (true)
        {
            // Use Peek/Get to handle idle
            var msgResult = blockOnWait
                ? GetMessageW(&msg, HWND.NULL, wMsgFilterMin: WM_NULL, wMsgFilterMax: WM_NULL)
                : PeekMessageW(&msg, HWND.NULL, wMsgFilterMin: WM_NULL, wMsgFilterMax: WM_NULL, wRemoveMsg: PM_REMOVE);

            if (msgResult)
            {
                // MSDN documentation says that if it returns -1, there is something wrong
                if (msgResult.Value == -1)
                {
                    throw new InvalidOperationException("Unexpected error while processing Win32 message");
                }

                if (msg.message == WM_QUIT)
                {
                    var frame = CurrentFrame;
                    if (frame != null)
                    {
                        frame.Continue = false;
                    }
                    Hwnd = HWND.NULL;
                }
                else
                {
                    TranslateMessage(&msg);
                    _ = DispatchMessageW(&msg);
                }

                if (blockOnWait)
                {
                    // Check if we have any pending messages in case of blocking
                    // If we don't have any messages, exit this loop to give the Idle event a chance to trigger
                    msgResult = PeekMessageW(&msg, HWND.NULL, wMsgFilterMin: WM_NULL, wMsgFilterMax: WM_NULL, wRemoveMsg: PM_NOREMOVE);
                    if (!msgResult)
                    {
                        break;
                    }
                }
            }
            else
            {
                break;
            }
        }
        */
    }

    private void RegisterWindow(Win32Window window)
    {
        _windows.Add(window);
        _mapHandleToWindow[(HWND)window.Handle] = window;
    }


    private void UnRegisterWindow(Win32Window window)
    {
        _windows.Remove(window);
        _mapHandleToWindow.Remove((HWND)window.Handle);
    }

    public bool TryGetWindowByHandle(HWND handle, [NotNullWhen(true)] out Win32Window? window)
    {
        return _mapHandleToWindow.TryGetValue(handle, out window);
    }

    internal bool TryHandleScreenChanges(HWND hWnd, uint message, WPARAM wParam, LPARAM lParam)
    {
        // https://stackoverflow.com/a/33762334/1356325
        bool updateScreens = false;
        switch (message)
        {
            case WM_DEVICECHANGE:
            case WM_SETTINGCHANGE:
            case WM_DISPLAYCHANGE:
                updateScreens = true;
                break;
            default:
                if (message == _uxdDisplayChangeMessage)
                {
                    updateScreens = true;
                }
                else if (message == _hotplugDetected)
                {
                    updateScreens = true;
                }
                break;

        }

        return updateScreens && Platform.PlatformImpl.ScreenManager.TryUpdateScreens();
    }

    private LRESULT WindowProc(HWND hWnd, uint message, WPARAM wParam, LPARAM lParam)
    {
        /*
        // Install our synchronization context
        SynchronizationContext.SetSynchronizationContext(DispatcherSynchronizationContext);

        if (Hwnd == 0)
        {
            Hwnd = hWnd;
        }

        LRESULT result = -1;
        try
        {
            // Output debug messages if requested
            if (DebugInternal && DebugOutputInternal is { } debugOutput)
            {
                var newMessage = new Win32Message(hWnd, message, wParam, lParam);
                if (_previousMessage != newMessage || message == WM_TIMER)
                {
                    debugOutput(newMessage.ToString());
                    _previousMessage = newMessage;
                }
            }

            if (hWnd == Hwnd)
            {
                if (message == WM_DISPATCHER_QUEUE)
                {
                    ProcessJobQueue();
                    result = 0;
                }
                else if (message == WM_TIMER)
                {
                    // We are calling the timer directly instead of going through the queue
                    if (_mapTimerIdToTimer.TryGetValue((nuint)wParam, out var timer))
                    {
                        timer.OnTick();
                    }
                    result = 0;
                }
            }
            else
            {
                var handle = GetWindowLongPtrW(hWnd, GWLP_USERDATA);
                Win32Window winWindow;
                if (handle == 0)
                {
                    winWindow = (Win32Window)CreatedWindowHandle.Target!;
                    handle = GCHandle.ToIntPtr(CreatedWindowHandle);
                    _ = SetWindowLongPtrW(hWnd, GWLP_USERDATA, handle);
                }
                else
                {
                    winWindow = (Win32Window)GCHandle.FromIntPtr(handle).Target!;
                }

                switch (message)
                {
                    case WM_CREATE:
                        RegisterWindow(winWindow);
                        result = winWindow.WindowProc(hWnd, message, wParam, lParam);
                        break;

                    case WM_DESTROY:
                        result = winWindow.WindowProc(hWnd, message, wParam, lParam);
                        UnRegisterWindow(winWindow);
                        break;

                    default:
                        result = winWindow.WindowProc(hWnd, message, wParam, lParam);
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            // We need to handle the filter here
            bool throwBackException = !FilterException(ex) || !HandleException(ex);
            if (throwBackException)
            {
                // If we have an unhandled exception pass it back to the frame (outside of the wndproc)
                // to properly flow it back to the render loop
                CurrentFrame?.CaptureException(ExceptionDispatchInfo.Capture(ex));
            }

            // We should never crash with an exception in a WindowProc
            result = -1;
        }
        finally
        {
            if (result < 0)
            {
                result = DefWindowProcW(hWnd, message, wParam, lParam);
            }
        }

        return result;
        */

        return default;
    }

    [UnmanagedCallersOnly]
    private static LRESULT StaticWindowProc(HWND hWnd, uint message, WPARAM wParam, LPARAM lParam)
    {
        return default; // Current.WindowProc(hWnd, message, wParam, lParam);
    }

    private void ReleaseUnmanagedResources()
    {
        if (ClassAtom != 0)
        {
            UnregisterClassW((ushort*)ClassAtom, Win32Helper.ModuleHandle);
        }
    }

    [UnmanagedCallersOnly]
    private static LRESULT LowLevelKeyboardProc(int nCode, WPARAM wParam, LPARAM lParam)
    {
        /*
        // From https://learn.microsoft.com/en-us/windows/win32/dxtecharts/disabling-shortcut-keys-in-games
        // We want to make sure that the Win keys are not going to be able to modify the position of a fullscreen window
        // So this hook will discard the LWIN/RWIN keys if we have such a window active
        var keyboardHook = _keyboardHook;
        if (nCode == HC_ACTION)
        {
            var currentDispatcher = (Win32Dispatcher?)CurrentDispatcher;

            var p = (KBDLLHOOKSTRUCT*)lParam;
            switch ((int)wParam)
            {
                case WM_KEYDOWN:
                case WM_KEYUP:
                    {
                        // Prevent Win keys to modify the window state
                        // Note that this will not block the Xbox Game Bar hotkeys (Win+G, Win+Alt+R, etc.)
                        if (currentDispatcher != null && false && (p->vkCode == VK.VK_LWIN) || (p->vkCode == VK.VK_RWIN))
                        {
                            return 1;
                        }
                        break;
                    }
            }
        }

        return CallNextHookEx(keyboardHook, nCode, wParam, lParam);
        */

        return default;
    }
}
