namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderTextureFlags : uint
    {
        None = 0U,
        RenderTarget = 1U << 0,
        DepthTarget = 1U << 1,
        Storage = 1U << 2,
        UnorderedAccess = 1U << 3,
        Cube = 1U << 4,
    }
}