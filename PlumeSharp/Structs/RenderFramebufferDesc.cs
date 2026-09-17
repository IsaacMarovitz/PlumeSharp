namespace Plume
{
    public unsafe struct RenderFramebufferDesc
    {
        [NativeTypeName("const RenderTexture **")]
        public RenderTexture** ColorAttachments = null;

        [NativeTypeName("const RenderTextureView **")]
        public RenderTextureView** ColorAttachmentViews = null;

        [NativeTypeName("uint32_t")]
        public uint ColorAttachmentsCount = 0;

        [NativeTypeName("const RenderTexture *")]
        public RenderTexture* DepthAttachment = null;

        [NativeTypeName("const RenderTextureView *")]
        public RenderTextureView* DepthAttachmentView = null;

        public bool DepthAttachmentReadOnly = false;

        public RenderFramebufferDesc() { }

        public RenderFramebufferDesc([NativeTypeName("const RenderTexture **")] RenderTexture** colorAttachments, [NativeTypeName("uint32_t")] uint colorAttachmentsCount, [NativeTypeName("const RenderTexture *")] RenderTexture* depthAttachment = null, bool depthAttachmentReadOnly = false)
        {
            ColorAttachments = colorAttachments;
            ColorAttachmentsCount = colorAttachmentsCount;
            DepthAttachment = depthAttachment;
            DepthAttachmentReadOnly = depthAttachmentReadOnly;
        }
    }
}
