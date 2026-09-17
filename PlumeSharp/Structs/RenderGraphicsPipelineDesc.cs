using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderGraphicsPipelineDesc
    {
        [NativeTypeName("const RenderPipelineLayout *")]
        public RenderPipelineLayout* PipelineLayout = null;

        [NativeTypeName("const RenderShader *")]
        public RenderShader* VertexShader = null;

        [NativeTypeName("const RenderShader *")]
        public RenderShader* GeometryShader = null;

        [NativeTypeName("const RenderShader *")]
        public RenderShader* PixelShader = null;

        [NativeTypeName("plume::RenderComparisonFunction")]
        public RenderComparisonFunction DepthFunction = RenderComparisonFunction.Never;

        public bool DepthClipEnabled = false;

        [NativeTypeName("int32_t")]
        public int DepthBias = 0;

        public float DepthBiasClamp = 0.0f;

        public float SlopeScaledDepthBias = 0.0f;

        public bool DynamicDepthBiasEnabled = false;

        public bool DepthEnabled = false;

        public bool DepthWriteEnabled = false;

        public bool StencilEnabled = false;

        [NativeTypeName("uint32_t")]
        public uint StencilReadMask = 0xFFFFFFFF;

        [NativeTypeName("uint32_t")]
        public uint StencilWriteMask = 0xFFFFFFFF;

        [NativeTypeName("uint32_t")]
        public uint StencilReference = 0;

        [NativeTypeName("plume::RenderStencilFaceDesc")]
        public RenderStencilFaceDesc StencilFrontFace = new();

        [NativeTypeName("plume::RenderStencilFaceDesc")]
        public RenderStencilFaceDesc StencilBackFace = new();

        [NativeTypeName("plume::RenderMultisampling")]
        public RenderMultisampling Multisampling = new();

        public bool AlphaToCoverageEnabled = false;

        [NativeTypeName("plume::RenderPrimitiveTopology")]
        public RenderPrimitiveTopology PrimitiveTopology = RenderPrimitiveTopology.TriangleList;

        [NativeTypeName("plume::RenderCullMode")]
        public RenderCullMode CullMode = RenderCullMode.None;

        [NativeTypeName("plume::RenderFrontFace")]
        public RenderFrontFace FrontFace = RenderFrontFace.Clockwise;

        [NativeTypeName("RenderFormat[8]")]
        public RenderTargetFormatEFixedBuffer RenderTargetFormat = default;

        [NativeTypeName("RenderBlendDesc[8]")]
        public RenderTargetBlendEFixedBuffer RenderTargetBlend = default;

        [NativeTypeName("uint32_t")]
        public uint RenderTargetCount = 0;

        public bool LogicOpEnabled = false;

        [NativeTypeName("plume::RenderLogicOperation")]
        public RenderLogicOperation LogicOp = RenderLogicOperation.Noop;

        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat DepthTargetFormat = RenderFormat.Unknown;

        [NativeTypeName("const RenderInputSlot *")]
        public RenderInputSlot* InputSlots = null;

        [NativeTypeName("uint32_t")]
        public uint InputSlotsCount = 0;

        [NativeTypeName("const RenderInputElement *")]
        public RenderInputElement* InputElements = null;

        [NativeTypeName("uint32_t")]
        public uint InputElementsCount = 0;

        [NativeTypeName("const RenderSpecConstant *")]
        public RenderSpecConstant* SpecConstants = null;

        [NativeTypeName("uint32_t")]
        public uint SpecConstantsCount = 0;

        public RenderGraphicsPipelineDesc() { }

        [NativeTypeName("const uint32_t")]
        public const uint MaxRenderTargets = 8;

        [InlineArray(8)]
        public struct RenderTargetFormatEFixedBuffer
        {
            public RenderFormat e0;
        }

        [InlineArray(8)]
        public struct RenderTargetBlendEFixedBuffer
        {
            public RenderBlendDesc e0;
        }
    }
}
