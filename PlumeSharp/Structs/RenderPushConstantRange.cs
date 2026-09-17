namespace Plume
{
    public struct RenderPushConstantRange
    {
        [NativeTypeName("uint32_t")]
        public uint Binding = 0;

        [NativeTypeName("uint32_t")]
        public uint Set = 0;

        [NativeTypeName("uint32_t")]
        public uint Offset = 0;

        [NativeTypeName("uint32_t")]
        public uint Size = 0;

        [NativeTypeName("plume::RenderShaderStageFlags")]
        public RenderShaderStageFlags StageFlags = RenderShaderStageFlags.None;

        public RenderPushConstantRange() { }

        public RenderPushConstantRange([NativeTypeName("uint32_t")] uint binding, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("plume::RenderShaderStageFlags")] RenderShaderStageFlags stageFlags)
        {
            Binding = binding;
            Set = set;
            Offset = offset;
            Size = size;
            StageFlags = stageFlags;
        }
    }
}
