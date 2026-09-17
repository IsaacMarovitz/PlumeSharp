namespace Plume
{
    public struct RenderBufferStructuredView
    {
        [NativeTypeName("uint32_t")]
        public uint StructureByteStride = 0;

        [NativeTypeName("uint32_t")]
        public uint FirstElement = 0;

        public RenderBufferStructuredView() { }

        public RenderBufferStructuredView([NativeTypeName("uint32_t")] uint structureByteStride, [NativeTypeName("uint32_t")] uint firstElement = 0)
        {
            StructureByteStride = structureByteStride;
            FirstElement = firstElement;
        }
    }
}
