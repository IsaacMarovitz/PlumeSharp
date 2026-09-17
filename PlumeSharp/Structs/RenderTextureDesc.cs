namespace Plume
{
    public unsafe struct RenderTextureDesc
    {
        [NativeTypeName("plume::RenderTextureDimension")]
        public RenderTextureDimension Dimension = RenderTextureDimension.Unknown;

        [NativeTypeName("uint32_t")]
        public uint Width = 0;

        [NativeTypeName("uint32_t")]
        public uint Height = 0;

        [NativeTypeName("uint32_t")]
        public uint Depth = 0;

        [NativeTypeName("uint32_t")]
        public uint MipLevels = 0;

        [NativeTypeName("uint32_t")]
        public uint ArraySize = 0;

        [NativeTypeName("plume::RenderMultisampling")]
        public RenderMultisampling Multisampling = default;

        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        [NativeTypeName("plume::RenderTextureArrangement")]
        public RenderTextureArrangement TextureArrangement = RenderTextureArrangement.Unknown;

        [NativeTypeName("const RenderClearValue *")]
        public RenderClearValue* OptimizedClearValue = null;

        [NativeTypeName("plume::RenderTextureFlags")]
        public RenderTextureFlags Flags = RenderTextureFlags.None;

        public bool Committed = false;

        public RenderTextureDesc() { }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc Texture([NativeTypeName("plume::RenderTextureDimension")] RenderTextureDimension dimension, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, [NativeTypeName("uint32_t")] uint mipLevels, [NativeTypeName("uint32_t")] uint arraySize, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            var desc = new RenderTextureDesc
            {
                Dimension = dimension,
                Width = width,
                Height = height,
                Depth = depth,
                MipLevels = mipLevels,
                ArraySize = arraySize,
                Format = format,
                Flags = flags
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc Texture1D([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint mipLevels, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            return Texture(RenderTextureDimension.Texture1D, width, 1, 1, mipLevels, 1, format, flags);
        }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc Texture2D([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint mipLevels, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            return Texture(RenderTextureDimension.Texture2D, width, height, 1, mipLevels, 1, format, flags);
        }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc Texture3D([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, [NativeTypeName("uint32_t")] uint mipLevels, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            return Texture(RenderTextureDimension.Texture3D, width, height, depth, mipLevels, 1, format, flags);
        }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc ColorTarget([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderMultisampling")] RenderMultisampling multisampling = default, [NativeTypeName("const RenderClearValue *")] RenderClearValue* optimizedClearValue = null, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            var desc = new RenderTextureDesc
            {
                Committed = true,
                Dimension = RenderTextureDimension.Texture2D,
                Width = width,
                Height = height,
                Depth = 1,
                MipLevels = 1,
                ArraySize = 1,
                Format = format,
                Multisampling = multisampling,
                Flags = flags | RenderTextureFlags.RenderTarget,
                OptimizedClearValue = optimizedClearValue
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderTextureDesc")]
        public static RenderTextureDesc DepthTarget([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("plume::RenderMultisampling")] RenderMultisampling multisampling = default, [NativeTypeName("const RenderClearValue *")] RenderClearValue* optimizedClearValue = null, [NativeTypeName("plume::RenderTextureFlags")] RenderTextureFlags flags = RenderTextureFlags.None)
        {
            var desc = new RenderTextureDesc
            {
                Committed = true,
                Dimension = RenderTextureDimension.Texture2D,
                Width = width,
                Height = height,
                Depth = 1,
                MipLevels = 1,
                ArraySize = 1,
                Format = format,
                Multisampling = multisampling,
                Flags = flags | RenderTextureFlags.DepthTarget,
                OptimizedClearValue = optimizedClearValue
            };

            return desc;
        }
    }
}
