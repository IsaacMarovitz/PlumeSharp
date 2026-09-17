namespace Plume
{
    public struct RenderTextureViewDesc
    {
        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        [NativeTypeName("plume::RenderTextureViewDimension")]
        public RenderTextureViewDimension Dimension = RenderTextureViewDimension.Unknown;

        [NativeTypeName("uint32_t")]
        public uint MipLevels = UInt32.MaxValue;

        [NativeTypeName("uint32_t")]
        public uint MipSlice = 0;

        [NativeTypeName("uint32_t")]
        public uint ArraySize = UInt32.MaxValue;

        [NativeTypeName("uint32_t")]
        public uint ArrayIndex = 0;

        [NativeTypeName("plume::RenderComponentMapping")]
        public RenderComponentMapping ComponentMapping = new();

        public RenderTextureViewDesc() { }

        [return: NativeTypeName("plume::RenderTextureViewDesc")]
        public static RenderTextureViewDesc Texture1D([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var viewDesc = new RenderTextureViewDesc
            {
                Format = format,
                Dimension = RenderTextureViewDimension.Texture1D
            };

            return viewDesc;
        }

        [return: NativeTypeName("plume::RenderTextureViewDesc")]
        public static RenderTextureViewDesc Texture2D([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var viewDesc = new RenderTextureViewDesc
            {
                Format = format,
                Dimension = RenderTextureViewDimension.Texture2D
            };

            return viewDesc;
        }

        [return: NativeTypeName("plume::RenderTextureViewDesc")]
        public static RenderTextureViewDesc Texture3D([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var viewDesc = new RenderTextureViewDesc
            {
                Format = format,
                Dimension = RenderTextureViewDimension.Texture3D
            };

            return viewDesc;
        }

        [return: NativeTypeName("plume::RenderTextureViewDesc")]
        public static RenderTextureViewDesc TextureCube([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var viewDesc = new RenderTextureViewDesc
            {
                Format = format,
                Dimension = RenderTextureViewDimension.TextureCube
            };

            return viewDesc;
        }
    }
}
