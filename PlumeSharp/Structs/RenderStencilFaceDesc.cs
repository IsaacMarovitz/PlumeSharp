namespace Plume
{
    public struct RenderStencilFaceDesc
    {
        [NativeTypeName("plume::RenderStencilOp")]
        public RenderStencilOp PassOp = RenderStencilOp.Keep;

        [NativeTypeName("plume::RenderStencilOp")]
        public RenderStencilOp FailOp = RenderStencilOp.Keep;

        [NativeTypeName("plume::RenderStencilOp")]
        public RenderStencilOp DepthFailOp = RenderStencilOp.Keep;

        [NativeTypeName("plume::RenderComparisonFunction")]
        public RenderComparisonFunction CompareFunction = RenderComparisonFunction.Always;

        public RenderStencilFaceDesc() { }
    }
}
