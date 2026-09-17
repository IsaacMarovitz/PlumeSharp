namespace Plume
{
    public struct RenderBufferDesc
    {
        [NativeTypeName("uint64_t")]
        public ulong Size = 0;

        [NativeTypeName("plume::RenderHeapType")]
        public RenderHeapType HeapType = RenderHeapType.Unknown;

        [NativeTypeName("plume::RenderBufferFlags")]
        public RenderBufferFlags Flags = RenderBufferFlags.None;

        public bool Committed = false;

        public RenderBufferDesc() { }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc DefaultBuffer([NativeTypeName("uint64_t")] ulong size, [NativeTypeName("plume::RenderBufferFlags")] RenderBufferFlags flags = RenderBufferFlags.None)
        {
            var desc = new RenderBufferDesc
            {
                Size = size,
                HeapType = RenderHeapType.Default,
                Flags = flags
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc UploadBuffer([NativeTypeName("uint64_t")] ulong size, [NativeTypeName("plume::RenderBufferFlags")] RenderBufferFlags flags = RenderBufferFlags.None)
        {
            var desc = new RenderBufferDesc
            {
                HeapType = RenderHeapType.Upload,
                Size = size,
                Flags = flags
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc ReadbackBuffer([NativeTypeName("uint64_t")] ulong size, [NativeTypeName("plume::RenderBufferFlags")] RenderBufferFlags flags = RenderBufferFlags.None)
        {
            var desc = new RenderBufferDesc
            {
                HeapType = RenderHeapType.Readback,
                Size = size,
                Flags = flags
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc VertexBuffer([NativeTypeName("uint64_t")] ulong size, [NativeTypeName("plume::RenderHeapType")] RenderHeapType heapType, [NativeTypeName("plume::RenderBufferFlags")] RenderBufferFlags flags = RenderBufferFlags.None)
        {
            var desc = new RenderBufferDesc
            {
                Size = size,
                HeapType = heapType,
                Flags = flags | RenderBufferFlags.Vertex
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc IndexBuffer([NativeTypeName("uint64_t")] ulong size, [NativeTypeName("plume::RenderHeapType")] RenderHeapType heapType, [NativeTypeName("plume::RenderBufferFlags")] RenderBufferFlags flags = RenderBufferFlags.None)
        {
            var desc = new RenderBufferDesc
            {
                Size = size,
                HeapType = heapType,
                Flags = flags | RenderBufferFlags.Index
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBufferDesc")]
        public static RenderBufferDesc AccelerationStructureBuffer([NativeTypeName("uint64_t")] ulong size)
        {
            var desc = new RenderBufferDesc
            {
                Size = size,
                HeapType = RenderHeapType.Default,
                Flags = RenderBufferFlags.AccelerationStructure
            };

            return desc;
        }
    }
}
