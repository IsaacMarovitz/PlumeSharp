namespace Plume
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum RenderBufferFlags : uint
    {
        None = 0U,
        Vertex = 1U << 0,
        Index = 1U << 1,
        Storage = 1U << 2,
        Constant = 1U << 3,
        Formatted = 1U << 4,
        AccelerationStructure = 1U << 5,
        AccelerationStructureInput = 1U << 6,
        AccelerationStructureScratch = 1U << 7,
        ShaderBindingTable = 1U << 8,
        UnorderedAccess = 1U << 9,
        DeviceAddressable = 1U << 10,
    }
}