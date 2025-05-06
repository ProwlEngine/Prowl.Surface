using Prowl.Surface.Mac.Interop;
using Prowl.Surface.Platform;

namespace Prowl.Surface.Native;

partial class AvaloniaNativePlatform
{
    public IWindowImpl CreateWindow()
    {
        return new WindowImpl(_factory, _options);
    }

    public IAvaloniaNativeFactory Factory => _factory;

    public static AvaloniaNativePlatform Initialize()
    {
        var options = new AvaloniaNativePlatformOptions();
        return Initialize(CreateAvaloniaNative(), options);
    }

}
