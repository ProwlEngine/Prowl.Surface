using System;

namespace Prowl.Surface.MicroCom;

public interface IMicroComExceptionCallback
{
    void RaiseException(Exception e);
}
