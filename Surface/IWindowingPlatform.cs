using Prowl.Surface.Metadata;

namespace Prowl.Surface.Platform;

[Unstable, PrivateApi]
public interface IWindowingPlatform
{
    IWindowImpl CreateWindow();

    //IWindowImpl CreateEmbeddableWindow();

    //ITrayIconImpl? CreateTrayIcon();
}
