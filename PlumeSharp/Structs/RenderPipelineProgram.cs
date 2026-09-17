namespace Plume
{
    public struct RenderPipelineProgram
    {
        [NativeTypeName("uint32_t")]
        public uint ProgramIndex = 0;

        public RenderPipelineProgram() { }

        public RenderPipelineProgram([NativeTypeName("uint32_t")] uint programIndex)
        {
            ProgramIndex = programIndex;
        }
    }
}
