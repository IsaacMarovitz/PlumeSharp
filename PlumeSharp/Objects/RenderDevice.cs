using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderDevice : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderDevice*, void>)LpVtbl[1])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderDescriptorSet *")]
        public RenderDescriptorSet* CreateDescriptorSet([NativeTypeName("const RenderDescriptorSetDesc &")] RenderDescriptorSetDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDescriptorSetDesc*, RenderDescriptorSet*>)LpVtbl[2])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderShader *")]
        public RenderShader* CreateShader([NativeTypeName("const void *")] void* data, [NativeTypeName("uint64_t")] ulong size, [NativeTypeName("const char *")] sbyte* entryPointName, [NativeTypeName("plume::RenderShaderFormat")] RenderShaderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, void*, ulong, sbyte*, RenderShaderFormat, RenderShader*>)LpVtbl[3])((RenderDevice*)Unsafe.AsPointer(ref this), data, size, entryPointName, format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("plume::RenderSampler *")]
        public RenderSampler* CreateSampler([NativeTypeName("const RenderSamplerDesc &")] RenderSamplerDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderSamplerDesc*, RenderSampler*>)LpVtbl[4])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("plume::RenderPipeline *")]
        public RenderPipeline* CreateComputePipeline([NativeTypeName("const RenderComputePipelineDesc &")] RenderComputePipelineDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderComputePipelineDesc*, RenderPipeline*>)LpVtbl[5])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("plume::RenderPipeline *")]
        public RenderPipeline* CreateGraphicsPipeline([NativeTypeName("const RenderGraphicsPipelineDesc &")] RenderGraphicsPipelineDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderGraphicsPipelineDesc*, RenderPipeline*>)LpVtbl[6])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("plume::RenderCommandQueue *")]
        public RenderCommandQueue* CreateCommandQueue([NativeTypeName("plume::RenderCommandListType")] RenderCommandListType type)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandListType, RenderCommandQueue*>)LpVtbl[8])((RenderDevice*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("plume::RenderBuffer *")]
        public RenderBuffer* CreateBuffer([NativeTypeName("const RenderBufferDesc &")] RenderBufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderBufferDesc*, RenderBuffer*>)LpVtbl[9])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* CreateTexture([NativeTypeName("const RenderTextureDesc &")] RenderTextureDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderTextureDesc*, RenderTexture*>)LpVtbl[10])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("plume::RenderPool *")]
        public RenderPool* CreatePool([NativeTypeName("const RenderPoolDesc &")] RenderPoolDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderPoolDesc*, RenderPool*>)LpVtbl[12])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("plume::RenderPipelineLayout *")]
        public RenderPipelineLayout* CreatePipelineLayout([NativeTypeName("const RenderPipelineLayoutDesc &")] RenderPipelineLayoutDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderPipelineLayoutDesc*, RenderPipelineLayout*>)LpVtbl[13])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("plume::RenderCommandFence *")]
        public RenderCommandFence* CreateCommandFence()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandFence*>)LpVtbl[14])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("plume::RenderCommandSemaphore *")]
        public RenderCommandSemaphore* CreateCommandSemaphore()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandSemaphore*>)LpVtbl[15])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("plume::RenderFramebuffer *")]
        public RenderFramebuffer* CreateFramebuffer([NativeTypeName("const RenderFramebufferDesc &")] RenderFramebufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderFramebufferDesc*, RenderFramebuffer*>)LpVtbl[16])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("plume::RenderQueryPool *")]
        public RenderQueryPool* CreateQueryPool([NativeTypeName("uint32_t")] uint queryCount)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, uint, RenderQueryPool*>)LpVtbl[17])((RenderDevice*)Unsafe.AsPointer(ref this), queryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("const RenderDeviceCapabilities &")]
        public readonly RenderDeviceCapabilities* GetCapabilities()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceCapabilities*>)LpVtbl[21])((RenderDevice*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("const RenderDeviceDescription &")]
        public readonly RenderDeviceDescription* GetDescription()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceDescription*>)LpVtbl[22])((RenderDevice*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("plume::RenderSampleCounts")]
        public readonly uint GetSampleCountsSupported([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderFormat, uint>)LpVtbl[23])((RenderDevice*)Unsafe.AsPointer(in this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public bool BeginCapture()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, bool>)LpVtbl[24])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public bool EndCapture()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, bool>)LpVtbl[25])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, void> Dispose;

            [NativeTypeName("RenderDescriptorSet *(const RenderDescriptorSetDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderDescriptorSetDesc*, RenderDescriptorSet*> CreateDescriptorSetRaw;

            [NativeTypeName("RenderShader *(const void *, uint64_t, const char *, RenderShaderFormat)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, void*, ulong, sbyte*, RenderShaderFormat, RenderShader*> CreateShaderRaw;

            [NativeTypeName("RenderSampler *(const RenderSamplerDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderSamplerDesc*, RenderSampler*> CreateSamplerRaw;

            [NativeTypeName("RenderPipeline *(const RenderComputePipelineDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderComputePipelineDesc*, RenderPipeline*> CreateComputePipelineRaw;

            [NativeTypeName("RenderPipeline *(const RenderGraphicsPipelineDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderGraphicsPipelineDesc*, RenderPipeline*> CreateGraphicsPipelineRaw;

            [NativeTypeName("RenderCommandQueue *(RenderCommandListType)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandListType, RenderCommandQueue*> CreateCommandQueueRaw;

            [NativeTypeName("RenderBuffer *(const RenderBufferDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderBufferDesc*, RenderBuffer*> CreateBufferRaw;

            [NativeTypeName("RenderTexture *(const RenderTextureDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderTextureDesc*, RenderTexture*> CreateTextureRaw;

            [NativeTypeName("RenderPool *(const RenderPoolDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderPoolDesc*, RenderPool*> CreatePoolRaw;

            [NativeTypeName("RenderPipelineLayout *(const RenderPipelineLayoutDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderPipelineLayoutDesc*, RenderPipelineLayout*> CreatePipelineLayoutRaw;

            [NativeTypeName("RenderCommandFence *()")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandFence*> CreateCommandFenceRaw;

            [NativeTypeName("RenderCommandSemaphore *()")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandSemaphore*> CreateCommandSemaphoreRaw;

            [NativeTypeName("RenderFramebuffer *(const RenderFramebufferDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderFramebufferDesc*, RenderFramebuffer*> CreateFramebufferRaw;

            [NativeTypeName("RenderQueryPool *(uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, uint, RenderQueryPool*> CreateQueryPoolRaw;

            [NativeTypeName("const RenderDeviceCapabilities &() const")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceCapabilities*> GetCapabilities;

            [NativeTypeName("const RenderDeviceDescription &() const")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceDescription*> GetDescription;

            [NativeTypeName("RenderSampleCounts (RenderFormat) const")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, RenderFormat, uint> GetSampleCountsSupported;

            [NativeTypeName("bool ()")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, bool> BeginCapture;

            [NativeTypeName("bool ()")]
            public delegate* unmanaged[Thiscall]<RenderDevice*, bool> EndCapture;
        }
    }
}
