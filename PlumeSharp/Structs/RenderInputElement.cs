namespace Plume
{
    public unsafe struct RenderInputElement
    {
        [NativeTypeName("const char *")]
        public sbyte* SemanticName = null;

        [NativeTypeName("uint32_t")]
        public uint SemanticIndex = 0;

        [NativeTypeName("uint32_t")]
        public uint Location = 0;

        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        [NativeTypeName("uint32_t")]
        public uint SlotIndex = 0;

        [NativeTypeName("uint32_t")]
        public uint AlignedByteOffset = 0;

        public RenderInputElement() { }

        public RenderInputElement([NativeTypeName("const char *")] sbyte* semanticName, [NativeTypeName("uint32_t")] uint semanticIndex, [NativeTypeName("uint32_t")] uint location, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("uint32_t")] uint slotIndex, [NativeTypeName("uint32_t")] uint alignedByteOffset)
        {
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            Location = location;
            Format = format;
            SlotIndex = slotIndex;
            AlignedByteOffset = alignedByteOffset;
        }
    }
}
