// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [LibraryImport("libX11")]
    public static partial int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

    [LibraryImport("libX11")]
    public static partial XTimeCoord* XGetMotionEvents(Display* param0, Window param1, Time param2, Time param3, int* param4);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XDeleteModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XGetModifierMapping(Display* param0);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XInsertModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XNewModifiermap(int param0);

    [LibraryImport("libX11")]
    public static partial XImage* XCreateImage(Display* param0, Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

    [LibraryImport("libX11")]
    public static partial int XInitImage(XImage* param0);

    [LibraryImport("libX11")]
    public static partial XImage* XGetImage(Display* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7);

    [LibraryImport("libX11")]
    public static partial XImage* XGetSubImage(Display* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7, XImage* param8, int param9, int param10);

    [LibraryImport("libX11")]
    public static partial Display* XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial void XrmInitialize();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBytes(Display* param0, int* param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBuffer(Display* param0, int* param1, int param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XGetAtomName(Display* param0, Atom param1);

    [LibraryImport("libX11")]
    public static partial int XGetAtomNames(Display* param0, Atom* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XGetDefault(Display* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XKeysymToString(KeySym param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<Display*, int> XSynchronize(Display* param0, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<Display*, int> XSetAfterFunction(Display* param0, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged<Display*, int> param1);

    [LibraryImport("libX11")]
    public static partial Atom XInternAtom(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XInternAtoms(Display* param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, Atom* param4);

    [LibraryImport("libX11")]
    public static partial Colormap XCopyColormapAndFree(Display* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial Colormap XCreateColormap(Display* param0, Window param1, Visual* param2, int param3);

    [LibraryImport("libX11")]
    public static partial Cursor XCreatePixmapCursor(Display* param0, Pixmap param1, Pixmap param2, XColor* param3, XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

    [LibraryImport("libX11")]
    public static partial Cursor XCreateFontCursor(Display* param0, [NativeTypeName("unsigned int")] uint param1);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreatePixmap(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreateBitmapFromData(Display* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreatePixmapFromBitmapData(Display* param0, Drawable param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] nuint param5, [NativeTypeName("unsigned long")] nuint param6, [NativeTypeName("unsigned int")] uint param7);

    [LibraryImport("libX11")]
    public static partial Window XCreateSimpleWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] nuint param7, [NativeTypeName("unsigned long")] nuint param8);

    [LibraryImport("libX11")]
    public static partial Window XGetSelectionOwner(Display* param0, Atom param1);

    [LibraryImport("libX11")]
    public static partial Window XCreateWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, Visual* param9, [NativeTypeName("unsigned long")] nuint param10, XSetWindowAttributes* param11);

    [LibraryImport("libX11")]
    public static partial Colormap* XListInstalledColormaps(Display* param0, Window param1, int* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char **")]
    public static partial sbyte** XListExtensions(Display* param0, int* param1);

    [LibraryImport("libX11")]
    public static partial Atom* XListProperties(Display* param0, Window param1, int* param2);

    [LibraryImport("libX11")]
    public static partial XHostAddress* XListHosts(Display* param0, int* param1, int* param2);

    [LibraryImport("libX11")]
    [Obsolete]
    public static partial KeySym XKeycodeToKeysym(Display* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial KeySym XLookupKeysym(XKeyEvent* param0, int param1);

    [LibraryImport("libX11")]
    public static partial KeySym* XGetKeyboardMapping(Display* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int* param3);

    [LibraryImport("libX11")]
    public static partial KeySym XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XMaxRequestSize(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XExtendedMaxRequestSize(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XResourceManagerString(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XScreenResourceString(Screen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XDisplayMotionBufferSize(Display* param0);

    [LibraryImport("libX11")]
    public static partial VisualID XVisualIDFromVisual(Visual* param0);

    [LibraryImport("libX11")]
    public static partial int XInitThreads();

    [LibraryImport("libX11")]
    public static partial void XLockDisplay(Display* param0);

    [LibraryImport("libX11")]
    public static partial void XUnlockDisplay(Display* param0);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XInitExtension(Display* param0, [NativeTypeName("const char *")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XAddExtension(Display* param0);

    [LibraryImport("libX11")]
    public static partial XExtData* XFindOnExtensionList(XExtData** param0, int param1);

    [LibraryImport("libX11")]
    public static partial Window XRootWindow(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Window XDefaultRootWindow(Display* param0);

    [LibraryImport("libX11")]
    public static partial Window XRootWindowOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisual(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisualOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XBlackPixel(Display* param0, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XWhitePixel(Display* param0, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XAllPlanes();

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XBlackPixelOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XWhitePixelOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XNextRequest(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XLastKnownRequestProcessed(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XServerVendor(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayString(Display* param0);

    [LibraryImport("libX11")]
    public static partial Colormap XDefaultColormap(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Colormap XDefaultColormapOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial Display* XDisplayOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial Screen* XScreenOfDisplay(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Screen* XDefaultScreenOfDisplay(Display* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XEventMaskOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XScreenNumberOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XErrorHandler")]
    public static partial delegate* unmanaged<Display*, XErrorEvent*, int> XSetErrorHandler([NativeTypeName("XErrorHandler")] delegate* unmanaged<Display*, XErrorEvent*, int> param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XIOErrorHandler")]
    public static partial delegate* unmanaged<Display*, int> XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] delegate* unmanaged<Display*, int> param0);

    [LibraryImport("libX11")]
    public static partial void XSetIOErrorExitHandler(Display* param0, [NativeTypeName("XIOErrorExitHandler")] delegate* unmanaged<Display*, void*, void> param1, void* param2);

    [LibraryImport("libX11")]
    public static partial XPixmapFormatValues* XListPixmapFormats(Display* param0, int* param1);

    [LibraryImport("libX11")]
    public static partial int* XListDepths(Display* param0, int param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XReconfigureWMWindow(Display* param0, Window param1, int param2, [NativeTypeName("unsigned int")] uint param3, XWindowChanges* param4);

    [LibraryImport("libX11")]
    public static partial int XGetWMProtocols(Display* param0, Window param1, Atom** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMProtocols(Display* param0, Window param1, Atom* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XIconifyWindow(Display* param0, Window param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XWithdrawWindow(Display* param0, Window param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetCommand(Display* param0, Window param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetWMColormapWindows(Display* param0, Window param1, Window** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMColormapWindows(Display* param0, Window param1, Window* param2, int param3);

    [LibraryImport("libX11")]
    public static partial void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XSetTransientForHint(Display* param0, Window param1, Window param2);

    [LibraryImport("libX11")]
    public static partial int XActivateScreenSaver(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XAddHost(Display* param0, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XAddHosts(Display* param0, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XAddToExtensionList([NativeTypeName("struct _XExtData **")] XExtData** param0, XExtData* param1);

    [LibraryImport("libX11")]
    public static partial int XAddToSaveSet(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XAllocColor(Display* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XAllocColorCells(Display* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] nuint* param5, [NativeTypeName("unsigned int")] uint param6);

    [LibraryImport("libX11")]
    public static partial int XAllocColorPlanes(Display* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

    [LibraryImport("libX11")]
    public static partial int XAllocNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [LibraryImport("libX11")]
    public static partial int XAllowEvents(Display* param0, int param1, Time param2);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOff(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOn(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XBell(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XBitmapBitOrder(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XBitmapPad(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XBitmapUnit(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XCellsOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XChangeActivePointerGrab(Display* param0, [NativeTypeName("unsigned int")] uint param1, Cursor param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardControl(Display* param0, [NativeTypeName("unsigned long")] nuint param1, XKeyboardControl* param2);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardMapping(Display* param0, int param1, int param2, KeySym* param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XChangePointerControl(Display* param0, int param1, int param2, int param3, int param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XChangeProperty(Display* param0, Window param1, Atom param2, Atom param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

    [LibraryImport("libX11")]
    public static partial int XChangeSaveSet(Display* param0, Window param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XChangeWindowAttributes(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2, XSetWindowAttributes* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckMaskEvent(Display* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedEvent(Display* param0, int param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedWindowEvent(Display* param0, Window param1, int param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckWindowEvent(Display* param0, Window param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindows(Display* param0, Window param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsDown(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsUp(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XClearArea(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XClearWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XCloseDisplay(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XConfigureWindow(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2, XWindowChanges* param3);

    [LibraryImport("libX11")]
    public static partial int XConnectionNumber(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XConvertSelection(Display* param0, Atom param1, Atom param2, Atom param3, Window param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepth(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepthOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XDefaultScreen(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XDefineCursor(Display* param0, Window param1, Cursor param2);

    [LibraryImport("libX11")]
    public static partial int XDeleteProperty(Display* param0, Window param1, Atom param2);

    [LibraryImport("libX11")]
    public static partial int XDestroyWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XDestroySubwindows(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XDoesBackingStore(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XDoesSaveUnders(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XDisableAccessControl(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XDisplayCells(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeight(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeightMM(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayKeycodes(Display* param0, int* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XDisplayPlanes(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidth(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidthMM(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XEnableAccessControl(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XEventsQueued(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XFetchName(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XFlush(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XForceScreenSaver(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XFree(void* param0);

    [LibraryImport("libX11")]
    public static partial int XFreeColormap(Display* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial int XFreeColors(Display* param0, Colormap param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, [NativeTypeName("unsigned long")] nuint param4);

    [LibraryImport("libX11")]
    public static partial int XFreeCursor(Display* param0, Cursor param1);

    [LibraryImport("libX11")]
    public static partial int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XFreeModifiermap(XModifierKeymap* param0);

    [LibraryImport("libX11")]
    public static partial int XFreePixmap(Display* param0, Pixmap param1);

    [LibraryImport("libX11")]
    public static partial int XGeometry(Display* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, int* param9, int* param10, int* param11, int* param12);

    [LibraryImport("libX11")]
    public static partial int XGetErrorDatabaseText(Display* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XGetErrorText(Display* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XGetGeometry(Display* param0, Drawable param1, Window* param2, int* param3, int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XGetIconName(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XGetInputFocus(Display* param0, Window* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XGetKeyboardControl(Display* param0, XKeyboardState* param1);

    [LibraryImport("libX11")]
    public static partial int XGetPointerControl(Display* param0, int* param1, int* param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetPointerMapping(Display* param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetScreenSaver(Display* param0, int* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XGetTransientForHint(Display* param0, Window param1, Window* param2);

    [LibraryImport("libX11")]
    public static partial int XGetWindowProperty(Display* param0, Window param1, Atom param2, [NativeTypeName("long")] nint param3, [NativeTypeName("long")] nint param4, int param5, Atom param6, Atom* param7, int* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10, [NativeTypeName("unsigned char **")] byte** param11);

    [LibraryImport("libX11")]
    public static partial int XGetWindowAttributes(Display* param0, Window param1, XWindowAttributes* param2);

    [LibraryImport("libX11")]
    public static partial int XGrabButton(Display* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, Window param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, Window param8, Cursor param9);

    [LibraryImport("libX11")]
    public static partial int XGrabKey(Display* param0, int param1, [NativeTypeName("unsigned int")] uint param2, Window param3, int param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XGrabKeyboard(Display* param0, Window param1, int param2, int param3, int param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XGrabPointer(Display* param0, Window param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, Window param6, Cursor param7, Time param8);

    [LibraryImport("libX11")]
    public static partial int XGrabServer(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XHeightMMOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XHeightOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XImageByteOrder(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XInstallColormap(Display* param0, Colormap param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("KeyCode")]
    public static partial byte XKeysymToKeycode(Display* param0, KeySym param1);

    [LibraryImport("libX11")]
    public static partial int XLookupColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [LibraryImport("libX11")]
    public static partial int XLowerWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XMapRaised(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XMapSubwindows(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XMapWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XMaskEvent(Display* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XMaxCmapsOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XMinCmapsOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XMoveResizeWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

    [LibraryImport("libX11")]
    public static partial int XMoveWindow(Display* param0, Window param1, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XNextEvent(Display* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XNoOp(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XParseColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, int* param1, int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

    [LibraryImport("libX11")]
    public static partial int XPeekEvent(Display* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XPeekIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XPending(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XPlanesOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XProtocolRevision(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XProtocolVersion(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XPutBackEvent(Display* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XQLength(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XQueryBestCursor(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestSize(Display* param0, int param1, Drawable param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

    [LibraryImport("libX11")]
    public static partial int XQueryBestStipple(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestTile(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryColor(Display* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XQueryColors(Display* param0, Colormap param1, XColor* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XQueryExtension(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XQueryKeymap(Display* param0, [NativeTypeName("char[32]")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial int XQueryPointer(Display* param0, Window param1, Window* param2, Window* param3, int* param4, int* param5, int* param6, int* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XQueryTree(Display* param0, Window param1, Window* param2, Window* param3, Window** param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XRaiseWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFile(Display* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, Pixmap* param5, int* param6, int* param7);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, int* param4, int* param5);

    [LibraryImport("libX11")]
    public static partial int XRebindKeysym(Display* param0, KeySym param1, KeySym* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XRecolorCursor(Display* param0, Cursor param1, XColor* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XRefreshKeyboardMapping(XMappingEvent* param0);

    [LibraryImport("libX11")]
    public static partial int XRemoveFromSaveSet(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XRemoveHost(Display* param0, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XRemoveHosts(Display* param0, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XReparentWindow(Display* param0, Window param1, Window param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XResetScreenSaver(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XResizeWindow(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XRestackWindows(Display* param0, Window* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XRotateBuffers(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XRotateWindowProperties(Display* param0, Window param1, Atom* param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XScreenCount(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XSelectInput(Display* param0, Window param1, [NativeTypeName("long")] nint param2);

    [LibraryImport("libX11")]
    public static partial int XSendEvent(Display* param0, Window param1, int param2, [NativeTypeName("long")] nint param3, XEvent* param4);

    [LibraryImport("libX11")]
    public static partial int XSetAccessControl(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCloseDownMode(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCommand(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XSetIconName(Display* param0, Window param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial int XSetInputFocus(Display* param0, Window param1, int param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetModifierMapping(Display* param0, XModifierKeymap* param1);

    [LibraryImport("libX11")]
    public static partial int XSetPointerMapping(Display* param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XSetScreenSaver(Display* param0, int param1, int param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSetSelectionOwner(Display* param0, Atom param1, Window param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackground(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackgroundPixmap(Display* param0, Window param1, Pixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorder(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderPixmap(Display* param0, Window param1, Pixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderWidth(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowColormap(Display* param0, Window param1, Colormap param2);

    [LibraryImport("libX11")]
    public static partial int XStoreBuffer(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XStoreBytes(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColor(Display* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColors(Display* param0, Colormap param1, XColor* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XStoreName(Display* param0, Window param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial int XStoreNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] nuint param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSync(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XTranslateCoordinates(Display* param0, Window param1, Window param2, int param3, int param4, int* param5, int* param6, Window* param7);

    [LibraryImport("libX11")]
    public static partial int XUndefineCursor(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabButton(Display* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, Window param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKey(Display* param0, int param1, [NativeTypeName("unsigned int")] uint param2, Window param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKeyboard(Display* param0, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabPointer(Display* param0, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabServer(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XUninstallColormap(Display* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial int XUnmapSubwindows(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XUnmapWindow(Display* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XVendorRelease(Display* param0);

    [LibraryImport("libX11")]
    public static partial int XWarpPointer(Display* param0, Window param1, Window param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

    [LibraryImport("libX11")]
    public static partial int XWidthMMOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XWidthOfScreen(Screen* param0);

    [LibraryImport("libX11")]
    public static partial int XWindowEvent(Display* param0, Window param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XWriteBitmapFile(Display* param0, [NativeTypeName("const char *")] sbyte* param1, Pixmap param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XSupportsLocale();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial int XFilterEvent(XEvent* param0, Window param1);

    [LibraryImport("libX11")]
    public static partial int XRegisterIMInstantiateCallback(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<Display*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XUnregisterIMInstantiateCallback(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<Display*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XInternalConnectionNumbers(Display* param0, int** param1, int* param2);

    [LibraryImport("libX11")]
    public static partial void XProcessInternalConnection(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XAddConnectionWatch(Display* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<Display*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XRemoveConnectionWatch(Display* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<Display*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int _Xmbtowc([NativeTypeName("wchar_t *")] uint* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] uint param1);

    [LibraryImport("libX11")]
    public static partial int XGetEventData(Display* param0, XGenericEventCookie* param1);

    [LibraryImport("libX11")]
    public static partial void XFreeEventData(Display* param0, XGenericEventCookie* param1);

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
