namespace Plume
{
    public unsafe struct RenderTextureBarrier
    {
        [NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* Texture = null;

        [NativeTypeName("plume::RenderTextureLayout")]
        public RenderTextureLayout Layout = RenderTextureLayout.Unknown;

        public RenderTextureBarrier() { }

        public RenderTextureBarrier([NativeTypeName("plume::RenderTexture *")] RenderTexture* texture, [NativeTypeName("plume::RenderTextureLayout")] RenderTextureLayout layout)
        {
            Texture = texture;
            Layout = layout;
        }
    }
}
