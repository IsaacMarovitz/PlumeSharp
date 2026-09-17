namespace Plume
{
    public struct RenderPoolDesc
    {
        [NativeTypeName("plume::RenderHeapType")]
        public RenderHeapType HeapType = RenderHeapType.Unknown;

        [NativeTypeName("uint32_t")]
        public uint MinBlockCount = 0;

        [NativeTypeName("uint32_t")]
        public uint MaxBlockCount = 0;

        public bool UseLinearAlgorithm = false;

        public bool AllowOnlyBuffers = false;

        public RenderPoolDesc() { }
    }
}
