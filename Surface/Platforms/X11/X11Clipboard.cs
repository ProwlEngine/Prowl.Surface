// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Prowl.Surface.Platforms.X11;


[SupportedOSPlatform("linux")]
internal sealed unsafe class X11Clipboard : ClipboardImpl
{
    public override void Clear() => throw new NotImplementedException();

    public override T? GetData<T>(DataFormat<T> mimeFormat) where T : class => throw new NotImplementedException();

    public override List<DataFormat> GetDataFormats() => throw new NotImplementedException();

    public override void Notify(DataTransferResult result) => throw new NotImplementedException();

    public override DataFormat<T> Register<T>(string mimeName, IDataFormatSerializer<T> serializer) => throw new NotImplementedException();

    public override bool SetData<T>(DataFormat<T> mimeFormat, T data) => throw new NotImplementedException();

    public override void SetData(ClipboardData data) => throw new NotImplementedException();
}
