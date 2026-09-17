namespace Plume
{
    public struct RenderBlendDesc
    {
        public bool BlendEnabled = false;

        [NativeTypeName("plume::RenderBlend")]
        public RenderBlend SrcBlend = RenderBlend.Unknown;

        [NativeTypeName("plume::RenderBlend")]
        public RenderBlend DstBlend = RenderBlend.Unknown;

        [NativeTypeName("plume::RenderBlendOperation")]
        public RenderBlendOperation BlendOp = RenderBlendOperation.Unknown;

        [NativeTypeName("plume::RenderBlend")]
        public RenderBlend SrcBlendAlpha = RenderBlend.Unknown;

        [NativeTypeName("plume::RenderBlend")]
        public RenderBlend DstBlendAlpha = RenderBlend.Unknown;

        [NativeTypeName("plume::RenderBlendOperation")]
        public RenderBlendOperation BlendOpAlpha = RenderBlendOperation.Unknown;

        [NativeTypeName("uint8_t")]
        public byte RenderTargetWriteMask = (byte)RenderColorWriteEnable.All;

        public RenderBlendDesc() { }

        [return: NativeTypeName("plume::RenderBlendDesc")]
        public static RenderBlendDesc Copy()
        {
            var desc = new RenderBlendDesc
            {
                SrcBlend = RenderBlend.One,
                DstBlend = RenderBlend.Zero,
                BlendOp = RenderBlendOperation.Add,
                SrcBlendAlpha = RenderBlend.One,
                DstBlendAlpha = RenderBlend.Zero,
                BlendOpAlpha = RenderBlendOperation.Add
            };

            return desc;
        }

        [return: NativeTypeName("plume::RenderBlendDesc")]
        public static RenderBlendDesc AlphaBlend()
        {
            var desc = new RenderBlendDesc
            {
                BlendEnabled = true,
                SrcBlend = RenderBlend.SrcAlpha,
                DstBlend = RenderBlend.InvSrcAlpha,
                BlendOp = RenderBlendOperation.Add,
                SrcBlendAlpha = RenderBlend.One,
                DstBlendAlpha = RenderBlend.InvSrcAlpha,
                BlendOpAlpha = RenderBlendOperation.Add
            };

            return desc;
        }
    }
}
