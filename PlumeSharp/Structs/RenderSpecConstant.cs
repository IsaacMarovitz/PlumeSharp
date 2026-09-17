namespace Plume
{
    public struct RenderSpecConstant
    {
        [NativeTypeName("uint32_t")]
        public uint Index = 0;

        [NativeTypeName("uint32_t")]
        public uint Value = 0;

        public RenderSpecConstant() { }

        public RenderSpecConstant([NativeTypeName("uint32_t")] uint index, [NativeTypeName("uint32_t")] uint value)
        {
            Index = index;
            Value = value;
        }
    }
}
