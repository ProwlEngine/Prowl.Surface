#pragma warning disable 108
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Prowl.Surface.MicroCom;

namespace Prowl.Surface.Mac.Interop
{
    internal enum AvnKey
    {
        AvnKeyNone = 0,
        AvnKeyCancel = 1,
        AvnKeyBack = 2,
        AvnKeyTab = 3,
        AvnKeyLineFeed = 4,
        AvnKeyClear = 5,
        AvnKeyReturn = 6,
        AvnKeyEnter = 6,
        AvnKeyPause = 7,
        AvnKeyCapsLock = 8,
        AvnKeyCapital = 8,
        AvnKeyHangulMode = 9,
        AvnKeyKanaMode = 9,
        AvnKeyJunjaMode = 10,
        AvnKeyFinalMode = 11,
        AvnKeyKanjiMode = 12,
        HanjaMode = 12,
        Escape = 13,
        ImeConvert = 14,
        ImeNonConvert = 15,
        ImeAccept = 16,
        ImeModeChange = 17,
        Space = 18,
        PageUp = 19,
        Prior = 19,
        PageDown = 20,
        Next = 20,
        End = 21,
        Home = 22,
        Left = 23,
        Up = 24,
        Right = 25,
        Down = 26,
        Select = 27,
        Print = 28,
        Execute = 29,
        Snapshot = 30,
        PrintScreen = 30,
        Insert = 31,
        Delete = 32,
        Help = 33,
        D0 = 34,
        D1 = 35,
        D2 = 36,
        D3 = 37,
        D4 = 38,
        D5 = 39,
        D6 = 40,
        D7 = 41,
        D8 = 42,
        D9 = 43,
        A = 44,
        B = 45,
        C = 46,
        D = 47,
        E = 48,
        F = 49,
        G = 50,
        H = 51,
        I = 52,
        J = 53,
        AvnKeyK = 54,
        L = 55,
        M = 56,
        N = 57,
        O = 58,
        P = 59,
        Q = 60,
        R = 61,
        S = 62,
        T = 63,
        U = 64,
        V = 65,
        W = 66,
        X = 67,
        Y = 68,
        Z = 69,
        LWin = 70,
        RWin = 71,
        Apps = 72,
        Sleep = 73,
        NumPad0 = 74,
        NumPad1 = 75,
        NumPad2 = 76,
        NumPad3 = 77,
        NumPad4 = 78,
        NumPad5 = 79,
        NumPad6 = 80,
        NumPad7 = 81,
        NumPad8 = 82,
        NumPad9 = 83,
        Multiply = 84,
        Add = 85,
        Separator = 86,
        Subtract = 87,
        Decimal = 88,
        Divide = 89,
        F1 = 90,
        F2 = 91,
        F3 = 92,
        F4 = 93,
        F5 = 94,
        F6 = 95,
        F7 = 96,
        F8 = 97,
        F9 = 98,
        F10 = 99,
        F11 = 100,
        F12 = 101,
        F13 = 102,
        F14 = 103,
        F15 = 104,
        F16 = 105,
        F17 = 106,
        F18 = 107,
        F19 = 108,
        F20 = 109,
        F21 = 110,
        F22 = 111,
        F23 = 112,
        F24 = 113,
        NumLock = 114,
        Scroll = 115,
        LeftShift = 116,
        RightShift = 117,
        LeftCtrl = 118,
        RightCtrl = 119,
        LeftAlt = 120,
        RightAlt = 121,
        BrowserBack = 122,
        BrowserForward = 123,
        BrowserRefresh = 124,
        BrowserStop = 125,
        BrowserSearch = 126,
        BrowserFavorites = 127,
        BrowserHome = 128,
        VolumeMute = 129,
        VolumeDown = 130,
        VolumeUp = 131,
        MediaNextTrack = 132,
        MediaPreviousTrack = 133,
        MediaStop = 134,
        MediaPlayPause = 135,
        LaunchMail = 136,
        SelectMedia = 137,
        LaunchApplication1 = 138,
        LaunchApplication2 = 139,
        OemSemicolon = 140,
        Oem1 = 140,
        OemPlus = 141,
        OemComma = 142,
        OemMinus = 143,
        OemPeriod = 144,
        OemQuestion = 145,
        Oem2 = 145,
        OemTilde = 146,
        Oem3 = 146,
        AbntC1 = 147,
        AbntC2 = 148,
        OemOpenBrackets = 149,
        Oem4 = 149,
        OemPipe = 150,
        Oem5 = 150,
        OemCloseBrackets = 151,
        Oem6 = 151,
        OemQuotes = 152,
        Oem7 = 152,
        Oem8 = 153,
        OemBackslash = 154,
        Oem102 = 154,
        ImeProcessed = 155,
        System = 156,
        OemAttn = 157,
        DbeAlphanumeric = 157,
        OemFinish = 158,
        DbeKatakana = 158,
        DbeHiragana = 159,
        OemCopy = 159,
        DbeSbcsChar = 160,
        OemAuto = 160,
        DbeDbcsChar = 161,
        OemEnlw = 161,
        OemBackTab = 162,
        DbeRoman = 162,
        DbeNoRoman = 163,
        Attn = 163,
        CrSel = 164,
        DbeEnterWordRegisterMode = 164,
        ExSel = 165,
        DbeEnterImeConfigureMode = 165,
        EraseEof = 166,
        DbeFlushString = 166,
        Play = 167,
        DbeCodeInput = 167,
        DbeNoCodeInput = 168,
        Zoom = 168,
        NoName = 169,
        DbeDetermineString = 169,
        DbeEnterDialogConversionMode = 170,
        Pa1 = 170,
        OemClear = 171,
        DeadCharProcessed = 172
    }

    internal enum SystemDecorations
    {
        SystemDecorationsNone = 0,
        SystemDecorationsBorderOnly = 1,
        SystemDecorationsFull = 2
    }

    internal enum AvnAutomationProperty
    {
        AutomationPeer_BoundingRectangle,
        AutomationPeer_ClassName,
        AutomationPeer_Name,
        RangeValueProvider_Value
    }

    internal enum AvnPixelFormat
    {
        kAvnRgb565,
        kAvnRgba8888,
        kAvnBgra8888
    }

    internal enum AvnRawMouseEventType
    {
        LeaveWindow,
        LeftButtonDown,
        LeftButtonUp,
        RightButtonDown,
        RightButtonUp,
        MiddleButtonDown,
        MiddleButtonUp,
        XButton1Down,
        XButton1Up,
        XButton2Down,
        XButton2Up,
        Move,
        Wheel,
        NonClientLeftButtonDown,
        TouchBegin,
        TouchUpdate,
        TouchEnd,
        TouchCancel,
        Magnify,
        Rotate,
        Swipe
    }

    internal enum AvnRawKeyEventType
    {
        KeyDown,
        KeyUp
    }

    internal enum AvnInputModifiers
    {
        AvnInputModifiersNone = 0,
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        LeftMouseButton = 16,
        RightMouseButton = 32,
        MiddleMouseButton = 64,
        XButton1MouseButton = 128,
        XButton2MouseButton = 256
    }

    internal enum AvnDragDropEffects
    {
        None = 0,
        Copy = 1,
        Move = 2,
        Link = 4
    }

    internal enum AvnDragEventType
    {
        Enter,
        Over,
        Leave,
        Drop
    }

    internal enum AvnWindowState
    {
        Normal,
        Minimized,
        Maximized,
        FullScreen
    }

    internal enum AvnStandardCursorType
    {
        CursorArrow,
        CursorIbeam,
        CursorWait,
        CursorCross,
        CursorUpArrow,
        CursorSizeWestEast,
        CursorSizeNorthSouth,
        CursorSizeAll,
        CursorNo,
        CursorHand,
        CursorAppStarting,
        CursorHelp,
        CursorTopSide,
        CursorBottomSize,
        CursorLeftSide,
        CursorRightSide,
        CursorTopLeftCorner,
        CursorTopRightCorner,
        CursorBottomLeftCorner,
        CursorBottomRightCorner,
        CursorDragMove,
        CursorDragCopy,
        CursorDragLink,
        CursorNone
    }

    internal enum AvnWindowEdge
    {
        WindowEdgeNorthWest,
        WindowEdgeNorth,
        WindowEdgeNorthEast,
        WindowEdgeWest,
        WindowEdgeEast,
        WindowEdgeSouthWest,
        WindowEdgeSouth,
        WindowEdgeSouthEast
    }

    internal enum AvnMenuItemToggleType
    {
        None,
        CheckMark,
        Radio
    }

    internal enum AvnExtendClientAreaChromeHints
    {
        AvnNoChrome = 0,
        AvnSystemChrome = 0x01,
        AvnPreferSystemChrome = 0x02,
        AvnOSXThickTitleBar = 0x08,
        AvnDefaultChrome = AvnPreferSystemChrome
    }

    internal enum AvnPlatformResizeReason
    {
        ResizeUnspecified,
        ResizeUser,
        ResizeApplication,
        ResizeLayout,
        ResizeDpiChange
    }

    internal enum AvnAutomationControlType
    {
        AutomationNone,
        AutomationButton,
        AutomationCalendar,
        AutomationCheckBox,
        AutomationComboBox,
        AutomationComboBoxItem,
        AutomationEdit,
        AutomationHyperlink,
        AutomationImage,
        AutomationListItem,
        AutomationList,
        AutomationMenu,
        AutomationMenuBar,
        AutomationMenuItem,
        AutomationProgressBar,
        AutomationRadioButton,
        AutomationScrollBar,
        AutomationSlider,
        AutomationSpinner,
        AutomationStatusBar,
        AutomationTab,
        AutomationTabItem,
        AutomationText,
        AutomationToolBar,
        AutomationToolTip,
        AutomationTree,
        AutomationTreeItem,
        AutomationCustom,
        AutomationGroup,
        AutomationThumb,
        AutomationDataGrid,
        AutomationDataItem,
        AutomationDocument,
        AutomationSplitButton,
        AutomationWindow,
        AutomationPane,
        AutomationHeader,
        AutomationHeaderItem,
        AutomationTable,
        AutomationTitleBar,
        AutomationSeparator
    }

    internal enum AvnWindowTransparencyMode
    {
        Opaque,
        Transparent,
        Blur
    }

    internal enum AvnPlatformThemeVariant
    {
        Light,
        Dark,
        HighContrastLight,
        HighContrastDark
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnSize
    {
        public double Width;
        public double Height;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnPixelSize
    {
        public int Width;
        public int Height;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnRect
    {
        public double X;
        public double Y;
        public double Width;
        public double Height;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnVector
    {
        public double X;
        public double Y;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnPoint
    {
        public double X;
        public double Y;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnScreen
    {
        public AvnRect Bounds;
        public AvnRect WorkingArea;
        public float Scaling;
        public int IsPrimary;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnFramebuffer
    {
        public void* Data;
        public int Width;
        public int Height;
        public int Stride;
        public AvnVector Dpi;
        public AvnPixelFormat PixelFormat;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal unsafe struct AvnColor
    {
        public byte Alpha;
        public byte Red;
        public byte Green;
        public byte Blue;
    }

    internal unsafe partial interface IAvaloniaNativeFactory : Prowl.Surface.MicroCom.IUnknown
    {
        void Initialize(IAvnGCHandleDeallocatorCallback deallocator, IAvnApplicationEvents appCb);
        IAvnMacOptions MacOptions { get; }

        IAvnWindow CreateWindow(IAvnWindowEvents cb, IAvnGlContext gl);
        IAvnPopup CreatePopup(IAvnWindowEvents cb, IAvnGlContext gl);
        IAvnPlatformThreadingInterface CreatePlatformThreadingInterface();
        IAvnSystemDialogs CreateSystemDialogs();
        IAvnScreens CreateScreens();
        IAvnClipboard CreateClipboard();
        IAvnClipboard CreateDndClipboard();
        IAvnCursorFactory CreateCursorFactory();
        IAvnGlDisplay ObtainGlDisplay();
        void SetAppMenu(IAvnMenu menu);
        void SetServicesMenu(IAvnMenu menu);
        IAvnMenu CreateMenu(IAvnMenuEvents cb);
        IAvnMenuItem CreateMenuItem();
        IAvnMenuItem CreateMenuItemSeparator();
        IAvnTrayIcon CreateTrayIcon();
        IAvnApplicationCommands CreateApplicationCommands();
        IAvnPlatformSettings CreatePlatformSettings();
        IAvnPlatformBehaviorInhibition CreatePlatformBehaviorInhibition();
    }

    internal unsafe partial interface IAvnString : Prowl.Surface.MicroCom.IUnknown
    {
        void* Pointer();
        int Length();
    }

    internal unsafe partial interface IAvnWindowBase : Prowl.Surface.MicroCom.IUnknown
    {
        void Show(int activate, int isDialog);
        void Hide();
        void Close();
        void Activate();
        AvnSize ClientSize { get; }

        void GetFrameSize(AvnSize* result);
        double Scaling { get; }

        void SetMinMaxSize(AvnSize minSize, AvnSize maxSize);
        void Resize(double width, double height, AvnPlatformResizeReason reason);
        void Invalidate(AvnRect rect);
        void BeginMoveDrag();
        void BeginResizeDrag(AvnWindowEdge edge);
        AvnPoint Position { get; }

        void SetPosition(AvnPoint point);
        AvnPoint PointToClient(AvnPoint point);
        AvnPoint PointToScreen(AvnPoint point);
        void ThreadSafeSetSwRenderedFrame(AvnFramebuffer* fb, IUnknown dispose);
        void SetTopMost(int value);
        void SetCursor(IAvnCursor cursor);
        IAvnGlSurfaceRenderTarget CreateGlRenderTarget();
        void SetMainMenu(IAvnMenu menu);
        IntPtr ObtainNSWindowHandle();
        IntPtr ObtainNSWindowHandleRetained();
        IntPtr ObtainNSViewHandle();
        IntPtr ObtainNSViewHandleRetained();
        IAvnNativeControlHost CreateNativeControlHost();
        void BeginDragAndDropOperation(AvnDragDropEffects effects, AvnPoint point, IAvnClipboard clipboard, IAvnDndResultCallback cb, IntPtr sourceHandle);
        void SetTransparencyMode(AvnWindowTransparencyMode mode);
        void SetFrameThemeVariant(AvnPlatformThemeVariant mode);
        IAvnTextInputMethod InputMethod { get; }
    }

    internal unsafe partial interface IAvnPopup : IAvnWindowBase
    {
    }

    internal unsafe partial interface IAvnWindow : IAvnWindowBase
    {
        void SetEnabled(int enable);
        void SetParent(IAvnWindow parent);
        void SetCanResize(int value);
        void SetDecorations(SystemDecorations value);
        void SetTitle(string utf8Title);
        void SetTitleBarColor(AvnColor color);
        void SetWindowState(AvnWindowState state);
        AvnWindowState WindowState { get; }

        void TakeFocusFromChildren();
        void SetExtendClientArea(int enable);
        void SetExtendClientAreaHints(AvnExtendClientAreaChromeHints hints);
        double ExtendTitleBarHeight { get; }

        void SetExtendTitleBarHeight(double value);
    }

    internal unsafe partial interface IAvnWindowBaseEvents : Prowl.Surface.MicroCom.IUnknown
    {
        void Paint();
        void Closed();
        void Activated();
        void Deactivated();
        void Resized(AvnSize* size, AvnPlatformResizeReason reason);
        void PositionChanged(AvnPoint position);
        void RawMouseEvent(AvnRawMouseEventType type, ulong timeStamp, AvnInputModifiers modifiers, AvnPoint point, AvnVector delta);
        int RawKeyEvent(AvnRawKeyEventType type, ulong timeStamp, AvnInputModifiers modifiers, uint key);
        int RawTextInputEvent(ulong timeStamp, string text);
        void ScalingChanged(double scaling);
        void RunRenderPriorityJobs();
        void LostFocus();
        AvnDragDropEffects DragEvent(AvnDragEventType type, AvnPoint position, AvnInputModifiers modifiers, AvnDragDropEffects effects, IAvnClipboard clipboard, IntPtr dataObjectHandle);
        IAvnAutomationPeer AutomationPeer { get; }
    }

    internal unsafe partial interface IAvnWindowEvents : IAvnWindowBaseEvents
    {
        int Closing();
        void WindowStateChanged(AvnWindowState state);
        void GotInputWhenDisabled();
    }

    internal unsafe partial interface IAvnTextInputMethodClient : Prowl.Surface.MicroCom.IUnknown
    {
        void SetPreeditText(string preeditText);
        void SelectInSurroundingText(int start, int length);
    }

    internal unsafe partial interface IAvnTextInputMethod : Prowl.Surface.MicroCom.IUnknown
    {
        void SetClient(IAvnTextInputMethodClient client);
        void Reset();
        void SetCursorRect(AvnRect rect);
        void SetSurroundingText(string text, int anchorOffset, int cursorOffset);
    }

    internal unsafe partial interface IAvnMacOptions : Prowl.Surface.MicroCom.IUnknown
    {
        void SetShowInDock(int show);
        void SetApplicationTitle(string utf8string);
        void SetDisableSetProcessName(int disable);
        void SetDisableAppDelegate(int disable);
    }

    internal unsafe partial interface IAvnActionCallback : Prowl.Surface.MicroCom.IUnknown
    {
        void Run();
    }

    internal unsafe partial interface IAvnPlatformThreadingInterfaceEvents : Prowl.Surface.MicroCom.IUnknown
    {
        void Signaled();
        void Timer();
        void ReadyForBackgroundProcessing();
    }

    internal unsafe partial interface IAvnLoopCancellation : Prowl.Surface.MicroCom.IUnknown
    {
        void Cancel();
    }

    internal unsafe partial interface IAvnPlatformThreadingInterface : Prowl.Surface.MicroCom.IUnknown
    {
        int CurrentThreadIsLoopThread { get; }

        void SetEvents(IAvnPlatformThreadingInterfaceEvents cb);
        IAvnLoopCancellation CreateLoopCancellation();
        void RunLoop(IAvnLoopCancellation cancel);
        void Signal();
        void UpdateTimer(int ms);
        void RequestBackgroundProcessing();
    }

    internal unsafe partial interface IAvnSystemDialogEvents : Prowl.Surface.MicroCom.IUnknown
    {
        void OnCompleted(int numResults, void* ptrFirstResult);
    }

    internal unsafe partial interface IAvnSystemDialogs : Prowl.Surface.MicroCom.IUnknown
    {
        void SelectFolderDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, int allowMultiple, string title, string initialPath);
        void OpenFileDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, int allowMultiple, string title, string initialDirectory, string initialFile, string filters);
        void SaveFileDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, string title, string initialDirectory, string initialFile, string filters);
    }

    internal unsafe partial interface IAvnScreens : Prowl.Surface.MicroCom.IUnknown
    {
        int ScreenCount { get; }

        AvnScreen GetScreen(int index);
    }

    internal unsafe partial interface IAvnClipboard : Prowl.Surface.MicroCom.IUnknown
    {
        IAvnString GetText(string type);
        void SetText(string type, string utf8Text);
        IAvnStringArray ObtainFormats();
        IAvnStringArray GetStrings(string type);
        void SetBytes(string type, void* utf8Text, int len);
        IAvnString GetBytes(string type);
        void Clear();
    }

    internal unsafe partial interface IAvnCursor : Prowl.Surface.MicroCom.IUnknown
    {
    }

    internal unsafe partial interface IAvnCursorFactory : Prowl.Surface.MicroCom.IUnknown
    {
        IAvnCursor GetCursor(AvnStandardCursorType cursorType);
        IAvnCursor CreateCustomCursor(void* bitmapData, System.IntPtr length, AvnPixelSize hotPixel);
    }

    internal unsafe partial interface IAvnGlDisplay : Prowl.Surface.MicroCom.IUnknown
    {
        IAvnGlContext CreateContext(IAvnGlContext share);
        void LegacyClearCurrentContext();
        IAvnGlContext WrapContext(IntPtr native);
        IntPtr GetProcAddress(string proc);
    }

    internal unsafe partial interface IAvnGlContext : Prowl.Surface.MicroCom.IUnknown
    {
        IUnknown MakeCurrent();
        void LegacyMakeCurrent();
        int SampleCount { get; }

        int StencilSize { get; }

        IntPtr NativeHandle { get; }
    }

    internal unsafe partial interface IAvnGlSurfaceRenderTarget : Prowl.Surface.MicroCom.IUnknown
    {
        IAvnGlSurfaceRenderingSession BeginDrawing();
    }

    internal unsafe partial interface IAvnGlSurfaceRenderingSession : Prowl.Surface.MicroCom.IUnknown
    {
        AvnPixelSize PixelSize { get; }

        double Scaling { get; }
    }

    internal unsafe partial interface IAvnTrayIcon : Prowl.Surface.MicroCom.IUnknown
    {
        void SetIcon(void* data, System.IntPtr length);
        void SetMenu(IAvnMenu menu);
        void SetIsVisible(int isVisible);
    }

    internal unsafe partial interface IAvnMenu : Prowl.Surface.MicroCom.IUnknown
    {
        void InsertItem(int index, IAvnMenuItem item);
        void RemoveItem(IAvnMenuItem item);
        void SetTitle(string utf8String);
        void Clear();
    }

    internal unsafe partial interface IAvnPredicateCallback : Prowl.Surface.MicroCom.IUnknown
    {
        int Evaluate();
    }

    internal unsafe partial interface IAvnMenuItem : Prowl.Surface.MicroCom.IUnknown
    {
        void SetSubMenu(IAvnMenu menu);
        void SetTitle(string utf8String);
        void SetGesture(AvnKey key, AvnInputModifiers modifiers);
        void SetAction(IAvnPredicateCallback predicate, IAvnActionCallback callback);
        void SetIsChecked(int isChecked);
        void SetToggleType(AvnMenuItemToggleType toggleType);
        void SetIcon(void* data, System.IntPtr length);
    }

    internal unsafe partial interface IAvnMenuEvents : Prowl.Surface.MicroCom.IUnknown
    {
        void NeedsUpdate();
        void Opening();
        void Closed();
    }

    internal unsafe partial interface IAvnStringArray : Prowl.Surface.MicroCom.IUnknown
    {
        uint Count { get; }

        IAvnString Get(uint index);
    }

    internal unsafe partial interface IAvnDndResultCallback : Prowl.Surface.MicroCom.IUnknown
    {
        void OnDragAndDropComplete(AvnDragDropEffects effecct);
    }

    internal unsafe partial interface IAvnGCHandleDeallocatorCallback : Prowl.Surface.MicroCom.IUnknown
    {
        void FreeGCHandle(IntPtr handle);
    }

    internal unsafe partial interface IAvnNativeControlHost : Prowl.Surface.MicroCom.IUnknown
    {
        IntPtr CreateDefaultChild(IntPtr parent);
        IAvnNativeControlHostTopLevelAttachment CreateAttachment();
        void DestroyDefaultChild(IntPtr child);
    }

    internal unsafe partial interface IAvnNativeControlHostTopLevelAttachment : Prowl.Surface.MicroCom.IUnknown
    {
        IntPtr ParentHandle { get; }

        void InitializeWithChildHandle(IntPtr child);
        void AttachTo(IAvnNativeControlHost host);
        void ShowInBounds(float x, float y, float width, float height);
        void HideWithSize(float width, float height);
        void ReleaseChild();
    }

    internal unsafe partial interface IAvnApplicationEvents : Prowl.Surface.MicroCom.IUnknown
    {
        void FilesOpened(IAvnStringArray urls);
        int TryShutdown();
    }

    internal unsafe partial interface IAvnApplicationCommands : Prowl.Surface.MicroCom.IUnknown
    {
        void HideApp();
        void ShowAll();
        void HideOthers();
    }

    internal unsafe partial interface IAvnAutomationPeer : Prowl.Surface.MicroCom.IUnknown
    {
        IAvnAutomationNode Node { get; }

        void SetNode(IAvnAutomationNode node);
        IAvnString AcceleratorKey { get; }

        IAvnString AccessKey { get; }

        AvnAutomationControlType AutomationControlType { get; }

        IAvnString AutomationId { get; }

        AvnRect BoundingRectangle { get; }

        IAvnAutomationPeerArray Children { get; }

        IAvnString ClassName { get; }

        IAvnAutomationPeer LabeledBy { get; }

        IAvnString Name { get; }

        IAvnAutomationPeer Parent { get; }

        int HasKeyboardFocus();
        int IsContentElement();
        int IsControlElement();
        int IsEnabled();
        int IsKeyboardFocusable();
        void SetFocus();
        int ShowContextMenu();
        IAvnAutomationPeer RootPeer { get; }

        int IsRootProvider();
        IAvnWindowBase RootProvider_GetWindow();
        IAvnAutomationPeer RootProvider_GetFocus();
        IAvnAutomationPeer RootProvider_GetPeerFromPoint(AvnPoint point);
        int IsExpandCollapseProvider();
        int ExpandCollapseProvider_GetIsExpanded();
        int ExpandCollapseProvider_GetShowsMenu();
        void ExpandCollapseProvider_Expand();
        void ExpandCollapseProvider_Collapse();
        int IsInvokeProvider();
        void InvokeProvider_Invoke();
        int IsRangeValueProvider();
        double RangeValueProvider_GetValue();
        double RangeValueProvider_GetMinimum();
        double RangeValueProvider_GetMaximum();
        double RangeValueProvider_GetSmallChange();
        double RangeValueProvider_GetLargeChange();
        void RangeValueProvider_SetValue(double value);
        int IsSelectionItemProvider();
        int SelectionItemProvider_IsSelected();
        int IsToggleProvider();
        int ToggleProvider_GetToggleState();
        void ToggleProvider_Toggle();
        int IsValueProvider();
        IAvnString ValueProvider_GetValue();
        void ValueProvider_SetValue(string value);
    }

    internal unsafe partial interface IAvnAutomationPeerArray : Prowl.Surface.MicroCom.IUnknown
    {
        uint Count { get; }

        IAvnAutomationPeer Get(uint index);
    }

    internal unsafe partial interface IAvnAutomationNode : Prowl.Surface.MicroCom.IUnknown
    {
        void Dispose();
        void ChildrenChanged();
        void PropertyChanged(AvnAutomationProperty property);
        void FocusChanged();
    }

    internal unsafe partial interface IAvnPlatformSettings : Prowl.Surface.MicroCom.IUnknown
    {
        AvnPlatformThemeVariant PlatformTheme { get; }

        uint AccentColor { get; }

        void RegisterColorsChange(IAvnActionCallback callback);
    }

    internal unsafe partial interface IAvnPlatformBehaviorInhibition : Prowl.Surface.MicroCom.IUnknown
    {
        void SetInhibitAppSleep(int inhibitAppSleep, string reason);
    }
}

namespace Prowl.Surface.Mac.Interop.Impl
{
    unsafe internal partial class __MicroComIAvaloniaNativeFactoryProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvaloniaNativeFactory
    {
        public void Initialize(IAvnGCHandleDeallocatorCallback deallocator, IAvnApplicationEvents appCb)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(deallocator), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(appCb), (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Initialize failed", __result);
        }

        public IAvnMacOptions MacOptions
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 1]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMacOptions>(__result, true);
            }
        }

        public IAvnWindow CreateWindow(IAvnWindowEvents cb, IAvnGlContext gl)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cb), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(gl), &__marshal_ppv, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateWindow failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindow>(__marshal_ppv, true);
        }

        public IAvnPopup CreatePopup(IAvnWindowEvents cb, IAvnGlContext gl)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cb), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(gl), &__marshal_ppv, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreatePopup failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPopup>(__marshal_ppv, true);
        }

        public IAvnPlatformThreadingInterface CreatePlatformThreadingInterface()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 4]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreatePlatformThreadingInterface failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPlatformThreadingInterface>(__marshal_ppv, true);
        }

        public IAvnSystemDialogs CreateSystemDialogs()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 5]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateSystemDialogs failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnSystemDialogs>(__marshal_ppv, true);
        }

        public IAvnScreens CreateScreens()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 6]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateScreens failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnScreens>(__marshal_ppv, true);
        }

        public IAvnClipboard CreateClipboard()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 7]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateClipboard failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnClipboard>(__marshal_ppv, true);
        }

        public IAvnClipboard CreateDndClipboard()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 8]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateDndClipboard failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnClipboard>(__marshal_ppv, true);
        }

        public IAvnCursorFactory CreateCursorFactory()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 9]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateCursorFactory failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnCursorFactory>(__marshal_ppv, true);
        }

        public IAvnGlDisplay ObtainGlDisplay()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 10]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainGlDisplay failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlDisplay>(__marshal_ppv, true);
        }

        public void SetAppMenu(IAvnMenu menu)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(menu), (*PPV)[base.VTableSize + 11]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetAppMenu failed", __result);
        }

        public void SetServicesMenu(IAvnMenu menu)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(menu), (*PPV)[base.VTableSize + 12]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetServicesMenu failed", __result);
        }

        public IAvnMenu CreateMenu(IAvnMenuEvents cb)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cb), &__marshal_ppv, (*PPV)[base.VTableSize + 13]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateMenu failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(__marshal_ppv, true);
        }

        public IAvnMenuItem CreateMenuItem()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 14]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateMenuItem failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenuItem>(__marshal_ppv, true);
        }

        public IAvnMenuItem CreateMenuItemSeparator()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 15]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateMenuItemSeparator failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenuItem>(__marshal_ppv, true);
        }

        public IAvnTrayIcon CreateTrayIcon()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 16]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateTrayIcon failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnTrayIcon>(__marshal_ppv, true);
        }

        public IAvnApplicationCommands CreateApplicationCommands()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 17]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateApplicationCommands failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnApplicationCommands>(__marshal_ppv, true);
        }

        public IAvnPlatformSettings CreatePlatformSettings()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 18]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreatePlatformSettings failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPlatformSettings>(__marshal_ppv, true);
        }

        public IAvnPlatformBehaviorInhibition CreatePlatformBehaviorInhibition()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 19]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreatePlatformBehaviorInhibition failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPlatformBehaviorInhibition>(__marshal_ppv, true);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvaloniaNativeFactory), new Guid("809c652e-7396-11d2-9771-00a0c9b4d50c"), (p, owns) => new __MicroComIAvaloniaNativeFactoryProxy(p, owns));
        }

        public __MicroComIAvaloniaNativeFactoryProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 20;
    }

    unsafe class __MicroComIAvaloniaNativeFactoryVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int InitializeDelegate(IntPtr @this, void* deallocator, void* appCb);
        static int Initialize(IntPtr @this, void* deallocator, void* appCb)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Initialize(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGCHandleDeallocatorCallback>(deallocator, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnApplicationEvents>(appCb, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetMacOptionsDelegate(IntPtr @this);
        static void* GetMacOptions(IntPtr @this)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.MacOptions;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateWindowDelegate(IntPtr @this, void* cb, void* gl, void** ppv);
        static int CreateWindow(IntPtr @this, void* cb, void* gl, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateWindow(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindowEvents>(cb, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlContext>(gl, false));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreatePopupDelegate(IntPtr @this, void* cb, void* gl, void** ppv);
        static int CreatePopup(IntPtr @this, void* cb, void* gl, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreatePopup(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindowEvents>(cb, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlContext>(gl, false));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreatePlatformThreadingInterfaceDelegate(IntPtr @this, void** ppv);
        static int CreatePlatformThreadingInterface(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreatePlatformThreadingInterface();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateSystemDialogsDelegate(IntPtr @this, void** ppv);
        static int CreateSystemDialogs(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateSystemDialogs();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateScreensDelegate(IntPtr @this, void** ppv);
        static int CreateScreens(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateScreens();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateClipboardDelegate(IntPtr @this, void** ppv);
        static int CreateClipboard(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateClipboard();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateDndClipboardDelegate(IntPtr @this, void** ppv);
        static int CreateDndClipboard(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateDndClipboard();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateCursorFactoryDelegate(IntPtr @this, void** ppv);
        static int CreateCursorFactory(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateCursorFactory();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainGlDisplayDelegate(IntPtr @this, void** ppv);
        static int ObtainGlDisplay(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainGlDisplay();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetAppMenuDelegate(IntPtr @this, void* menu);
        static int SetAppMenu(IntPtr @this, void* menu)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetAppMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(menu, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetServicesMenuDelegate(IntPtr @this, void* menu);
        static int SetServicesMenu(IntPtr @this, void* menu)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetServicesMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(menu, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateMenuDelegate(IntPtr @this, void* cb, void** ppv);
        static int CreateMenu(IntPtr @this, void* cb, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenuEvents>(cb, false));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateMenuItemDelegate(IntPtr @this, void** ppv);
        static int CreateMenuItem(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateMenuItem();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateMenuItemSeparatorDelegate(IntPtr @this, void** ppv);
        static int CreateMenuItemSeparator(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateMenuItemSeparator();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateTrayIconDelegate(IntPtr @this, void** ppv);
        static int CreateTrayIcon(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateTrayIcon();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateApplicationCommandsDelegate(IntPtr @this, void** ppv);
        static int CreateApplicationCommands(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateApplicationCommands();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreatePlatformSettingsDelegate(IntPtr @this, void** ppv);
        static int CreatePlatformSettings(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreatePlatformSettings();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreatePlatformBehaviorInhibitionDelegate(IntPtr @this, void** ppv);
        static int CreatePlatformBehaviorInhibition(IntPtr @this, void** ppv)
        {
            IAvaloniaNativeFactory __target = null;
            try
            {
                {
                    __target = (IAvaloniaNativeFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreatePlatformBehaviorInhibition();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvaloniaNativeFactoryVTable()
        {
            base.AddMethod((InitializeDelegate)Initialize);
            base.AddMethod((GetMacOptionsDelegate)GetMacOptions);
            base.AddMethod((CreateWindowDelegate)CreateWindow);
            base.AddMethod((CreatePopupDelegate)CreatePopup);
            base.AddMethod((CreatePlatformThreadingInterfaceDelegate)CreatePlatformThreadingInterface);
            base.AddMethod((CreateSystemDialogsDelegate)CreateSystemDialogs);
            base.AddMethod((CreateScreensDelegate)CreateScreens);
            base.AddMethod((CreateClipboardDelegate)CreateClipboard);
            base.AddMethod((CreateDndClipboardDelegate)CreateDndClipboard);
            base.AddMethod((CreateCursorFactoryDelegate)CreateCursorFactory);
            base.AddMethod((ObtainGlDisplayDelegate)ObtainGlDisplay);
            base.AddMethod((SetAppMenuDelegate)SetAppMenu);
            base.AddMethod((SetServicesMenuDelegate)SetServicesMenu);
            base.AddMethod((CreateMenuDelegate)CreateMenu);
            base.AddMethod((CreateMenuItemDelegate)CreateMenuItem);
            base.AddMethod((CreateMenuItemSeparatorDelegate)CreateMenuItemSeparator);
            base.AddMethod((CreateTrayIconDelegate)CreateTrayIcon);
            base.AddMethod((CreateApplicationCommandsDelegate)CreateApplicationCommands);
            base.AddMethod((CreatePlatformSettingsDelegate)CreatePlatformSettings);
            base.AddMethod((CreatePlatformBehaviorInhibitionDelegate)CreatePlatformBehaviorInhibition);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvaloniaNativeFactory), new __MicroComIAvaloniaNativeFactoryVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnStringProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnString
    {
        public void* Pointer()
        {
            int __result;
            void* retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &retOut, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Pointer failed", __result);
            return retOut;
        }

        public int Length()
        {
            int __result;
            int ret = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Length failed", __result);
            return ret;
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnString), new Guid("233e094f-9b9f-44a3-9a6e-6948bbdd9fb1"), (p, owns) => new __MicroComIAvnStringProxy(p, owns));
        }

        public __MicroComIAvnStringProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnStringVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int PointerDelegate(IntPtr @this, void** retOut);
        static int Pointer(IntPtr @this, void** retOut)
        {
            IAvnString __target = null;
            try
            {
                {
                    __target = (IAvnString)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Pointer();
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int LengthDelegate(IntPtr @this, int* ret);
        static int Length(IntPtr @this, int* ret)
        {
            IAvnString __target = null;
            try
            {
                {
                    __target = (IAvnString)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Length();
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnStringVTable()
        {
            base.AddMethod((PointerDelegate)Pointer);
            base.AddMethod((LengthDelegate)Length);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnString), new __MicroComIAvnStringVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnWindowBaseProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnWindowBase
    {
        public void Show(int activate, int isDialog)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, activate, isDialog, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Show failed", __result);
        }

        public void Hide()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Hide failed", __result);
        }

        public void Close()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Close failed", __result);
        }

        public void Activate()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Activate failed", __result);
        }

        public AvnSize ClientSize
        {
            get
            {
                int __result;
                AvnSize ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 4]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetClientSize failed", __result);
                return ret;
            }
        }

        public void GetFrameSize(AvnSize* result)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, result, (*PPV)[base.VTableSize + 5]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetFrameSize failed", __result);
        }

        public double Scaling
        {
            get
            {
                int __result;
                double ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 6]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetScaling failed", __result);
                return ret;
            }
        }

        public void SetMinMaxSize(AvnSize minSize, AvnSize maxSize)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, minSize, maxSize, (*PPV)[base.VTableSize + 7]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetMinMaxSize failed", __result);
        }

        public void Resize(double width, double height, AvnPlatformResizeReason reason)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, width, height, reason, (*PPV)[base.VTableSize + 8]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Resize failed", __result);
        }

        public void Invalidate(AvnRect rect)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, rect, (*PPV)[base.VTableSize + 9]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Invalidate failed", __result);
        }

        public void BeginMoveDrag()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 10]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("BeginMoveDrag failed", __result);
        }

        public void BeginResizeDrag(AvnWindowEdge edge)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, edge, (*PPV)[base.VTableSize + 11]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("BeginResizeDrag failed", __result);
        }

        public AvnPoint Position
        {
            get
            {
                int __result;
                AvnPoint ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 12]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetPosition failed", __result);
                return ret;
            }
        }

        public void SetPosition(AvnPoint point)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, point, (*PPV)[base.VTableSize + 13]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetPosition failed", __result);
        }

        public AvnPoint PointToClient(AvnPoint point)
        {
            int __result;
            AvnPoint ret = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, point, &ret, (*PPV)[base.VTableSize + 14]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("PointToClient failed", __result);
            return ret;
        }

        public AvnPoint PointToScreen(AvnPoint point)
        {
            int __result;
            AvnPoint ret = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, point, &ret, (*PPV)[base.VTableSize + 15]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("PointToScreen failed", __result);
            return ret;
        }

        public void ThreadSafeSetSwRenderedFrame(AvnFramebuffer* fb, IUnknown dispose)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, fb, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(dispose), (*PPV)[base.VTableSize + 16]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ThreadSafeSetSwRenderedFrame failed", __result);
        }

        public void SetTopMost(int value)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, value, (*PPV)[base.VTableSize + 17]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTopMost failed", __result);
        }

        public void SetCursor(IAvnCursor cursor)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cursor), (*PPV)[base.VTableSize + 18]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetCursor failed", __result);
        }

        public IAvnGlSurfaceRenderTarget CreateGlRenderTarget()
        {
            int __result;
            void* __marshal_ret = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ret, (*PPV)[base.VTableSize + 19]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateGlRenderTarget failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlSurfaceRenderTarget>(__marshal_ret, true);
        }

        public void SetMainMenu(IAvnMenu menu)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(menu), (*PPV)[base.VTableSize + 20]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetMainMenu failed", __result);
        }

        public IntPtr ObtainNSWindowHandle()
        {
            int __result;
            IntPtr retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &retOut, (*PPV)[base.VTableSize + 21]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainNSWindowHandle failed", __result);
            return retOut;
        }

        public IntPtr ObtainNSWindowHandleRetained()
        {
            int __result;
            IntPtr retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &retOut, (*PPV)[base.VTableSize + 22]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainNSWindowHandleRetained failed", __result);
            return retOut;
        }

        public IntPtr ObtainNSViewHandle()
        {
            int __result;
            IntPtr retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &retOut, (*PPV)[base.VTableSize + 23]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainNSViewHandle failed", __result);
            return retOut;
        }

        public IntPtr ObtainNSViewHandleRetained()
        {
            int __result;
            IntPtr retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &retOut, (*PPV)[base.VTableSize + 24]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainNSViewHandleRetained failed", __result);
            return retOut;
        }

        public IAvnNativeControlHost CreateNativeControlHost()
        {
            int __result;
            void* __marshal_retOut = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_retOut, (*PPV)[base.VTableSize + 25]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateNativeControlHost failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnNativeControlHost>(__marshal_retOut, true);
        }

        public void BeginDragAndDropOperation(AvnDragDropEffects effects, AvnPoint point, IAvnClipboard clipboard, IAvnDndResultCallback cb, IntPtr sourceHandle)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, effects, point, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(clipboard), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cb), sourceHandle, (*PPV)[base.VTableSize + 26]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("BeginDragAndDropOperation failed", __result);
        }

        public void SetTransparencyMode(AvnWindowTransparencyMode mode)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, mode, (*PPV)[base.VTableSize + 27]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTransparencyMode failed", __result);
        }

        public void SetFrameThemeVariant(AvnPlatformThemeVariant mode)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, mode, (*PPV)[base.VTableSize + 28]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetFrameThemeVariant failed", __result);
        }

        public IAvnTextInputMethod InputMethod
        {
            get
            {
                int __result;
                void* __marshal_ppv = null;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 29]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetInputMethod failed", __result);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnTextInputMethod>(__marshal_ppv, true);
            }
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnWindowBase), new Guid("e5aca675-02b7-4129-aa79-d6e417210bda"), (p, owns) => new __MicroComIAvnWindowBaseProxy(p, owns));
        }

        public __MicroComIAvnWindowBaseProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 30;
    }

    unsafe class __MicroComIAvnWindowBaseVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ShowDelegate(IntPtr @this, int activate, int isDialog);
        static int Show(IntPtr @this, int activate, int isDialog)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Show(activate, isDialog);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int HideDelegate(IntPtr @this);
        static int Hide(IntPtr @this)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Hide();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CloseDelegate(IntPtr @this);
        static int Close(IntPtr @this)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Close();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ActivateDelegate(IntPtr @this);
        static int Activate(IntPtr @this)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Activate();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetClientSizeDelegate(IntPtr @this, AvnSize* ret);
        static int GetClientSize(IntPtr @this, AvnSize* ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ClientSize;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetFrameSizeDelegate(IntPtr @this, AvnSize* result);
        static int GetFrameSize(IntPtr @this, AvnSize* result)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.GetFrameSize(result);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetScalingDelegate(IntPtr @this, double* ret);
        static int GetScaling(IntPtr @this, double* ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Scaling;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetMinMaxSizeDelegate(IntPtr @this, AvnSize minSize, AvnSize maxSize);
        static int SetMinMaxSize(IntPtr @this, AvnSize minSize, AvnSize maxSize)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetMinMaxSize(minSize, maxSize);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ResizeDelegate(IntPtr @this, double width, double height, AvnPlatformResizeReason reason);
        static int Resize(IntPtr @this, double width, double height, AvnPlatformResizeReason reason)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Resize(width, height, reason);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int InvalidateDelegate(IntPtr @this, AvnRect rect);
        static int Invalidate(IntPtr @this, AvnRect rect)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Invalidate(rect);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int BeginMoveDragDelegate(IntPtr @this);
        static int BeginMoveDrag(IntPtr @this)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.BeginMoveDrag();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int BeginResizeDragDelegate(IntPtr @this, AvnWindowEdge edge);
        static int BeginResizeDrag(IntPtr @this, AvnWindowEdge edge)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.BeginResizeDrag(edge);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetPositionDelegate(IntPtr @this, AvnPoint* ret);
        static int GetPosition(IntPtr @this, AvnPoint* ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Position;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetPositionDelegate(IntPtr @this, AvnPoint point);
        static int SetPosition(IntPtr @this, AvnPoint point)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetPosition(point);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int PointToClientDelegate(IntPtr @this, AvnPoint point, AvnPoint* ret);
        static int PointToClient(IntPtr @this, AvnPoint point, AvnPoint* ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.PointToClient(point);
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int PointToScreenDelegate(IntPtr @this, AvnPoint point, AvnPoint* ret);
        static int PointToScreen(IntPtr @this, AvnPoint point, AvnPoint* ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.PointToScreen(point);
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ThreadSafeSetSwRenderedFrameDelegate(IntPtr @this, AvnFramebuffer* fb, void* dispose);
        static int ThreadSafeSetSwRenderedFrame(IntPtr @this, AvnFramebuffer* fb, void* dispose)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ThreadSafeSetSwRenderedFrame(fb, Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IUnknown>(dispose, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTopMostDelegate(IntPtr @this, int value);
        static int SetTopMost(IntPtr @this, int value)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTopMost(value);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetCursorDelegate(IntPtr @this, void* cursor);
        static int SetCursor(IntPtr @this, void* cursor)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetCursor(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnCursor>(cursor, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateGlRenderTargetDelegate(IntPtr @this, void** ret);
        static int CreateGlRenderTarget(IntPtr @this, void** ret)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateGlRenderTarget();
                        *ret = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetMainMenuDelegate(IntPtr @this, void* menu);
        static int SetMainMenu(IntPtr @this, void* menu)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetMainMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(menu, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainNSWindowHandleDelegate(IntPtr @this, IntPtr* retOut);
        static int ObtainNSWindowHandle(IntPtr @this, IntPtr* retOut)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainNSWindowHandle();
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainNSWindowHandleRetainedDelegate(IntPtr @this, IntPtr* retOut);
        static int ObtainNSWindowHandleRetained(IntPtr @this, IntPtr* retOut)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainNSWindowHandleRetained();
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainNSViewHandleDelegate(IntPtr @this, IntPtr* retOut);
        static int ObtainNSViewHandle(IntPtr @this, IntPtr* retOut)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainNSViewHandle();
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainNSViewHandleRetainedDelegate(IntPtr @this, IntPtr* retOut);
        static int ObtainNSViewHandleRetained(IntPtr @this, IntPtr* retOut)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainNSViewHandleRetained();
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateNativeControlHostDelegate(IntPtr @this, void** retOut);
        static int CreateNativeControlHost(IntPtr @this, void** retOut)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateNativeControlHost();
                        *retOut = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int BeginDragAndDropOperationDelegate(IntPtr @this, AvnDragDropEffects effects, AvnPoint point, void* clipboard, void* cb, IntPtr sourceHandle);
        static int BeginDragAndDropOperation(IntPtr @this, AvnDragDropEffects effects, AvnPoint point, void* clipboard, void* cb, IntPtr sourceHandle)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.BeginDragAndDropOperation(effects, point, Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnClipboard>(clipboard, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnDndResultCallback>(cb, false), sourceHandle);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTransparencyModeDelegate(IntPtr @this, AvnWindowTransparencyMode mode);
        static int SetTransparencyMode(IntPtr @this, AvnWindowTransparencyMode mode)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTransparencyMode(mode);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetFrameThemeVariantDelegate(IntPtr @this, AvnPlatformThemeVariant mode);
        static int SetFrameThemeVariant(IntPtr @this, AvnPlatformThemeVariant mode)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetFrameThemeVariant(mode);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetInputMethodDelegate(IntPtr @this, void** ppv);
        static int GetInputMethod(IntPtr @this, void** ppv)
        {
            IAvnWindowBase __target = null;
            try
            {
                {
                    __target = (IAvnWindowBase)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.InputMethod;
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnWindowBaseVTable()
        {
            base.AddMethod((ShowDelegate)Show);
            base.AddMethod((HideDelegate)Hide);
            base.AddMethod((CloseDelegate)Close);
            base.AddMethod((ActivateDelegate)Activate);
            base.AddMethod((GetClientSizeDelegate)GetClientSize);
            base.AddMethod((GetFrameSizeDelegate)GetFrameSize);
            base.AddMethod((GetScalingDelegate)GetScaling);
            base.AddMethod((SetMinMaxSizeDelegate)SetMinMaxSize);
            base.AddMethod((ResizeDelegate)Resize);
            base.AddMethod((InvalidateDelegate)Invalidate);
            base.AddMethod((BeginMoveDragDelegate)BeginMoveDrag);
            base.AddMethod((BeginResizeDragDelegate)BeginResizeDrag);
            base.AddMethod((GetPositionDelegate)GetPosition);
            base.AddMethod((SetPositionDelegate)SetPosition);
            base.AddMethod((PointToClientDelegate)PointToClient);
            base.AddMethod((PointToScreenDelegate)PointToScreen);
            base.AddMethod((ThreadSafeSetSwRenderedFrameDelegate)ThreadSafeSetSwRenderedFrame);
            base.AddMethod((SetTopMostDelegate)SetTopMost);
            base.AddMethod((SetCursorDelegate)SetCursor);
            base.AddMethod((CreateGlRenderTargetDelegate)CreateGlRenderTarget);
            base.AddMethod((SetMainMenuDelegate)SetMainMenu);
            base.AddMethod((ObtainNSWindowHandleDelegate)ObtainNSWindowHandle);
            base.AddMethod((ObtainNSWindowHandleRetainedDelegate)ObtainNSWindowHandleRetained);
            base.AddMethod((ObtainNSViewHandleDelegate)ObtainNSViewHandle);
            base.AddMethod((ObtainNSViewHandleRetainedDelegate)ObtainNSViewHandleRetained);
            base.AddMethod((CreateNativeControlHostDelegate)CreateNativeControlHost);
            base.AddMethod((BeginDragAndDropOperationDelegate)BeginDragAndDropOperation);
            base.AddMethod((SetTransparencyModeDelegate)SetTransparencyMode);
            base.AddMethod((SetFrameThemeVariantDelegate)SetFrameThemeVariant);
            base.AddMethod((GetInputMethodDelegate)GetInputMethod);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnWindowBase), new __MicroComIAvnWindowBaseVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPopupProxy : __MicroComIAvnWindowBaseProxy, IAvnPopup
    {
        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPopup), new Guid("83e588f3-6981-4e48-9ea0-e1e569f79a91"), (p, owns) => new __MicroComIAvnPopupProxy(p, owns));
        }

        public __MicroComIAvnPopupProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 0;
    }

    unsafe class __MicroComIAvnPopupVTable : __MicroComIAvnWindowBaseVTable
    {
        public __MicroComIAvnPopupVTable()
        {
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPopup), new __MicroComIAvnPopupVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnWindowProxy : __MicroComIAvnWindowBaseProxy, IAvnWindow
    {
        public void SetEnabled(int enable)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, enable, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetEnabled failed", __result);
        }

        public void SetParent(IAvnWindow parent)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(parent), (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetParent failed", __result);
        }

        public void SetCanResize(int value)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, value, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetCanResize failed", __result);
        }

        public void SetDecorations(SystemDecorations value)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, value, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetDecorations failed", __result);
        }

        public void SetTitle(string utf8Title)
        {
            int __result;
            var __bytemarshal_utf8Title = new byte[System.Text.Encoding.UTF8.GetByteCount(utf8Title) + 1];
            System.Text.Encoding.UTF8.GetBytes(utf8Title, 0, utf8Title.Length, __bytemarshal_utf8Title, 0);
            fixed (byte* __fixedmarshal_utf8Title = __bytemarshal_utf8Title)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_utf8Title, (*PPV)[base.VTableSize + 4]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTitle failed", __result);
        }

        public void SetTitleBarColor(AvnColor color)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, color, (*PPV)[base.VTableSize + 5]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTitleBarColor failed", __result);
        }

        public void SetWindowState(AvnWindowState state)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, state, (*PPV)[base.VTableSize + 6]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetWindowState failed", __result);
        }

        public AvnWindowState WindowState
        {
            get
            {
                int __result;
                AvnWindowState ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 7]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetWindowState failed", __result);
                return ret;
            }
        }

        public void TakeFocusFromChildren()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 8]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("TakeFocusFromChildren failed", __result);
        }

        public void SetExtendClientArea(int enable)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, enable, (*PPV)[base.VTableSize + 9]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetExtendClientArea failed", __result);
        }

        public void SetExtendClientAreaHints(AvnExtendClientAreaChromeHints hints)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, hints, (*PPV)[base.VTableSize + 10]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetExtendClientAreaHints failed", __result);
        }

        public double ExtendTitleBarHeight
        {
            get
            {
                int __result;
                double ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 11]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetExtendTitleBarHeight failed", __result);
                return ret;
            }
        }

        public void SetExtendTitleBarHeight(double value)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, value, (*PPV)[base.VTableSize + 12]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetExtendTitleBarHeight failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnWindow), new Guid("cab661de-49d6-4ead-b59c-eac9b2b6c28d"), (p, owns) => new __MicroComIAvnWindowProxy(p, owns));
        }

        public __MicroComIAvnWindowProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 13;
    }

    unsafe class __MicroComIAvnWindowVTable : __MicroComIAvnWindowBaseVTable
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetEnabledDelegate(IntPtr @this, int enable);
        static int SetEnabled(IntPtr @this, int enable)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetEnabled(enable);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetParentDelegate(IntPtr @this, void* parent);
        static int SetParent(IntPtr @this, void* parent)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetParent(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindow>(parent, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetCanResizeDelegate(IntPtr @this, int value);
        static int SetCanResize(IntPtr @this, int value)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetCanResize(value);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetDecorationsDelegate(IntPtr @this, SystemDecorations value);
        static int SetDecorations(IntPtr @this, SystemDecorations value)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetDecorations(value);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTitleDelegate(IntPtr @this, byte* utf8Title);
        static int SetTitle(IntPtr @this, byte* utf8Title)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTitle((utf8Title == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(utf8Title))));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTitleBarColorDelegate(IntPtr @this, AvnColor color);
        static int SetTitleBarColor(IntPtr @this, AvnColor color)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTitleBarColor(color);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetWindowStateDelegate(IntPtr @this, AvnWindowState state);
        static int SetWindowState(IntPtr @this, AvnWindowState state)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetWindowState(state);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetWindowStateDelegate(IntPtr @this, AvnWindowState* ret);
        static int GetWindowState(IntPtr @this, AvnWindowState* ret)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.WindowState;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int TakeFocusFromChildrenDelegate(IntPtr @this);
        static int TakeFocusFromChildren(IntPtr @this)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.TakeFocusFromChildren();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetExtendClientAreaDelegate(IntPtr @this, int enable);
        static int SetExtendClientArea(IntPtr @this, int enable)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetExtendClientArea(enable);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetExtendClientAreaHintsDelegate(IntPtr @this, AvnExtendClientAreaChromeHints hints);
        static int SetExtendClientAreaHints(IntPtr @this, AvnExtendClientAreaChromeHints hints)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetExtendClientAreaHints(hints);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetExtendTitleBarHeightDelegate(IntPtr @this, double* ret);
        static int GetExtendTitleBarHeight(IntPtr @this, double* ret)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ExtendTitleBarHeight;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetExtendTitleBarHeightDelegate(IntPtr @this, double value);
        static int SetExtendTitleBarHeight(IntPtr @this, double value)
        {
            IAvnWindow __target = null;
            try
            {
                {
                    __target = (IAvnWindow)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetExtendTitleBarHeight(value);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnWindowVTable()
        {
            base.AddMethod((SetEnabledDelegate)SetEnabled);
            base.AddMethod((SetParentDelegate)SetParent);
            base.AddMethod((SetCanResizeDelegate)SetCanResize);
            base.AddMethod((SetDecorationsDelegate)SetDecorations);
            base.AddMethod((SetTitleDelegate)SetTitle);
            base.AddMethod((SetTitleBarColorDelegate)SetTitleBarColor);
            base.AddMethod((SetWindowStateDelegate)SetWindowState);
            base.AddMethod((GetWindowStateDelegate)GetWindowState);
            base.AddMethod((TakeFocusFromChildrenDelegate)TakeFocusFromChildren);
            base.AddMethod((SetExtendClientAreaDelegate)SetExtendClientArea);
            base.AddMethod((SetExtendClientAreaHintsDelegate)SetExtendClientAreaHints);
            base.AddMethod((GetExtendTitleBarHeightDelegate)GetExtendTitleBarHeight);
            base.AddMethod((SetExtendTitleBarHeightDelegate)SetExtendTitleBarHeight);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnWindow), new __MicroComIAvnWindowVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnWindowBaseEventsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnWindowBaseEvents
    {
        public void Paint()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Paint failed", __result);
        }

        public void Closed()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public void Activated()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 2]);
        }

        public void Deactivated()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 3]);
        }

        public void Resized(AvnSize* size, AvnPlatformResizeReason reason)
        {
            LocalInterop.CalliStdCallvoid(PPV, size, reason, (*PPV)[base.VTableSize + 4]);
        }

        public void PositionChanged(AvnPoint position)
        {
            LocalInterop.CalliStdCallvoid(PPV, position, (*PPV)[base.VTableSize + 5]);
        }

        public void RawMouseEvent(AvnRawMouseEventType type, ulong timeStamp, AvnInputModifiers modifiers, AvnPoint point, AvnVector delta)
        {
            LocalInterop.CalliStdCallvoid(PPV, type, timeStamp, modifiers, point, delta, (*PPV)[base.VTableSize + 6]);
        }

        public int RawKeyEvent(AvnRawKeyEventType type, ulong timeStamp, AvnInputModifiers modifiers, uint key)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, type, timeStamp, modifiers, key, (*PPV)[base.VTableSize + 7]);
            return __result;
        }

        public int RawTextInputEvent(ulong timeStamp, string text)
        {
            int __result;
            var __bytemarshal_text = new byte[System.Text.Encoding.UTF8.GetByteCount(text) + 1];
            System.Text.Encoding.UTF8.GetBytes(text, 0, text.Length, __bytemarshal_text, 0);
            fixed (byte* __fixedmarshal_text = __bytemarshal_text)
                __result = (int)LocalInterop.CalliStdCallint(PPV, timeStamp, __fixedmarshal_text, (*PPV)[base.VTableSize + 8]);
            return __result;
        }

        public void ScalingChanged(double scaling)
        {
            LocalInterop.CalliStdCallvoid(PPV, scaling, (*PPV)[base.VTableSize + 9]);
        }

        public void RunRenderPriorityJobs()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 10]);
        }

        public void LostFocus()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 11]);
        }

        public AvnDragDropEffects DragEvent(AvnDragEventType type, AvnPoint position, AvnInputModifiers modifiers, AvnDragDropEffects effects, IAvnClipboard clipboard, IntPtr dataObjectHandle)
        {
            AvnDragDropEffects __result;
            __result = (AvnDragDropEffects)LocalInterop.CalliStdCallAvnDragDropEffects(PPV, type, position, modifiers, effects, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(clipboard), dataObjectHandle, (*PPV)[base.VTableSize + 12]);
            return __result;
        }

        public IAvnAutomationPeer AutomationPeer
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 13]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
            }
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnWindowBaseEvents), new Guid("939b6599-40a8-4710-a4c8-5d72d8f174fb"), (p, owns) => new __MicroComIAvnWindowBaseEventsProxy(p, owns));
        }

        public __MicroComIAvnWindowBaseEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 14;
    }

    unsafe class __MicroComIAvnWindowBaseEventsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int PaintDelegate(IntPtr @this);
        static int Paint(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Paint();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ClosedDelegate(IntPtr @this);
        static void Closed(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Closed();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ActivatedDelegate(IntPtr @this);
        static void Activated(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Activated();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void DeactivatedDelegate(IntPtr @this);
        static void Deactivated(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Deactivated();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ResizedDelegate(IntPtr @this, AvnSize* size, AvnPlatformResizeReason reason);
        static void Resized(IntPtr @this, AvnSize* size, AvnPlatformResizeReason reason)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Resized(size, reason);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void PositionChangedDelegate(IntPtr @this, AvnPoint position);
        static void PositionChanged(IntPtr @this, AvnPoint position)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.PositionChanged(position);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RawMouseEventDelegate(IntPtr @this, AvnRawMouseEventType type, ulong timeStamp, AvnInputModifiers modifiers, AvnPoint point, AvnVector delta);
        static void RawMouseEvent(IntPtr @this, AvnRawMouseEventType type, ulong timeStamp, AvnInputModifiers modifiers, AvnPoint point, AvnVector delta)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RawMouseEvent(type, timeStamp, modifiers, point, delta);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int RawKeyEventDelegate(IntPtr @this, AvnRawKeyEventType type, ulong timeStamp, AvnInputModifiers modifiers, uint key);
        static int RawKeyEvent(IntPtr @this, AvnRawKeyEventType type, ulong timeStamp, AvnInputModifiers modifiers, uint key)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RawKeyEvent(type, timeStamp, modifiers, key);
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int RawTextInputEventDelegate(IntPtr @this, ulong timeStamp, byte* text);
        static int RawTextInputEvent(IntPtr @this, ulong timeStamp, byte* text)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RawTextInputEvent(timeStamp, (text == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(text))));
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ScalingChangedDelegate(IntPtr @this, double scaling);
        static void ScalingChanged(IntPtr @this, double scaling)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ScalingChanged(scaling);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RunRenderPriorityJobsDelegate(IntPtr @this);
        static void RunRenderPriorityJobs(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RunRenderPriorityJobs();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void LostFocusDelegate(IntPtr @this);
        static void LostFocus(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.LostFocus();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate AvnDragDropEffects DragEventDelegate(IntPtr @this, AvnDragEventType type, AvnPoint position, AvnInputModifiers modifiers, AvnDragDropEffects effects, void* clipboard, IntPtr dataObjectHandle);
        static AvnDragDropEffects DragEvent(IntPtr @this, AvnDragEventType type, AvnPoint position, AvnInputModifiers modifiers, AvnDragDropEffects effects, void* clipboard, IntPtr dataObjectHandle)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.DragEvent(type, position, modifiers, effects, Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnClipboard>(clipboard, false), dataObjectHandle);
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetAutomationPeerDelegate(IntPtr @this);
        static void* GetAutomationPeer(IntPtr @this)
        {
            IAvnWindowBaseEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowBaseEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AutomationPeer;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        public __MicroComIAvnWindowBaseEventsVTable()
        {
            base.AddMethod((PaintDelegate)Paint);
            base.AddMethod((ClosedDelegate)Closed);
            base.AddMethod((ActivatedDelegate)Activated);
            base.AddMethod((DeactivatedDelegate)Deactivated);
            base.AddMethod((ResizedDelegate)Resized);
            base.AddMethod((PositionChangedDelegate)PositionChanged);
            base.AddMethod((RawMouseEventDelegate)RawMouseEvent);
            base.AddMethod((RawKeyEventDelegate)RawKeyEvent);
            base.AddMethod((RawTextInputEventDelegate)RawTextInputEvent);
            base.AddMethod((ScalingChangedDelegate)ScalingChanged);
            base.AddMethod((RunRenderPriorityJobsDelegate)RunRenderPriorityJobs);
            base.AddMethod((LostFocusDelegate)LostFocus);
            base.AddMethod((DragEventDelegate)DragEvent);
            base.AddMethod((GetAutomationPeerDelegate)GetAutomationPeer);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnWindowBaseEvents), new __MicroComIAvnWindowBaseEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnWindowEventsProxy : __MicroComIAvnWindowBaseEventsProxy, IAvnWindowEvents
    {
        public int Closing()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 0]);
            return __result;
        }

        public void WindowStateChanged(AvnWindowState state)
        {
            LocalInterop.CalliStdCallvoid(PPV, state, (*PPV)[base.VTableSize + 1]);
        }

        public void GotInputWhenDisabled()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnWindowEvents), new Guid("1ae178ee-1fcc-447f-b6dd-b7bb727f934c"), (p, owns) => new __MicroComIAvnWindowEventsProxy(p, owns));
        }

        public __MicroComIAvnWindowEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnWindowEventsVTable : __MicroComIAvnWindowBaseEventsVTable
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ClosingDelegate(IntPtr @this);
        static int Closing(IntPtr @this)
        {
            IAvnWindowEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Closing();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void WindowStateChangedDelegate(IntPtr @this, AvnWindowState state);
        static void WindowStateChanged(IntPtr @this, AvnWindowState state)
        {
            IAvnWindowEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.WindowStateChanged(state);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void GotInputWhenDisabledDelegate(IntPtr @this);
        static void GotInputWhenDisabled(IntPtr @this)
        {
            IAvnWindowEvents __target = null;
            try
            {
                {
                    __target = (IAvnWindowEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.GotInputWhenDisabled();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnWindowEventsVTable()
        {
            base.AddMethod((ClosingDelegate)Closing);
            base.AddMethod((WindowStateChangedDelegate)WindowStateChanged);
            base.AddMethod((GotInputWhenDisabledDelegate)GotInputWhenDisabled);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnWindowEvents), new __MicroComIAvnWindowEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnTextInputMethodClientProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnTextInputMethodClient
    {
        public void SetPreeditText(string preeditText)
        {
            var __bytemarshal_preeditText = new byte[System.Text.Encoding.UTF8.GetByteCount(preeditText) + 1];
            System.Text.Encoding.UTF8.GetBytes(preeditText, 0, preeditText.Length, __bytemarshal_preeditText, 0);
            fixed (byte* __fixedmarshal_preeditText = __bytemarshal_preeditText)
                LocalInterop.CalliStdCallvoid(PPV, __fixedmarshal_preeditText, (*PPV)[base.VTableSize + 0]);
        }

        public void SelectInSurroundingText(int start, int length)
        {
            LocalInterop.CalliStdCallvoid(PPV, start, length, (*PPV)[base.VTableSize + 1]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnTextInputMethodClient), new Guid("f2079145-a2d9-42b8-a85e-2732e3c2b055"), (p, owns) => new __MicroComIAvnTextInputMethodClientProxy(p, owns));
        }

        public __MicroComIAvnTextInputMethodClientProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnTextInputMethodClientVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetPreeditTextDelegate(IntPtr @this, byte* preeditText);
        static void SetPreeditText(IntPtr @this, byte* preeditText)
        {
            IAvnTextInputMethodClient __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethodClient)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetPreeditText((preeditText == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(preeditText))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SelectInSurroundingTextDelegate(IntPtr @this, int start, int length);
        static void SelectInSurroundingText(IntPtr @this, int start, int length)
        {
            IAvnTextInputMethodClient __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethodClient)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SelectInSurroundingText(start, length);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnTextInputMethodClientVTable()
        {
            base.AddMethod((SetPreeditTextDelegate)SetPreeditText);
            base.AddMethod((SelectInSurroundingTextDelegate)SelectInSurroundingText);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnTextInputMethodClient), new __MicroComIAvnTextInputMethodClientVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnTextInputMethodProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnTextInputMethod
    {
        public void SetClient(IAvnTextInputMethodClient client)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(client), (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetClient failed", __result);
        }

        public void Reset()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public void SetCursorRect(AvnRect rect)
        {
            LocalInterop.CalliStdCallvoid(PPV, rect, (*PPV)[base.VTableSize + 2]);
        }

        public void SetSurroundingText(string text, int anchorOffset, int cursorOffset)
        {
            var __bytemarshal_text = new byte[System.Text.Encoding.UTF8.GetByteCount(text) + 1];
            System.Text.Encoding.UTF8.GetBytes(text, 0, text.Length, __bytemarshal_text, 0);
            fixed (byte* __fixedmarshal_text = __bytemarshal_text)
                LocalInterop.CalliStdCallvoid(PPV, __fixedmarshal_text, anchorOffset, cursorOffset, (*PPV)[base.VTableSize + 3]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnTextInputMethod), new Guid("1382a29f-e260-4c7a-b83f-c99fc72e27c2"), (p, owns) => new __MicroComIAvnTextInputMethodProxy(p, owns));
        }

        public __MicroComIAvnTextInputMethodProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 4;
    }

    unsafe class __MicroComIAvnTextInputMethodVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetClientDelegate(IntPtr @this, void* client);
        static int SetClient(IntPtr @this, void* client)
        {
            IAvnTextInputMethod __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethod)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetClient(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnTextInputMethodClient>(client, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ResetDelegate(IntPtr @this);
        static void Reset(IntPtr @this)
        {
            IAvnTextInputMethod __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethod)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Reset();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetCursorRectDelegate(IntPtr @this, AvnRect rect);
        static void SetCursorRect(IntPtr @this, AvnRect rect)
        {
            IAvnTextInputMethod __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethod)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetCursorRect(rect);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetSurroundingTextDelegate(IntPtr @this, byte* text, int anchorOffset, int cursorOffset);
        static void SetSurroundingText(IntPtr @this, byte* text, int anchorOffset, int cursorOffset)
        {
            IAvnTextInputMethod __target = null;
            try
            {
                {
                    __target = (IAvnTextInputMethod)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetSurroundingText((text == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(text))), anchorOffset, cursorOffset);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnTextInputMethodVTable()
        {
            base.AddMethod((SetClientDelegate)SetClient);
            base.AddMethod((ResetDelegate)Reset);
            base.AddMethod((SetCursorRectDelegate)SetCursorRect);
            base.AddMethod((SetSurroundingTextDelegate)SetSurroundingText);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnTextInputMethod), new __MicroComIAvnTextInputMethodVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnMacOptionsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnMacOptions
    {
        public void SetShowInDock(int show)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, show, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetShowInDock failed", __result);
        }

        public void SetApplicationTitle(string utf8string)
        {
            int __result;
            var __bytemarshal_utf8string = new byte[System.Text.Encoding.UTF8.GetByteCount(utf8string) + 1];
            System.Text.Encoding.UTF8.GetBytes(utf8string, 0, utf8string.Length, __bytemarshal_utf8string, 0);
            fixed (byte* __fixedmarshal_utf8string = __bytemarshal_utf8string)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_utf8string, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetApplicationTitle failed", __result);
        }

        public void SetDisableSetProcessName(int disable)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, disable, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetDisableSetProcessName failed", __result);
        }

        public void SetDisableAppDelegate(int disable)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, disable, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetDisableAppDelegate failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnMacOptions), new Guid("e34ae0f8-18b4-48a3-b09d-2e6b19a3cf5e"), (p, owns) => new __MicroComIAvnMacOptionsProxy(p, owns));
        }

        public __MicroComIAvnMacOptionsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 4;
    }

    unsafe class __MicroComIAvnMacOptionsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetShowInDockDelegate(IntPtr @this, int show);
        static int SetShowInDock(IntPtr @this, int show)
        {
            IAvnMacOptions __target = null;
            try
            {
                {
                    __target = (IAvnMacOptions)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetShowInDock(show);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetApplicationTitleDelegate(IntPtr @this, byte* utf8string);
        static int SetApplicationTitle(IntPtr @this, byte* utf8string)
        {
            IAvnMacOptions __target = null;
            try
            {
                {
                    __target = (IAvnMacOptions)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetApplicationTitle((utf8string == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(utf8string))));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetDisableSetProcessNameDelegate(IntPtr @this, int disable);
        static int SetDisableSetProcessName(IntPtr @this, int disable)
        {
            IAvnMacOptions __target = null;
            try
            {
                {
                    __target = (IAvnMacOptions)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetDisableSetProcessName(disable);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetDisableAppDelegateDelegate(IntPtr @this, int disable);
        static int SetDisableAppDelegate(IntPtr @this, int disable)
        {
            IAvnMacOptions __target = null;
            try
            {
                {
                    __target = (IAvnMacOptions)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetDisableAppDelegate(disable);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnMacOptionsVTable()
        {
            base.AddMethod((SetShowInDockDelegate)SetShowInDock);
            base.AddMethod((SetApplicationTitleDelegate)SetApplicationTitle);
            base.AddMethod((SetDisableSetProcessNameDelegate)SetDisableSetProcessName);
            base.AddMethod((SetDisableAppDelegateDelegate)SetDisableAppDelegate);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnMacOptions), new __MicroComIAvnMacOptionsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnActionCallbackProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnActionCallback
    {
        public void Run()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnActionCallback), new Guid("04c1b049-1f43-418a-9159-cae627ec1367"), (p, owns) => new __MicroComIAvnActionCallbackProxy(p, owns));
        }

        public __MicroComIAvnActionCallbackProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnActionCallbackVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RunDelegate(IntPtr @this);
        static void Run(IntPtr @this)
        {
            IAvnActionCallback __target = null;
            try
            {
                {
                    __target = (IAvnActionCallback)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Run();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnActionCallbackVTable()
        {
            base.AddMethod((RunDelegate)Run);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnActionCallback), new __MicroComIAvnActionCallbackVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPlatformThreadingInterfaceEventsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnPlatformThreadingInterfaceEvents
    {
        public void Signaled()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 0]);
        }

        public void Timer()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public void ReadyForBackgroundProcessing()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPlatformThreadingInterfaceEvents), new Guid("6df4d2db-0b80-4f59-ad88-0baa5e21eb14"), (p, owns) => new __MicroComIAvnPlatformThreadingInterfaceEventsProxy(p, owns));
        }

        public __MicroComIAvnPlatformThreadingInterfaceEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnPlatformThreadingInterfaceEventsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SignaledDelegate(IntPtr @this);
        static void Signaled(IntPtr @this)
        {
            IAvnPlatformThreadingInterfaceEvents __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterfaceEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Signaled();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void TimerDelegate(IntPtr @this);
        static void Timer(IntPtr @this)
        {
            IAvnPlatformThreadingInterfaceEvents __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterfaceEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Timer();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ReadyForBackgroundProcessingDelegate(IntPtr @this);
        static void ReadyForBackgroundProcessing(IntPtr @this)
        {
            IAvnPlatformThreadingInterfaceEvents __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterfaceEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ReadyForBackgroundProcessing();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnPlatformThreadingInterfaceEventsVTable()
        {
            base.AddMethod((SignaledDelegate)Signaled);
            base.AddMethod((TimerDelegate)Timer);
            base.AddMethod((ReadyForBackgroundProcessingDelegate)ReadyForBackgroundProcessing);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPlatformThreadingInterfaceEvents), new __MicroComIAvnPlatformThreadingInterfaceEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnLoopCancellationProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnLoopCancellation
    {
        public void Cancel()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnLoopCancellation), new Guid("97330f88-c22b-4a8e-a130-201520091b01"), (p, owns) => new __MicroComIAvnLoopCancellationProxy(p, owns));
        }

        public __MicroComIAvnLoopCancellationProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnLoopCancellationVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void CancelDelegate(IntPtr @this);
        static void Cancel(IntPtr @this)
        {
            IAvnLoopCancellation __target = null;
            try
            {
                {
                    __target = (IAvnLoopCancellation)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Cancel();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnLoopCancellationVTable()
        {
            base.AddMethod((CancelDelegate)Cancel);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnLoopCancellation), new __MicroComIAvnLoopCancellationVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPlatformThreadingInterfaceProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnPlatformThreadingInterface
    {
        public int CurrentThreadIsLoopThread
        {
            get
            {
                int __result;
                __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 0]);
                return __result;
            }
        }

        public void SetEvents(IAvnPlatformThreadingInterfaceEvents cb)
        {
            LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cb), (*PPV)[base.VTableSize + 1]);
        }

        public IAvnLoopCancellation CreateLoopCancellation()
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 2]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnLoopCancellation>(__result, true);
        }

        public void RunLoop(IAvnLoopCancellation cancel)
        {
            LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(cancel), (*PPV)[base.VTableSize + 3]);
        }

        public void Signal()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 4]);
        }

        public void UpdateTimer(int ms)
        {
            LocalInterop.CalliStdCallvoid(PPV, ms, (*PPV)[base.VTableSize + 5]);
        }

        public void RequestBackgroundProcessing()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 6]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPlatformThreadingInterface), new Guid("fbc06f3d-7860-42df-83fd-53c4b02dd9c3"), (p, owns) => new __MicroComIAvnPlatformThreadingInterfaceProxy(p, owns));
        }

        public __MicroComIAvnPlatformThreadingInterfaceProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 7;
    }

    unsafe class __MicroComIAvnPlatformThreadingInterfaceVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetCurrentThreadIsLoopThreadDelegate(IntPtr @this);
        static int GetCurrentThreadIsLoopThread(IntPtr @this)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CurrentThreadIsLoopThread;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetEventsDelegate(IntPtr @this, void* cb);
        static void SetEvents(IntPtr @this, void* cb)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetEvents(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPlatformThreadingInterfaceEvents>(cb, false));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* CreateLoopCancellationDelegate(IntPtr @this);
        static void* CreateLoopCancellation(IntPtr @this)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateLoopCancellation();
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RunLoopDelegate(IntPtr @this, void* cancel);
        static void RunLoop(IntPtr @this, void* cancel)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RunLoop(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnLoopCancellation>(cancel, false));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SignalDelegate(IntPtr @this);
        static void Signal(IntPtr @this)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Signal();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void UpdateTimerDelegate(IntPtr @this, int ms);
        static void UpdateTimer(IntPtr @this, int ms)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.UpdateTimer(ms);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RequestBackgroundProcessingDelegate(IntPtr @this);
        static void RequestBackgroundProcessing(IntPtr @this)
        {
            IAvnPlatformThreadingInterface __target = null;
            try
            {
                {
                    __target = (IAvnPlatformThreadingInterface)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RequestBackgroundProcessing();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnPlatformThreadingInterfaceVTable()
        {
            base.AddMethod((GetCurrentThreadIsLoopThreadDelegate)GetCurrentThreadIsLoopThread);
            base.AddMethod((SetEventsDelegate)SetEvents);
            base.AddMethod((CreateLoopCancellationDelegate)CreateLoopCancellation);
            base.AddMethod((RunLoopDelegate)RunLoop);
            base.AddMethod((SignalDelegate)Signal);
            base.AddMethod((UpdateTimerDelegate)UpdateTimer);
            base.AddMethod((RequestBackgroundProcessingDelegate)RequestBackgroundProcessing);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPlatformThreadingInterface), new __MicroComIAvnPlatformThreadingInterfaceVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnSystemDialogEventsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnSystemDialogEvents
    {
        public void OnCompleted(int numResults, void* ptrFirstResult)
        {
            LocalInterop.CalliStdCallvoid(PPV, numResults, ptrFirstResult, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnSystemDialogEvents), new Guid("6c621a6e-e4c1-4ae3-9749-83eeeffa09b6"), (p, owns) => new __MicroComIAvnSystemDialogEventsProxy(p, owns));
        }

        public __MicroComIAvnSystemDialogEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnSystemDialogEventsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void OnCompletedDelegate(IntPtr @this, int numResults, void* ptrFirstResult);
        static void OnCompleted(IntPtr @this, int numResults, void* ptrFirstResult)
        {
            IAvnSystemDialogEvents __target = null;
            try
            {
                {
                    __target = (IAvnSystemDialogEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.OnCompleted(numResults, ptrFirstResult);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnSystemDialogEventsVTable()
        {
            base.AddMethod((OnCompletedDelegate)OnCompleted);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnSystemDialogEvents), new __MicroComIAvnSystemDialogEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnSystemDialogsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnSystemDialogs
    {
        public void SelectFolderDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, int allowMultiple, string title, string initialPath)
        {
            var __bytemarshal_title = new byte[System.Text.Encoding.UTF8.GetByteCount(title) + 1];
            System.Text.Encoding.UTF8.GetBytes(title, 0, title.Length, __bytemarshal_title, 0);
            var __bytemarshal_initialPath = new byte[System.Text.Encoding.UTF8.GetByteCount(initialPath) + 1];
            System.Text.Encoding.UTF8.GetBytes(initialPath, 0, initialPath.Length, __bytemarshal_initialPath, 0);
            fixed (byte* __fixedmarshal_initialPath = __bytemarshal_initialPath)
            fixed (byte* __fixedmarshal_title = __bytemarshal_title)
                LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(parentWindowHandle), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(events), allowMultiple, __fixedmarshal_title, __fixedmarshal_initialPath, (*PPV)[base.VTableSize + 0]);
        }

        public void OpenFileDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, int allowMultiple, string title, string initialDirectory, string initialFile, string filters)
        {
            var __bytemarshal_title = new byte[System.Text.Encoding.UTF8.GetByteCount(title) + 1];
            System.Text.Encoding.UTF8.GetBytes(title, 0, title.Length, __bytemarshal_title, 0);
            var __bytemarshal_initialDirectory = new byte[System.Text.Encoding.UTF8.GetByteCount(initialDirectory) + 1];
            System.Text.Encoding.UTF8.GetBytes(initialDirectory, 0, initialDirectory.Length, __bytemarshal_initialDirectory, 0);
            var __bytemarshal_initialFile = new byte[System.Text.Encoding.UTF8.GetByteCount(initialFile) + 1];
            System.Text.Encoding.UTF8.GetBytes(initialFile, 0, initialFile.Length, __bytemarshal_initialFile, 0);
            var __bytemarshal_filters = new byte[System.Text.Encoding.UTF8.GetByteCount(filters) + 1];
            System.Text.Encoding.UTF8.GetBytes(filters, 0, filters.Length, __bytemarshal_filters, 0);
            fixed (byte* __fixedmarshal_filters = __bytemarshal_filters)
            fixed (byte* __fixedmarshal_initialFile = __bytemarshal_initialFile)
            fixed (byte* __fixedmarshal_initialDirectory = __bytemarshal_initialDirectory)
            fixed (byte* __fixedmarshal_title = __bytemarshal_title)
                LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(parentWindowHandle), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(events), allowMultiple, __fixedmarshal_title, __fixedmarshal_initialDirectory, __fixedmarshal_initialFile, __fixedmarshal_filters, (*PPV)[base.VTableSize + 1]);
        }

        public void SaveFileDialog(IAvnWindow parentWindowHandle, IAvnSystemDialogEvents events, string title, string initialDirectory, string initialFile, string filters)
        {
            var __bytemarshal_title = new byte[System.Text.Encoding.UTF8.GetByteCount(title) + 1];
            System.Text.Encoding.UTF8.GetBytes(title, 0, title.Length, __bytemarshal_title, 0);
            var __bytemarshal_initialDirectory = new byte[System.Text.Encoding.UTF8.GetByteCount(initialDirectory) + 1];
            System.Text.Encoding.UTF8.GetBytes(initialDirectory, 0, initialDirectory.Length, __bytemarshal_initialDirectory, 0);
            var __bytemarshal_initialFile = new byte[System.Text.Encoding.UTF8.GetByteCount(initialFile) + 1];
            System.Text.Encoding.UTF8.GetBytes(initialFile, 0, initialFile.Length, __bytemarshal_initialFile, 0);
            var __bytemarshal_filters = new byte[System.Text.Encoding.UTF8.GetByteCount(filters) + 1];
            System.Text.Encoding.UTF8.GetBytes(filters, 0, filters.Length, __bytemarshal_filters, 0);
            fixed (byte* __fixedmarshal_filters = __bytemarshal_filters)
            fixed (byte* __fixedmarshal_initialFile = __bytemarshal_initialFile)
            fixed (byte* __fixedmarshal_initialDirectory = __bytemarshal_initialDirectory)
            fixed (byte* __fixedmarshal_title = __bytemarshal_title)
                LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(parentWindowHandle), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(events), __fixedmarshal_title, __fixedmarshal_initialDirectory, __fixedmarshal_initialFile, __fixedmarshal_filters, (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnSystemDialogs), new Guid("4d7a47db-a944-4061-abe7-62cb6aa0ffd5"), (p, owns) => new __MicroComIAvnSystemDialogsProxy(p, owns));
        }

        public __MicroComIAvnSystemDialogsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnSystemDialogsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SelectFolderDialogDelegate(IntPtr @this, void* parentWindowHandle, void* events, int allowMultiple, byte* title, byte* initialPath);
        static void SelectFolderDialog(IntPtr @this, void* parentWindowHandle, void* events, int allowMultiple, byte* title, byte* initialPath)
        {
            IAvnSystemDialogs __target = null;
            try
            {
                {
                    __target = (IAvnSystemDialogs)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SelectFolderDialog(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindow>(parentWindowHandle, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnSystemDialogEvents>(events, false), allowMultiple, (title == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(title))), (initialPath == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(initialPath))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void OpenFileDialogDelegate(IntPtr @this, void* parentWindowHandle, void* events, int allowMultiple, byte* title, byte* initialDirectory, byte* initialFile, byte* filters);
        static void OpenFileDialog(IntPtr @this, void* parentWindowHandle, void* events, int allowMultiple, byte* title, byte* initialDirectory, byte* initialFile, byte* filters)
        {
            IAvnSystemDialogs __target = null;
            try
            {
                {
                    __target = (IAvnSystemDialogs)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.OpenFileDialog(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindow>(parentWindowHandle, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnSystemDialogEvents>(events, false), allowMultiple, (title == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(title))), (initialDirectory == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(initialDirectory))), (initialFile == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(initialFile))), (filters == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(filters))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SaveFileDialogDelegate(IntPtr @this, void* parentWindowHandle, void* events, byte* title, byte* initialDirectory, byte* initialFile, byte* filters);
        static void SaveFileDialog(IntPtr @this, void* parentWindowHandle, void* events, byte* title, byte* initialDirectory, byte* initialFile, byte* filters)
        {
            IAvnSystemDialogs __target = null;
            try
            {
                {
                    __target = (IAvnSystemDialogs)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SaveFileDialog(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindow>(parentWindowHandle, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnSystemDialogEvents>(events, false), (title == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(title))), (initialDirectory == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(initialDirectory))), (initialFile == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(initialFile))), (filters == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(filters))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnSystemDialogsVTable()
        {
            base.AddMethod((SelectFolderDialogDelegate)SelectFolderDialog);
            base.AddMethod((OpenFileDialogDelegate)OpenFileDialog);
            base.AddMethod((SaveFileDialogDelegate)SaveFileDialog);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnSystemDialogs), new __MicroComIAvnSystemDialogsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnScreensProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnScreens
    {
        public int ScreenCount
        {
            get
            {
                int __result;
                int ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 0]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetScreenCount failed", __result);
                return ret;
            }
        }

        public AvnScreen GetScreen(int index)
        {
            int __result;
            AvnScreen ret = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, index, &ret, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetScreen failed", __result);
            return ret;
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnScreens), new Guid("9a52bc7a-d8c7-4230-8d34-704a0b70a933"), (p, owns) => new __MicroComIAvnScreensProxy(p, owns));
        }

        public __MicroComIAvnScreensProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnScreensVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetScreenCountDelegate(IntPtr @this, int* ret);
        static int GetScreenCount(IntPtr @this, int* ret)
        {
            IAvnScreens __target = null;
            try
            {
                {
                    __target = (IAvnScreens)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ScreenCount;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetScreenDelegate(IntPtr @this, int index, AvnScreen* ret);
        static int GetScreen(IntPtr @this, int index, AvnScreen* ret)
        {
            IAvnScreens __target = null;
            try
            {
                {
                    __target = (IAvnScreens)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetScreen(index);
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnScreensVTable()
        {
            base.AddMethod((GetScreenCountDelegate)GetScreenCount);
            base.AddMethod((GetScreenDelegate)GetScreen);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnScreens), new __MicroComIAvnScreensVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnClipboardProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnClipboard
    {
        public IAvnString GetText(string type)
        {
            int __result;
            var __bytemarshal_type = new byte[System.Text.Encoding.UTF8.GetByteCount(type) + 1];
            System.Text.Encoding.UTF8.GetBytes(type, 0, type.Length, __bytemarshal_type, 0);
            void* __marshal_ppv = null;
            fixed (byte* __fixedmarshal_type = __bytemarshal_type)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_type, &__marshal_ppv, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetText failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__marshal_ppv, true);
        }

        public void SetText(string type, string utf8Text)
        {
            int __result;
            var __bytemarshal_type = new byte[System.Text.Encoding.UTF8.GetByteCount(type) + 1];
            System.Text.Encoding.UTF8.GetBytes(type, 0, type.Length, __bytemarshal_type, 0);
            var __bytemarshal_utf8Text = new byte[System.Text.Encoding.UTF8.GetByteCount(utf8Text) + 1];
            System.Text.Encoding.UTF8.GetBytes(utf8Text, 0, utf8Text.Length, __bytemarshal_utf8Text, 0);
            fixed (byte* __fixedmarshal_utf8Text = __bytemarshal_utf8Text)
            fixed (byte* __fixedmarshal_type = __bytemarshal_type)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_type, __fixedmarshal_utf8Text, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetText failed", __result);
        }

        public IAvnStringArray ObtainFormats()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ObtainFormats failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnStringArray>(__marshal_ppv, true);
        }

        public IAvnStringArray GetStrings(string type)
        {
            int __result;
            var __bytemarshal_type = new byte[System.Text.Encoding.UTF8.GetByteCount(type) + 1];
            System.Text.Encoding.UTF8.GetBytes(type, 0, type.Length, __bytemarshal_type, 0);
            void* __marshal_ppv = null;
            fixed (byte* __fixedmarshal_type = __bytemarshal_type)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_type, &__marshal_ppv, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetStrings failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnStringArray>(__marshal_ppv, true);
        }

        public void SetBytes(string type, void* utf8Text, int len)
        {
            int __result;
            var __bytemarshal_type = new byte[System.Text.Encoding.UTF8.GetByteCount(type) + 1];
            System.Text.Encoding.UTF8.GetBytes(type, 0, type.Length, __bytemarshal_type, 0);
            fixed (byte* __fixedmarshal_type = __bytemarshal_type)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_type, utf8Text, len, (*PPV)[base.VTableSize + 4]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetBytes failed", __result);
        }

        public IAvnString GetBytes(string type)
        {
            int __result;
            var __bytemarshal_type = new byte[System.Text.Encoding.UTF8.GetByteCount(type) + 1];
            System.Text.Encoding.UTF8.GetBytes(type, 0, type.Length, __bytemarshal_type, 0);
            void* __marshal_ppv = null;
            fixed (byte* __fixedmarshal_type = __bytemarshal_type)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_type, &__marshal_ppv, (*PPV)[base.VTableSize + 5]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetBytes failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__marshal_ppv, true);
        }

        public void Clear()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 6]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Clear failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnClipboard), new Guid("792b1bd4-76cc-46ea-bfd0-9d642154b1b3"), (p, owns) => new __MicroComIAvnClipboardProxy(p, owns));
        }

        public __MicroComIAvnClipboardProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 7;
    }

    unsafe class __MicroComIAvnClipboardVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetTextDelegate(IntPtr @this, byte* type, void** ppv);
        static int GetText(IntPtr @this, byte* type, void** ppv)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetText((type == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(type))));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTextDelegate(IntPtr @this, byte* type, byte* utf8Text);
        static int SetText(IntPtr @this, byte* type, byte* utf8Text)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetText((type == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(type))), (utf8Text == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(utf8Text))));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ObtainFormatsDelegate(IntPtr @this, void** ppv);
        static int ObtainFormats(IntPtr @this, void** ppv)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ObtainFormats();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetStringsDelegate(IntPtr @this, byte* type, void** ppv);
        static int GetStrings(IntPtr @this, byte* type, void** ppv)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetStrings((type == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(type))));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetBytesDelegate(IntPtr @this, byte* type, void* utf8Text, int len);
        static int SetBytes(IntPtr @this, byte* type, void* utf8Text, int len)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetBytes((type == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(type))), utf8Text, len);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetBytesDelegate(IntPtr @this, byte* type, void** ppv);
        static int GetBytes(IntPtr @this, byte* type, void** ppv)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetBytes((type == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(type))));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ClearDelegate(IntPtr @this);
        static int Clear(IntPtr @this)
        {
            IAvnClipboard __target = null;
            try
            {
                {
                    __target = (IAvnClipboard)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Clear();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnClipboardVTable()
        {
            base.AddMethod((GetTextDelegate)GetText);
            base.AddMethod((SetTextDelegate)SetText);
            base.AddMethod((ObtainFormatsDelegate)ObtainFormats);
            base.AddMethod((GetStringsDelegate)GetStrings);
            base.AddMethod((SetBytesDelegate)SetBytes);
            base.AddMethod((GetBytesDelegate)GetBytes);
            base.AddMethod((ClearDelegate)Clear);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnClipboard), new __MicroComIAvnClipboardVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnCursorProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnCursor
    {
        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnCursor), new Guid("3f998545-f027-4d4d-bd2a-1a80926d984e"), (p, owns) => new __MicroComIAvnCursorProxy(p, owns));
        }

        public __MicroComIAvnCursorProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 0;
    }

    unsafe class __MicroComIAvnCursorVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        public __MicroComIAvnCursorVTable()
        {
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnCursor), new __MicroComIAvnCursorVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnCursorFactoryProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnCursorFactory
    {
        public IAvnCursor GetCursor(AvnStandardCursorType cursorType)
        {
            int __result;
            void* __marshal_retOut = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, cursorType, &__marshal_retOut, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("GetCursor failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnCursor>(__marshal_retOut, true);
        }

        public IAvnCursor CreateCustomCursor(void* bitmapData, System.IntPtr length, AvnPixelSize hotPixel)
        {
            int __result;
            void* __marshal_retOut = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, bitmapData, length, hotPixel, &__marshal_retOut, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateCustomCursor failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnCursor>(__marshal_retOut, true);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnCursorFactory), new Guid("51ecfb12-c427-4757-a2c9-1596bfce53ef"), (p, owns) => new __MicroComIAvnCursorFactoryProxy(p, owns));
        }

        public __MicroComIAvnCursorFactoryProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnCursorFactoryVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetCursorDelegate(IntPtr @this, AvnStandardCursorType cursorType, void** retOut);
        static int GetCursor(IntPtr @this, AvnStandardCursorType cursorType, void** retOut)
        {
            IAvnCursorFactory __target = null;
            try
            {
                {
                    __target = (IAvnCursorFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetCursor(cursorType);
                        *retOut = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateCustomCursorDelegate(IntPtr @this, void* bitmapData, System.IntPtr length, AvnPixelSize hotPixel, void** retOut);
        static int CreateCustomCursor(IntPtr @this, void* bitmapData, System.IntPtr length, AvnPixelSize hotPixel, void** retOut)
        {
            IAvnCursorFactory __target = null;
            try
            {
                {
                    __target = (IAvnCursorFactory)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateCustomCursor(bitmapData, length, hotPixel);
                        *retOut = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnCursorFactoryVTable()
        {
            base.AddMethod((GetCursorDelegate)GetCursor);
            base.AddMethod((CreateCustomCursorDelegate)CreateCustomCursor);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnCursorFactory), new __MicroComIAvnCursorFactoryVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnGlDisplayProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnGlDisplay
    {
        public IAvnGlContext CreateContext(IAvnGlContext share)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(share), &__marshal_ppv, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateContext failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlContext>(__marshal_ppv, true);
        }

        public void LegacyClearCurrentContext()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public IAvnGlContext WrapContext(IntPtr native)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, native, &__marshal_ppv, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("WrapContext failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlContext>(__marshal_ppv, true);
        }

        public IntPtr GetProcAddress(string proc)
        {
            IntPtr __result;
            var __bytemarshal_proc = new byte[System.Text.Encoding.UTF8.GetByteCount(proc) + 1];
            System.Text.Encoding.UTF8.GetBytes(proc, 0, proc.Length, __bytemarshal_proc, 0);
            fixed (byte* __fixedmarshal_proc = __bytemarshal_proc)
                __result = (IntPtr)LocalInterop.CalliStdCallIntPtr(PPV, __fixedmarshal_proc, (*PPV)[base.VTableSize + 3]);
            return __result;
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnGlDisplay), new Guid("60452465-8616-40af-bc00-042e69828ce7"), (p, owns) => new __MicroComIAvnGlDisplayProxy(p, owns));
        }

        public __MicroComIAvnGlDisplayProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 4;
    }

    unsafe class __MicroComIAvnGlDisplayVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateContextDelegate(IntPtr @this, void* share, void** ppv);
        static int CreateContext(IntPtr @this, void* share, void** ppv)
        {
            IAvnGlDisplay __target = null;
            try
            {
                {
                    __target = (IAvnGlDisplay)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateContext(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlContext>(share, false));
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void LegacyClearCurrentContextDelegate(IntPtr @this);
        static void LegacyClearCurrentContext(IntPtr @this)
        {
            IAvnGlDisplay __target = null;
            try
            {
                {
                    __target = (IAvnGlDisplay)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.LegacyClearCurrentContext();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int WrapContextDelegate(IntPtr @this, IntPtr native, void** ppv);
        static int WrapContext(IntPtr @this, IntPtr native, void** ppv)
        {
            IAvnGlDisplay __target = null;
            try
            {
                {
                    __target = (IAvnGlDisplay)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.WrapContext(native);
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate IntPtr GetProcAddressDelegate(IntPtr @this, byte* proc);
        static IntPtr GetProcAddress(IntPtr @this, byte* proc)
        {
            IAvnGlDisplay __target = null;
            try
            {
                {
                    __target = (IAvnGlDisplay)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.GetProcAddress((proc == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(proc))));
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        public __MicroComIAvnGlDisplayVTable()
        {
            base.AddMethod((CreateContextDelegate)CreateContext);
            base.AddMethod((LegacyClearCurrentContextDelegate)LegacyClearCurrentContext);
            base.AddMethod((WrapContextDelegate)WrapContext);
            base.AddMethod((GetProcAddressDelegate)GetProcAddress);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnGlDisplay), new __MicroComIAvnGlDisplayVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnGlContextProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnGlContext
    {
        public IUnknown MakeCurrent()
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ppv, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("MakeCurrent failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IUnknown>(__marshal_ppv, true);
        }

        public void LegacyMakeCurrent()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("LegacyMakeCurrent failed", __result);
        }

        public int SampleCount
        {
            get
            {
                int __result;
                __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 2]);
                return __result;
            }
        }

        public int StencilSize
        {
            get
            {
                int __result;
                __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 3]);
                return __result;
            }
        }

        public IntPtr NativeHandle
        {
            get
            {
                IntPtr __result;
                __result = (IntPtr)LocalInterop.CalliStdCallIntPtr(PPV, (*PPV)[base.VTableSize + 4]);
                return __result;
            }
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnGlContext), new Guid("78c5711e-2a98-40d2-bac4-0cc9a49dc4f3"), (p, owns) => new __MicroComIAvnGlContextProxy(p, owns));
        }

        public __MicroComIAvnGlContextProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 5;
    }

    unsafe class __MicroComIAvnGlContextVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int MakeCurrentDelegate(IntPtr @this, void** ppv);
        static int MakeCurrent(IntPtr @this, void** ppv)
        {
            IAvnGlContext __target = null;
            try
            {
                {
                    __target = (IAvnGlContext)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.MakeCurrent();
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int LegacyMakeCurrentDelegate(IntPtr @this);
        static int LegacyMakeCurrent(IntPtr @this)
        {
            IAvnGlContext __target = null;
            try
            {
                {
                    __target = (IAvnGlContext)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.LegacyMakeCurrent();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetSampleCountDelegate(IntPtr @this);
        static int GetSampleCount(IntPtr @this)
        {
            IAvnGlContext __target = null;
            try
            {
                {
                    __target = (IAvnGlContext)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.SampleCount;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetStencilSizeDelegate(IntPtr @this);
        static int GetStencilSize(IntPtr @this)
        {
            IAvnGlContext __target = null;
            try
            {
                {
                    __target = (IAvnGlContext)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.StencilSize;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate IntPtr GetNativeHandleDelegate(IntPtr @this);
        static IntPtr GetNativeHandle(IntPtr @this)
        {
            IAvnGlContext __target = null;
            try
            {
                {
                    __target = (IAvnGlContext)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.NativeHandle;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        public __MicroComIAvnGlContextVTable()
        {
            base.AddMethod((MakeCurrentDelegate)MakeCurrent);
            base.AddMethod((LegacyMakeCurrentDelegate)LegacyMakeCurrent);
            base.AddMethod((GetSampleCountDelegate)GetSampleCount);
            base.AddMethod((GetStencilSizeDelegate)GetStencilSize);
            base.AddMethod((GetNativeHandleDelegate)GetNativeHandle);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnGlContext), new __MicroComIAvnGlContextVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnGlSurfaceRenderTargetProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnGlSurfaceRenderTarget
    {
        public IAvnGlSurfaceRenderingSession BeginDrawing()
        {
            int __result;
            void* __marshal_ret = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, &__marshal_ret, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("BeginDrawing failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnGlSurfaceRenderingSession>(__marshal_ret, true);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnGlSurfaceRenderTarget), new Guid("931062d2-5bc8-4062-8588-83dd8deb99c2"), (p, owns) => new __MicroComIAvnGlSurfaceRenderTargetProxy(p, owns));
        }

        public __MicroComIAvnGlSurfaceRenderTargetProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnGlSurfaceRenderTargetVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int BeginDrawingDelegate(IntPtr @this, void** ret);
        static int BeginDrawing(IntPtr @this, void** ret)
        {
            IAvnGlSurfaceRenderTarget __target = null;
            try
            {
                {
                    __target = (IAvnGlSurfaceRenderTarget)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.BeginDrawing();
                        *ret = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnGlSurfaceRenderTargetVTable()
        {
            base.AddMethod((BeginDrawingDelegate)BeginDrawing);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnGlSurfaceRenderTarget), new __MicroComIAvnGlSurfaceRenderTargetVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnGlSurfaceRenderingSessionProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnGlSurfaceRenderingSession
    {
        public AvnPixelSize PixelSize
        {
            get
            {
                int __result;
                AvnPixelSize ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 0]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetPixelSize failed", __result);
                return ret;
            }
        }

        public double Scaling
        {
            get
            {
                int __result;
                double ret = default;
                __result = (int)LocalInterop.CalliStdCallint(PPV, &ret, (*PPV)[base.VTableSize + 1]);
                if (__result != 0)
                    throw new System.Runtime.InteropServices.COMException("GetScaling failed", __result);
                return ret;
            }
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnGlSurfaceRenderingSession), new Guid("e625b406-f04c-484e-946a-4abd2c6015ad"), (p, owns) => new __MicroComIAvnGlSurfaceRenderingSessionProxy(p, owns));
        }

        public __MicroComIAvnGlSurfaceRenderingSessionProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnGlSurfaceRenderingSessionVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetPixelSizeDelegate(IntPtr @this, AvnPixelSize* ret);
        static int GetPixelSize(IntPtr @this, AvnPixelSize* ret)
        {
            IAvnGlSurfaceRenderingSession __target = null;
            try
            {
                {
                    __target = (IAvnGlSurfaceRenderingSession)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.PixelSize;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetScalingDelegate(IntPtr @this, double* ret);
        static int GetScaling(IntPtr @this, double* ret)
        {
            IAvnGlSurfaceRenderingSession __target = null;
            try
            {
                {
                    __target = (IAvnGlSurfaceRenderingSession)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Scaling;
                        *ret = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnGlSurfaceRenderingSessionVTable()
        {
            base.AddMethod((GetPixelSizeDelegate)GetPixelSize);
            base.AddMethod((GetScalingDelegate)GetScaling);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnGlSurfaceRenderingSession), new __MicroComIAvnGlSurfaceRenderingSessionVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnTrayIconProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnTrayIcon
    {
        public void SetIcon(void* data, System.IntPtr length)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, data, length, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetIcon failed", __result);
        }

        public void SetMenu(IAvnMenu menu)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(menu), (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetMenu failed", __result);
        }

        public void SetIsVisible(int isVisible)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, isVisible, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetIsVisible failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnTrayIcon), new Guid("60992d19-38f0-4141-a0a9-76ac303801f3"), (p, owns) => new __MicroComIAvnTrayIconProxy(p, owns));
        }

        public __MicroComIAvnTrayIconProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnTrayIconVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetIconDelegate(IntPtr @this, void* data, System.IntPtr length);
        static int SetIcon(IntPtr @this, void* data, System.IntPtr length)
        {
            IAvnTrayIcon __target = null;
            try
            {
                {
                    __target = (IAvnTrayIcon)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetIcon(data, length);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetMenuDelegate(IntPtr @this, void* menu);
        static int SetMenu(IntPtr @this, void* menu)
        {
            IAvnTrayIcon __target = null;
            try
            {
                {
                    __target = (IAvnTrayIcon)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(menu, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetIsVisibleDelegate(IntPtr @this, int isVisible);
        static int SetIsVisible(IntPtr @this, int isVisible)
        {
            IAvnTrayIcon __target = null;
            try
            {
                {
                    __target = (IAvnTrayIcon)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetIsVisible(isVisible);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnTrayIconVTable()
        {
            base.AddMethod((SetIconDelegate)SetIcon);
            base.AddMethod((SetMenuDelegate)SetMenu);
            base.AddMethod((SetIsVisibleDelegate)SetIsVisible);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnTrayIcon), new __MicroComIAvnTrayIconVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnMenuProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnMenu
    {
        public void InsertItem(int index, IAvnMenuItem item)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, index, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(item), (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("InsertItem failed", __result);
        }

        public void RemoveItem(IAvnMenuItem item)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(item), (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("RemoveItem failed", __result);
        }

        public void SetTitle(string utf8String)
        {
            int __result;
            var __bytemarshal_utf8String = new byte[System.Text.Encoding.UTF8.GetByteCount(utf8String) + 1];
            System.Text.Encoding.UTF8.GetBytes(utf8String, 0, utf8String.Length, __bytemarshal_utf8String, 0);
            fixed (byte* __fixedmarshal_utf8String = __bytemarshal_utf8String)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_utf8String, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTitle failed", __result);
        }

        public void Clear()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Clear failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnMenu), new Guid("a7724dc1-cf6b-4fa8-9d23-228bf2593edc"), (p, owns) => new __MicroComIAvnMenuProxy(p, owns));
        }

        public __MicroComIAvnMenuProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 4;
    }

    unsafe class __MicroComIAvnMenuVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int InsertItemDelegate(IntPtr @this, int index, void* item);
        static int InsertItem(IntPtr @this, int index, void* item)
        {
            IAvnMenu __target = null;
            try
            {
                {
                    __target = (IAvnMenu)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.InsertItem(index, Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenuItem>(item, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int RemoveItemDelegate(IntPtr @this, void* item);
        static int RemoveItem(IntPtr @this, void* item)
        {
            IAvnMenu __target = null;
            try
            {
                {
                    __target = (IAvnMenu)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RemoveItem(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenuItem>(item, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTitleDelegate(IntPtr @this, byte* utf8String);
        static int SetTitle(IntPtr @this, byte* utf8String)
        {
            IAvnMenu __target = null;
            try
            {
                {
                    __target = (IAvnMenu)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTitle((utf8String == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(utf8String))));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ClearDelegate(IntPtr @this);
        static int Clear(IntPtr @this)
        {
            IAvnMenu __target = null;
            try
            {
                {
                    __target = (IAvnMenu)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Clear();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnMenuVTable()
        {
            base.AddMethod((InsertItemDelegate)InsertItem);
            base.AddMethod((RemoveItemDelegate)RemoveItem);
            base.AddMethod((SetTitleDelegate)SetTitle);
            base.AddMethod((ClearDelegate)Clear);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnMenu), new __MicroComIAvnMenuVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPredicateCallbackProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnPredicateCallback
    {
        public int Evaluate()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 0]);
            return __result;
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPredicateCallback), new Guid("59e0586d-bd1c-4b85-9882-80d448b0fed9"), (p, owns) => new __MicroComIAvnPredicateCallbackProxy(p, owns));
        }

        public __MicroComIAvnPredicateCallbackProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnPredicateCallbackVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int EvaluateDelegate(IntPtr @this);
        static int Evaluate(IntPtr @this)
        {
            IAvnPredicateCallback __target = null;
            try
            {
                {
                    __target = (IAvnPredicateCallback)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Evaluate();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        public __MicroComIAvnPredicateCallbackVTable()
        {
            base.AddMethod((EvaluateDelegate)Evaluate);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPredicateCallback), new __MicroComIAvnPredicateCallbackVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnMenuItemProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnMenuItem
    {
        public void SetSubMenu(IAvnMenu menu)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(menu), (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetSubMenu failed", __result);
        }

        public void SetTitle(string utf8String)
        {
            int __result;
            var __bytemarshal_utf8String = new byte[System.Text.Encoding.UTF8.GetByteCount(utf8String) + 1];
            System.Text.Encoding.UTF8.GetBytes(utf8String, 0, utf8String.Length, __bytemarshal_utf8String, 0);
            fixed (byte* __fixedmarshal_utf8String = __bytemarshal_utf8String)
                __result = (int)LocalInterop.CalliStdCallint(PPV, __fixedmarshal_utf8String, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetTitle failed", __result);
        }

        public void SetGesture(AvnKey key, AvnInputModifiers modifiers)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, key, modifiers, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetGesture failed", __result);
        }

        public void SetAction(IAvnPredicateCallback predicate, IAvnActionCallback callback)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(predicate), Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(callback), (*PPV)[base.VTableSize + 3]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetAction failed", __result);
        }

        public void SetIsChecked(int isChecked)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, isChecked, (*PPV)[base.VTableSize + 4]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetIsChecked failed", __result);
        }

        public void SetToggleType(AvnMenuItemToggleType toggleType)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, toggleType, (*PPV)[base.VTableSize + 5]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetToggleType failed", __result);
        }

        public void SetIcon(void* data, System.IntPtr length)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, data, length, (*PPV)[base.VTableSize + 6]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("SetIcon failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnMenuItem), new Guid("f890219a-1720-4cd5-9a26-cd95fccbf53c"), (p, owns) => new __MicroComIAvnMenuItemProxy(p, owns));
        }

        public __MicroComIAvnMenuItemProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 7;
    }

    unsafe class __MicroComIAvnMenuItemVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetSubMenuDelegate(IntPtr @this, void* menu);
        static int SetSubMenu(IntPtr @this, void* menu)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetSubMenu(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnMenu>(menu, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetTitleDelegate(IntPtr @this, byte* utf8String);
        static int SetTitle(IntPtr @this, byte* utf8String)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetTitle((utf8String == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(utf8String))));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetGestureDelegate(IntPtr @this, AvnKey key, AvnInputModifiers modifiers);
        static int SetGesture(IntPtr @this, AvnKey key, AvnInputModifiers modifiers)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetGesture(key, modifiers);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetActionDelegate(IntPtr @this, void* predicate, void* callback);
        static int SetAction(IntPtr @this, void* predicate, void* callback)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetAction(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnPredicateCallback>(predicate, false), Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnActionCallback>(callback, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetIsCheckedDelegate(IntPtr @this, int isChecked);
        static int SetIsChecked(IntPtr @this, int isChecked)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetIsChecked(isChecked);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetToggleTypeDelegate(IntPtr @this, AvnMenuItemToggleType toggleType);
        static int SetToggleType(IntPtr @this, AvnMenuItemToggleType toggleType)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetToggleType(toggleType);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SetIconDelegate(IntPtr @this, void* data, System.IntPtr length);
        static int SetIcon(IntPtr @this, void* data, System.IntPtr length)
        {
            IAvnMenuItem __target = null;
            try
            {
                {
                    __target = (IAvnMenuItem)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetIcon(data, length);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnMenuItemVTable()
        {
            base.AddMethod((SetSubMenuDelegate)SetSubMenu);
            base.AddMethod((SetTitleDelegate)SetTitle);
            base.AddMethod((SetGestureDelegate)SetGesture);
            base.AddMethod((SetActionDelegate)SetAction);
            base.AddMethod((SetIsCheckedDelegate)SetIsChecked);
            base.AddMethod((SetToggleTypeDelegate)SetToggleType);
            base.AddMethod((SetIconDelegate)SetIcon);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnMenuItem), new __MicroComIAvnMenuItemVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnMenuEventsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnMenuEvents
    {
        public void NeedsUpdate()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 0]);
        }

        public void Opening()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public void Closed()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnMenuEvents), new Guid("0af7df53-7632-42f4-a650-0992c361b477"), (p, owns) => new __MicroComIAvnMenuEventsProxy(p, owns));
        }

        public __MicroComIAvnMenuEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnMenuEventsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void NeedsUpdateDelegate(IntPtr @this);
        static void NeedsUpdate(IntPtr @this)
        {
            IAvnMenuEvents __target = null;
            try
            {
                {
                    __target = (IAvnMenuEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.NeedsUpdate();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void OpeningDelegate(IntPtr @this);
        static void Opening(IntPtr @this)
        {
            IAvnMenuEvents __target = null;
            try
            {
                {
                    __target = (IAvnMenuEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Opening();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ClosedDelegate(IntPtr @this);
        static void Closed(IntPtr @this)
        {
            IAvnMenuEvents __target = null;
            try
            {
                {
                    __target = (IAvnMenuEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Closed();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnMenuEventsVTable()
        {
            base.AddMethod((NeedsUpdateDelegate)NeedsUpdate);
            base.AddMethod((OpeningDelegate)Opening);
            base.AddMethod((ClosedDelegate)Closed);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnMenuEvents), new __MicroComIAvnMenuEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnStringArrayProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnStringArray
    {
        public uint Count
        {
            get
            {
                uint __result;
                __result = (uint)LocalInterop.CalliStdCalluint(PPV, (*PPV)[base.VTableSize + 0]);
                return __result;
            }
        }

        public IAvnString Get(uint index)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, index, &__marshal_ppv, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Get failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__marshal_ppv, true);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnStringArray), new Guid("5142bb41-66ab-49e7-bb37-cd079c000f27"), (p, owns) => new __MicroComIAvnStringArrayProxy(p, owns));
        }

        public __MicroComIAvnStringArrayProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnStringArrayVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate uint GetCountDelegate(IntPtr @this);
        static uint GetCount(IntPtr @this)
        {
            IAvnStringArray __target = null;
            try
            {
                {
                    __target = (IAvnStringArray)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Count;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetDelegate(IntPtr @this, uint index, void** ppv);
        static int Get(IntPtr @this, uint index, void** ppv)
        {
            IAvnStringArray __target = null;
            try
            {
                {
                    __target = (IAvnStringArray)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Get(index);
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnStringArrayVTable()
        {
            base.AddMethod((GetCountDelegate)GetCount);
            base.AddMethod((GetDelegate)Get);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnStringArray), new __MicroComIAvnStringArrayVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnDndResultCallbackProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnDndResultCallback
    {
        public void OnDragAndDropComplete(AvnDragDropEffects effecct)
        {
            LocalInterop.CalliStdCallvoid(PPV, effecct, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnDndResultCallback), new Guid("a13d2382-3b3a-4d1c-9b27-8f34653d3f01"), (p, owns) => new __MicroComIAvnDndResultCallbackProxy(p, owns));
        }

        public __MicroComIAvnDndResultCallbackProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnDndResultCallbackVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void OnDragAndDropCompleteDelegate(IntPtr @this, AvnDragDropEffects effecct);
        static void OnDragAndDropComplete(IntPtr @this, AvnDragDropEffects effecct)
        {
            IAvnDndResultCallback __target = null;
            try
            {
                {
                    __target = (IAvnDndResultCallback)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.OnDragAndDropComplete(effecct);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnDndResultCallbackVTable()
        {
            base.AddMethod((OnDragAndDropCompleteDelegate)OnDragAndDropComplete);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnDndResultCallback), new __MicroComIAvnDndResultCallbackVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnGCHandleDeallocatorCallbackProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnGCHandleDeallocatorCallback
    {
        public void FreeGCHandle(IntPtr handle)
        {
            LocalInterop.CalliStdCallvoid(PPV, handle, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnGCHandleDeallocatorCallback), new Guid("f07c608e-52e9-422d-836e-c70f6e9b80f5"), (p, owns) => new __MicroComIAvnGCHandleDeallocatorCallbackProxy(p, owns));
        }

        public __MicroComIAvnGCHandleDeallocatorCallbackProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnGCHandleDeallocatorCallbackVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void FreeGCHandleDelegate(IntPtr @this, IntPtr handle);
        static void FreeGCHandle(IntPtr @this, IntPtr handle)
        {
            IAvnGCHandleDeallocatorCallback __target = null;
            try
            {
                {
                    __target = (IAvnGCHandleDeallocatorCallback)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.FreeGCHandle(handle);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnGCHandleDeallocatorCallbackVTable()
        {
            base.AddMethod((FreeGCHandleDelegate)FreeGCHandle);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnGCHandleDeallocatorCallback), new __MicroComIAvnGCHandleDeallocatorCallbackVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnNativeControlHostProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnNativeControlHost
    {
        public IntPtr CreateDefaultChild(IntPtr parent)
        {
            int __result;
            IntPtr retOut = default;
            __result = (int)LocalInterop.CalliStdCallint(PPV, parent, &retOut, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("CreateDefaultChild failed", __result);
            return retOut;
        }

        public IAvnNativeControlHostTopLevelAttachment CreateAttachment()
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 1]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnNativeControlHostTopLevelAttachment>(__result, true);
        }

        public void DestroyDefaultChild(IntPtr child)
        {
            LocalInterop.CalliStdCallvoid(PPV, child, (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnNativeControlHost), new Guid("91c7f677-f26b-4ff3-93cc-cf15aa966ffa"), (p, owns) => new __MicroComIAvnNativeControlHostProxy(p, owns));
        }

        public __MicroComIAvnNativeControlHostProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnNativeControlHostVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int CreateDefaultChildDelegate(IntPtr @this, IntPtr parent, IntPtr* retOut);
        static int CreateDefaultChild(IntPtr @this, IntPtr parent, IntPtr* retOut)
        {
            IAvnNativeControlHost __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHost)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateDefaultChild(parent);
                        *retOut = __result;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* CreateAttachmentDelegate(IntPtr @this);
        static void* CreateAttachment(IntPtr @this)
        {
            IAvnNativeControlHost __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHost)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.CreateAttachment();
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void DestroyDefaultChildDelegate(IntPtr @this, IntPtr child);
        static void DestroyDefaultChild(IntPtr @this, IntPtr child)
        {
            IAvnNativeControlHost __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHost)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.DestroyDefaultChild(child);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnNativeControlHostVTable()
        {
            base.AddMethod((CreateDefaultChildDelegate)CreateDefaultChild);
            base.AddMethod((CreateAttachmentDelegate)CreateAttachment);
            base.AddMethod((DestroyDefaultChildDelegate)DestroyDefaultChild);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnNativeControlHost), new __MicroComIAvnNativeControlHostVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnNativeControlHostTopLevelAttachmentProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnNativeControlHostTopLevelAttachment
    {
        public IntPtr ParentHandle
        {
            get
            {
                IntPtr __result;
                __result = (IntPtr)LocalInterop.CalliStdCallIntPtr(PPV, (*PPV)[base.VTableSize + 0]);
                return __result;
            }
        }

        public void InitializeWithChildHandle(IntPtr child)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, child, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("InitializeWithChildHandle failed", __result);
        }

        public void AttachTo(IAvnNativeControlHost host)
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(host), (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("AttachTo failed", __result);
        }

        public void ShowInBounds(float x, float y, float width, float height)
        {
            LocalInterop.CalliStdCallvoid(PPV, x, y, width, height, (*PPV)[base.VTableSize + 3]);
        }

        public void HideWithSize(float width, float height)
        {
            LocalInterop.CalliStdCallvoid(PPV, width, height, (*PPV)[base.VTableSize + 4]);
        }

        public void ReleaseChild()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 5]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnNativeControlHostTopLevelAttachment), new Guid("14a9e164-1aae-4271-bb78-7b5230999b52"), (p, owns) => new __MicroComIAvnNativeControlHostTopLevelAttachmentProxy(p, owns));
        }

        public __MicroComIAvnNativeControlHostTopLevelAttachmentProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 6;
    }

    unsafe class __MicroComIAvnNativeControlHostTopLevelAttachmentVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate IntPtr GetParentHandleDelegate(IntPtr @this);
        static IntPtr GetParentHandle(IntPtr @this)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ParentHandle;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int InitializeWithChildHandleDelegate(IntPtr @this, IntPtr child);
        static int InitializeWithChildHandle(IntPtr @this, IntPtr child)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.InitializeWithChildHandle(child);
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int AttachToDelegate(IntPtr @this, void* host);
        static int AttachTo(IntPtr @this, void* host)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.AttachTo(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnNativeControlHost>(host, false));
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ShowInBoundsDelegate(IntPtr @this, float x, float y, float width, float height);
        static void ShowInBounds(IntPtr @this, float x, float y, float width, float height)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ShowInBounds(x, y, width, height);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void HideWithSizeDelegate(IntPtr @this, float width, float height);
        static void HideWithSize(IntPtr @this, float width, float height)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.HideWithSize(width, height);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ReleaseChildDelegate(IntPtr @this);
        static void ReleaseChild(IntPtr @this)
        {
            IAvnNativeControlHostTopLevelAttachment __target = null;
            try
            {
                {
                    __target = (IAvnNativeControlHostTopLevelAttachment)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ReleaseChild();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnNativeControlHostTopLevelAttachmentVTable()
        {
            base.AddMethod((GetParentHandleDelegate)GetParentHandle);
            base.AddMethod((InitializeWithChildHandleDelegate)InitializeWithChildHandle);
            base.AddMethod((AttachToDelegate)AttachTo);
            base.AddMethod((ShowInBoundsDelegate)ShowInBounds);
            base.AddMethod((HideWithSizeDelegate)HideWithSize);
            base.AddMethod((ReleaseChildDelegate)ReleaseChild);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnNativeControlHostTopLevelAttachment), new __MicroComIAvnNativeControlHostTopLevelAttachmentVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnApplicationEventsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnApplicationEvents
    {
        public void FilesOpened(IAvnStringArray urls)
        {
            LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(urls), (*PPV)[base.VTableSize + 0]);
        }

        public int TryShutdown()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 1]);
            return __result;
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnApplicationEvents), new Guid("6575b5af-f27a-4609-866c-f1f014c20f79"), (p, owns) => new __MicroComIAvnApplicationEventsProxy(p, owns));
        }

        public __MicroComIAvnApplicationEventsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnApplicationEventsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void FilesOpenedDelegate(IntPtr @this, void* urls);
        static void FilesOpened(IntPtr @this, void* urls)
        {
            IAvnApplicationEvents __target = null;
            try
            {
                {
                    __target = (IAvnApplicationEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.FilesOpened(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnStringArray>(urls, false));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int TryShutdownDelegate(IntPtr @this);
        static int TryShutdown(IntPtr @this)
        {
            IAvnApplicationEvents __target = null;
            try
            {
                {
                    __target = (IAvnApplicationEvents)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.TryShutdown();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        public __MicroComIAvnApplicationEventsVTable()
        {
            base.AddMethod((FilesOpenedDelegate)FilesOpened);
            base.AddMethod((TryShutdownDelegate)TryShutdown);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnApplicationEvents), new __MicroComIAvnApplicationEventsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnApplicationCommandsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnApplicationCommands
    {
        public void HideApp()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 0]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("HideApp failed", __result);
        }

        public void ShowAll()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("ShowAll failed", __result);
        }

        public void HideOthers()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 2]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("HideOthers failed", __result);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnApplicationCommands), new Guid("b4284791-055b-4313-8c2e-50f0a8c72ce9"), (p, owns) => new __MicroComIAvnApplicationCommandsProxy(p, owns));
        }

        public __MicroComIAvnApplicationCommandsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnApplicationCommandsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int HideAppDelegate(IntPtr @this);
        static int HideApp(IntPtr @this)
        {
            IAvnApplicationCommands __target = null;
            try
            {
                {
                    __target = (IAvnApplicationCommands)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.HideApp();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ShowAllDelegate(IntPtr @this);
        static int ShowAll(IntPtr @this)
        {
            IAvnApplicationCommands __target = null;
            try
            {
                {
                    __target = (IAvnApplicationCommands)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ShowAll();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int HideOthersDelegate(IntPtr @this);
        static int HideOthers(IntPtr @this)
        {
            IAvnApplicationCommands __target = null;
            try
            {
                {
                    __target = (IAvnApplicationCommands)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.HideOthers();
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnApplicationCommandsVTable()
        {
            base.AddMethod((HideAppDelegate)HideApp);
            base.AddMethod((ShowAllDelegate)ShowAll);
            base.AddMethod((HideOthersDelegate)HideOthers);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnApplicationCommands), new __MicroComIAvnApplicationCommandsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnAutomationPeerProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnAutomationPeer
    {
        public IAvnAutomationNode Node
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 0]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationNode>(__result, true);
            }
        }

        public void SetNode(IAvnAutomationNode node)
        {
            LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(node), (*PPV)[base.VTableSize + 1]);
        }

        public IAvnString AcceleratorKey
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 2]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
            }
        }

        public IAvnString AccessKey
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 3]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
            }
        }

        public AvnAutomationControlType AutomationControlType
        {
            get
            {
                AvnAutomationControlType __result;
                __result = (AvnAutomationControlType)LocalInterop.CalliStdCallAvnAutomationControlType(PPV, (*PPV)[base.VTableSize + 4]);
                return __result;
            }
        }

        public IAvnString AutomationId
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 5]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
            }
        }

        public AvnRect BoundingRectangle
        {
            get
            {
                AvnRect __result;
                __result = (AvnRect)LocalInterop.CalliStdCallAvnRect(PPV, (*PPV)[base.VTableSize + 6]);
                return __result;
            }
        }

        public IAvnAutomationPeerArray Children
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 7]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeerArray>(__result, true);
            }
        }

        public IAvnString ClassName
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 8]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
            }
        }

        public IAvnAutomationPeer LabeledBy
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 9]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
            }
        }

        public IAvnString Name
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 10]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
            }
        }

        public IAvnAutomationPeer Parent
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 11]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
            }
        }

        public int HasKeyboardFocus()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 12]);
            return __result;
        }

        public int IsContentElement()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 13]);
            return __result;
        }

        public int IsControlElement()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 14]);
            return __result;
        }

        public int IsEnabled()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 15]);
            return __result;
        }

        public int IsKeyboardFocusable()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 16]);
            return __result;
        }

        public void SetFocus()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 17]);
        }

        public int ShowContextMenu()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 18]);
            return __result;
        }

        public IAvnAutomationPeer RootPeer
        {
            get
            {
                void* __result;
                __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 19]);
                return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
            }
        }

        public int IsRootProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 20]);
            return __result;
        }

        public IAvnWindowBase RootProvider_GetWindow()
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 21]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnWindowBase>(__result, true);
        }

        public IAvnAutomationPeer RootProvider_GetFocus()
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 22]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
        }

        public IAvnAutomationPeer RootProvider_GetPeerFromPoint(AvnPoint point)
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, point, (*PPV)[base.VTableSize + 23]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__result, true);
        }

        public int IsExpandCollapseProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 24]);
            return __result;
        }

        public int ExpandCollapseProvider_GetIsExpanded()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 25]);
            return __result;
        }

        public int ExpandCollapseProvider_GetShowsMenu()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 26]);
            return __result;
        }

        public void ExpandCollapseProvider_Expand()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 27]);
        }

        public void ExpandCollapseProvider_Collapse()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 28]);
        }

        public int IsInvokeProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 29]);
            return __result;
        }

        public void InvokeProvider_Invoke()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 30]);
        }

        public int IsRangeValueProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 31]);
            return __result;
        }

        public double RangeValueProvider_GetValue()
        {
            double __result;
            __result = (double)LocalInterop.CalliStdCalldouble(PPV, (*PPV)[base.VTableSize + 32]);
            return __result;
        }

        public double RangeValueProvider_GetMinimum()
        {
            double __result;
            __result = (double)LocalInterop.CalliStdCalldouble(PPV, (*PPV)[base.VTableSize + 33]);
            return __result;
        }

        public double RangeValueProvider_GetMaximum()
        {
            double __result;
            __result = (double)LocalInterop.CalliStdCalldouble(PPV, (*PPV)[base.VTableSize + 34]);
            return __result;
        }

        public double RangeValueProvider_GetSmallChange()
        {
            double __result;
            __result = (double)LocalInterop.CalliStdCalldouble(PPV, (*PPV)[base.VTableSize + 35]);
            return __result;
        }

        public double RangeValueProvider_GetLargeChange()
        {
            double __result;
            __result = (double)LocalInterop.CalliStdCalldouble(PPV, (*PPV)[base.VTableSize + 36]);
            return __result;
        }

        public void RangeValueProvider_SetValue(double value)
        {
            LocalInterop.CalliStdCallvoid(PPV, value, (*PPV)[base.VTableSize + 37]);
        }

        public int IsSelectionItemProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 38]);
            return __result;
        }

        public int SelectionItemProvider_IsSelected()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 39]);
            return __result;
        }

        public int IsToggleProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 40]);
            return __result;
        }

        public int ToggleProvider_GetToggleState()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 41]);
            return __result;
        }

        public void ToggleProvider_Toggle()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 42]);
        }

        public int IsValueProvider()
        {
            int __result;
            __result = (int)LocalInterop.CalliStdCallint(PPV, (*PPV)[base.VTableSize + 43]);
            return __result;
        }

        public IAvnString ValueProvider_GetValue()
        {
            void* __result;
            __result = (void*)LocalInterop.CalliStdCallvoid_ptr(PPV, (*PPV)[base.VTableSize + 44]);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnString>(__result, true);
        }

        public void ValueProvider_SetValue(string value)
        {
            var __bytemarshal_value = new byte[System.Text.Encoding.UTF8.GetByteCount(value) + 1];
            System.Text.Encoding.UTF8.GetBytes(value, 0, value.Length, __bytemarshal_value, 0);
            fixed (byte* __fixedmarshal_value = __bytemarshal_value)
                LocalInterop.CalliStdCallvoid(PPV, __fixedmarshal_value, (*PPV)[base.VTableSize + 45]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnAutomationPeer), new Guid("b87016f3-7eec-41de-b385-07844c268dc4"), (p, owns) => new __MicroComIAvnAutomationPeerProxy(p, owns));
        }

        public __MicroComIAvnAutomationPeerProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 46;
    }

    unsafe class __MicroComIAvnAutomationPeerVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetNodeDelegate(IntPtr @this);
        static void* GetNode(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Node;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetNodeDelegate(IntPtr @this, void* node);
        static void SetNode(IntPtr @this, void* node)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetNode(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationNode>(node, false));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetAcceleratorKeyDelegate(IntPtr @this);
        static void* GetAcceleratorKey(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AcceleratorKey;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetAccessKeyDelegate(IntPtr @this);
        static void* GetAccessKey(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AccessKey;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate AvnAutomationControlType GetAutomationControlTypeDelegate(IntPtr @this);
        static AvnAutomationControlType GetAutomationControlType(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AutomationControlType;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetAutomationIdDelegate(IntPtr @this);
        static void* GetAutomationId(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AutomationId;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate AvnRect GetBoundingRectangleDelegate(IntPtr @this);
        static AvnRect GetBoundingRectangle(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.BoundingRectangle;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetChildrenDelegate(IntPtr @this);
        static void* GetChildren(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Children;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetClassNameDelegate(IntPtr @this);
        static void* GetClassName(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ClassName;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetLabeledByDelegate(IntPtr @this);
        static void* GetLabeledBy(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.LabeledBy;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetNameDelegate(IntPtr @this);
        static void* GetName(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Name;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetParentDelegate(IntPtr @this);
        static void* GetParent(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Parent;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int HasKeyboardFocusDelegate(IntPtr @this);
        static int HasKeyboardFocus(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.HasKeyboardFocus();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsContentElementDelegate(IntPtr @this);
        static int IsContentElement(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsContentElement();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsControlElementDelegate(IntPtr @this);
        static int IsControlElement(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsControlElement();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsEnabledDelegate(IntPtr @this);
        static int IsEnabled(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsEnabled();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsKeyboardFocusableDelegate(IntPtr @this);
        static int IsKeyboardFocusable(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsKeyboardFocusable();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetFocusDelegate(IntPtr @this);
        static void SetFocus(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetFocus();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ShowContextMenuDelegate(IntPtr @this);
        static int ShowContextMenu(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ShowContextMenu();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* GetRootPeerDelegate(IntPtr @this);
        static void* GetRootPeer(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RootPeer;
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsRootProviderDelegate(IntPtr @this);
        static int IsRootProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsRootProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* RootProvider_GetWindowDelegate(IntPtr @this);
        static void* RootProvider_GetWindow(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RootProvider_GetWindow();
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* RootProvider_GetFocusDelegate(IntPtr @this);
        static void* RootProvider_GetFocus(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RootProvider_GetFocus();
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* RootProvider_GetPeerFromPointDelegate(IntPtr @this, AvnPoint point);
        static void* RootProvider_GetPeerFromPoint(IntPtr @this, AvnPoint point)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RootProvider_GetPeerFromPoint(point);
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsExpandCollapseProviderDelegate(IntPtr @this);
        static int IsExpandCollapseProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsExpandCollapseProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ExpandCollapseProvider_GetIsExpandedDelegate(IntPtr @this);
        static int ExpandCollapseProvider_GetIsExpanded(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ExpandCollapseProvider_GetIsExpanded();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ExpandCollapseProvider_GetShowsMenuDelegate(IntPtr @this);
        static int ExpandCollapseProvider_GetShowsMenu(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ExpandCollapseProvider_GetShowsMenu();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ExpandCollapseProvider_ExpandDelegate(IntPtr @this);
        static void ExpandCollapseProvider_Expand(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ExpandCollapseProvider_Expand();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ExpandCollapseProvider_CollapseDelegate(IntPtr @this);
        static void ExpandCollapseProvider_Collapse(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ExpandCollapseProvider_Collapse();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsInvokeProviderDelegate(IntPtr @this);
        static int IsInvokeProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsInvokeProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void InvokeProvider_InvokeDelegate(IntPtr @this);
        static void InvokeProvider_Invoke(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.InvokeProvider_Invoke();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsRangeValueProviderDelegate(IntPtr @this);
        static int IsRangeValueProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsRangeValueProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate double RangeValueProvider_GetValueDelegate(IntPtr @this);
        static double RangeValueProvider_GetValue(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RangeValueProvider_GetValue();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate double RangeValueProvider_GetMinimumDelegate(IntPtr @this);
        static double RangeValueProvider_GetMinimum(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RangeValueProvider_GetMinimum();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate double RangeValueProvider_GetMaximumDelegate(IntPtr @this);
        static double RangeValueProvider_GetMaximum(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RangeValueProvider_GetMaximum();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate double RangeValueProvider_GetSmallChangeDelegate(IntPtr @this);
        static double RangeValueProvider_GetSmallChange(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RangeValueProvider_GetSmallChange();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate double RangeValueProvider_GetLargeChangeDelegate(IntPtr @this);
        static double RangeValueProvider_GetLargeChange(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.RangeValueProvider_GetLargeChange();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RangeValueProvider_SetValueDelegate(IntPtr @this, double value);
        static void RangeValueProvider_SetValue(IntPtr @this, double value)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RangeValueProvider_SetValue(value);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsSelectionItemProviderDelegate(IntPtr @this);
        static int IsSelectionItemProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsSelectionItemProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int SelectionItemProvider_IsSelectedDelegate(IntPtr @this);
        static int SelectionItemProvider_IsSelected(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.SelectionItemProvider_IsSelected();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsToggleProviderDelegate(IntPtr @this);
        static int IsToggleProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsToggleProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int ToggleProvider_GetToggleStateDelegate(IntPtr @this);
        static int ToggleProvider_GetToggleState(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ToggleProvider_GetToggleState();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ToggleProvider_ToggleDelegate(IntPtr @this);
        static void ToggleProvider_Toggle(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ToggleProvider_Toggle();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int IsValueProviderDelegate(IntPtr @this);
        static int IsValueProvider(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.IsValueProvider();
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void* ValueProvider_GetValueDelegate(IntPtr @this);
        static void* ValueProvider_GetValue(IntPtr @this)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.ValueProvider_GetValue();
                        return Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ValueProvider_SetValueDelegate(IntPtr @this, byte* value);
        static void ValueProvider_SetValue(IntPtr @this, byte* value)
        {
            IAvnAutomationPeer __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeer)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ValueProvider_SetValue((value == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(value))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnAutomationPeerVTable()
        {
            base.AddMethod((GetNodeDelegate)GetNode);
            base.AddMethod((SetNodeDelegate)SetNode);
            base.AddMethod((GetAcceleratorKeyDelegate)GetAcceleratorKey);
            base.AddMethod((GetAccessKeyDelegate)GetAccessKey);
            base.AddMethod((GetAutomationControlTypeDelegate)GetAutomationControlType);
            base.AddMethod((GetAutomationIdDelegate)GetAutomationId);
            base.AddMethod((GetBoundingRectangleDelegate)GetBoundingRectangle);
            base.AddMethod((GetChildrenDelegate)GetChildren);
            base.AddMethod((GetClassNameDelegate)GetClassName);
            base.AddMethod((GetLabeledByDelegate)GetLabeledBy);
            base.AddMethod((GetNameDelegate)GetName);
            base.AddMethod((GetParentDelegate)GetParent);
            base.AddMethod((HasKeyboardFocusDelegate)HasKeyboardFocus);
            base.AddMethod((IsContentElementDelegate)IsContentElement);
            base.AddMethod((IsControlElementDelegate)IsControlElement);
            base.AddMethod((IsEnabledDelegate)IsEnabled);
            base.AddMethod((IsKeyboardFocusableDelegate)IsKeyboardFocusable);
            base.AddMethod((SetFocusDelegate)SetFocus);
            base.AddMethod((ShowContextMenuDelegate)ShowContextMenu);
            base.AddMethod((GetRootPeerDelegate)GetRootPeer);
            base.AddMethod((IsRootProviderDelegate)IsRootProvider);
            base.AddMethod((RootProvider_GetWindowDelegate)RootProvider_GetWindow);
            base.AddMethod((RootProvider_GetFocusDelegate)RootProvider_GetFocus);
            base.AddMethod((RootProvider_GetPeerFromPointDelegate)RootProvider_GetPeerFromPoint);
            base.AddMethod((IsExpandCollapseProviderDelegate)IsExpandCollapseProvider);
            base.AddMethod((ExpandCollapseProvider_GetIsExpandedDelegate)ExpandCollapseProvider_GetIsExpanded);
            base.AddMethod((ExpandCollapseProvider_GetShowsMenuDelegate)ExpandCollapseProvider_GetShowsMenu);
            base.AddMethod((ExpandCollapseProvider_ExpandDelegate)ExpandCollapseProvider_Expand);
            base.AddMethod((ExpandCollapseProvider_CollapseDelegate)ExpandCollapseProvider_Collapse);
            base.AddMethod((IsInvokeProviderDelegate)IsInvokeProvider);
            base.AddMethod((InvokeProvider_InvokeDelegate)InvokeProvider_Invoke);
            base.AddMethod((IsRangeValueProviderDelegate)IsRangeValueProvider);
            base.AddMethod((RangeValueProvider_GetValueDelegate)RangeValueProvider_GetValue);
            base.AddMethod((RangeValueProvider_GetMinimumDelegate)RangeValueProvider_GetMinimum);
            base.AddMethod((RangeValueProvider_GetMaximumDelegate)RangeValueProvider_GetMaximum);
            base.AddMethod((RangeValueProvider_GetSmallChangeDelegate)RangeValueProvider_GetSmallChange);
            base.AddMethod((RangeValueProvider_GetLargeChangeDelegate)RangeValueProvider_GetLargeChange);
            base.AddMethod((RangeValueProvider_SetValueDelegate)RangeValueProvider_SetValue);
            base.AddMethod((IsSelectionItemProviderDelegate)IsSelectionItemProvider);
            base.AddMethod((SelectionItemProvider_IsSelectedDelegate)SelectionItemProvider_IsSelected);
            base.AddMethod((IsToggleProviderDelegate)IsToggleProvider);
            base.AddMethod((ToggleProvider_GetToggleStateDelegate)ToggleProvider_GetToggleState);
            base.AddMethod((ToggleProvider_ToggleDelegate)ToggleProvider_Toggle);
            base.AddMethod((IsValueProviderDelegate)IsValueProvider);
            base.AddMethod((ValueProvider_GetValueDelegate)ValueProvider_GetValue);
            base.AddMethod((ValueProvider_SetValueDelegate)ValueProvider_SetValue);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnAutomationPeer), new __MicroComIAvnAutomationPeerVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnAutomationPeerArrayProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnAutomationPeerArray
    {
        public uint Count
        {
            get
            {
                uint __result;
                __result = (uint)LocalInterop.CalliStdCalluint(PPV, (*PPV)[base.VTableSize + 0]);
                return __result;
            }
        }

        public IAvnAutomationPeer Get(uint index)
        {
            int __result;
            void* __marshal_ppv = null;
            __result = (int)LocalInterop.CalliStdCallint(PPV, index, &__marshal_ppv, (*PPV)[base.VTableSize + 1]);
            if (__result != 0)
                throw new System.Runtime.InteropServices.COMException("Get failed", __result);
            return Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnAutomationPeer>(__marshal_ppv, true);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnAutomationPeerArray), new Guid("b00af5da-78af-4b33-bfff-4ce13a6239a9"), (p, owns) => new __MicroComIAvnAutomationPeerArrayProxy(p, owns));
        }

        public __MicroComIAvnAutomationPeerArrayProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 2;
    }

    unsafe class __MicroComIAvnAutomationPeerArrayVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate uint GetCountDelegate(IntPtr @this);
        static uint GetCount(IntPtr @this)
        {
            IAvnAutomationPeerArray __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeerArray)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Count;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate int GetDelegate(IntPtr @this, uint index, void** ppv);
        static int Get(IntPtr @this, uint index, void** ppv)
        {
            IAvnAutomationPeerArray __target = null;
            try
            {
                {
                    __target = (IAvnAutomationPeerArray)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.Get(index);
                        *ppv = Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(__result, true);
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException __com_exception__)
            {
                return __com_exception__.ErrorCode;
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return unchecked((int)0x80004005u);
            }

            return 0;
        }

        public __MicroComIAvnAutomationPeerArrayVTable()
        {
            base.AddMethod((GetCountDelegate)GetCount);
            base.AddMethod((GetDelegate)Get);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnAutomationPeerArray), new __MicroComIAvnAutomationPeerArrayVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnAutomationNodeProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnAutomationNode
    {
        public void Dispose()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 0]);
        }

        public void ChildrenChanged()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 1]);
        }

        public void PropertyChanged(AvnAutomationProperty property)
        {
            LocalInterop.CalliStdCallvoid(PPV, property, (*PPV)[base.VTableSize + 2]);
        }

        public void FocusChanged()
        {
            LocalInterop.CalliStdCallvoid(PPV, (*PPV)[base.VTableSize + 3]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnAutomationNode), new Guid("004dc40b-e435-49dc-bac5-6272ee35382a"), (p, owns) => new __MicroComIAvnAutomationNodeProxy(p, owns));
        }

        public __MicroComIAvnAutomationNodeProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 4;
    }

    unsafe class __MicroComIAvnAutomationNodeVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void DisposeDelegate(IntPtr @this);
        static void Dispose(IntPtr @this)
        {
            IAvnAutomationNode __target = null;
            try
            {
                {
                    __target = (IAvnAutomationNode)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.Dispose();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void ChildrenChangedDelegate(IntPtr @this);
        static void ChildrenChanged(IntPtr @this)
        {
            IAvnAutomationNode __target = null;
            try
            {
                {
                    __target = (IAvnAutomationNode)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.ChildrenChanged();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void PropertyChangedDelegate(IntPtr @this, AvnAutomationProperty property);
        static void PropertyChanged(IntPtr @this, AvnAutomationProperty property)
        {
            IAvnAutomationNode __target = null;
            try
            {
                {
                    __target = (IAvnAutomationNode)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.PropertyChanged(property);
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void FocusChangedDelegate(IntPtr @this);
        static void FocusChanged(IntPtr @this)
        {
            IAvnAutomationNode __target = null;
            try
            {
                {
                    __target = (IAvnAutomationNode)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.FocusChanged();
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnAutomationNodeVTable()
        {
            base.AddMethod((DisposeDelegate)Dispose);
            base.AddMethod((ChildrenChangedDelegate)ChildrenChanged);
            base.AddMethod((PropertyChangedDelegate)PropertyChanged);
            base.AddMethod((FocusChangedDelegate)FocusChanged);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnAutomationNode), new __MicroComIAvnAutomationNodeVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPlatformSettingsProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnPlatformSettings
    {
        public AvnPlatformThemeVariant PlatformTheme
        {
            get
            {
                AvnPlatformThemeVariant __result;
                __result = (AvnPlatformThemeVariant)LocalInterop.CalliStdCallAvnPlatformThemeVariant(PPV, (*PPV)[base.VTableSize + 0]);
                return __result;
            }
        }

        public uint AccentColor
        {
            get
            {
                uint __result;
                __result = (uint)LocalInterop.CalliStdCalluint(PPV, (*PPV)[base.VTableSize + 1]);
                return __result;
            }
        }

        public void RegisterColorsChange(IAvnActionCallback callback)
        {
            LocalInterop.CalliStdCallvoid(PPV, Prowl.Surface.MicroCom.MicroComRuntime.GetNativePointer(callback), (*PPV)[base.VTableSize + 2]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPlatformSettings), new Guid("d1f009cc-9d2d-493b-845d-90d2c104baae"), (p, owns) => new __MicroComIAvnPlatformSettingsProxy(p, owns));
        }

        public __MicroComIAvnPlatformSettingsProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 3;
    }

    unsafe class __MicroComIAvnPlatformSettingsVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate AvnPlatformThemeVariant GetPlatformThemeDelegate(IntPtr @this);
        static AvnPlatformThemeVariant GetPlatformTheme(IntPtr @this)
        {
            IAvnPlatformSettings __target = null;
            try
            {
                {
                    __target = (IAvnPlatformSettings)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.PlatformTheme;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate uint GetAccentColorDelegate(IntPtr @this);
        static uint GetAccentColor(IntPtr @this)
        {
            IAvnPlatformSettings __target = null;
            try
            {
                {
                    __target = (IAvnPlatformSettings)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    {
                        var __result = __target.AccentColor;
                        return __result;
                    }
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                return default;
            }
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void RegisterColorsChangeDelegate(IntPtr @this, void* callback);
        static void RegisterColorsChange(IntPtr @this, void* callback)
        {
            IAvnPlatformSettings __target = null;
            try
            {
                {
                    __target = (IAvnPlatformSettings)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.RegisterColorsChange(Prowl.Surface.MicroCom.MicroComRuntime.CreateProxyFor<IAvnActionCallback>(callback, false));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnPlatformSettingsVTable()
        {
            base.AddMethod((GetPlatformThemeDelegate)GetPlatformTheme);
            base.AddMethod((GetAccentColorDelegate)GetAccentColor);
            base.AddMethod((RegisterColorsChangeDelegate)RegisterColorsChange);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPlatformSettings), new __MicroComIAvnPlatformSettingsVTable().CreateVTable());
    }

    unsafe internal partial class __MicroComIAvnPlatformBehaviorInhibitionProxy : Prowl.Surface.MicroCom.MicroComProxyBase, IAvnPlatformBehaviorInhibition
    {
        public void SetInhibitAppSleep(int inhibitAppSleep, string reason)
        {
            var __bytemarshal_reason = new byte[System.Text.Encoding.UTF8.GetByteCount(reason) + 1];
            System.Text.Encoding.UTF8.GetBytes(reason, 0, reason.Length, __bytemarshal_reason, 0);
            fixed (byte* __fixedmarshal_reason = __bytemarshal_reason)
                LocalInterop.CalliStdCallvoid(PPV, inhibitAppSleep, __fixedmarshal_reason, (*PPV)[base.VTableSize + 0]);
        }

        static internal void __MicroComModuleInit()
        {
            Prowl.Surface.MicroCom.MicroComRuntime.Register(typeof(IAvnPlatformBehaviorInhibition), new Guid("12edf00d-5803-4d3f-9947-b4840e5e9372"), (p, owns) => new __MicroComIAvnPlatformBehaviorInhibitionProxy(p, owns));
        }

        public __MicroComIAvnPlatformBehaviorInhibitionProxy(IntPtr nativePointer, bool ownsHandle) : base(nativePointer, ownsHandle)
        {
        }

        protected override int VTableSize => base.VTableSize + 1;
    }

    unsafe class __MicroComIAvnPlatformBehaviorInhibitionVTable : Prowl.Surface.MicroCom.MicroComVtblBase
    {
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        delegate void SetInhibitAppSleepDelegate(IntPtr @this, int inhibitAppSleep, byte* reason);
        static void SetInhibitAppSleep(IntPtr @this, int inhibitAppSleep, byte* reason)
        {
            IAvnPlatformBehaviorInhibition __target = null;
            try
            {
                {
                    __target = (IAvnPlatformBehaviorInhibition)Prowl.Surface.MicroCom.MicroComRuntime.GetObjectFromCcw(@this);
                    __target.SetInhibitAppSleep(inhibitAppSleep, (reason == null ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(new IntPtr(reason))));
                }
            }
            catch (System.Exception __exception__)
            {
                Prowl.Surface.MicroCom.MicroComRuntime.UnhandledException(__target, __exception__);
                ;
            }
        }

        public __MicroComIAvnPlatformBehaviorInhibitionVTable()
        {
            base.AddMethod((SetInhibitAppSleepDelegate)SetInhibitAppSleep);
        }

        static internal void __MicroComModuleInit() => Prowl.Surface.MicroCom.MicroComRuntime.RegisterVTable(typeof(IAvnPlatformBehaviorInhibition), new __MicroComIAvnPlatformBehaviorInhibitionVTable().CreateVTable());
    }

    class LocalInterop
    {
        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void* CalliStdCallvoid_ptr(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, void* arg1, void* arg2, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, int arg0, int arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnSize arg0, AvnSize arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, double arg0, double arg1, AvnPlatformResizeReason arg2, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnRect arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnWindowEdge arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnPoint arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnPoint arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, int arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnDragDropEffects arg0, AvnPoint arg1, void* arg2, void* arg3, IntPtr arg4, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnWindowTransparencyMode arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnPlatformThemeVariant arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, SystemDecorations arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnColor arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnWindowState arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnExtendClientAreaChromeHints arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, double arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, AvnPlatformResizeReason arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnPoint arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnRawMouseEventType arg0, ulong arg1, AvnInputModifiers arg2, AvnPoint arg3, AvnVector arg4, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnRawKeyEventType arg0, ulong arg1, AvnInputModifiers arg2, uint arg3, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, ulong arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, double arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public AvnDragDropEffects CalliStdCallAvnDragDropEffects(void* thisObj, AvnDragEventType arg0, AvnPoint arg1, AvnInputModifiers arg2, AvnDragDropEffects arg3, void* arg4, IntPtr arg5, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnWindowState arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, int arg0, int arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnRect arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, int arg1, int arg2, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, int arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, int arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, void* arg1, int arg2, void* arg3, void* arg4, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, void* arg1, int arg2, void* arg3, void* arg4, void* arg5, void* arg6, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, void* arg0, void* arg1, void* arg2, void* arg3, void* arg4, void* arg5, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, int arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, void* arg1, int arg2, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnStandardCursorType arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, System.IntPtr arg1, AvnPixelSize arg2, void* arg3, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, IntPtr arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public IntPtr CalliStdCallIntPtr(void* thisObj, void* arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public IntPtr CalliStdCallIntPtr(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, void* arg0, System.IntPtr arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnKey arg0, AvnInputModifiers arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, AvnMenuItemToggleType arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public uint CalliStdCalluint(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, uint arg0, void* arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnDragDropEffects arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, IntPtr arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public int CalliStdCallint(void* thisObj, IntPtr arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, float arg0, float arg1, float arg2, float arg3, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, float arg0, float arg1, void* methodPtr)
        {
            throw null;
        }

        static unsafe public AvnAutomationControlType CalliStdCallAvnAutomationControlType(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public AvnRect CalliStdCallAvnRect(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void* CalliStdCallvoid_ptr(void* thisObj, AvnPoint arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public double CalliStdCalldouble(void* thisObj, void* methodPtr)
        {
            throw null;
        }

        static unsafe public void CalliStdCallvoid(void* thisObj, AvnAutomationProperty arg0, void* methodPtr)
        {
            throw null;
        }

        static unsafe public AvnPlatformThemeVariant CalliStdCallAvnPlatformThemeVariant(void* thisObj, void* methodPtr)
        {
            throw null;
        }
    }
}
