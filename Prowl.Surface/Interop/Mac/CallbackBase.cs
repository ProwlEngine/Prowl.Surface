using System;


using Prowl.Surface.MicroCom;

namespace Prowl.Surface.Mac;

internal abstract class NativeCallbackBase : CallbackBase, IMicroComExceptionCallback
{
    public void RaiseException(Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}
