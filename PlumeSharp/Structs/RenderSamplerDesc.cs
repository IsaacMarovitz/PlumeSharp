namespace Plume
{
    public struct RenderSamplerDesc
    {
        [NativeTypeName("plume::RenderFilter")]
        public RenderFilter MinFilter = RenderFilter.Linear;

        [NativeTypeName("plume::RenderFilter")]
        public RenderFilter MagFilter = RenderFilter.Linear;

        [NativeTypeName("plume::RenderMipmapMode")]
        public RenderMipmapMode MipmapMode = RenderMipmapMode.Linear;

        [NativeTypeName("plume::RenderTextureAddressMode")]
        public RenderTextureAddressMode AddressU = RenderTextureAddressMode.Wrap;

        [NativeTypeName("plume::RenderTextureAddressMode")]
        public RenderTextureAddressMode AddressV = RenderTextureAddressMode.Wrap;

        [NativeTypeName("plume::RenderTextureAddressMode")]
        public RenderTextureAddressMode AddressW = RenderTextureAddressMode.Wrap;

        public float MipLodBias = 0.0f;

        [NativeTypeName("uint32_t")]
        public uint MaxAnisotropy = 16;

        public bool AnisotropyEnabled = false;

        [NativeTypeName("plume::RenderComparisonFunction")]
        public RenderComparisonFunction ComparisonFunc = RenderComparisonFunction.Never;

        public bool ComparisonEnabled = false;

        [NativeTypeName("plume::RenderBorderColor")]
        public RenderBorderColor BorderColor = RenderBorderColor.OpaqueBlack;

        public float MinLod = 0.0f;

        public float MaxLod = float.PositiveInfinity;

        [NativeTypeName("plume::RenderShaderVisibility")]
        public RenderShaderVisibility ShaderVisibility = RenderShaderVisibility.All;

        public RenderSamplerDesc() { }
    }
}
