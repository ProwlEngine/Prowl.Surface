// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [LibraryImport("libX11")]
    public static partial int _Xmblen(byte* str, int len);

    [LibraryImport("libX11")]
    public static partial XTimeCoord* XGetMotionEvents(XDisplay* display, XWindow window, Time param2, Time param3, int* param4);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XDeleteModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XGetModifierMapping(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XInsertModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XNewModifiermap(int param0);

    [LibraryImport("libX11")]
    public static partial XImage* XCreateImage(XDisplay* display, Visual* param1, uint param2, int param3, int param4, byte* param5, uint param6, uint param7, int param8, int param9);

    [LibraryImport("libX11")]
    public static partial int XInitImage(XImage* param0);

    [LibraryImport("libX11")]
    public static partial XImage* XGetImage(XDisplay* display, XDrawable param1, int param2, int param3, uint param4, uint param5, ulong param6, int param7);

    [LibraryImport("libX11")]
    public static partial XImage* XGetSubImage(XDisplay* display, XDrawable param1, int param2, int param3, uint param4, uint param5, ulong param6, int param7, XImage* param8, int param9, int param10);

    [LibraryImport("libX11")]
    public static partial XDisplay* XOpenDisplay(byte* param0);

    [LibraryImport("libX11")]
    public static partial void XrmInitialize();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBytes(XDisplay* display, int* param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBuffer(XDisplay* display, int* param1, int param2);

    [LibraryImport("libX11")]
    public static partial byte* XGetAtomName(XDisplay* display, Atom param1);

    public static string GetAtomName(XDisplay* display, Atom atom)
    {
        byte* atoms = XGetAtomName(display, atom);

        string name = Marshal.PtrToStringAnsi((nint)atoms) ?? "";

        XFree(atoms);

        return name;
    }

    [LibraryImport("libX11")]
    public static partial int XGetAtomNames(XDisplay* display, Atom* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XGetDefault(XDisplay* display, byte* param1, byte* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayName(byte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XKeysymToString(KeySym param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<XDisplay*, int> XSynchronize(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<XDisplay*, int> XSetAfterFunction(XDisplay* display, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged<XDisplay*, int> param1);

    [LibraryImport("libX11", StringMarshalling = StringMarshalling.Utf8)]
    public static partial Atom XInternAtom(XDisplay* display, string name, [MarshalAs(UnmanagedType.Bool)] bool only_if_exists);

    [LibraryImport("libX11")]
    public static partial int XInternAtoms(XDisplay* display, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, Atom* param4);

    [LibraryImport("libX11")]
    public static partial XColormap XCopyColormapAndFree(XDisplay* display, XColormap param1);

    [LibraryImport("libX11")]
    public static partial XColormap XCreateColormap(XDisplay* display, XWindow window, Visual* param2, int param3);

    [LibraryImport("libX11")]
    public static partial XCursor XCreatePixmapCursor(XDisplay* display, XPixmap source, XPixmap mask, ref XColor foreground, ref XColor background, uint xhot, uint yhot);

    [LibraryImport("libX11")]
    public static partial XCursor XCreateFontCursor(XDisplay* display, XCursorShape shape);

    [LibraryImport("libX11")]
    public static partial XPixmap XCreatePixmap(XDisplay* display, XDrawable param1, uint param2, uint param3, uint param4);

    [LibraryImport("libX11")]
    public static partial XPixmap XCreateBitmapFromData(XDisplay* display, XDrawable drawable, byte* data, uint width, uint height);

    [LibraryImport("libX11")]
    public static partial XPixmap XCreatePixmapFromBitmapData(XDisplay* display, XDrawable param1, byte* param2, uint param3, uint param4, ulong param5, ulong param6, uint param7);

    [LibraryImport("libX11")]
    public static partial XWindow XCreateSimpleWindow(XDisplay* display, XWindow window, int param2, int param3, uint param4, uint param5, uint param6, ulong param7, ulong param8);

    [LibraryImport("libX11")]
    public static partial XWindow XGetSelectionOwner(XDisplay* display, Atom param1);

    [LibraryImport("libX11")]
    public static partial XWindow XCreateWindow(XDisplay* display, XWindow window, int x, int y, uint width, uint height, uint border_width, int depth, uint xclass, Visual* visual, ulong valuemask, XSetWindowAttributes* attributes);

    [LibraryImport("libX11")]
    public static partial XColormap* XListInstalledColormaps(XDisplay* display, XWindow window, int* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char **")]
    public static partial sbyte** XListExtensions(XDisplay* display, int* param1);

    [LibraryImport("libX11")]
    public static partial Atom* XListProperties(XDisplay* display, XWindow window, int* param2);

    [LibraryImport("libX11")]
    public static partial XHostAddress* XListHosts(XDisplay* display, int* param1, int* param2);

    [LibraryImport("libX11")]
    [Obsolete]
    public static partial KeySym XKeycodeToKeysym(XDisplay* display, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial KeySym XLookupKeysym(XKeyEvent* param0, int param1);

    [LibraryImport("libX11")]
    public static partial KeySym* XGetKeyboardMapping(XDisplay* display, [NativeTypeName("KeyCode")] byte param1, int param2, int* param3);

    [LibraryImport("libX11")]
    public static partial KeySym XStringToKeysym(byte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XMaxRequestSize(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XExtendedMaxRequestSize(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XResourceManagerString(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XScreenResourceString(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XDisplayMotionBufferSize(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial VisualID XVisualIDFromVisual(Visual* param0);

    [LibraryImport("libX11")]
    public static partial int XInitThreads();

    [LibraryImport("libX11")]
    public static partial void XLockDisplay(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial void XUnlockDisplay(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XInitExtension(XDisplay* display, byte* param1);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XAddExtension(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XExtData* XFindOnExtensionList(XExtData** param0, int param1);

    [LibraryImport("libX11")]
    public static partial XWindow XRootWindow(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial XWindow XDefaultRootWindow(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XWindow XRootWindowOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisual(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisualOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XBlackPixel(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XWhitePixel(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XAllPlanes();

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XBlackPixelOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XWhitePixelOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XNextRequest(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XLastKnownRequestProcessed(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XServerVendor(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayString(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XColormap XDefaultColormap(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial XColormap XDefaultColormapOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial XDisplay* XDisplayOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial XScreen* XScreenOfDisplay(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial XScreen* XDefaultScreenOfDisplay(XDisplay* display);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XEventMaskOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XScreenNumberOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XErrorHandler")]
    public static partial delegate* unmanaged<XDisplay*, XErrorEvent*, int> XSetErrorHandler([NativeTypeName("XErrorHandler")] delegate* unmanaged<XDisplay*, XErrorEvent*, int> param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XIOErrorHandler")]
    public static partial delegate* unmanaged<XDisplay*, int> XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] delegate* unmanaged<XDisplay*, int> param0);

    [LibraryImport("libX11")]
    public static partial void XSetIOErrorExitHandler(XDisplay* display, [NativeTypeName("XIOErrorExitHandler")] delegate* unmanaged<XDisplay*, void*, void> param1, void* param2);

    [LibraryImport("libX11")]
    public static partial XPixmapFormatValues* XListPixmapFormats(XDisplay* display, int* param1);

    [LibraryImport("libX11")]
    public static partial int* XListDepths(XDisplay* display, int param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XReconfigureWMWindow(XDisplay* display, XWindow window, int param2, uint param3, XWindowChanges* param4);

    [LibraryImport("libX11")]
    public static partial int XGetWMProtocols(XDisplay* display, XWindow window, Atom** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMProtocols(XDisplay* display, XWindow window, Atom* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XIconifyWindow(XDisplay* display, XWindow window, int param2);

    [LibraryImport("libX11")]
    public static partial int XWithdrawWindow(XDisplay* display, XWindow window, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetCommand(XDisplay* display, XWindow window, [NativeTypeName("char ***")] sbyte*** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetWMColormapWindows(XDisplay* display, XWindow window, XWindow** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMColormapWindows(XDisplay* display, XWindow window, XWindow* param2, int param3);

    [LibraryImport("libX11")]
    public static partial void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XSetTransientForHint(XDisplay* display, XWindow window, XWindow param2);

    [LibraryImport("libX11")]
    public static partial int XActivateScreenSaver(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XAddHost(XDisplay* display, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XAddHosts(XDisplay* display, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XAddToExtensionList([NativeTypeName("struct _XExtData **")] XExtData** param0, XExtData* param1);

    [LibraryImport("libX11")]
    public static partial int XAddToSaveSet(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XAllocColor(XDisplay* display, XColormap colormap, ref XColor color);

    [LibraryImport("libX11")]
    public static partial int XAllocColorCells(XDisplay* display, XColormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, uint param4, [NativeTypeName("unsigned long *")] nuint* param5, uint param6);

    [LibraryImport("libX11")]
    public static partial int XAllocColorPlanes(XDisplay* display, XColormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

    [LibraryImport("libX11", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int XAllocNamedColor(XDisplay* display, XColormap colormap, string name, out XColor screen_def, out XColor exact_def);

    [LibraryImport("libX11")]
    public static partial int XAllowEvents(XDisplay* display, int param1, Time param2);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOff(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOn(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XBell(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XBitmapBitOrder(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XBitmapPad(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XBitmapUnit(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XCellsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XChangeActivePointerGrab(XDisplay* display, uint param1, XCursor param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardControl(XDisplay* display, ulong param1, XKeyboardControl* param2);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardMapping(XDisplay* display, int param1, int param2, KeySym* param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XChangePointerControl(XDisplay* display, int param1, int param2, int param3, int param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XChangeProperty(XDisplay* display, XWindow window, Atom param2, Atom param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

    [LibraryImport("libX11")]
    public static partial int XChangeSaveSet(XDisplay* display, XWindow window, int param2);

    [LibraryImport("libX11")]
    public static partial int XChangeWindowAttributes(XDisplay* display, XWindow window, ulong param2, XSetWindowAttributes* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckIfEvent(XDisplay* display, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckMaskEvent(XDisplay* display, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedEvent(XDisplay* display, int param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedWindowEvent(XDisplay* display, XWindow window, int param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckWindowEvent(XDisplay* display, XWindow window, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindows(XDisplay* display, XWindow window, int param2);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsDown(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsUp(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XClearArea(XDisplay* display, XWindow window, int param2, int param3, uint param4, uint param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XClearWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XCloseDisplay(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XConfigureWindow(XDisplay* display, XWindow window, uint param2, XWindowChanges* param3);

    [LibraryImport("libX11")]
    public static partial int XConnectionNumber(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XConvertSelection(XDisplay* display, Atom param1, Atom param2, Atom param3, XWindow param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepth(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepthOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDefaultScreen(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XDefineCursor(XDisplay* display, XWindow window, XCursor param2);

    [LibraryImport("libX11")]
    public static partial int XDeleteProperty(XDisplay* display, XWindow window, Atom param2);

    [LibraryImport("libX11")]
    public static partial int XDestroyWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XDestroySubwindows(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XDoesBackingStore(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDoesSaveUnders(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDisableAccessControl(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XDisplayCells(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeight(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeightMM(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayKeycodes(XDisplay* display, int* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XDisplayPlanes(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidth(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidthMM(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XEnableAccessControl(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XEventsQueued(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XFetchName(XDisplay* display, XWindow window, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XFlush(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XForceScreenSaver(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XFree(void* param0);

    [LibraryImport("libX11")]
    public static partial int XFreeColormap(XDisplay* display, XColormap param1);

    [LibraryImport("libX11")]
    public static partial int XFreeColors(XDisplay* display, XColormap param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, ulong param4);

    [LibraryImport("libX11")]
    public static partial int XFreeCursor(XDisplay* display, XCursor param1);

    [LibraryImport("libX11")]
    public static partial int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XFreeModifiermap(XModifierKeymap* param0);

    [LibraryImport("libX11")]
    public static partial int XFreePixmap(XDisplay* display, XPixmap param1);

    [LibraryImport("libX11")]
    public static partial int XGeometry(XDisplay* display, int param1, byte* param2, byte* param3, uint param4, uint param5, uint param6, int param7, int param8, int* param9, int* param10, int* param11, int* param12);

    [LibraryImport("libX11")]
    public static partial int XGetErrorDatabaseText(XDisplay* display, byte* param1, byte* param2, byte* param3, byte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XGetErrorText(XDisplay* display, int param1, byte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XGetGeometry(XDisplay* display, XDrawable param1, XWindow* param2, int* param3, int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XGetIconName(XDisplay* display, XWindow window, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XGetInputFocus(XDisplay* display, XWindow* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XGetKeyboardControl(XDisplay* display, XKeyboardState* param1);

    [LibraryImport("libX11")]
    public static partial int XGetPointerControl(XDisplay* display, int* param1, int* param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetPointerMapping(XDisplay* display, [NativeTypeName("unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetScreenSaver(XDisplay* display, int* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XGetTransientForHint(XDisplay* display, XWindow window, XWindow* param2);

    [LibraryImport("libX11")]
    public static partial int XGetWindowProperty(XDisplay* display, XWindow window, Atom property, long offset, long length, [MarshalAs(UnmanagedType.Bool)] bool delete, Atom req_type, out Atom actual_type, out int actual_format, out ulong nitems, out ulong bytes_after, out byte* data);

    [LibraryImport("libX11")]
    public static partial int XGetWindowAttributes(XDisplay* display, XWindow window, XWindowAttributes* param2);

    [LibraryImport("libX11")]
    public static partial int XGrabButton(XDisplay* display, uint param1, uint param2, XWindow param3, int param4, uint param5, int param6, int param7, XWindow param8, XCursor param9);

    [LibraryImport("libX11")]
    public static partial int XGrabKey(XDisplay* display, int param1, uint param2, XWindow param3, int param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XGrabKeyboard(XDisplay* display, XWindow window, int param2, int param3, int param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XGrabPointer(XDisplay* display, XWindow window, int param2, uint param3, int param4, int param5, XWindow param6, XCursor param7, Time param8);

    [LibraryImport("libX11")]
    public static partial int XGrabServer(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XHeightMMOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XHeightOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XIfEvent(XDisplay* display, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XImageByteOrder(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XInstallColormap(XDisplay* display, XColormap param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("KeyCode")]
    public static partial byte XKeysymToKeycode(XDisplay* display, KeySym param1);

    [LibraryImport("libX11")]
    public static partial int XLookupColor(XDisplay* display, XColormap param1, byte* param2, XColor* param3, XColor* param4);

    [LibraryImport("libX11")]
    public static partial int XLowerWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XMapRaised(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XMapSubwindows(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XMapWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XMaskEvent(XDisplay* display, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XMaxCmapsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XMinCmapsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XMoveResizeWindow(XDisplay* display, XWindow window, int param2, int param3, uint param4, uint param5);

    [LibraryImport("libX11")]
    public static partial int XMoveWindow(XDisplay* display, XWindow window, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XNextEvent(XDisplay* display, out XEvent out_event);

    [LibraryImport("libX11")]
    public static partial int XNoOp(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XParseColor(XDisplay* display, XColormap param1, byte* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XParseGeometry(byte* param0, int* param1, int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

    [LibraryImport("libX11")]
    public static partial int XPeekEvent(XDisplay* display, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XPeekIfEvent(XDisplay* display, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XPending(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XPlanesOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XProtocolRevision(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XProtocolVersion(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XPutBackEvent(XDisplay* display, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XQLength(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XQueryBestCursor(XDisplay* display, XDrawable param1, uint param2, uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestSize(XDisplay* display, int param1, XDrawable param2, uint param3, uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

    [LibraryImport("libX11")]
    public static partial int XQueryBestStipple(XDisplay* display, XDrawable param1, uint param2, uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestTile(XDisplay* display, XDrawable param1, uint param2, uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryColor(XDisplay* display, XColormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XQueryColors(XDisplay* display, XColormap param1, XColor* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XQueryExtension(XDisplay* display, byte* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XQueryKeymap(XDisplay* display, [NativeTypeName("char[32]")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial int XQueryPointer(XDisplay* display, XWindow window, XWindow* param2, XWindow* param3, int* param4, int* param5, int* param6, int* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XQueryTree(XDisplay* display, XWindow window, XWindow* param2, XWindow* param3, XWindow** param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XRaiseWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFile(XDisplay* display, XDrawable param1, byte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, XPixmap* param5, int* param6, int* param7);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFileData(byte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, int* param4, int* param5);

    [LibraryImport("libX11")]
    public static partial int XRebindKeysym(XDisplay* display, KeySym param1, KeySym* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XRecolorCursor(XDisplay* display, XCursor param1, XColor* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XRefreshKeyboardMapping(XMappingEvent* param0);

    [LibraryImport("libX11")]
    public static partial int XRemoveFromSaveSet(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XRemoveHost(XDisplay* display, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XRemoveHosts(XDisplay* display, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XReparentWindow(XDisplay* display, XWindow window, XWindow param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XResetScreenSaver(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XResizeWindow(XDisplay* display, XWindow window, uint param2, uint param3);

    [LibraryImport("libX11")]
    public static partial int XRestackWindows(XDisplay* display, XWindow* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XRotateBuffers(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XRotateWindowProperties(XDisplay* display, XWindow window, Atom* param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XScreenCount(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XSelectInput(XDisplay* display, XWindow window, XEventMask eventMask);

    [LibraryImport("libX11")]
    public static partial int XSendEvent(XDisplay* display, XWindow window, [MarshalAs(UnmanagedType.Bool)] bool propagate, long eventmask, XEvent* param4);

    [LibraryImport("libX11")]
    public static partial int XSetAccessControl(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCloseDownMode(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCommand(XDisplay* display, XWindow window, [NativeTypeName("char **")] sbyte** param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XSetIconName(XDisplay* display, XWindow window, byte* param2);

    [LibraryImport("libX11")]
    public static partial int XSetInputFocus(XDisplay* display, XWindow window, int param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetModifierMapping(XDisplay* display, XModifierKeymap* param1);

    [LibraryImport("libX11")]
    public static partial int XSetPointerMapping(XDisplay* display, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XSetScreenSaver(XDisplay* display, int param1, int param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSetSelectionOwner(XDisplay* display, Atom param1, XWindow param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackground(XDisplay* display, XWindow window, ulong param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackgroundPixmap(XDisplay* display, XWindow window, XPixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorder(XDisplay* display, XWindow window, ulong param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderPixmap(XDisplay* display, XWindow window, XPixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderWidth(XDisplay* display, XWindow window, uint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowColormap(XDisplay* display, XWindow window, XColormap param2);

    [LibraryImport("libX11")]
    public static partial int XStoreBuffer(XDisplay* display, byte* param1, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XStoreBytes(XDisplay* display, byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColor(XDisplay* display, XColormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColors(XDisplay* display, XColormap param1, XColor* param2, int param3);

    [LibraryImport("libX11", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int XStoreName(XDisplay* display, XWindow window, string name);

    [LibraryImport("libX11")]
    public static partial int XStoreNamedColor(XDisplay* display, XColormap param1, byte* param2, ulong param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSync(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XTranslateCoordinates(XDisplay* display, XWindow window, XWindow param2, int param3, int param4, int* param5, int* param6, XWindow* param7);

    [LibraryImport("libX11")]
    public static partial int XUndefineCursor(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XUngrabButton(XDisplay* display, uint param1, uint param2, XWindow param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKey(XDisplay* display, int param1, uint param2, XWindow param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKeyboard(XDisplay* display, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabPointer(XDisplay* display, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabServer(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XUninstallColormap(XDisplay* display, XColormap param1);

    [LibraryImport("libX11")]
    public static partial int XUnmapSubwindows(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XUnmapWindow(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XVendorRelease(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial int XWarpPointer(XDisplay* display, XWindow window, XWindow param2, int param3, int param4, uint param5, uint param6, int param7, int param8);

    [LibraryImport("libX11")]
    public static partial int XWidthMMOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XWidthOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XWindowEvent(XDisplay* display, XWindow window, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XWriteBitmapFile(XDisplay* display, byte* param1, XPixmap param2, uint param3, uint param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XSupportsLocale();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XSetLocaleModifiers(byte* param0);

    [LibraryImport("libX11")]
    public static partial int XFilterEvent(XEvent* param0, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XRegisterIMInstantiateCallback(XDisplay* display, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, byte* param2, byte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XUnregisterIMInstantiateCallback(XDisplay* display, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, byte* param2, byte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XInternalConnectionNumbers(XDisplay* display, int** param1, int* param2);

    [LibraryImport("libX11")]
    public static partial void XProcessInternalConnection(XDisplay* display, int param1);

    [LibraryImport("libX11")]
    public static partial int XAddConnectionWatch(XDisplay* display, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XRemoveConnectionWatch(XDisplay* display, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XSetAuthorization(byte* param0, int param1, byte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int _Xmbtowc([NativeTypeName("wchar_t *")] uint* param0, byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int _Xwctomb(byte* param0, [NativeTypeName("wchar_t")] uint param1);

    [LibraryImport("libX11")]
    public static partial int XGetEventData(XDisplay* display, XGenericEventCookie* param1);

    [LibraryImport("libX11")]
    public static partial void XFreeEventData(XDisplay* display, XGenericEventCookie* param1);

    public const int XlibSpecificationRelease = 6;

    public const int X_HAVE_UTF8_STRING = 1;

    public const int True = 1;

    public const int False = 0;

    public const int QueuedAlready = 0;

    public const int QueuedAfterReading = 1;

    public const int QueuedAfterFlush = 2;

    public static ReadOnlySpan<byte> XNRequiredCharSet => "requiredCharSet"u8;

    public static ReadOnlySpan<byte> XNQueryOrientation => "queryOrientation"u8;

    public static ReadOnlySpan<byte> XNBaseFontName => "baseFontName"u8;

    public static ReadOnlySpan<byte> XNOMAutomatic => "omAutomatic"u8;

    public static ReadOnlySpan<byte> XNMissingCharSet => "missingCharSet"u8;

    public static ReadOnlySpan<byte> XNDefaultString => "defaultString"u8;

    public static ReadOnlySpan<byte> XNOrientation => "orientation"u8;

    public static ReadOnlySpan<byte> XNDirectionalDependentDrawing => "directionalDependentDrawing"u8;

    public static ReadOnlySpan<byte> XNContextualDrawing => "contextualDrawing"u8;

    public static ReadOnlySpan<byte> XNFontInfo => "fontInfo"u8;

    public const nint XIMPreeditArea = 0x0001;

    public const nint XIMPreeditCallbacks = 0x0002;

    public const nint XIMPreeditPosition = 0x0004;

    public const nint XIMPreeditNothing = 0x0008;

    public const nint XIMPreeditNone = 0x0010;

    public const nint XIMStatusArea = 0x0100;

    public const nint XIMStatusCallbacks = 0x0200;

    public const nint XIMStatusNothing = 0x0400;

    public const nint XIMStatusNone = 0x0800;

    public static ReadOnlySpan<byte> XNVaNestedList => "XNVaNestedList"u8;

    public static ReadOnlySpan<byte> XNQueryInputStyle => "queryInputStyle"u8;

    public static ReadOnlySpan<byte> XNClientWindow => "clientWindow"u8;

    public static ReadOnlySpan<byte> XNInputStyle => "inputStyle"u8;

    public static ReadOnlySpan<byte> XNFocusWindow => "focusWindow"u8;

    public static ReadOnlySpan<byte> XNResourceName => "resourceName"u8;

    public static ReadOnlySpan<byte> XNResourceClass => "resourceClass"u8;

    public static ReadOnlySpan<byte> XNGeometryCallback => "geometryCallback"u8;

    public static ReadOnlySpan<byte> XNDestroyCallback => "destroyCallback"u8;

    public static ReadOnlySpan<byte> XNFilterEvents => "filterEvents"u8;

    public static ReadOnlySpan<byte> XNPreeditStartCallback => "preeditStartCallback"u8;

    public static ReadOnlySpan<byte> XNPreeditDoneCallback => "preeditDoneCallback"u8;

    public static ReadOnlySpan<byte> XNPreeditDrawCallback => "preeditDrawCallback"u8;

    public static ReadOnlySpan<byte> XNPreeditCaretCallback => "preeditCaretCallback"u8;

    public static ReadOnlySpan<byte> XNPreeditStateNotifyCallback => "preeditStateNotifyCallback"u8;

    public static ReadOnlySpan<byte> XNPreeditAttributes => "preeditAttributes"u8;

    public static ReadOnlySpan<byte> XNStatusStartCallback => "statusStartCallback"u8;

    public static ReadOnlySpan<byte> XNStatusDoneCallback => "statusDoneCallback"u8;

    public static ReadOnlySpan<byte> XNStatusDrawCallback => "statusDrawCallback"u8;

    public static ReadOnlySpan<byte> XNStatusAttributes => "statusAttributes"u8;

    public static ReadOnlySpan<byte> XNArea => "area"u8;

    public static ReadOnlySpan<byte> XNAreaNeeded => "areaNeeded"u8;

    public static ReadOnlySpan<byte> XNSpotLocation => "spotLocation"u8;

    public static ReadOnlySpan<byte> XNColormap => "colorMap"u8;

    public static ReadOnlySpan<byte> XNStdColormap => "stdColorMap"u8;

    public static ReadOnlySpan<byte> XNForeground => "foreground"u8;

    public static ReadOnlySpan<byte> XNBackground => "background"u8;

    public static ReadOnlySpan<byte> XNBackgroundPixmap => "backgroundPixmap"u8;

    public static ReadOnlySpan<byte> XNFontSet => "fontSet"u8;

    public static ReadOnlySpan<byte> XNLineSpace => "lineSpace"u8;

    public static ReadOnlySpan<byte> XNCursor => "cursor"u8;

    public static ReadOnlySpan<byte> XNQueryIMValuesList => "queryIMValuesList"u8;

    public static ReadOnlySpan<byte> XNQueryICValuesList => "queryICValuesList"u8;

    public static ReadOnlySpan<byte> XNVisiblePosition => "visiblePosition"u8;

    public static ReadOnlySpan<byte> XNR6PreeditCallback => "r6PreeditCallback"u8;

    public static ReadOnlySpan<byte> XNStringConversionCallback => "stringConversionCallback"u8;

    public static ReadOnlySpan<byte> XNStringConversion => "stringConversion"u8;

    public static ReadOnlySpan<byte> XNResetState => "resetState"u8;

    public static ReadOnlySpan<byte> XNHotKey => "hotKey"u8;

    public static ReadOnlySpan<byte> XNHotKeyState => "hotKeyState"u8;

    public static ReadOnlySpan<byte> XNPreeditState => "preeditState"u8;

    public static ReadOnlySpan<byte> XNSeparatorofNestedList => "separatorofNestedList"u8;

    public const int XBufferOverflow = -1;

    public const int XLookupNone = 1;

    public const int XLookupChars = 2;

    public const int XLookupKeySym = 3;

    public const int XLookupBoth = 4;

    public const nint XIMReverse = 1;

    public const nint XIMUnderline = (1 << 1);

    public const nint XIMHighlight = (1 << 2);

    public const nint XIMPrimary = (1 << 5);

    public const nint XIMSecondary = (1 << 6);

    public const nint XIMTertiary = (1 << 7);

    public const nint XIMVisibleToForward = (1 << 8);

    public const nint XIMVisibleToBackword = (1 << 9);

    public const nint XIMVisibleToCenter = (1 << 10);

    public const nint XIMPreeditUnKnown = 0;

    public const nint XIMPreeditEnable = 1;

    public const nint XIMPreeditDisable = (1 << 1);

    public const nint XIMInitialState = 1;

    public const nint XIMPreserveState = (1 << 1);

    public const int XIMStringConversionLeftEdge = (0x00000001);

    public const int XIMStringConversionRightEdge = (0x00000002);

    public const int XIMStringConversionTopEdge = (0x00000004);

    public const int XIMStringConversionBottomEdge = (0x00000008);

    public const int XIMStringConversionConcealed = (0x00000010);

    public const int XIMStringConversionWrapped = (0x00000020);

    public const int XIMStringConversionBuffer = (0x0001);

    public const int XIMStringConversionLine = (0x0002);

    public const int XIMStringConversionWord = (0x0003);

    public const int XIMStringConversionChar = (0x0004);

    public const int XIMStringConversionSubstitution = (0x0001);

    public const int XIMStringConversionRetrieval = (0x0002);

    public const nint XIMHotKeyStateON = (0x0001);

    public const nint XIMHotKeyStateOFF = (0x0002);
}
