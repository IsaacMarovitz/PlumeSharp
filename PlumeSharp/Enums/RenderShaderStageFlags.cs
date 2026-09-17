namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderShaderStageFlags : uint
    {
        None = 0U,
        Vertex = 1U << 0,
        Geometry = 1U << 1,
        Pixel = 1U << 2,
        Compute = 1U << 3,
        Raygen = 1U << 4,
        AnyHit = 1U << 5,
        ClosestHit = 1U << 6,
        Miss = 1U << 7,
        Intersection = 1U << 8,
        Callable = 1U << 9,
    }
}