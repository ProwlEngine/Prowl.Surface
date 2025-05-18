using Prowl.Vector;

namespace Prowl.Surface.Platform;

public partial interface ITopLevelImpl
{
    /// <summary>
    /// Invalidates a rect on the toplevel.
    /// </summary>
    void Invalidate(Rect rect);
}
