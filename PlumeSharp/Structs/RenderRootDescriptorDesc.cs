namespace Plume
{
    public struct RenderRootDescriptorDesc
    {
        [NativeTypeName("uint32_t")]
        public uint ShaderRegister = 0;

        [NativeTypeName("uint32_t")]
        public uint RegisterSpace = 0;

        [NativeTypeName("plume::RenderRootDescriptorType")]
        public RenderRootDescriptorType Type = RenderRootDescriptorType.Unknown;

        public RenderRootDescriptorDesc() { }

        public RenderRootDescriptorDesc([NativeTypeName("uint32_t")] uint shaderRegister, [NativeTypeName("uint32_t")] uint registerSpace, [NativeTypeName("plume::RenderRootDescriptorType")] RenderRootDescriptorType type)
        {
            ShaderRegister = shaderRegister;
            RegisterSpace = registerSpace;
            Type = type;
        }
    }
}
