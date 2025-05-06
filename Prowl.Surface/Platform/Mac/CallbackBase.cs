using System;
using System.Runtime.ExceptionServices;

using Prowl.Surface.MicroCom;
using Prowl.Surface.Threading;

namespace Prowl.Surface.Native;

internal abstract class NativeCallbackBase : CallbackBase, IMicroComExceptionCallback
{
    public void RaiseException(Exception e)
    {
        if (AvaloniaLocator.Current.GetService<IDispatcherImpl>() is DispatcherImpl dispatcherImpl)
        {
            dispatcherImpl.PropagateCallbackException(ExceptionDispatchInfo.Capture(e));
        }
    }
}
