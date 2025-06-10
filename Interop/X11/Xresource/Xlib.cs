// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* Xpermalloc([NativeTypeName("unsigned int")] uint param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XrmQuark")]
    public static partial int XrmStringToQuark([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XrmQuark")]
    public static partial int XrmPermStringToQuark([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XrmString")]
    public static partial sbyte* XrmQuarkToString([NativeTypeName("XrmQuark")] int param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XrmQuark")]
    public static partial int XrmUniqueQuark();

    [LibraryImport("libX11")]
    public static partial void XrmStringToQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmQuarkList")] int* param1);

    [LibraryImport("libX11")]
    public static partial void XrmStringToBindingQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2);

    [LibraryImport("libX11")]
    public static partial void XrmDestroyDatabase(XrmDatabase param0);

    [LibraryImport("libX11")]
    public static partial void XrmQPutResource(XrmDatabase* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("XrmRepresentation")] int param3, XrmValue* param4);

    [LibraryImport("libX11")]
    public static partial void XrmPutResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, XrmValue* param3);

    [LibraryImport("libX11")]
    public static partial void XrmQPutStringResource(XrmDatabase* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("const char *")] sbyte* param3);

    [LibraryImport("libX11")]
    public static partial void XrmPutStringResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial void XrmPutLineResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial int XrmQGetResource(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmRepresentation *")] int* param3, XrmValue* param4);

    [LibraryImport("libX11")]
    public static partial int XrmGetResource(XrmDatabase param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("char **")] sbyte** param3, XrmValue* param4);

    [LibraryImport("libX11")]
    public static partial int XrmQGetSearchList(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmSearchList")] XrmHashBucket** param3, int param4);

    [LibraryImport("libX11")]
    public static partial int XrmQGetSearchResource([NativeTypeName("XrmSearchList")] XrmHashBucket** param0, [NativeTypeName("XrmName")] int param1, [NativeTypeName("XrmClass")] int param2, [NativeTypeName("XrmRepresentation *")] int* param3, XrmValue* param4);

    [LibraryImport("libX11")]
    public static partial void XrmSetDatabase(XDisplay* display, XrmDatabase param1);

    [LibraryImport("libX11")]
    public static partial XrmDatabase XrmGetDatabase(XDisplay* display);

    [LibraryImport("libX11")]
    public static partial XrmDatabase XrmGetFileDatabase([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial int XrmCombineFileDatabase([NativeTypeName("const char *")] sbyte* param0, XrmDatabase* param1, int param2);

    [LibraryImport("libX11")]
    public static partial XrmDatabase XrmGetStringDatabase([NativeTypeName("const char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial void XrmPutFileDatabase(XrmDatabase param0, [NativeTypeName("const char *")] sbyte* param1);

    [LibraryImport("libX11")]
    public static partial void XrmMergeDatabases(XrmDatabase param0, XrmDatabase* param1);

    [LibraryImport("libX11")]
    public static partial void XrmCombineDatabase(XrmDatabase param0, XrmDatabase* param1, int param2);

    [LibraryImport("libX11")]
    public static partial int XrmEnumerateDatabase(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, int param3, [NativeTypeName("int (*)(XrmDatabase *, XrmBindingList, XrmQuarkList, XrmRepresentation *, XrmValue *, XPointer)")] delegate* unmanaged<XrmDatabase*, XrmBinding*, int*, int*, XrmValue*, sbyte*, int> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [LibraryImport("libX11")]
    [return: NativeTypeName("const char *")]
    public static partial sbyte* XrmLocaleOfDatabase(XrmDatabase param0);

    [LibraryImport("libX11")]
    public static partial void XrmParseCommand(XrmDatabase* param0, [NativeTypeName("XrmOptionDescList")] XrmOptionDescRec* param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int* param4, [NativeTypeName("char **")] sbyte** param5);

    [NativeTypeName("#define NULLQUARK ((XrmQuark) 0)")]
    public const int NULLQUARK = ((int)(0));

    [NativeTypeName("#define NULLSTRING ((XrmString) 0)")]
    public static sbyte* NULLSTRING => ((sbyte*)(0));

    [NativeTypeName("#define XrmEnumAllLevels 0")]
    public const int XrmEnumAllLevels = 0;

    [NativeTypeName("#define XrmEnumOneLevel 1")]
    public const int XrmEnumOneLevel = 1;
}
