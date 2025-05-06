namespace Prowl.Surface.MicroCom;

public interface IMicroComShadowContainer
{
    MicroComShadow Shadow { get; set; }
    void OnReferencedFromNative();
    void OnUnreferencedFromNative();
}
