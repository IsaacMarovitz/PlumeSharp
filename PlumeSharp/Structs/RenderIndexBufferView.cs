namespace Plume
{
    public struct RenderIndexBufferView
    {
        [NativeTypeName("plume::RenderBufferReference")]
        public RenderBufferReference Buffer = default;

        [NativeTypeName("uint32_t")]
        public uint Size = 0;

        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        public RenderIndexBufferView() { }

        public RenderIndexBufferView([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference buffer, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            Buffer = buffer;
            Size = size;
            Format = format;
        }
    }
}
