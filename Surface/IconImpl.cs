// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Prowl.Surface;

/// <summary>
/// Internal Icon abstract class that requires a platform dependent implementation.
/// </summary>
internal abstract class IconImpl
{
    public abstract Icon GetApplicationIcon();
}
