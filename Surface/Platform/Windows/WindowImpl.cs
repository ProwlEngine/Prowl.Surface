﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

using Prowl.Surface.Controls;
using Prowl.Surface.Input;
using Prowl.Surface.Input.Platform;
using Prowl.Surface.Input.Raw;
using Prowl.Surface.Platform;
using Prowl.Surface.Platform.Storage;
using Prowl.Surface.Win32.Input;
using Prowl.Surface.Win32.Interop;
using Prowl.Surface.Win32.WinRT;

using Prowl.Vector;

using static Prowl.Surface.Win32.Interop.UnmanagedMethods;

namespace Prowl.Surface.Win32;

/// <summary>
/// Window implementation for Win32 platform.
/// </summary>
internal partial class WindowImpl : IWindowImpl //, EglGlPlatformSurface.IEglWindowGlPlatformSurfaceInfo
{
    private static readonly List<WindowImpl> s_instances = new();

    private static readonly IntPtr s_defaultCursor = LoadCursor(
        IntPtr.Zero, new IntPtr((int)UnmanagedMethods.Cursor.IDC_ARROW));

    private static readonly Dictionary<WindowEdge, HitTestValues> s_edgeLookup =
        new()
        {
            { WindowEdge.East, HitTestValues.HTRIGHT },
            { WindowEdge.North, HitTestValues.HTTOP },
            { WindowEdge.NorthEast, HitTestValues.HTTOPRIGHT },
            { WindowEdge.NorthWest, HitTestValues.HTTOPLEFT },
            { WindowEdge.South, HitTestValues.HTBOTTOM },
            { WindowEdge.SouthEast, HitTestValues.HTBOTTOMRIGHT },
            { WindowEdge.SouthWest, HitTestValues.HTBOTTOMLEFT },
            { WindowEdge.West, HitTestValues.HTLEFT }
        };

    private SavedWindowInfo _savedWindowInfo;
    private bool _isFullScreenActive;
    private bool _isClientAreaExtended;
    private Thickness _extendedMargins;
    private Thickness _offScreenMargin;
    private double _extendTitleBarHint = -1;
    private readonly bool _isUsingComposition;
    private readonly IBlurHost? _blurHost;
    private WindowResizeReason _resizeReason;
    private MOUSEMOVEPOINT _lastWmMousePoint;

#if USE_MANAGED_DRAG
    private readonly ManagedWindowResizeDragHelper _managedDrag;
#endif

    private const WindowStyles WindowStateMask = WindowStyles.WS_MAXIMIZE | WindowStyles.WS_MINIMIZE;
    private readonly TouchDevice _touchDevice;
    private readonly WindowsMouseDevice _mouseDevice;
    //private readonly PenDevice _penDevice;
    private readonly FramebufferManager _framebuffer;
    private readonly object? _gl;
    private readonly bool _wmPointerEnabled;

    //private readonly Win32NativeControlHost _nativeControlHost;
    private readonly IStorageProvider _storageProvider;
    private WndProc _wndProcDelegate;
    private string? _className;
    private IntPtr _hwnd;
    private IInputRoot? _owner;
    private WindowProperties _windowProperties;
    private bool _trackingMouse;//ToDo - there is something missed. Needs investigation @Steven Kirk
    private bool _topmost;
    private double _scaling = 1;
    private WindowState _showWindowState;
    private WindowState _lastWindowState;
    //private OleDropTarget? _dropTarget;
    private Vector2 _minSize;
    private Vector2 _maxSize;
    private POINT _maxTrackSize;
    private WindowImpl? _parent;
    private ExtendClientAreaChromeHints _extendChromeHints = ExtendClientAreaChromeHints.Default;
    private bool _isCloseRequested;
    private bool _shown;
    private bool _hiddenWindowIsParent;
    private uint _langid;
    internal bool _ignoreWmChar;
    private WindowTransparencyLevel _transparencyLevel;

    //private const int MaxPointerHistorySize = 512;
    //private static readonly PooledList<RawPointerPoint> s_intermediatePointsPooledList = new();
    //private static POINTER_TOUCH_INFO[]? s_historyTouchInfos;
    //private static POINTER_PEN_INFO[]? s_historyPenInfos;
    //private static POINTER_INFO[]? s_historyInfos;
    //private static MOUSEMOVEPOINT[]? s_mouseHistoryInfos;

    public WindowImpl()
    {
        _touchDevice = new TouchDevice();
        _mouseDevice = new WindowsMouseDevice();
        //_penDevice = new PenDevice();

#if USE_MANAGED_DRAG
        _managedDrag = new ManagedWindowResizeDragHelper(this, capture =>
        {
            if (capture)
                UnmanagedMethods.SetCapture(Handle.Handle);
            else
                UnmanagedMethods.ReleaseCapture();
        });
#endif

        _windowProperties = new WindowProperties
        {
            ShowInTaskbar = true,
            IsResizable = true,
            Decorations = SystemDecorations.Full
        };

        //var glPlatform = AvaloniaLocator.Current.GetService<IPlatformGraphics>();

        //var compositionConnector = AvaloniaLocator.Current.GetService<WinUiCompositorConnection>();

        //var isUsingAngleDX11 = glPlatform is AngleWin32PlatformGraphics angle &&
        //              angle.PlatformApi == AngleOptions.PlatformApi.DirectX11;
        //_isUsingComposition = compositionConnector is { } && isUsingAngleDX11;

        //DxgiConnection? dxgiConnection = null;
        //var isUsingDxgiSwapchain = false;
        //if (!_isUsingComposition)
        //{
        //    dxgiConnection = AvaloniaLocator.Current.GetService<DxgiConnection>();
        //    isUsingDxgiSwapchain = dxgiConnection is { } && isUsingAngleDX11;
        //}

        _wmPointerEnabled = Win32Platform.WindowsVersion >= PlatformConstants.Windows8;

        CreateWindow();
        _framebuffer = new FramebufferManager(_hwnd);

        if (this is not PopupImpl)
        {
            UpdateInputMethod(GetKeyboardLayout(0));
        }

        //if (glPlatform != null)
        //{
        //    if (_isUsingComposition)
        //    {
        //        var cgl = compositionConnector!.CreateSurface(this);
        //        _blurHost = cgl;
        //        _gl = cgl;
        //    }
        //    else if (isUsingDxgiSwapchain)
        //    {
        //        var dxgigl = new DxgiSwapchainWindow(dxgiConnection!, this);
        //        _gl = dxgigl;
        //    }
        //    else
        //    {
        //        if (glPlatform is AngleWin32PlatformGraphics)
        //            _gl = new EglGlPlatformSurface(this);
        //        else if (glPlatform is WglPlatformOpenGlInterface)
        //            _gl = new WglGlPlatformSurface(this);
        //    }
        //}

        Screen = new ScreenImpl();
        _storageProvider = new Win32StorageProvider(this);

        //_nativeControlHost = new Win32NativeControlHost(this, _isUsingComposition);
        _transparencyLevel = _isUsingComposition ? WindowTransparencyLevel.Transparent : WindowTransparencyLevel.None;
        s_instances.Add(this);
    }

    internal IInputRoot Owner
        => _owner; // ?? throw new InvalidOperationException($"{nameof(SetInputRoot)} must have been called");

    public Action? Activated { get; set; }

    public Func<WindowCloseReason, bool>? Closing { get; set; }

    public Action? Closed { get; set; }

    public Action? Deactivated { get; set; }

    public Action<RawInputEventArgs>? Input { get; set; }

    public Action<Rect>? Paint { get; set; }

    public Action<Vector2, WindowResizeReason>? Resized { get; set; }

    public Action<double>? ScalingChanged { get; set; }

    public Action<PixelPoint>? PositionChanged { get; set; }

    public Action<WindowState>? WindowStateChanged { get; set; }

    public Action? LostFocus { get; set; }

    public Action<WindowTransparencyLevel>? TransparencyLevelChanged { get; set; }

    public Thickness BorderThickness
    {
        get
        {
            if (HasFullDecorations)
            {
                var style = GetStyle();
                var exStyle = GetExtendedStyle();

                var padding = new RECT();

                if (AdjustWindowRectEx(ref padding, (uint)style, false, (uint)exStyle))
                {
                    return new Thickness(-padding.left, -padding.top, padding.right, padding.bottom);
                }
                else
                {
                    throw new Win32Exception();
                }
            }
            else
            {
                return new Thickness();
            }
        }
    }

    private double PrimaryScreenRenderScaling => Screen.AllScreens.FirstOrDefault(screen => screen.IsPrimary)?.Scaling ?? 1;

    public double RenderScaling => _scaling;

    public double DesktopScaling => RenderScaling;

    public Vector2 ClientSize
    {
        get
        {
            GetClientRect(_hwnd, out var rect);

            return new Vector2(rect.right, rect.bottom) / RenderScaling;
        }
    }

    public Vector2? FrameSize
    {
        get
        {
            if (DwmIsCompositionEnabled(out var compositionEnabled) != 0 || !compositionEnabled)
            {
                GetWindowRect(_hwnd, out var rcWindow);
                return new Vector2(rcWindow.Width, rcWindow.Height) / RenderScaling;
            }

            DwmGetWindowAttribute(_hwnd, (int)DwmWindowAttribute.DWMWA_EXTENDED_FRAME_BOUNDS, out var rect, Marshal.SizeOf<RECT>());
            return new Vector2(rect.Width, rect.Height) / RenderScaling;
        }
    }

    public IScreenImpl Screen { get; }

    public IPlatformHandle Handle { get; private set; }

    public virtual Vector2 MaxAutoSizeHint => new Vector2(_maxTrackSize.X / RenderScaling, _maxTrackSize.Y / RenderScaling);

    public IMouseDevice MouseDevice => _mouseDevice;

    public WindowState WindowState
    {
        get
        {
            if (!IsWindowVisible(_hwnd))
            {
                return _showWindowState;
            }

            if (_isFullScreenActive)
            {
                return WindowState.FullScreen;
            }

            var placement = default(WINDOWPLACEMENT);
            GetWindowPlacement(_hwnd, ref placement);

            return placement.ShowCmd switch
            {
                ShowWindowCommand.Maximize => WindowState.Maximized,
                ShowWindowCommand.Minimize => WindowState.Minimized,
                _ => WindowState.Normal
            };
        }

        set
        {
            if (IsWindowVisible(_hwnd) && _lastWindowState != value)
            {
                ShowWindow(value, value != WindowState.Minimized); // If the window is minimized, it shouldn't be activated
            }

            _lastWindowState = value;
            _showWindowState = value;
        }
    }

    public WindowTransparencyLevel TransparencyLevel
    {
        get => _transparencyLevel;
        private set
        {
            if (_transparencyLevel != value)
            {
                _transparencyLevel = value;
                TransparencyLevelChanged?.Invoke(value);
            }
        }
    }

    protected IntPtr Hwnd => _hwnd;

    private bool IsMouseInPointerEnabled => _wmPointerEnabled && IsMouseInPointerEnabled();

    public object? TryGetFeature(Type featureType)
    {
        //if (featureType == typeof(ITextInputMethodImpl))
        //{
        //    return Imm32InputMethod.Current;
        //}

        //if (featureType == typeof(INativeControlHostImpl))
        //{
        //    return _nativeControlHost;
        //}

        if (featureType == typeof(IStorageProvider))
        {
            return _storageProvider;
        }

        if (featureType == typeof(IClipboard))
        {
            return AvaloniaLocator.Current.GetRequiredService<IClipboard>();
        }

        return null;
    }

    public void SetTransparencyLevelHint(IReadOnlyList<WindowTransparencyLevel> transparencyLevels)
    {
        var windowsVersion = Win32Platform.WindowsVersion;

        foreach (var level in transparencyLevels)
        {
            if (!IsSupported(level, windowsVersion))
                continue;
            if (level == TransparencyLevel)
                return;
            if (level == WindowTransparencyLevel.Transparent)
                SetTransparencyTransparent(windowsVersion);
            else if (level == WindowTransparencyLevel.Blur)
                SetTransparencyBlur(windowsVersion);
            else if (level == WindowTransparencyLevel.AcrylicBlur)
                SetTransparencyAcrylicBlur(windowsVersion);
            else if (level == WindowTransparencyLevel.Mica)
                SetTransparencyMica(windowsVersion);

            TransparencyLevel = level;
            return;
        }

        // If we get here, we didn't find a supported level. Use the defualt of Transparent or
        // None, depending on whether composition is enabled.
        if (_isUsingComposition)
        {
            SetTransparencyTransparent(windowsVersion);
            TransparencyLevel = WindowTransparencyLevel.Transparent;
        }
        else
        {
            TransparencyLevel = WindowTransparencyLevel.None;
        }
    }

    private bool IsSupported(WindowTransparencyLevel level, Version windowsVersion)
    {
        // Only None is suppported when composition is disabled.
        if (!_isUsingComposition)
            return level == WindowTransparencyLevel.None;

        // When composition is enabled, None is not supported because the backing visual always
        // has an alpha channel
        if (level == WindowTransparencyLevel.None)
            return false;

        // Transparent only supported on Windows 8+.
        if (level == WindowTransparencyLevel.Transparent)
            return windowsVersion >= PlatformConstants.Windows8;

        // Blur only supported on Windows 8 and lower.
        if (level == WindowTransparencyLevel.Blur)
            return windowsVersion < PlatformConstants.Windows10;

        //// Acrylic is supported on Windows >= 10.0.15063.
        //if (level == WindowTransparencyLevel.AcrylicBlur)
        //    return windowsVersion >= WinUiCompositionShared.MinAcrylicVersion;

        //// Mica is supported on Windows >= 10.0.22000.
        //if (level == WindowTransparencyLevel.Mica)
        //    return windowsVersion >= WinUiCompositionShared.MinHostBackdropVersion;

        return false;
    }

    private void SetTransparencyTransparent(Version windowsVersion)
    {
        // Transparent only supported with composition on Windows 8+.
        if (!_isUsingComposition || windowsVersion < PlatformConstants.Windows8)
            return;

        if (windowsVersion < PlatformConstants.Windows10)
        {
            // Some of the AccentState Enum's values have different meanings on Windows 8.x than on
            // Windows 10, hence using ACCENT_ENABLE_BLURBEHIND to disable blurbehind  ¯\_(ツ)_/¯.
            // Hey, I'm just porting what was here before.
            SetAccentState(AccentState.ACCENT_ENABLE_BLURBEHIND);
            var blurInfo = new DWM_BLURBEHIND(false);
            DwmEnableBlurBehindWindow(_hwnd, ref blurInfo);
        }

        SetUseHostBackdropBrush(false);
        _blurHost?.SetBlur(BlurEffect.None);
    }

    private void SetTransparencyBlur(Version windowsVersion)
    {
        // Blur only supported with composition on Windows 8 and lower.
        if (!_isUsingComposition || windowsVersion >= PlatformConstants.Windows10)
            return;

        // Some of the AccentState Enum's values have different meanings on Windows 8.x than on
        // Windows 10.
        SetAccentState(AccentState.ACCENT_DISABLED);
        var blurInfo = new DWM_BLURBEHIND(true);
        DwmEnableBlurBehindWindow(_hwnd, ref blurInfo);
    }

    private void SetTransparencyAcrylicBlur(Version windowsVersion)
    {
        // Acrylic blur only supported with composition on Windows >= 10.0.15063.
        //if (!_isUsingComposition || windowsVersion < WinUiCompositionShared.MinAcrylicVersion)
        return;

        SetUseHostBackdropBrush(true);
        _blurHost?.SetBlur(BlurEffect.Acrylic);
    }

    private void SetTransparencyMica(Version windowsVersion)
    {
        // Mica only supported with composition on Windows >= 10.0.22000.
        //if (!_isUsingComposition || windowsVersion < WinUiCompositionShared.MinHostBackdropVersion)
        return;

        SetUseHostBackdropBrush(false);
        _blurHost?.SetBlur(BlurEffect.Mica);
    }

    private void SetAccentState(AccentState state)
    {
        var accent = new AccentPolicy();
        var accentStructSize = Marshal.SizeOf(accent);

        //Some of the AccentState Enum's values have different meanings on Windows 8.x than on Windows 10
        accent.AccentState = state;

        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);

        var data = new WindowCompositionAttributeData();
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
        data.SizeOfData = accentStructSize;
        data.Data = accentPtr;

        SetWindowCompositionAttribute(_hwnd, ref data);
        Marshal.FreeHGlobal(accentPtr);
    }

    private void SetUseHostBackdropBrush(bool useHostBackdropBrush)
    {
        //if (Win32Platform.WindowsVersion < WinUiCompositionShared.MinHostBackdropVersion)
        return;

        unsafe
        {
            var pvUseBackdropBrush = useHostBackdropBrush ? 1 : 0;
            DwmSetWindowAttribute(_hwnd, (int)DwmWindowAttribute.DWMWA_USE_HOSTBACKDROPBRUSH, &pvUseBackdropBrush, sizeof(int));
        }
    }

    //public IEnumerable<object> Surfaces
    //    => _gl is null ?
    //        new object[] { Handle, _framebuffer } :
    //        new object[] { Handle, _gl, _framebuffer };

    public PixelPoint Position
    {
        get
        {
            GetWindowRect(_hwnd, out var rc);

            var border = HiddenBorderSize;
            return new PixelPoint(rc.left + border.Width, rc.top + border.Height);
        }
        set
        {
            var border = HiddenBorderSize;
            value = new PixelPoint(value.X - border.Width, value.Y - border.Height);

            SetWindowPos(
                Handle.Handle,
                IntPtr.Zero,
                value.X,
                value.Y,
                0,
                0,
                SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOZORDER);
        }
    }

    private bool HasFullDecorations => _windowProperties.Decorations == SystemDecorations.Full;

    private PixelSize HiddenBorderSize
    {
        get
        {
            // Windows 10 and 11 add a 7 pixel invisible border on the left/right/bottom of windows for resizing
            if (Win32Platform.WindowsVersion.Major < 10 || !HasFullDecorations)
            {
                return PixelSize.Empty;
            }

            DwmGetWindowAttribute(_hwnd, (int)DwmWindowAttribute.DWMWA_EXTENDED_FRAME_BOUNDS, out var clientRect, Marshal.SizeOf(typeof(RECT)));
            GetWindowRect(_hwnd, out var frameRect);
            var borderWidth = GetSystemMetrics(SystemMetric.SM_CXBORDER);

            return new PixelSize(clientRect.left - frameRect.left - borderWidth, 0);
        }
    }

    public void Move(PixelPoint point) => Position = point;

    public void SetMinMaxSize(Vector2 minSize, Vector2 maxSize)
    {
        _minSize = minSize;
        _maxSize = maxSize;
    }

    //public Compositor Compositor => Win32Platform.Compositor;

    public void Resize(Vector2 value, WindowResizeReason reason)
    {
        if (WindowState != WindowState.Normal)
            return;

        int requestedClientWidth = (int)(value.x * RenderScaling);
        int requestedClientHeight = (int)(value.y * RenderScaling);

        GetClientRect(_hwnd, out var clientRect);

        // do comparison after scaling to avoid rounding issues
        if (requestedClientWidth != clientRect.Width || requestedClientHeight != clientRect.Height)
        {
            GetWindowRect(_hwnd, out var windowRect);

            using var scope = SetResizeReason(reason);
            SetWindowPos(
                _hwnd,
                IntPtr.Zero,
                0,
                0,
                requestedClientWidth + (_isClientAreaExtended ? 0 : windowRect.Width - clientRect.Width),
                requestedClientHeight + (_isClientAreaExtended ? 0 : windowRect.Height - clientRect.Height),
                SetWindowPosFlags.SWP_RESIZE);
        }
    }

    public void Activate()
    {
        SetForegroundWindow(_hwnd);
    }

    public IPopupImpl? CreatePopup() => Win32Platform.UseOverlayPopups ? null : new PopupImpl(this);

    public void Dispose()
    {
        if (_hwnd != IntPtr.Zero)
        {
            // Detect if we are being closed programmatically - this would mean that WM_CLOSE was not called
            // and we didn't prepare this window for destruction.
            if (!_isCloseRequested)
            {
                BeforeCloseCleanup(true);
            }

            DestroyWindow(_hwnd);
            _hwnd = IntPtr.Zero;
        }
    }

    public void Invalidate(Rect rect)
    {
        var scaling = RenderScaling;
        var r = new RECT
        {
            left = (int)Math.Floor(rect.x * scaling),
            top = (int)Math.Floor(rect.y * scaling),
            right = (int)Math.Ceiling(rect.Right * scaling),
            bottom = (int)Math.Ceiling(rect.Bottom * scaling),
        };

        InvalidateRect(_hwnd, ref r, false);
    }

    public Vector2 PointToClient(PixelPoint point)
    {
        var p = new POINT { X = point.X, Y = point.Y };
        ScreenToClient(_hwnd, ref p);
        return new Vector2(p.X, p.Y) / RenderScaling;
    }

    public PixelPoint PointToScreen(Vector2 point)
    {
        point *= RenderScaling;
        var p = new POINT { X = (int)point.x, Y = (int)point.y };
        ClientToScreen(_hwnd, ref p);
        return new PixelPoint(p.X, p.Y);
    }

    public void SetInputRoot(IInputRoot inputRoot)
    {
        _owner = inputRoot;
        CreateDropTarget(inputRoot);
    }

    public void Hide()
    {
        UnmanagedMethods.ShowWindow(_hwnd, ShowWindowCommand.Hide);
        _shown = false;
    }

    public virtual void Show(bool activate, bool isDialog)
    {
        SetParent(_parent);
        ShowWindow(_showWindowState, activate);
    }

    public Action? GotInputWhenDisabled { get; set; }

    public void SetParent(IWindowImpl? parent)
    {
        _parent = parent as WindowImpl;

        var parentHwnd = _parent?._hwnd ?? IntPtr.Zero;

        if (parentHwnd == IntPtr.Zero && !_windowProperties.ShowInTaskbar)
        {
            parentHwnd = OffscreenParentWindow.Handle;
            _hiddenWindowIsParent = true;
        }

        SetWindowLongPtr(_hwnd, (int)WindowLongParam.GWL_HWNDPARENT, parentHwnd);
    }

    public void SetEnabled(bool enable) => EnableWindow(_hwnd, enable);

    public void BeginMoveDrag(PointerPressedEventArgs e)
    {
        //e.Pointer.Capture(null);
        DefWindowProc(_hwnd, (int)WindowsMessage.WM_NCLBUTTONDOWN,
        new IntPtr((int)HitTestValues.HTCAPTION), IntPtr.Zero);
    }

    public void BeginResizeDrag(WindowEdge edge, PointerPressedEventArgs e)
    {
        if (_windowProperties.IsResizable)
        {
#if USE_MANAGED_DRAG
            _managedDrag.BeginResizeDrag(edge, ScreenToClient(MouseDevice.Position.ToPoint(_scaling)));
#else
            //e.Pointer.Capture(null);
            DefWindowProc(_hwnd, (int)WindowsMessage.WM_NCLBUTTONDOWN,
                new IntPtr((int)s_edgeLookup[edge]), IntPtr.Zero);
#endif
        }
    }

    public void SetTitle(string? title)
    {
        SetWindowText(_hwnd, title);
    }

    public void SetCursor(ICursorImpl? cursor)
    {
        var impl = cursor as CursorImpl;

        var hCursor = impl?.Handle ?? s_defaultCursor;
        SetClassLong(_hwnd, ClassLongIndex.GCLP_HCURSOR, hCursor);

        //if (Owner.IsPointerOver)
        //{
        //    UnmanagedMethods.SetCursor(hCursor);
        //}
    }

    //public void SetIcon(IWindowIconImpl? icon)
    //{
    //    var impl = icon as IconImpl;

    //    var hIcon = impl?.HIcon ?? IntPtr.Zero;
    //    PostMessage(_hwnd, (int)WindowsMessage.WM_SETICON,
    //        new IntPtr((int)Icons.ICON_BIG), hIcon);
    //}

    public void ShowTaskbarIcon(bool value)
    {
        var newWindowProperties = _windowProperties;

        newWindowProperties.ShowInTaskbar = value;

        UpdateWindowProperties(newWindowProperties);
    }

    public void CanResize(bool value)
    {
        var newWindowProperties = _windowProperties;

        newWindowProperties.IsResizable = value;

        UpdateWindowProperties(newWindowProperties);
    }

    public void SetSystemDecorations(SystemDecorations value)
    {
        var newWindowProperties = _windowProperties;

        newWindowProperties.Decorations = value;

        UpdateWindowProperties(newWindowProperties);
    }

    public void SetTopmost(bool value)
    {
        if (value == _topmost)
        {
            return;
        }

        IntPtr hWndInsertAfter = value ? WindowPosZOrder.HWND_TOPMOST : WindowPosZOrder.HWND_NOTOPMOST;
        SetWindowPos(_hwnd,
            hWndInsertAfter,
            0, 0, 0, 0,
            SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOACTIVATE);

        _topmost = value;
    }

    public unsafe void SetFrameThemeVariant(PlatformThemeVariant themeVariant)
    {
        if (Win32Platform.WindowsVersion.Build >= 22000)
        {
            var pvUseBackdropBrush = themeVariant == PlatformThemeVariant.Dark ? 1 : 0;
            DwmSetWindowAttribute(
                _hwnd,
                (int)DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE,
                &pvUseBackdropBrush,
                sizeof(int));
        }
    }

    protected virtual IntPtr CreateWindowOverride(ushort atom)
    {
        return CreateWindowEx(
            _isUsingComposition ? (int)WindowStyles.WS_EX_NOREDIRECTIONBITMAP : 0,
            atom,
            null,
            (int)WindowStyles.WS_OVERLAPPEDWINDOW | (int)WindowStyles.WS_CLIPCHILDREN,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            IntPtr.Zero,
            IntPtr.Zero,
            IntPtr.Zero,
            IntPtr.Zero);
    }

    [MemberNotNull(nameof(_wndProcDelegate))]
    [MemberNotNull(nameof(_className))]
    [MemberNotNull(nameof(Handle))]
    private void CreateWindow()
    {
        // Ensure that the delegate doesn't get garbage collected by storing it as a field.
        _wndProcDelegate = WndProc;

        _className = $"Avalonia-{Guid.NewGuid().ToString()}";

        // Unique DC helps with performance when using Gpu based rendering
        const ClassStyles windowClassStyle = ClassStyles.CS_OWNDC | ClassStyles.CS_HREDRAW | ClassStyles.CS_VREDRAW;

        var wndClassEx = new WNDCLASSEX
        {
            cbSize = Marshal.SizeOf<WNDCLASSEX>(),
            style = (int)windowClassStyle,
            lpfnWndProc = _wndProcDelegate,
            hInstance = GetModuleHandle(null),
            hCursor = s_defaultCursor,
            hbrBackground = IntPtr.Zero,
            lpszClassName = _className
        };

        ushort atom = RegisterClassEx(ref wndClassEx);

        if (atom == 0)
        {
            throw new Win32Exception();
        }

        _hwnd = CreateWindowOverride(atom);

        if (_hwnd == IntPtr.Zero)
        {
            throw new Win32Exception();
        }

        Handle = new WindowImplPlatformHandle(this);

        RegisterTouchWindow(_hwnd, 0);

        if (ShCoreAvailable && Win32Platform.WindowsVersion > PlatformConstants.Windows8)
        {
            var monitor = MonitorFromWindow(
                _hwnd,
                MONITOR.MONITOR_DEFAULTTONEAREST);

            if (GetDpiForMonitor(
                monitor,
                MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI,
                out var dpix,
                out _) == 0)
            {
                _scaling = dpix / 96.0;
            }
        }
    }

    private void CreateDropTarget(IInputRoot inputRoot)
    {
        //if (AvaloniaLocator.Current.GetService<IDragDropDevice>() is { } dragDropDevice)
        //{
        //    var odt = new OleDropTarget(this, inputRoot, dragDropDevice);

        //    if (OleContext.Current?.RegisterDragDrop(Handle, odt) ?? false)
        //    {
        //        _dropTarget = odt;
        //    }
        //}
    }

    /// <summary>
    /// Ported from https://github.com/chromium/chromium/blob/master/ui/views/win/fullscreen_handler.cc
    /// Method must only be called from inside UpdateWindowProperties.
    /// </summary>
    /// <param name="fullscreen"></param>
    private void SetFullScreen(bool fullscreen)
    {
        if (fullscreen)
        {
            GetWindowRect(_hwnd, out var windowRect);
            GetClientRect(_hwnd, out var clientRect);

            clientRect.left += windowRect.left;
            clientRect.right += windowRect.left;
            clientRect.top += windowRect.top;
            clientRect.bottom += windowRect.top;

            _savedWindowInfo.WindowRect = clientRect;

            var current = GetStyle();
            var currentEx = GetExtendedStyle();

            _savedWindowInfo.Style = current;
            _savedWindowInfo.ExStyle = currentEx;

            // Set new window style and size.
            SetStyle(current & ~(WindowStyles.WS_CAPTION | WindowStyles.WS_THICKFRAME), false);
            SetExtendedStyle(currentEx & ~(WindowStyles.WS_EX_DLGMODALFRAME | WindowStyles.WS_EX_WINDOWEDGE | WindowStyles.WS_EX_CLIENTEDGE | WindowStyles.WS_EX_STATICEDGE), false);

            // On expand, if we're given a window_rect, grow to it, otherwise do
            // not resize.
            MONITORINFO monitor_info = MONITORINFO.Create();
            GetMonitorInfo(MonitorFromWindow(_hwnd, MONITOR.MONITOR_DEFAULTTONEAREST), ref monitor_info);

            var window_rect = monitor_info.rcMonitor.ToPixelRect();

            _isFullScreenActive = true;
            SetWindowPos(_hwnd, IntPtr.Zero, window_rect.X, window_rect.Y,
                         window_rect.Width, window_rect.Height,
                         SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_FRAMECHANGED);
        }
        else
        {
            // Reset original window style and size.  The multiple window size/moves
            // here are ugly, but if SetWindowPos() doesn't redraw, the taskbar won't be
            // repainted.  Better-looking methods welcome.
            _isFullScreenActive = false;

            var windowStates = GetWindowStateStyles();
            SetStyle((_savedWindowInfo.Style & ~WindowStateMask) | windowStates, false);
            SetExtendedStyle(_savedWindowInfo.ExStyle, false);

            // On restore, resize to the previous saved rect size.
            var newClientRect = _savedWindowInfo.WindowRect.ToPixelRect();

            SetWindowPos(_hwnd, IntPtr.Zero, newClientRect.X, newClientRect.Y, newClientRect.Width,
                         newClientRect.Height,
                        SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_FRAMECHANGED);

            UpdateWindowProperties(_windowProperties, true);
        }

        //TaskBarList.MarkFullscreen(_hwnd, fullscreen);

        ExtendClientArea();
    }

    private MARGINS UpdateExtendMargins()
    {
        RECT borderThickness = new RECT();
        RECT borderCaptionThickness = new RECT();

        AdjustWindowRectEx(ref borderCaptionThickness, (uint)GetStyle(), false, 0);
        AdjustWindowRectEx(ref borderThickness, (uint)(GetStyle() & ~WindowStyles.WS_CAPTION), false, 0);
        borderThickness.left *= -1;
        borderThickness.top *= -1;
        borderCaptionThickness.left *= -1;
        borderCaptionThickness.top *= -1;

        bool wantsTitleBar = _extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.SystemChrome) || _extendTitleBarHint == -1;

        if (!wantsTitleBar)
        {
            borderCaptionThickness.top = 1;
        }

        //using a default margin of 0 when using WinUiComp removes artefacts when resizing. See issue #8316
        var defaultMargin = _isUsingComposition ? 0 : 1;

        MARGINS margins = new MARGINS();
        margins.cxLeftWidth = defaultMargin;
        margins.cxRightWidth = defaultMargin;
        margins.cyBottomHeight = defaultMargin;

        if (_extendTitleBarHint != -1)
        {
            borderCaptionThickness.top = (int)(_extendTitleBarHint * RenderScaling);
        }

        margins.cyTopHeight = _extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.SystemChrome) && !_extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.PreferSystemChrome) ? borderCaptionThickness.top : defaultMargin;

        if (WindowState == WindowState.Maximized)
        {
            _extendedMargins = new Thickness(0, (borderCaptionThickness.top - borderThickness.top) / RenderScaling, 0, 0);
            _offScreenMargin = new Thickness(borderThickness.left / PrimaryScreenRenderScaling, borderThickness.top / PrimaryScreenRenderScaling, borderThickness.right / PrimaryScreenRenderScaling, borderThickness.bottom / PrimaryScreenRenderScaling);
        }
        else
        {
            _extendedMargins = new Thickness(0, borderCaptionThickness.top / RenderScaling, 0, 0);
            _offScreenMargin = new Thickness();
        }

        return margins;
    }

    private void ExtendClientArea()
    {
        if ((Handle?.Handle ?? IntPtr.Zero) == IntPtr.Zero)
        {
            return;
        }

        if (DwmIsCompositionEnabled(out bool compositionEnabled) < 0 || !compositionEnabled)
        {
            _isClientAreaExtended = false;
            return;
        }
        GetClientRect(_hwnd, out var rcClient);
        GetWindowRect(_hwnd, out var rcWindow);

        // Inform the application of the frame change.
        SetWindowPos(_hwnd,
            IntPtr.Zero,
            rcWindow.left, rcWindow.top,
            rcClient.Width, rcClient.Height,
            SetWindowPosFlags.SWP_FRAMECHANGED | SetWindowPosFlags.SWP_NOACTIVATE);

        if (_isClientAreaExtended && WindowState != WindowState.FullScreen)
        {
            var margins = UpdateExtendMargins();
            DwmExtendFrameIntoClientArea(_hwnd, ref margins);

            unsafe
            {
                //int cornerPreference = (int)DwmWindowCornerPreference.DWMWCP_ROUND;
                //DwmSetWindowAttribute(_hwnd, (int)DwmWindowAttribute.DWMWA_WINDOW_CORNER_PREFERENCE, &cornerPreference, sizeof(int));
            }
        }
        else
        {
            var margins = new MARGINS();
            DwmExtendFrameIntoClientArea(_hwnd, ref margins);

            _offScreenMargin = new Thickness();
            _extendedMargins = new Thickness();

            Resize(new Vector2(rcWindow.Width / RenderScaling, rcWindow.Height / RenderScaling), WindowResizeReason.Layout);

            unsafe
            {
                //int cornerPreference = (int)DwmWindowCornerPreference.DWMWCP_DEFAULT;
                //DwmSetWindowAttribute(_hwnd, (int)DwmWindowAttribute.DWMWA_WINDOW_CORNER_PREFERENCE, &cornerPreference, sizeof(int));
            }
        }

        if (!_isClientAreaExtended || (_extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.SystemChrome) &&
            !_extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.PreferSystemChrome)))
        {
            EnableCloseButton(_hwnd);
        }
        else
        {
            DisableCloseButton(_hwnd);
        }

        ExtendClientAreaToDecorationsChanged?.Invoke(_isClientAreaExtended);
    }

    private void ShowWindow(WindowState state, bool activate)
    {
        _shown = true;

        if (_isClientAreaExtended)
        {
            ExtendClientArea();
        }

        ShowWindowCommand? command;

        var newWindowProperties = _windowProperties;

        switch (state)
        {
            case WindowState.Minimized:
                newWindowProperties.IsFullScreen = false;
                command = ShowWindowCommand.Minimize;
                break;
            case WindowState.Maximized:
                newWindowProperties.IsFullScreen = false;
                command = ShowWindowCommand.Maximize;
                break;

            case WindowState.Normal:
                newWindowProperties.IsFullScreen = false;
                command = IsWindowVisible(_hwnd) ? ShowWindowCommand.Restore :
                    activate ? ShowWindowCommand.Normal : ShowWindowCommand.ShowNoActivate;
                break;

            case WindowState.FullScreen:
                newWindowProperties.IsFullScreen = true;
                command = IsWindowVisible(_hwnd) ? null : ShowWindowCommand.Restore;
                break;

            default:
                throw new ArgumentException("Invalid WindowState.");
        }

        UpdateWindowProperties(newWindowProperties);

        if (command.HasValue)
        {
            UnmanagedMethods.ShowWindow(_hwnd, command.Value);
        }

        if (state == WindowState.Maximized)
        {
            MaximizeWithoutCoveringTaskbar();
        }

        //if (!Design.IsDesignMode && activate)
        //{
        //    SetFocus(_hwnd);
        //    SetForegroundWindow(_hwnd);
        //}
    }

    private void BeforeCloseCleanup(bool isDisposing)
    {
        // Based on https://github.com/dotnet/wpf/blob/master/src/Microsoft.DotNet.Wpf/src/PresentationFramework/System/Windows/Window.cs#L4270-L4337
        // We need to enable parent window before destroying child window to prevent OS from activating a random window behind us (or last active window).
        // This is described here: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enablewindow#remarks
        // We need to verify if parent is still alive (perhaps it got destroyed somehow).
        if (_parent != null && IsWindow(_parent._hwnd))
        {
            var wasActive = GetActiveWindow() == _hwnd;

            // We can only set enabled state if we are not disposing - generally Dispose happens after enabled state has been set.
            // Ignoring this would cause us to enable a window that might be disabled.
            if (!isDisposing)
            {
                // Our window closed callback will set enabled state to a correct value after child window gets destroyed.
                _parent.SetEnabled(true);
            }

            // We also need to activate our parent window since again OS might try to activate a window behind if it is not set.
            if (wasActive)
            {
                SetActiveWindow(_parent._hwnd);
            }
        }
    }

    private void AfterCloseCleanup()
    {
        if (_className != null)
        {
            UnregisterClass(_className, GetModuleHandle(null));
            _className = null;
        }
    }

    private void MaximizeWithoutCoveringTaskbar()
    {
        IntPtr monitor = MonitorFromWindow(_hwnd, MONITOR.MONITOR_DEFAULTTONEAREST);

        if (monitor != IntPtr.Zero)
        {
            var monitorInfo = MONITORINFO.Create();

            if (GetMonitorInfo(monitor, ref monitorInfo))
            {
                var x = monitorInfo.rcWork.left;
                var y = monitorInfo.rcWork.top;
                var cx = Math.Abs(monitorInfo.rcWork.right - x);
                var cy = Math.Abs(monitorInfo.rcWork.bottom - y);
                var style = (WindowStyles)GetWindowLong(_hwnd, (int)WindowLongParam.GWL_STYLE);

                if (!style.HasFlag(WindowStyles.WS_SIZEFRAME))
                {
                    // When calling SetWindowPos on a maximized window it automatically adjusts
                    // for "hidden" borders which are placed offscreen, EVEN IF THE WINDOW HAS
                    // NO BORDERS, meaning that the window is placed wrong when we have CanResize
                    // == false. Account for this here.
                    var borderThickness = BorderThickness;
                    x -= (int)borderThickness.Left;
                    cx += (int)borderThickness.Left + (int)borderThickness.Right;
                    cy += (int)borderThickness.Bottom;
                }

                SetWindowPos(_hwnd, WindowPosZOrder.HWND_NOTOPMOST, x, y, cx, cy, SetWindowPosFlags.SWP_SHOWWINDOW | SetWindowPosFlags.SWP_FRAMECHANGED);
            }
        }
    }

    private WindowStyles GetWindowStateStyles()
    {
        return GetStyle() & WindowStateMask;
    }

    private WindowStyles GetStyle()
    {
        if (_isFullScreenActive)
        {
            return _savedWindowInfo.Style;
        }
        else
        {
            return (WindowStyles)GetWindowLong(_hwnd, (int)WindowLongParam.GWL_STYLE);
        }
    }

    private WindowStyles GetExtendedStyle()
    {
        if (_isFullScreenActive)
        {
            return _savedWindowInfo.ExStyle;
        }
        else
        {
            return (WindowStyles)GetWindowLong(_hwnd, (int)WindowLongParam.GWL_EXSTYLE);
        }
    }

    private void SetStyle(WindowStyles style, bool save = true)
    {
        if (save)
        {
            _savedWindowInfo.Style = style;
        }

        if (!_isFullScreenActive)
        {
            SetWindowLong(_hwnd, (int)WindowLongParam.GWL_STYLE, (uint)style);
        }
    }

    private void SetExtendedStyle(WindowStyles style, bool save = true)
    {
        if (save)
        {
            _savedWindowInfo.ExStyle = style;
        }

        if (!_isFullScreenActive)
        {
            SetWindowLong(_hwnd, (int)WindowLongParam.GWL_EXSTYLE, (uint)style);
        }
    }

    private void UpdateWindowProperties(WindowProperties newProperties, bool forceChanges = false)
    {
        var oldProperties = _windowProperties;

        // Calling SetWindowPos will cause events to be sent and we need to respond
        // according to the new values already.
        _windowProperties = newProperties;

        if ((oldProperties.ShowInTaskbar != newProperties.ShowInTaskbar) || forceChanges)
        {
            var exStyle = GetExtendedStyle();

            if (newProperties.ShowInTaskbar)
            {
                exStyle |= WindowStyles.WS_EX_APPWINDOW;

                if (_hiddenWindowIsParent)
                {
                    // Can't enable the taskbar icon by clearing the parent window unless the window
                    // is hidden. Hide the window and show it again with the same activation state
                    // when we've finished. Interestingly it seems to work fine the other way.
                    var shown = IsWindowVisible(_hwnd);
                    var activated = GetActiveWindow() == _hwnd;

                    if (shown)
                        Hide();

                    _hiddenWindowIsParent = false;
                    SetParent(null);

                    if (shown)
                        Show(activated, false);
                }
            }
            else
            {
                // To hide a non-owned window's taskbar icon we need to parent it to a hidden window.
                if (_parent is null)
                {
                    SetWindowLongPtr(_hwnd, (int)WindowLongParam.GWL_HWNDPARENT, OffscreenParentWindow.Handle);
                    _hiddenWindowIsParent = true;
                }

                exStyle &= ~WindowStyles.WS_EX_APPWINDOW;
            }

            SetExtendedStyle(exStyle);
        }

        WindowStyles style;
        if ((oldProperties.IsResizable != newProperties.IsResizable) || forceChanges)
        {
            style = GetStyle();

            if (newProperties.IsResizable)
            {
                style |= WindowStyles.WS_SIZEFRAME;
                style |= WindowStyles.WS_MAXIMIZEBOX;
            }
            else
            {
                style &= ~WindowStyles.WS_SIZEFRAME;
                style &= ~WindowStyles.WS_MAXIMIZEBOX;
            }

            SetStyle(style);
        }

        if (oldProperties.IsFullScreen != newProperties.IsFullScreen)
        {
            SetFullScreen(newProperties.IsFullScreen);
        }

        if ((oldProperties.Decorations != newProperties.Decorations) || forceChanges)
        {
            style = GetStyle();

            const WindowStyles fullDecorationFlags = WindowStyles.WS_CAPTION | WindowStyles.WS_SYSMENU;

            if (newProperties.Decorations == SystemDecorations.Full)
            {
                style |= fullDecorationFlags;
            }
            else
            {
                style &= ~fullDecorationFlags;
            }

            SetStyle(style);

            if (!_isFullScreenActive)
            {
                var margin = newProperties.Decorations == SystemDecorations.BorderOnly ? 1 : 0;

                var margins = new MARGINS
                {
                    cyBottomHeight = margin,
                    cxRightWidth = margin,
                    cxLeftWidth = margin,
                    cyTopHeight = margin
                };

                DwmExtendFrameIntoClientArea(_hwnd, ref margins);

                GetClientRect(_hwnd, out var oldClientRect);
                var oldClientRectOrigin = new POINT();
                ClientToScreen(_hwnd, ref oldClientRectOrigin);
                oldClientRect.Offset(oldClientRectOrigin);

                var newRect = oldClientRect;

                if (newProperties.Decorations == SystemDecorations.Full)
                {
                    AdjustWindowRectEx(ref newRect, (uint)style, false, (uint)GetExtendedStyle());
                }

                SetWindowPos(_hwnd, IntPtr.Zero, newRect.left, newRect.top, newRect.Width, newRect.Height,
                    SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE |
                    SetWindowPosFlags.SWP_FRAMECHANGED);
            }
        }
    }

    private const int MF_BYCOMMAND = 0x0;
    private const int MF_ENABLED = 0x0;
    private const int MF_GRAYED = 0x1;
    private const int MF_DISABLED = 0x2;
    private const int SC_CLOSE = 0xF060;

    private static void DisableCloseButton(IntPtr hwnd)
    {
        EnableMenuItem(GetSystemMenu(hwnd, false), SC_CLOSE,
                       MF_BYCOMMAND | MF_DISABLED | MF_GRAYED);
    }

    private static void EnableCloseButton(IntPtr hwnd)
    {
        EnableMenuItem(GetSystemMenu(hwnd, false), SC_CLOSE,
                       MF_BYCOMMAND | MF_ENABLED);
    }

#if USE_MANAGED_DRAG
    private Point ScreenToClient(Point point)
    {
        var p = new UnmanagedMethods.POINT { X = (int)point.X, Y = (int)point.Y };
        UnmanagedMethods.ScreenToClient(_hwnd, ref p);
        return new Point(p.X, p.Y);
    }
#endif

    //PixelSize EglGlPlatformSurface.IEglWindowGlPlatformSurfaceInfo.Size
    //{
    //    get
    //    {
    //        GetClientRect(_hwnd, out var rect);

    //        return new PixelSize(
    //            Math.Max(1, rect.right - rect.left),
    //            Math.Max(1, rect.bottom - rect.top));
    //    }
    //}

    //double EglGlPlatformSurface.IEglWindowGlPlatformSurfaceInfo.Scaling => RenderScaling;

    //IntPtr EglGlPlatformSurface.IEglWindowGlPlatformSurfaceInfo.Handle => Handle.Handle;

    public void SetExtendClientAreaToDecorationsHint(bool hint)
    {
        _isClientAreaExtended = hint;

        ExtendClientArea();
    }

    public void SetExtendClientAreaChromeHints(ExtendClientAreaChromeHints hints)
    {
        _extendChromeHints = hints;

        ExtendClientArea();
    }

    /// <inheritdoc/>
    public void SetExtendClientAreaTitleBarHeightHint(double titleBarHeight)
    {
        _extendTitleBarHint = titleBarHeight;

        ExtendClientArea();
    }

    /// <inheritdoc/>
    public bool IsClientAreaExtendedToDecorations => _isClientAreaExtended;

    /// <inheritdoc/>
    public Action<bool>? ExtendClientAreaToDecorationsChanged { get; set; }

    /// <inheritdoc/>
    public bool NeedsManagedDecorations => _isClientAreaExtended && _extendChromeHints.HasAllFlags(ExtendClientAreaChromeHints.PreferSystemChrome);

    /// <inheritdoc/>
    public Thickness ExtendedMargins => _extendedMargins;

    /// <inheritdoc/>
    public Thickness OffScreenMargin => _offScreenMargin;

    /// <inheritdoc/>
    public AcrylicPlatformCompensationLevels AcrylicCompensationLevels { get; } = new AcrylicPlatformCompensationLevels(1, 0.8, 0);

    private ResizeReasonScope SetResizeReason(WindowResizeReason reason)
    {
        var old = _resizeReason;
        _resizeReason = reason;
        return new ResizeReasonScope(this, old);
    }

    private struct SavedWindowInfo
    {
        public WindowStyles Style { get; set; }
        public WindowStyles ExStyle { get; set; }
        public RECT WindowRect { get; set; }
    };

    private struct WindowProperties
    {
        public bool ShowInTaskbar;
        public bool IsResizable;
        public SystemDecorations Decorations;
        public bool IsFullScreen;
    }

    private struct ResizeReasonScope : IDisposable
    {
        private readonly WindowImpl _owner;
        private readonly WindowResizeReason _restore;

        public ResizeReasonScope(WindowImpl owner, WindowResizeReason restore)
        {
            _owner = owner;
            _restore = restore;
        }

        public void Dispose() => _owner._resizeReason = _restore;
    }

    private class WindowImplPlatformHandle : INativePlatformHandleSurface
    {
        private readonly WindowImpl _owner;
        public WindowImplPlatformHandle(WindowImpl owner) => _owner = owner;
        public IntPtr Handle => _owner.Hwnd;
        public string HandleDescriptor => PlatformConstants.WindowHandleType;

        public PixelSize Size => PixelSize.FromSize(_owner.ClientSize, Scaling);

        public double Scaling => _owner.RenderScaling;
    }
}
