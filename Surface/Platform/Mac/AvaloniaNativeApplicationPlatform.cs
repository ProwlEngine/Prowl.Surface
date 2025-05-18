using System;

using Prowl.Surface.Controls.ApplicationLifetimes;
using Prowl.Surface.Mac.Interop;

namespace Prowl.Surface.Native;

internal class AvaloniaNativeApplicationPlatform : NativeCallbackBase, IAvnApplicationEvents
{
    public event EventHandler<ShutdownRequestedEventArgs> ShutdownRequested;

    void IAvnApplicationEvents.FilesOpened(IAvnStringArray urls)
    {
        //((IApplicationPlatformEvents)Application.Current).RaiseUrlsOpened(urls.ToStringArray());
    }

    public int TryShutdown()
    {
        if (ShutdownRequested is null) return 1;
        var e = new ShutdownRequestedEventArgs();
        ShutdownRequested(this, e);
        return (!e.Cancel).AsComBool();
    }
}
