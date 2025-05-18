using System;

using Prowl.Surface.Mac.Interop;

namespace Prowl.Surface.Native;

partial class WindowBaseImpl
{
    protected unsafe partial class WindowBaseEvents
    {
        public AvnDragDropEffects DragEvent(AvnDragEventType type, AvnPoint position,
            AvnInputModifiers modifiers,
            AvnDragDropEffects effects,
            IAvnClipboard clipboard, IntPtr dataObjectHandle)
        {
            return AvnDragDropEffects.None;
        }
    }
}
