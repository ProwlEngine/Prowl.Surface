using Prowl.Surface.Input.Raw;
using Prowl.Surface.Metadata;

namespace Prowl.Surface.Input;

[PrivateApi]
public interface IPointerDevice : IInputDevice
{
    /// <summary>
    /// Gets a pointer for specific event args.
    /// </summary>
    /// <remarks>
    /// If pointer doesn't exist or wasn't yet created this method will return null.
    /// </remarks>
    /// <param name="ev">Raw pointer event args associated with the pointer.</param>
    /// <returns>The pointer.</returns>
    IPointer? TryGetPointer(RawPointerEventArgs ev);
}
