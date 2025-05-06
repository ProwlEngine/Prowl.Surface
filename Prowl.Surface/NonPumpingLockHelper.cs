﻿using System;

using Prowl.Surface.Threading;

namespace Prowl.Surface.Utilities;

internal class NonPumpingLockHelper
{
    public interface IHelperImpl
    {
        int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout);
    }

    public static IDisposable? Use()
    {
        var impl = AvaloniaLocator.Current.GetService<IHelperImpl>();
        if (impl == null)
            return null;
        return NonPumpingSyncContext.Use(impl);
    }
}
