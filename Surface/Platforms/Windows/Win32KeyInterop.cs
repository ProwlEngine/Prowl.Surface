// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using Prowl.Surface.Input;

using static TerraFX.Interop.Windows.Windows;
using static TerraFX.Interop.Windows.VK;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.Win32;


[SupportedOSPlatform("windows")]
internal static class Win32KeyInterop
{
    public static ModifierKeys GetSystemModifierKeys()
    {
        ModifierKeys modifierKeys = ModifierKeys.None;

        short keyState = GetKeyState(VK_SHIFT);
        if ((keyState & 0x8000) == 0x8000)
        {
            modifierKeys |= ModifierKeys.Shift;
        }

        keyState = GetKeyState(VK_CONTROL);
        if ((keyState & 0x8000) == 0x8000)
        {
            modifierKeys |= ModifierKeys.Control;
        }

        keyState = GetKeyState(VK_MENU);
        if ((keyState & 0x8000) == 0x8000)
        {
            modifierKeys |= ModifierKeys.Alt;
        }

        return modifierKeys;
    }


    private static readonly IReadOnlyDictionary<int, Key> s_keyMappings = new Dictionary<int, Key>()
    {
        { VK_CANCEL, Key.Cancel },
        { VK_BACK, Key.Back },
        { VK_TAB, Key.Tab },
        { VK_CLEAR, Key.Clear },
        { VK_RETURN, Key.Return },
        { VK_PAUSE, Key.Pause },
        { VK_CAPITAL, Key.Capital },
        { VK_KANA, Key.KanaMode },
        { VK_JUNJA, Key.JunjaMode },
        { VK_FINAL, Key.FinalMode },
        { VK_KANJI, Key.KanjiMode },
        { VK_ESCAPE, Key.Escape },
        { VK_CONVERT, Key.ImeConvert },
        { VK_NONCONVERT, Key.ImeNonConvert },
        { VK_ACCEPT, Key.ImeAccept },
        { VK_MODECHANGE, Key.ImeModeChange },
        { VK_SPACE, Key.Space },
        { VK_PRIOR, Key.Prior },
        { VK_NEXT, Key.Next },
        { VK_END, Key.End },
        { VK_HOME, Key.Home },
        { VK_LEFT, Key.Left },
        { VK_UP, Key.Up },
        { VK_RIGHT, Key.Right },
        { VK_DOWN, Key.Down },
        { VK_SELECT, Key.Select },
        { VK_PRINT, Key.Print },
        { VK_EXECUTE, Key.Execute },
        { VK_SNAPSHOT, Key.Snapshot },
        { VK_INSERT, Key.Insert },
        { VK_DELETE, Key.Delete },
        { VK_HELP, Key.Help },
        { VK_0, Key.D0 },
        { VK_1, Key.D1 },
        { VK_2, Key.D2 },
        { VK_3, Key.D3 },
        { VK_4, Key.D4 },
        { VK_5, Key.D5 },
        { VK_6, Key.D6 },
        { VK_7, Key.D7 },
        { VK_8, Key.D8 },
        { VK_9, Key.D9 },
        { VK_A, Key.A },
        { VK_B, Key.B },
        { VK_C, Key.C },
        { VK_D, Key.D },
        { VK_E, Key.E },
        { VK_F, Key.F },
        { VK_G, Key.G },
        { VK_H, Key.H },
        { VK_I, Key.I },
        { VK_J, Key.J },
        { VK_K, Key.K },
        { VK_L, Key.L },
        { VK_M, Key.M },
        { VK_N, Key.N },
        { VK_O, Key.O },
        { VK_P, Key.P },
        { VK_Q, Key.Q },
        { VK_R, Key.R },
        { VK_S, Key.S },
        { VK_T, Key.T },
        { VK_U, Key.U },
        { VK_V, Key.V },
        { VK_W, Key.W },
        { VK_X, Key.X },
        { VK_Y, Key.Y },
        { VK_Z, Key.Z },
        { VK_LWIN, Key.LWin },
        { VK_RWIN, Key.RWin },
        { VK_APPS, Key.Apps },
        { VK_SLEEP, Key.Sleep },
        { VK_NUMPAD0, Key.NumPad0 },
        { VK_NUMPAD1, Key.NumPad1 },
        { VK_NUMPAD2, Key.NumPad2 },
        { VK_NUMPAD3, Key.NumPad3 },
        { VK_NUMPAD4, Key.NumPad4 },
        { VK_NUMPAD5, Key.NumPad5 },
        { VK_NUMPAD6, Key.NumPad6 },
        { VK_NUMPAD7, Key.NumPad7 },
        { VK_NUMPAD8, Key.NumPad8 },
        { VK_NUMPAD9, Key.NumPad9 },
        { VK_MULTIPLY, Key.Multiply },
        { VK_ADD, Key.Add },
        { VK_SEPARATOR, Key.Separator },
        { VK_SUBTRACT, Key.Subtract },
        { VK_DECIMAL, Key.Decimal },
        { VK_DIVIDE, Key.Divide },
        { VK_F1, Key.F1 },
        { VK_F2, Key.F2 },
        { VK_F3, Key.F3 },
        { VK_F4, Key.F4 },
        { VK_F5, Key.F5 },
        { VK_F6, Key.F6 },
        { VK_F7, Key.F7 },
        { VK_F8, Key.F8 },
        { VK_F9, Key.F9 },
        { VK_F10, Key.F10 },
        { VK_F11, Key.F11 },
        { VK_F12, Key.F12 },
        { VK_F13, Key.F13 },
        { VK_F14, Key.F14 },
        { VK_F15, Key.F15 },
        { VK_F16, Key.F16 },
        { VK_F17, Key.F17 },
        { VK_F18, Key.F18 },
        { VK_F19, Key.F19 },
        { VK_F20, Key.F20 },
        { VK_F21, Key.F21 },
        { VK_F22, Key.F22 },
        { VK_F23, Key.F23 },
        { VK_F24, Key.F24 },
        { VK_NUMLOCK, Key.NumLock },
        { VK_SCROLL, Key.Scroll },
        { VK_SHIFT, Key.LeftShift },
        { VK_LSHIFT, Key.LeftShift },
        { VK_RSHIFT, Key.RightShift },
        { VK_CONTROL, Key.LeftCtrl },
        { VK_LCONTROL, Key.LeftCtrl },
        { VK_RCONTROL, Key.RightCtrl },
        { VK_MENU, Key.LeftAlt },
        { VK_LMENU, Key.LeftAlt },
        { VK_RMENU, Key.RightAlt },
        { VK_BROWSER_BACK, Key.BrowserBack },
        { VK_BROWSER_FORWARD, Key.BrowserForward },
        { VK_BROWSER_REFRESH, Key.BrowserRefresh },
        { VK_BROWSER_STOP, Key.BrowserStop },
        { VK_BROWSER_SEARCH, Key.BrowserSearch },
        { VK_BROWSER_FAVORITES, Key.BrowserFavorites },
        { VK_BROWSER_HOME, Key.BrowserHome },
        { VK_VOLUME_MUTE, Key.VolumeMute },
        { VK_VOLUME_DOWN, Key.VolumeDown },
        { VK_VOLUME_UP, Key.VolumeUp },
        { VK_MEDIA_NEXT_TRACK, Key.MediaNextTrack },
        { VK_MEDIA_PREV_TRACK, Key.MediaPreviousTrack },
        { VK_MEDIA_STOP, Key.MediaStop },
        { VK_MEDIA_PLAY_PAUSE, Key.MediaPlayPause },
        { VK_LAUNCH_MAIL, Key.LaunchMail },
        { VK_LAUNCH_MEDIA_SELECT, Key.SelectMedia },
        { VK_LAUNCH_APP1, Key.LaunchApplication1 },
        { VK_LAUNCH_APP2, Key.LaunchApplication2 },
        { VK_OEM_1, Key.OemSemicolon },
        { VK_OEM_PLUS, Key.OemPlus },
        { VK_OEM_COMMA, Key.OemComma },
        { VK_OEM_MINUS, Key.OemMinus },
        { VK_OEM_PERIOD, Key.OemPeriod },
        { VK_OEM_2, Key.OemQuestion },
        { VK_OEM_3, Key.OemTilde },
        { VK_C1, Key.AbntC1 },
        { VK_C2, Key.AbntC2 },
        { VK_OEM_4, Key.OemOpenBrackets },
        { VK_OEM_5, Key.OemPipe },
        { VK_OEM_6, Key.OemCloseBrackets },
        { VK_OEM_7, Key.OemQuotes },
        { VK_OEM_8, Key.Oem8 },
        { VK_OEM_102, Key.OemBackslash },
        { VK_PROCESSKEY, Key.ImeProcessed },
        { VK_OEM_ATTN, Key.OemAttn },
        { VK_OEM_FINISH, Key.OemFinish },
        { VK_OEM_COPY, Key.OemCopy },
        { VK_OEM_AUTO, Key.OemAuto },
        { VK_OEM_ENLW, Key.OemEnlw },
        { VK_OEM_BACKTAB, Key.OemBackTab },
        { VK_ATTN, Key.Attn },
        { VK_CRSEL, Key.CrSel },
        { VK_EXSEL, Key.ExSel },
        { VK_EREOF, Key.EraseEof },
        { VK_PLAY, Key.Play },
        { VK_ZOOM, Key.Zoom },
        { VK_NONAME, Key.NoName },
        { VK_PA1, Key.Pa1 },
        { VK_OEM_CLEAR, Key.OemClear },
    };


    private static readonly IReadOnlyDictionary<Key, int> s_virtualKeyMappings = new Dictionary<Key, int>(s_keyMappings
        .Select(x => new KeyValuePair<Key, int>(x.Value, x.Key))
    );


    public static Key VirtualKeyToKey(int virtualKey)
    {
        // https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

        if (s_keyMappings.TryGetValue(virtualKey, out Key key))
            return key;

        return Key.None;
    }

    /// <summary>
    /// Convert our Key enum into a Win32 VirtualKey.
    /// </summary>
    public static int VirtualKeyFromKey(Key key)
    {
        if (s_virtualKeyMappings.TryGetValue(key, out int virtualKey))
            return virtualKey;

        return 0;
    }

    private const int VK_0 = 0x30;

    private const int VK_1 = 0x31;

    private const int VK_2 = 0x32;

    private const int VK_3 = 0x33;

    private const int VK_4 = 0x34;

    private const int VK_5 = 0x35;

    private const int VK_6 = 0x36;

    private const int VK_7 = 0x37;

    private const int VK_8 = 0x38;

    private const int VK_9 = 0x39;

    private const int VK_A = 0x41;

    private const int VK_B = 0x42;

    private const int VK_C = 0x43;

    private const int VK_D = 0x44;

    private const int VK_E = 0x45;

    private const int VK_F = 0x46;

    private const int VK_G = 0x47;

    private const int VK_H = 0x48;

    private const int VK_I = 0x49;

    private const int VK_J = 0x4A;

    private const int VK_K = 0x4B;

    private const int VK_L = 0x4C;

    private const int VK_M = 0x4D;

    private const int VK_N = 0x4E;

    private const int VK_O = 0x4F;

    private const int VK_P = 0x50;

    private const int VK_Q = 0x51;

    private const int VK_R = 0x52;

    private const int VK_S = 0x53;

    private const int VK_T = 0x54;

    private const int VK_U = 0x55;

    private const int VK_V = 0x56;

    private const int VK_W = 0x57;

    private const int VK_X = 0x58;

    private const int VK_Y = 0x59;

    private const int VK_Z = 0x5A;

    private const int VK_C1 = 0xC1;   // Brazilian ABNT_C1 key (not defined in winuser.h).
    private const int VK_C2 = 0xC2;   // Brazilian ABNT_C2 key (not defined in winuser.h).
}
