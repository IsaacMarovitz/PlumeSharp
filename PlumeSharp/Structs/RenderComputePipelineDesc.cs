namespace Plume
{
    public unsafe struct RenderComputePipelineDesc
    {
        [NativeTypeName("const RenderPipelineLayout *")]
        public RenderPipelineLayout* PipelineLayout = null;

        [NativeTypeName("const RenderShader *")]
        public RenderShader* ComputeShader = null;

        [NativeTypeName("const RenderSpecConstant *")]
        public RenderSpecConstant* SpecConstants = null;

        [NativeTypeName("uint32_t")]
        public uint SpecConstantsCount = 0;

        [NativeTypeName("uint32_t")]
        public uint ThreadGroupSizeX = 0;

        [NativeTypeName("uint32_t")]
        public uint ThreadGroupSizeY = 0;

        [NativeTypeName("uint32_t")]
        public uint ThreadGroupSizeZ = 0;

        public RenderComputePipelineDesc() { }

        public RenderComputePipelineDesc([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout, [NativeTypeName("const RenderShader *")] RenderShader* computeShader, [NativeTypeName("uint32_t")] uint threadGroupSizeX, [NativeTypeName("uint32_t")] uint threadGroupSizeY, [NativeTypeName("uint32_t")] uint threadGroupSizeZ)
        {
            PipelineLayout = pipelineLayout;
            ComputeShader = computeShader;
            ThreadGroupSizeX = threadGroupSizeX;
            ThreadGroupSizeY = threadGroupSizeY;
            ThreadGroupSizeZ = threadGroupSizeZ;
        }
    }
}
