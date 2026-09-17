namespace Plume
{
    public enum RenderTextureLayout
    {
        Unknown,
        General,
        ShaderRead,
        ColorWrite,
        DepthWrite,
        DepthRead,
        CopySource,
        CopyDest,
        ResolveSource,
        ResolveDest,
        Present,
    }
}
