namespace Plume
{
    public unsafe struct RenderDescriptorRange
    {
        [NativeTypeName("plume::RenderDescriptorRangeType")]
        public RenderDescriptorRangeType Type = RenderDescriptorRangeType.Unknown;

        [NativeTypeName("uint32_t")]
        public uint Count = 0;

        [NativeTypeName("uint32_t")]
        public uint Binding = 0;

        [NativeTypeName("const RenderSampler **")]
        public RenderSampler** ImmutableSampler = null;

        public RenderDescriptorRange() { }

        public RenderDescriptorRange([NativeTypeName("plume::RenderDescriptorRangeType")] RenderDescriptorRangeType type, [NativeTypeName("uint32_t")] uint binding, [NativeTypeName("uint32_t")] uint count, [NativeTypeName("const RenderSampler **")] RenderSampler** immutableSampler = null)
        {
            Type = type;
            Binding = binding;
            Count = count;
            ImmutableSampler = immutableSampler;
        }
    }
}
