// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [LibraryImport("libX11")]
    public static partial int XcmsAddColorSpace(XcmsColorSpace* param0);

    [LibraryImport("libX11")]
    public static partial int XcmsAddFunctionSet(XcmsFunctionSet* param0);

    [LibraryImport("libX11")]
    public static partial int XcmsAllocColor(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsAllocNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XcmsColor* param3, XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

    [LibraryImport("libX11")]
    public static partial XcmsCCC XcmsCCCOfColormap(Display* param0, Colormap param1);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabClipab(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabClipL(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabClipLab(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabQueryMaxL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabQueryMaxLC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabQueryMinL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELabWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvClipL(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvClipLuv(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvClipuv(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvQueryMaxL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvQueryMaxLC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvQueryMinL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIELuvWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEXYZToCIELab(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEXYZToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEXYZToCIExyY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEXYZToRGBi(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEuvYToCIELuv(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEuvYToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIEuvYToTekHVC(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsCIExyYToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial XcmsColor* XcmsClientWhitePointOfCCC(XcmsCCC param0);

    [LibraryImport("libX11")]
    public static partial int XcmsConvertColors(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XcmsColorFormat")] nuint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial XcmsCCC XcmsCreateCCC(Display* param0, int param1, Visual* param2, XcmsColor* param3, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> param4, [NativeTypeName("XPointer")] sbyte* param5, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param6, [NativeTypeName("XPointer")] sbyte* param7);

    [LibraryImport("libX11")]
    public static partial XcmsCCC XcmsDefaultCCC(Display* param0, int param1);

    [LibraryImport("libX11")]
    public static partial Display* XcmsDisplayOfCCC(XcmsCCC param0);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XcmsColorFormat")]
    public static partial nuint XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* param0);

    [LibraryImport("libX11")]
    public static partial void XcmsFreeCCC(XcmsCCC param0);

    [LibraryImport("libX11")]
    public static partial int XcmsLookupColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XcmsColor* param3, XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

    [LibraryImport("libX11")]
    [return: NativeTypeName("char *")]
    public static partial sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] nuint param0);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryBlack(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryBlue(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryColor(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryColors(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XcmsColorFormat")] nuint param4);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryGreen(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryRed(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsQueryWhite(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsRGBiToCIEXYZ(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsRGBiToRGB(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsRGBToRGBi(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsScreenNumberOfCCC(XcmsCCC param0);

    [LibraryImport("libX11")]
    public static partial XcmsColor* XcmsScreenWhitePointOfCCC(XcmsCCC param0);

    [LibraryImport("libX11")]
    public static partial XcmsCCC XcmsSetCCCOfColormap(Display* param0, Colormap param1, XcmsCCC param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XcmsCompressionProc")]
    public static partial delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> XcmsSetCompressionProc(XcmsCCC param0, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    [return: NativeTypeName("XcmsWhiteAdjustProc")]
    public static partial delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> XcmsSetWhiteAdjustProc(XcmsCCC param0, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsSetWhitePoint(XcmsCCC param0, XcmsColor* param1);

    [LibraryImport("libX11")]
    public static partial int XcmsStoreColor(Display* param0, Colormap param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsStoreColors(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCClipC(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCClipV(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCClipVC(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCQueryMaxV(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCQueryMaxVC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCQueryMaxVSamples(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCQueryMinV(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [LibraryImport("libX11")]
    public static partial int XcmsTekHVCWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [LibraryImport("libX11")]
    public static partial Visual* XcmsVisualOfCCC(XcmsCCC param0);

    [NativeTypeName("#define XcmsFailure 0")]
    public const int XcmsFailure = 0;

    [NativeTypeName("#define XcmsSuccess 1")]
    public const int XcmsSuccess = 1;

    [NativeTypeName("#define XcmsSuccessWithCompression 2")]
    public const int XcmsSuccessWithCompression = 2;

    [NativeTypeName("#define XcmsUndefinedFormat (XcmsColorFormat)0x00000000")]
    public const nuint XcmsUndefinedFormat = (nuint)(0x00000000);

    [NativeTypeName("#define XcmsCIEXYZFormat (XcmsColorFormat)0x00000001")]
    public const nuint XcmsCIEXYZFormat = (nuint)(0x00000001);

    [NativeTypeName("#define XcmsCIEuvYFormat (XcmsColorFormat)0x00000002")]
    public const nuint XcmsCIEuvYFormat = (nuint)(0x00000002);

    [NativeTypeName("#define XcmsCIExyYFormat (XcmsColorFormat)0x00000003")]
    public const nuint XcmsCIExyYFormat = (nuint)(0x00000003);

    [NativeTypeName("#define XcmsCIELabFormat (XcmsColorFormat)0x00000004")]
    public const nuint XcmsCIELabFormat = (nuint)(0x00000004);

    [NativeTypeName("#define XcmsCIELuvFormat (XcmsColorFormat)0x00000005")]
    public const nuint XcmsCIELuvFormat = (nuint)(0x00000005);

    [NativeTypeName("#define XcmsTekHVCFormat (XcmsColorFormat)0x00000006")]
    public const nuint XcmsTekHVCFormat = (nuint)(0x00000006);

    [NativeTypeName("#define XcmsRGBFormat (XcmsColorFormat)0x80000000")]
    public const nuint XcmsRGBFormat = (nuint)(0x80000000);

    [NativeTypeName("#define XcmsRGBiFormat (XcmsColorFormat)0x80000001")]
    public const nuint XcmsRGBiFormat = (nuint)(0x80000001);

    [NativeTypeName("#define XcmsInitNone 0x00")]
    public const int XcmsInitNone = 0x00;

    [NativeTypeName("#define XcmsInitSuccess 0x01")]
    public const int XcmsInitSuccess = 0x01;

    [NativeTypeName("#define XcmsInitFailure 0xff")]
    public const int XcmsInitFailure = 0xff;
}
