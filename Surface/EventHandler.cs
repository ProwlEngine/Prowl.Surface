// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using Prowl.Surface.Events;


namespace Prowl.Surface;


public abstract class EventHandler
{
    internal abstract bool PollEvent(out WindowEvent ev);


    /// <summary>
    /// Indicates if there is a pending event that needs to get processed, and returns a <see cref="WindowEvent"/> with window event information.
    /// </summary>
    /// <param name="ev">Event information.</param>
    /// <returns>True if an event is avaliable, false otherwise.</returns>
    public static bool PollEvents(out WindowEvent ev)
    {
        return Platform.PlatformImpl.EventHandler.PollEvent(out ev);
    }
}
