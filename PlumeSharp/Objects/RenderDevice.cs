using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderDevice : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderDevice*, void>)_lpVtbl[1])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderDescriptorSet *")]
        public RenderDescriptorSet* CreateDescriptorSet([NativeTypeName("const RenderDescriptorSetDesc &")] RenderDescriptorSetDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDescriptorSetDesc*, RenderDescriptorSet*>)_lpVtbl[2])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderShader *")]
        public RenderShader* CreateShader([NativeTypeName("const void *")] void* data, [NativeTypeName("uint64_t")] ulong size, [NativeTypeName("const char *")] sbyte* entryPointName, [NativeTypeName("plume::RenderShaderFormat")] RenderShaderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, void*, ulong, sbyte*, RenderShaderFormat, RenderShader*>)_lpVtbl[3])((RenderDevice*)Unsafe.AsPointer(ref this), data, size, entryPointName, format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("plume::RenderSampler *")]
        public RenderSampler* CreateSampler([NativeTypeName("const RenderSamplerDesc &")] RenderSamplerDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderSamplerDesc*, RenderSampler*>)_lpVtbl[4])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("plume::RenderPipeline *")]
        public RenderPipeline* CreateComputePipeline([NativeTypeName("const RenderComputePipelineDesc &")] RenderComputePipelineDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderComputePipelineDesc*, RenderPipeline*>)_lpVtbl[5])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("plume::RenderPipeline *")]
        public RenderPipeline* CreateGraphicsPipeline([NativeTypeName("const RenderGraphicsPipelineDesc &")] RenderGraphicsPipelineDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderGraphicsPipelineDesc*, RenderPipeline*>)_lpVtbl[6])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("plume::RenderCommandQueue *")]
        public RenderCommandQueue* CreateCommandQueue([NativeTypeName("plume::RenderCommandListType")] RenderCommandListType type)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandListType, RenderCommandQueue*>)_lpVtbl[8])((RenderDevice*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("plume::RenderBuffer *")]
        public RenderBuffer* CreateBuffer([NativeTypeName("const RenderBufferDesc &")] RenderBufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderBufferDesc*, RenderBuffer*>)_lpVtbl[9])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* CreateTexture([NativeTypeName("const RenderTextureDesc &")] RenderTextureDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderTextureDesc*, RenderTexture*>)_lpVtbl[10])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("plume::RenderPool *")]
        public RenderPool* CreatePool([NativeTypeName("const RenderPoolDesc &")] RenderPoolDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderPoolDesc*, RenderPool*>)_lpVtbl[12])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("plume::RenderPipelineLayout *")]
        public RenderPipelineLayout* CreatePipelineLayout([NativeTypeName("const RenderPipelineLayoutDesc &")] RenderPipelineLayoutDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderPipelineLayoutDesc*, RenderPipelineLayout*>)_lpVtbl[13])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("plume::RenderCommandFence *")]
        public RenderCommandFence* CreateCommandFence()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandFence*>)_lpVtbl[14])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("plume::RenderCommandSemaphore *")]
        public RenderCommandSemaphore* CreateCommandSemaphore()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderCommandSemaphore*>)_lpVtbl[15])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("plume::RenderFramebuffer *")]
        public RenderFramebuffer* CreateFramebuffer([NativeTypeName("const RenderFramebufferDesc &")] RenderFramebufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderFramebufferDesc*, RenderFramebuffer*>)_lpVtbl[16])((RenderDevice*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("plume::RenderQueryPool *")]
        public RenderQueryPool* CreateQueryPool([NativeTypeName("uint32_t")] uint queryCount)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, uint, RenderQueryPool*>)_lpVtbl[17])((RenderDevice*)Unsafe.AsPointer(ref this), queryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("const RenderDeviceCapabilities &")]
        public readonly RenderDeviceCapabilities* GetCapabilities()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceCapabilities*>)_lpVtbl[21])((RenderDevice*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("const RenderDeviceDescription &")]
        public readonly RenderDeviceDescription* GetDescription()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderDeviceDescription*>)_lpVtbl[22])((RenderDevice*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("plume::RenderSampleCounts")]
        public readonly uint GetSampleCountsSupported([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, RenderFormat, uint>)_lpVtbl[23])((RenderDevice*)Unsafe.AsPointer(in this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public bool BeginCapture()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, bool>)_lpVtbl[24])((RenderDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public bool EndCapture()
        {
            return ((delegate* unmanaged[Thiscall]<RenderDevice*, bool>)_lpVtbl[25])((RenderDevice*)Unsafe.AsPointer(ref this));
        }
    }
}
