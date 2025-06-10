// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [LibraryImport("libX11")]
    public static partial XClassHint* XAllocClassHint();

    [LibraryImport("libX11")]
    public static partial XIconSize* XAllocIconSize();

    [LibraryImport("libX11")]
    public static partial XSizeHints* XAllocSizeHints();

    [LibraryImport("libX11")]
    public static partial XStandardColormap* XAllocStandardColormap();

    [LibraryImport("libX11")]
    public static partial XWMHints* XAllocWMHints();

    [LibraryImport("libX11")]
    public static partial int XClipBox(Region param0, XRectangle* param1);

    [LibraryImport("libX11")]
    public static partial Region XCreateRegion();

    [LibraryImport("libX11")]
    [return: NativeTypeName("const char *")]
    public static partial sbyte* XDefaultString();

    [LibraryImport("libX11")]
    public static partial int XDestroyRegion(Region param0);

    [LibraryImport("libX11")]
    public static partial int XEmptyRegion(Region param0);

    [LibraryImport("libX11")]
    public static partial int XEqualRegion(Region param0, Region param1);

    [LibraryImport("libX11")]
    public static partial int XGetClassHint(XDisplay* display, XWindow window, XClassHint* param2);

    [LibraryImport("libX11")]
    public static partial int XGetIconSizes(XDisplay* display, XWindow window, XIconSize** param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetNormalHints(XDisplay* display, XWindow window, XSizeHints* param2);

    [LibraryImport("libX11")]
    public static partial int XGetRGBColormaps(XDisplay* display, XWindow window, XStandardColormap** param2, int* param3, Atom param4);

    [LibraryImport("libX11")]
    public static partial int XGetSizeHints(XDisplay* display, XWindow window, XSizeHints* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial int XGetStandardColormap(XDisplay* display, XWindow window, XStandardColormap* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial int XGetTextProperty(XDisplay* display, XWindow window, XTextProperty* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial XVisualInfo* XGetVisualInfo(XDisplay* display, [NativeTypeName("long")] nint param1, XVisualInfo* param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XGetWMClientMachine(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial XWMHints* XGetWMHints(XDisplay* display, XWindow window);

    [LibraryImport("libX11")]
    public static partial int XGetWMIconName(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial int XGetWMName(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial int XGetWMNormalHints(XDisplay* display, XWindow window, XSizeHints* param2, [NativeTypeName("long *")] nint* param3);

    [LibraryImport("libX11")]
    public static partial int XGetWMSizeHints(XDisplay* display, XWindow window, XSizeHints* param2, [NativeTypeName("long *")] nint* param3, Atom param4);

    [LibraryImport("libX11")]
    public static partial int XGetZoomHints(XDisplay* display, XWindow window, XSizeHints* param2);

    [LibraryImport("libX11")]
    public static partial int XIntersectRegion(Region param0, Region param1, Region param2);

    [LibraryImport("libX11")]
    public static partial void XConvertCase(KeySym param0, KeySym* param1, KeySym* param2);

    [LibraryImport("libX11")]
    public static partial int XLookupString(XKeyEvent* param0, [NativeTypeName("char *")] sbyte* param1, int param2, KeySym* param3, XComposeStatus* param4);

    [LibraryImport("libX11")]
    public static partial int XMatchVisualInfo(XDisplay* display, int param1, int param2, int param3, XVisualInfo* param4);

    [LibraryImport("libX11")]
    public static partial int XOffsetRegion(Region param0, int param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XPointInRegion(Region param0, int param1, int param2);

    [LibraryImport("libX11")]
    public static partial Region XPolygonRegion(XPoint* param0, int param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XRectInRegion(Region param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [LibraryImport("libX11")]
    public static partial int XSetClassHint(XDisplay* display, XWindow window, XClassHint* param2);

    [LibraryImport("libX11")]
    public static partial int XSetIconSizes(XDisplay* display, XWindow window, XIconSize* param2, int param3);

    [LibraryImport("libX11")]
    public static partial int XSetNormalHints(XDisplay* display, XWindow window, XSizeHints* param2);

    [LibraryImport("libX11")]
    public static partial void XSetRGBColormaps(XDisplay* display, XWindow window, XStandardColormap* param2, int param3, Atom param4);

    [LibraryImport("libX11")]
    public static partial int XSetSizeHints(XDisplay* display, XWindow window, XSizeHints* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial int XSetStandardProperties(XDisplay* display, XWindow window, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, XPixmap param4, [NativeTypeName("char **")] sbyte** param5, int param6, XSizeHints* param7);

    [LibraryImport("libX11")]
    public static partial void XSetTextProperty(XDisplay* display, XWindow window, XTextProperty* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial void XSetWMClientMachine(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial int XSetWMHints(XDisplay* display, XWindow window, XWMHints* param2);

    [LibraryImport("libX11")]
    public static partial void XSetWMIconName(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial void XSetWMName(XDisplay* display, XWindow window, XTextProperty* param2);

    [LibraryImport("libX11")]
    public static partial void XSetWMNormalHints(XDisplay* display, XWindow window, XSizeHints* param2);

    [LibraryImport("libX11")]
    public static partial void XSetWMProperties(XDisplay* display, XWindow window, XTextProperty* param2, XTextProperty* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

    [LibraryImport("libX11")]
    public static partial void XmbSetWMProperties(XDisplay* display, XWindow window, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

    [LibraryImport("libX11")]
    public static partial void Xutf8SetWMProperties(XDisplay* display, XWindow window, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

    [LibraryImport("libX11")]
    public static partial void XSetWMSizeHints(XDisplay* display, XWindow window, XSizeHints* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial void XSetStandardColormap(XDisplay* display, XWindow window, XStandardColormap* param2, Atom param3);

    [LibraryImport("libX11")]
    public static partial int XSetZoomHints(XDisplay* display, XWindow window, XSizeHints* param2);

    [LibraryImport("libX11")]
    public static partial int XShrinkRegion(Region param0, int param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XStringListToTextProperty(byte** strings, int strings_count, out XTextProperty text);

    [LibraryImport("libX11")]
    public static partial int XSubtractRegion(Region param0, Region param1, Region param2);

    [LibraryImport("libX11")]
    public static partial int XmbTextListToTextProperty(XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

    [LibraryImport("libX11")]
    public static partial int XwcTextListToTextProperty(XDisplay* display, [NativeTypeName("wchar_t **")] uint** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

    [LibraryImport("libX11")]
    public static partial int Xutf8TextListToTextProperty(XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

    [LibraryImport("libX11")]
    public static partial void XwcFreeStringList([NativeTypeName("wchar_t **")] uint** list);

    [LibraryImport("libX11")]
    public static partial int XTextPropertyToStringList(XTextProperty* param0, [NativeTypeName("char ***")] sbyte*** param1, int* param2);

    [LibraryImport("libX11")]
    public static partial int XmbTextPropertyToTextList(XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, int* count_return);

    [LibraryImport("libX11")]
    public static partial int XwcTextPropertyToTextList(XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("wchar_t ***")] uint*** list_return, int* count_return);

    [LibraryImport("libX11")]
    public static partial int Xutf8TextPropertyToTextList(XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, int* count_return);

    [LibraryImport("libX11")]
    public static partial int XUnionRectWithRegion(XRectangle* param0, Region param1, Region param2);

    [LibraryImport("libX11")]
    public static partial int XUnionRegion(Region param0, Region param1, Region param2);

    [LibraryImport("libX11")]
    public static partial int XWMGeometry(XDisplay* display, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, XSizeHints* param5, int* param6, int* param7, int* param8, int* param9, int* param10);

    [LibraryImport("libX11")]
    public static partial int XXorRegion(Region param0, Region param1, Region param2);

    [NativeTypeName("#define NoValue 0x0000")]
    public const int NoValue = 0x0000;

    [NativeTypeName("#define XValue 0x0001")]
    public const int XValue = 0x0001;

    [NativeTypeName("#define YValue 0x0002")]
    public const int YValue = 0x0002;

    [NativeTypeName("#define WidthValue 0x0004")]
    public const int WidthValue = 0x0004;

    [NativeTypeName("#define HeightValue 0x0008")]
    public const int HeightValue = 0x0008;

    [NativeTypeName("#define AllValues 0x000F")]
    public const int AllValues = 0x000F;

    [NativeTypeName("#define XNegative 0x0010")]
    public const int XNegative = 0x0010;

    [NativeTypeName("#define YNegative 0x0020")]
    public const int YNegative = 0x0020;

    [NativeTypeName("#define USPosition (1L << 0)")]
    public const nint USPosition = (1 << 0);

    [NativeTypeName("#define USSize (1L << 1)")]
    public const nint USSize = (1 << 1);

    [NativeTypeName("#define PPosition (1L << 2)")]
    public const nint PPosition = (1 << 2);

    [NativeTypeName("#define PSize (1L << 3)")]
    public const nint PSize = (1 << 3);

    [NativeTypeName("#define PMinSize (1L << 4)")]
    public const nint PMinSize = (1 << 4);

    [NativeTypeName("#define PMaxSize (1L << 5)")]
    public const nint PMaxSize = (1 << 5);

    [NativeTypeName("#define PResizeInc (1L << 6)")]
    public const nint PResizeInc = (1 << 6);

    [NativeTypeName("#define PAspect (1L << 7)")]
    public const nint PAspect = (1 << 7);

    [NativeTypeName("#define PBaseSize (1L << 8)")]
    public const nint PBaseSize = (1 << 8);

    [NativeTypeName("#define PWinGravity (1L << 9)")]
    public const nint PWinGravity = (1 << 9);

    [NativeTypeName("#define PAllHints (PPosition|PSize|PMinSize|PMaxSize|PResizeInc|PAspect)")]
    public const nint PAllHints = ((1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7));

    [NativeTypeName("#define InputHint (1L << 0)")]
    public const nint InputHint = (1 << 0);

    [NativeTypeName("#define StateHint (1L << 1)")]
    public const nint StateHint = (1 << 1);

    [NativeTypeName("#define IconPixmapHint (1L << 2)")]
    public const nint IconPixmapHint = (1 << 2);

    [NativeTypeName("#define IconWindowHint (1L << 3)")]
    public const nint IconWindowHint = (1 << 3);

    [NativeTypeName("#define IconPositionHint (1L << 4)")]
    public const nint IconPositionHint = (1 << 4);

    [NativeTypeName("#define IconMaskHint (1L << 5)")]
    public const nint IconMaskHint = (1 << 5);

    [NativeTypeName("#define WindowGroupHint (1L << 6)")]
    public const nint WindowGroupHint = (1 << 6);

    [NativeTypeName("#define AllHints (InputHint|StateHint|IconPixmapHint|IconWindowHint| \\\nIconPositionHint|IconMaskHint|WindowGroupHint)")]
    public const nint AllHints = ((1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6));

    [NativeTypeName("#define XUrgencyHint (1L << 8)")]
    public const nint XUrgencyHint = (1 << 8);

    [NativeTypeName("#define WithdrawnState 0")]
    public const int WithdrawnState = 0;

    [NativeTypeName("#define NormalState 1")]
    public const int NormalState = 1;

    [NativeTypeName("#define IconicState 3")]
    public const int IconicState = 3;

    [NativeTypeName("#define DontCareState 0")]
    public const int DontCareState = 0;

    [NativeTypeName("#define ZoomState 2")]
    public const int ZoomState = 2;

    [NativeTypeName("#define InactiveState 4")]
    public const int InactiveState = 4;

    [NativeTypeName("#define XNoMemory -1")]
    public const int XNoMemory = -1;

    [NativeTypeName("#define XLocaleNotSupported -2")]
    public const int XLocaleNotSupported = -2;

    [NativeTypeName("#define XConverterNotFound -3")]
    public const int XConverterNotFound = -3;

    [NativeTypeName("#define RectangleOut 0")]
    public const int RectangleOut = 0;

    [NativeTypeName("#define RectangleIn 1")]
    public const int RectangleIn = 1;

    [NativeTypeName("#define RectanglePart 2")]
    public const int RectanglePart = 2;

    [NativeTypeName("#define VisualNoMask 0x0")]
    public const int VisualNoMask = 0x0;

    [NativeTypeName("#define VisualIDMask 0x1")]
    public const int VisualIDMask = 0x1;

    [NativeTypeName("#define VisualScreenMask 0x2")]
    public const int VisualScreenMask = 0x2;

    [NativeTypeName("#define VisualDepthMask 0x4")]
    public const int VisualDepthMask = 0x4;

    [NativeTypeName("#define VisualClassMask 0x8")]
    public const int VisualClassMask = 0x8;

    [NativeTypeName("#define VisualRedMaskMask 0x10")]
    public const int VisualRedMaskMask = 0x10;

    [NativeTypeName("#define VisualGreenMaskMask 0x20")]
    public const int VisualGreenMaskMask = 0x20;

    [NativeTypeName("#define VisualBlueMaskMask 0x40")]
    public const int VisualBlueMaskMask = 0x40;

    [NativeTypeName("#define VisualColormapSizeMask 0x80")]
    public const int VisualColormapSizeMask = 0x80;

    [NativeTypeName("#define VisualBitsPerRGBMask 0x100")]
    public const int VisualBitsPerRGBMask = 0x100;

    [NativeTypeName("#define VisualAllMask 0x1FF")]
    public const int VisualAllMask = 0x1FF;

    [NativeTypeName("#define BitmapSuccess 0")]
    public const int BitmapSuccess = 0;

    [NativeTypeName("#define BitmapOpenFailed 1")]
    public const int BitmapOpenFailed = 1;

    [NativeTypeName("#define BitmapFileInvalid 2")]
    public const int BitmapFileInvalid = 2;

    [NativeTypeName("#define BitmapNoMemory 3")]
    public const int BitmapNoMemory = 3;

    [NativeTypeName("#define XCSUCCESS 0")]
    public const int XCSUCCESS = 0;

    [NativeTypeName("#define XCNOMEM 1")]
    public const int XCNOMEM = 1;

    [NativeTypeName("#define XCNOENT 2")]
    public const int XCNOENT = 2;
}
