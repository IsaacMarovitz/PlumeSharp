namespace Plume
{
    public struct RenderInputSlot
    {
        [NativeTypeName("uint32_t")]
        public uint Index = 0;

        [NativeTypeName("uint32_t")]
        public uint Stride = 0;

        [NativeTypeName("plume::RenderInputSlotClassification")]
        public RenderInputSlotClassification Classification = RenderInputSlotClassification.Unknown;

        public RenderInputSlot() { }

        public RenderInputSlot([NativeTypeName("uint32_t")] uint index, [NativeTypeName("uint32_t")] uint stride, [NativeTypeName("plume::RenderInputSlotClassification")] RenderInputSlotClassification classification = RenderInputSlotClassification.PerVertexData)
        {
            Index = index;
            Stride = stride;
            Classification = classification;
        }
    }
}
