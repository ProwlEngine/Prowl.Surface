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
    public static partial XTimeCoord* XGetMotionEvents(XDisplay* param0, XWindow param1, Time param2, Time param3, int* param4);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XDeleteModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XGetModifierMapping(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XInsertModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial XModifierKeymap* XNewModifiermap(int param0);

    [LibraryImport("libX11")]
    public static partial XImage* XCreateImage(XDisplay* param0, Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

    [LibraryImport("libX11")]
    public static partial int XInitImage(XImage* param0);

    [LibraryImport("libX11")]
    public static partial XImage* XGetImage(XDisplay* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7);

    [LibraryImport("libX11")]
    public static partial XImage* XGetSubImage(XDisplay* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7, XImage* param8, int param9, int param10);

    [LibraryImport("libX11")]
    public static partial XDisplay* XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial void XrmInitialize();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBytes(XDisplay* param0, int* param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XFetchBuffer(XDisplay* param0, int* param1, int param2);

    [LibraryImport("libX11")]
    public static partial byte* XGetAtomName(XDisplay* param0, Atom param1);

    public static string GetAtomName(XDisplay* display, Atom atom)
    {
        byte* atoms = XGetAtomName(display, atom);

        string name = Marshal.PtrToStringAnsi((nint)atoms) ?? "";

        XFree(atoms);

        return name;
    }

    [LibraryImport("libX11")]
    public static partial int XGetAtomNames(XDisplay* param0, Atom* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XGetDefault(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XKeysymToString(KeySym param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<XDisplay*, int> XSynchronize(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("int (*)(Display *)")]
    public static partial delegate* unmanaged<XDisplay*, int> XSetAfterFunction(XDisplay* param0, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged<XDisplay*, int> param1);

    [LibraryImport("libX11")]
    public static partial Atom XInternAtom(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XInternAtoms(XDisplay* param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, Atom* param4);

    [LibraryImport("libX11")]
    public static partial Colormap XCopyColormapAndFree(XDisplay* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial Colormap XCreateColormap(XDisplay* param0, XWindow param1, Visual* param2, int param3);

    [LibraryImport("libX11")]
    public static partial Cursor XCreatePixmapCursor(XDisplay* param0, Pixmap param1, Pixmap param2, XColor* param3, XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

    [LibraryImport("libX11")]
    public static partial Cursor XCreateFontCursor(XDisplay* param0, [NativeTypeName("unsigned int")] uint param1);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreatePixmap(XDisplay* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreateBitmapFromData(XDisplay* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [LibraryImport("libX11")]
    public static partial Pixmap XCreatePixmapFromBitmapData(XDisplay* param0, Drawable param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] nuint param5, [NativeTypeName("unsigned long")] nuint param6, [NativeTypeName("unsigned int")] uint param7);

    [LibraryImport("libX11")]
    public static partial XWindow XCreateSimpleWindow(XDisplay* param0, XWindow param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] nuint param7, [NativeTypeName("unsigned long")] nuint param8);

    [LibraryImport("libX11")]
    public static partial XWindow XGetSelectionOwner(XDisplay* param0, Atom param1);

    [LibraryImport("libX11")]
    public static partial XWindow XCreateWindow(XDisplay* param0, XWindow param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, Visual* param9, [NativeTypeName("unsigned long")] nuint param10, XSetWindowAttributes* param11);

    [LibraryImport("libX11")]
    public static partial Colormap* XListInstalledColormaps(XDisplay* param0, XWindow param1, int* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char **")]
    public static partial sbyte** XListExtensions(XDisplay* param0, int* param1);

    [LibraryImport("libX11")]
    public static partial Atom* XListProperties(XDisplay* param0, XWindow param1, int* param2);

    [LibraryImport("libX11")]
    public static partial XHostAddress* XListHosts(XDisplay* param0, int* param1, int* param2);

    [LibraryImport("libX11")]
    [Obsolete]
    public static partial KeySym XKeycodeToKeysym(XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [LibraryImport("libX11")]
    public static partial KeySym XLookupKeysym(XKeyEvent* param0, int param1);

    [LibraryImport("libX11")]
    public static partial KeySym* XGetKeyboardMapping(XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int* param3);

    [LibraryImport("libX11")]
    public static partial KeySym XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XMaxRequestSize(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("long")]
    public static partial nint XExtendedMaxRequestSize(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XResourceManagerString(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XScreenResourceString(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XDisplayMotionBufferSize(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial VisualID XVisualIDFromVisual(Visual* param0);

    [LibraryImport("libX11")]
    public static partial int XInitThreads();

    [LibraryImport("libX11")]
    public static partial void XLockDisplay(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial void XUnlockDisplay(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XInitExtension(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial XExtCodes* XAddExtension(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial XExtData* XFindOnExtensionList(XExtData** param0, int param1);

    [LibraryImport("libX11")]
    public static partial XWindow XRootWindow(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial XWindow XDefaultRootWindow(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial XWindow XRootWindowOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisual(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Visual* XDefaultVisualOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XBlackPixel(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XWhitePixel(XDisplay* param0, int param1);

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
    public static partial nuint XNextRequest(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("unsigned long")]
    public static partial nuint XLastKnownRequestProcessed(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XServerVendor(XDisplay* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XDisplayString(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial Colormap XDefaultColormap(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Colormap XDefaultColormapOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial XDisplay* XDisplayOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial XScreen* XScreenOfDisplay(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial XScreen* XDefaultScreenOfDisplay(XDisplay* param0);

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
    public static partial void XSetIOErrorExitHandler(XDisplay* param0, [NativeTypeName("XIOErrorExitHandler")] delegate* unmanaged<XDisplay*, void*, void> param1, void* param2);

    [LibraryImport("libX11")]
    public static partial XPixmapFormatValues* XListPixmapFormats(XDisplay* param0, int* param1);

    [LibraryImport("libX11")]
    public static partial int* XListDepths(XDisplay* param0, int param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XReconfigureWMWindow(XDisplay* param0, XWindow param1, int param2, [NativeTypeName("unsigned int")] uint param3, XWindowChanges* param4);

    [LibraryImport("libX11")]
    public static partial int XGetWMProtocols(XDisplay* param0, XWindow param1, Atom** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMProtocols(XDisplay* param0, XWindow param1, Atom* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XIconifyWindow(XDisplay* param0, XWindow param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XWithdrawWindow(XDisplay* param0, XWindow param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetCommand(XDisplay* param0, XWindow param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetWMColormapWindows(XDisplay* param0, XWindow param1, XWindow** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XSetWMColormapWindows(XDisplay* param0, XWindow param1, XWindow* param2, int param3);

    [LibraryImport("libX11")]
    public static partial void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XSetTransientForHint(XDisplay* param0, XWindow param1, XWindow param2);

    [LibraryImport("libX11")]
    public static partial int XActivateScreenSaver(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XAddHost(XDisplay* param0, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XAddHosts(XDisplay* param0, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XAddToExtensionList([NativeTypeName("struct _XExtData **")] XExtData** param0, XExtData* param1);

    [LibraryImport("libX11")]
    public static partial int XAddToSaveSet(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XAllocColor(XDisplay* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XAllocColorCells(XDisplay* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] nuint* param5, [NativeTypeName("unsigned int")] uint param6);

    [LibraryImport("libX11")]
    public static partial int XAllocColorPlanes(XDisplay* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

    [LibraryImport("libX11")]
    public static partial int XAllocNamedColor(XDisplay* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [LibraryImport("libX11")]
    public static partial int XAllowEvents(XDisplay* param0, int param1, Time param2);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOff(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XAutoRepeatOn(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XBell(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XBitmapBitOrder(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XBitmapPad(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XBitmapUnit(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XCellsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XChangeActivePointerGrab(XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, Cursor param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardControl(XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, XKeyboardControl* param2);

    [LibraryImport("libX11")]
    public static partial int XChangeKeyboardMapping(XDisplay* param0, int param1, int param2, KeySym* param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XChangePointerControl(XDisplay* param0, int param1, int param2, int param3, int param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XChangeProperty(XDisplay* param0, XWindow param1, Atom param2, Atom param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

    [LibraryImport("libX11")]
    public static partial int XChangeSaveSet(XDisplay* param0, XWindow param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XChangeWindowAttributes(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned long")] nuint param2, XSetWindowAttributes* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckIfEvent(XDisplay* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckMaskEvent(XDisplay* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedEvent(XDisplay* param0, int param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XCheckTypedWindowEvent(XDisplay* param0, XWindow param1, int param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCheckWindowEvent(XDisplay* param0, XWindow param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindows(XDisplay* param0, XWindow param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsDown(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XCirculateSubwindowsUp(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XClearArea(XDisplay* param0, XWindow param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XClearWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XCloseDisplay(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XConfigureWindow(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned int")] uint param2, XWindowChanges* param3);

    [LibraryImport("libX11")]
    public static partial int XConnectionNumber(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XConvertSelection(XDisplay* param0, Atom param1, Atom param2, Atom param3, XWindow param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepth(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDefaultDepthOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDefaultScreen(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XDefineCursor(XDisplay* param0, XWindow param1, Cursor param2);

    [LibraryImport("libX11")]
    public static partial int XDeleteProperty(XDisplay* param0, XWindow param1, Atom param2);

    [LibraryImport("libX11")]
    public static partial int XDestroyWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XDestroySubwindows(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XDoesBackingStore(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDoesSaveUnders(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XDisableAccessControl(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XDisplayCells(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeight(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayHeightMM(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayKeycodes(XDisplay* param0, int* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XDisplayPlanes(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidth(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XDisplayWidthMM(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XEnableAccessControl(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XEventsQueued(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XFetchName(XDisplay* param0, XWindow param1, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XFlush(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XForceScreenSaver(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XFree(void* param0);

    [LibraryImport("libX11")]
    public static partial int XFreeColormap(XDisplay* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial int XFreeColors(XDisplay* param0, Colormap param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, [NativeTypeName("unsigned long")] nuint param4);

    [LibraryImport("libX11")]
    public static partial int XFreeCursor(XDisplay* param0, Cursor param1);

    [LibraryImport("libX11")]
    public static partial int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

    [LibraryImport("libX11")]
    public static partial int XFreeModifiermap(XModifierKeymap* param0);

    [LibraryImport("libX11")]
    public static partial int XFreePixmap(XDisplay* param0, Pixmap param1);

    [LibraryImport("libX11")]
    public static partial int XGeometry(XDisplay* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, int* param9, int* param10, int* param11, int* param12);

    [LibraryImport("libX11")]
    public static partial int XGetErrorDatabaseText(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XGetErrorText(XDisplay* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XGetGeometry(XDisplay* param0, Drawable param1, XWindow* param2, int* param3, int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XGetIconName(XDisplay* param0, XWindow param1, [NativeTypeName("char **")] sbyte** param2);

    [LibraryImport("libX11")]
    public static partial int XGetInputFocus(XDisplay* param0, XWindow* param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XGetKeyboardControl(XDisplay* param0, XKeyboardState* param1);

    [LibraryImport("libX11")]
    public static partial int XGetPointerControl(XDisplay* param0, int* param1, int* param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetPointerMapping(XDisplay* param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XGetScreenSaver(XDisplay* param0, int* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XGetTransientForHint(XDisplay* param0, XWindow param1, XWindow* param2);

    [LibraryImport("libX11")]
    public static partial int XGetWindowProperty(XDisplay* param0, XWindow param1, Atom param2, [NativeTypeName("long")] nint param3, [NativeTypeName("long")] nint param4, int param5, Atom param6, Atom* param7, int* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10, [NativeTypeName("unsigned char **")] byte** param11);

    [LibraryImport("libX11")]
    public static partial int XGetWindowAttributes(XDisplay* param0, XWindow param1, XWindowAttributes* param2);

    [LibraryImport("libX11")]
    public static partial int XGrabButton(XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, XWindow param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, XWindow param8, Cursor param9);

    [LibraryImport("libX11")]
    public static partial int XGrabKey(XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, XWindow param3, int param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XGrabKeyboard(XDisplay* param0, XWindow param1, int param2, int param3, int param4, Time param5);

    [LibraryImport("libX11")]
    public static partial int XGrabPointer(XDisplay* param0, XWindow param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, XWindow param6, Cursor param7, Time param8);

    [LibraryImport("libX11")]
    public static partial int XGrabServer(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XHeightMMOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XHeightOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XIfEvent(XDisplay* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XImageByteOrder(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XInstallColormap(XDisplay* param0, Colormap param1);

    [LibraryImport("libX11")]
    [return: NativeTypeName("KeyCode")]
    public static partial byte XKeysymToKeycode(XDisplay* param0, KeySym param1);

    [LibraryImport("libX11")]
    public static partial int XLookupColor(XDisplay* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [LibraryImport("libX11")]
    public static partial int XLowerWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XMapRaised(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XMapSubwindows(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XMapWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XMaskEvent(XDisplay* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [LibraryImport("libX11")]
    public static partial int XMaxCmapsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XMinCmapsOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XMoveResizeWindow(XDisplay* param0, XWindow param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

    [LibraryImport("libX11")]
    public static partial int XMoveWindow(XDisplay* param0, XWindow param1, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XNextEvent(XDisplay* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XNoOp(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XParseColor(XDisplay* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, int* param1, int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

    [LibraryImport("libX11")]
    public static partial int XPeekEvent(XDisplay* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XPeekIfEvent(XDisplay* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<XDisplay*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial int XPending(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XPlanesOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XProtocolRevision(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XProtocolVersion(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XPutBackEvent(XDisplay* param0, XEvent* param1);

    [LibraryImport("libX11")]
    public static partial int XQLength(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XQueryBestCursor(XDisplay* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestSize(XDisplay* param0, int param1, Drawable param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

    [LibraryImport("libX11")]
    public static partial int XQueryBestStipple(XDisplay* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryBestTile(XDisplay* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XQueryColor(XDisplay* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XQueryColors(XDisplay* param0, Colormap param1, XColor* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XQueryExtension(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int* param2, int* param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XQueryKeymap(XDisplay* param0, [NativeTypeName("char[32]")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial int XQueryPointer(XDisplay* param0, XWindow param1, XWindow* param2, XWindow* param3, int* param4, int* param5, int* param6, int* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [LibraryImport("libX11")]
    public static partial int XQueryTree(XDisplay* param0, XWindow param1, XWindow* param2, XWindow* param3, XWindow** param4, [NativeTypeName("unsigned int *")] uint* param5);

    [LibraryImport("libX11")]
    public static partial int XRaiseWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFile(XDisplay* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, Pixmap* param5, int* param6, int* param7);

    [LibraryImport("libX11")]
    public static partial int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, int* param4, int* param5);

    [LibraryImport("libX11")]
    public static partial int XRebindKeysym(XDisplay* param0, KeySym param1, KeySym* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

    [LibraryImport("libX11")]
    public static partial int XRecolorCursor(XDisplay* param0, Cursor param1, XColor* param2, XColor* param3);

    [LibraryImport("libX11")]
    public static partial int XRefreshKeyboardMapping(XMappingEvent* param0);

    [LibraryImport("libX11")]
    public static partial int XRemoveFromSaveSet(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XRemoveHost(XDisplay* param0, XHostAddress* param1);

    [LibraryImport("libX11")]
    public static partial int XRemoveHosts(XDisplay* param0, XHostAddress* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XReparentWindow(XDisplay* param0, XWindow param1, XWindow param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XResetScreenSaver(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XResizeWindow(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XRestackWindows(XDisplay* param0, XWindow* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XRotateBuffers(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XRotateWindowProperties(XDisplay* param0, XWindow param1, Atom* param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XScreenCount(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XSelectInput(XDisplay* param0, XWindow param1, [NativeTypeName("long")] nint param2);

    [LibraryImport("libX11")]
    public static partial int XSendEvent(XDisplay* param0, XWindow param1, int param2, [NativeTypeName("long")] nint param3, XEvent* param4);

    [LibraryImport("libX11")]
    public static partial int XSetAccessControl(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCloseDownMode(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XSetCommand(XDisplay* param0, XWindow param1, [NativeTypeName("char **")] sbyte** param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XSetIconName(XDisplay* param0, XWindow param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial int XSetInputFocus(XDisplay* param0, XWindow param1, int param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetModifierMapping(XDisplay* param0, XModifierKeymap* param1);

    [LibraryImport("libX11")]
    public static partial int XSetPointerMapping(XDisplay* param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XSetScreenSaver(XDisplay* param0, int param1, int param2, int param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSetSelectionOwner(XDisplay* param0, Atom param1, XWindow param2, Time param3);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackground(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned long")] nuint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBackgroundPixmap(XDisplay* param0, XWindow param1, Pixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorder(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned long")] nuint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderPixmap(XDisplay* param0, XWindow param1, Pixmap param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowBorderWidth(XDisplay* param0, XWindow param1, [NativeTypeName("unsigned int")] uint param2);

    [LibraryImport("libX11")]
    public static partial int XSetWindowColormap(XDisplay* param0, XWindow param1, Colormap param2);

    [LibraryImport("libX11")]
    public static partial int XStoreBuffer(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XStoreBytes(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColor(XDisplay* param0, Colormap param1, XColor* param2);

    [LibraryImport("libX11")]
    public static partial int XStoreColors(XDisplay* param0, Colormap param1, XColor* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XStoreName(XDisplay* param0, XWindow param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial int XStoreNamedColor(XDisplay* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] nuint param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XSync(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XTranslateCoordinates(XDisplay* param0, XWindow param1, XWindow param2, int param3, int param4, int* param5, int* param6, XWindow* param7);

    [LibraryImport("libX11")]
    public static partial int XUndefineCursor(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabButton(XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, XWindow param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKey(XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, XWindow param3);

    [LibraryImport("libX11")]
    public static partial int XUngrabKeyboard(XDisplay* param0, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabPointer(XDisplay* param0, Time param1);

    [LibraryImport("libX11")]
    public static partial int XUngrabServer(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XUninstallColormap(XDisplay* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial int XUnmapSubwindows(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XUnmapWindow(XDisplay* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XVendorRelease(XDisplay* param0);

    [LibraryImport("libX11")]
    public static partial int XWarpPointer(XDisplay* param0, XWindow param1, XWindow param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

    [LibraryImport("libX11")]
    public static partial int XWidthMMOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XWidthOfScreen(XScreen* param0);

    [LibraryImport("libX11")]
    public static partial int XWindowEvent(XDisplay* param0, XWindow param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [LibraryImport("libX11")]
    public static partial int XWriteBitmapFile(XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, Pixmap param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

    [LibraryImport("libX11")]
    public static partial int XSupportsLocale();

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial int XFilterEvent(XEvent* param0, XWindow param1);

    [LibraryImport("libX11")]
    public static partial int XRegisterIMInstantiateCallback(XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XUnregisterIMInstantiateCallback(XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    public static partial int XInternalConnectionNumbers(XDisplay* param0, int** param1, int* param2);

    [LibraryImport("libX11")]
    public static partial void XProcessInternalConnection(XDisplay* param0, int param1);

    [LibraryImport("libX11")]
    public static partial int XAddConnectionWatch(XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XRemoveConnectionWatch(XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int _Xmbtowc([NativeTypeName("wchar_t *")] uint* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] uint param1);

    [LibraryImport("libX11")]
    public static partial int XGetEventData(XDisplay* param0, XGenericEventCookie* param1);

    [LibraryImport("libX11")]
    public static partial void XFreeEventData(XDisplay* param0, XGenericEventCookie* param1);

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
