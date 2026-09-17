namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderSampleCounts : uint
    {
        Count0 = 0x0,
        Count1 = 0x1,
        Count2 = 0x2,
        Count4 = 0x4,
        Count8 = 0x8,
        Count16 = 0x10,
        Count32 = 0x20,
        Count64 = 0x40,
        CountMax = Count64,
    }
}