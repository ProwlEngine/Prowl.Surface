﻿using Prowl.Surface.Input.Raw;
using Prowl.Surface.Metadata;

namespace Prowl.Surface.Input;

[NotClientImplementable, PrivateApi]
public interface IInputDevice
{
    /// </summary>
    /// Processes raw event. Is called after preprocessing by InputManager
    /// </summary>
    /// <param name="ev"></param>
    void ProcessRawEvent(RawInputEventArgs ev);
}
