namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderBarrierStages : uint
    {
        None = 0U,
        Graphics = 1U << 0,
        Compute = 1U << 1,
        Copy = 1U << 2,
        GraphicsAndCompute = Graphics | Compute,
        All = Graphics | Compute | Copy,
    }
}