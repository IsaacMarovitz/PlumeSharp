namespace Plume
{
    public struct RenderVertexBufferView
    {
        [NativeTypeName("plume::RenderBufferReference")]
        public RenderBufferReference Buffer;

        [NativeTypeName("uint32_t")]
        public uint Size = 0;

        public RenderVertexBufferView() { }

        public RenderVertexBufferView([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference buffer, [NativeTypeName("uint32_t")] uint size)
        {
            Buffer = buffer;
            Size = size;
        }
    }
}
