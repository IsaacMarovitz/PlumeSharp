namespace Plume
{
    public unsafe struct RenderDescriptorSetDesc
    {
        [NativeTypeName("const RenderDescriptorRange *")]
        public RenderDescriptorRange* DescriptorRanges = null;

        [NativeTypeName("uint32_t")]
        public uint DescriptorRangesCount = 0;

        public bool LastRangeIsBoundless = false;

        [NativeTypeName("uint32_t")]
        public uint BoundlessRangeSize = 0;

        public RenderDescriptorSetDesc() { }

        public RenderDescriptorSetDesc([NativeTypeName("const RenderDescriptorRange *")] RenderDescriptorRange* descriptorRanges, [NativeTypeName("uint32_t")] uint descriptorRangesCount, bool lastRangeIsBoundless = false, [NativeTypeName("uint32_t")] uint boundlessRangeSize = 0)
        {
            DescriptorRanges = descriptorRanges;
            DescriptorRangesCount = descriptorRangesCount;
            LastRangeIsBoundless = lastRangeIsBoundless;
            BoundlessRangeSize = boundlessRangeSize;
        }
    }
}
