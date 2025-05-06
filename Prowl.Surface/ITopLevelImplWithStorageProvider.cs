using Prowl.Surface.Metadata;
using Prowl.Surface.Platform;
using Prowl.Surface.Platform.Storage;

namespace Prowl.Surface.Controls.Platform;

[Unstable]
public interface ITopLevelImplWithStorageProvider : ITopLevelImpl
{
    public IStorageProvider StorageProvider { get; }
}
