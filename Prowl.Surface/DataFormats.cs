﻿using System;
using System.ComponentModel;

namespace Prowl.Surface.Input;

public static class DataFormats
{
    /// <summary>
    /// Dataformat for plaintext
    /// </summary>
    public static readonly string Text = nameof(Text);

    /// <summary>
    /// Dataformat for one or more files.
    /// </summary>
    public static readonly string Files = nameof(Files);

    /// <summary>
    /// Dataformat for one or more filenames
    /// </summary>
    [Obsolete("Use DataFormats.Files, this format is supported only on desktop platforms."), EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly string FileNames = nameof(FileNames);
}
