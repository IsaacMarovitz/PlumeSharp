namespace Plume
{
    public unsafe struct RenderBufferBarrier
    {
        [NativeTypeName("plume::RenderBuffer *")]
        public RenderBuffer* Buffer = null;

        [NativeTypeName("plume::RenderBufferAccessBits")]
        public RenderBufferAccessBits AccessBits = RenderBufferAccessBits.None;

        public RenderBufferBarrier() { }

        public RenderBufferBarrier([NativeTypeName("plume::RenderBuffer *")] RenderBuffer* buffer, [NativeTypeName("plume::RenderBufferAccessBits")] RenderBufferAccessBits accessBits)
        {
            Buffer = buffer;
            AccessBits = accessBits;
        }
    }
}
