namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderBufferAccessBits : uint
    {
        None = 0U,
        Read = 1U << 0,
        Write = 1U << 1,
    }
}
