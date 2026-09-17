namespace Plume
{
    public unsafe struct RenderPipelineLayoutDesc
    {
        [NativeTypeName("const RenderPushConstantRange *")]
        public RenderPushConstantRange* PushConstantRanges = null;

        [NativeTypeName("uint32_t")]
        public uint PushConstantRangesCount = 0;

        [NativeTypeName("const RenderDescriptorSetDesc *")]
        public RenderDescriptorSetDesc* DescriptorSetDescs = null;

        [NativeTypeName("uint32_t")]
        public uint DescriptorSetDescsCount = 0;

        [NativeTypeName("const RenderRootDescriptorDesc *")]
        public RenderRootDescriptorDesc* RootDescriptorDescs = null;

        [NativeTypeName("uint32_t")]
        public uint RootDescriptorDescsCount = 0;

        public bool IsLocal = false;

        public bool AllowInputLayout = false;

        public RenderPipelineLayoutDesc() { }

        public RenderPipelineLayoutDesc([NativeTypeName("const RenderPushConstantRange *")] RenderPushConstantRange* pushConstantRanges, [NativeTypeName("uint32_t")] uint pushConstantRangesCount, [NativeTypeName("const RenderDescriptorSetDesc *")] RenderDescriptorSetDesc* descriptorSetDescs, [NativeTypeName("uint32_t")] uint descriptorSetDescsCount, bool isLocal = false, bool allowInputLayout = false)
        {
            PushConstantRanges = pushConstantRanges;
            PushConstantRangesCount = pushConstantRangesCount;
            DescriptorSetDescs = descriptorSetDescs;
            DescriptorSetDescsCount = descriptorSetDescsCount;
            IsLocal = isLocal;
            AllowInputLayout = allowInputLayout;
        }
    }
}
