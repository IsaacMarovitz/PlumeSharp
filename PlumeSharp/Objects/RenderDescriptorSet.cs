using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderDescriptorSet : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, void>)_lpVtbl[1])((RenderDescriptorSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetBuffer([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderBuffer *")] RenderBuffer* buffer, [NativeTypeName("uint64_t")] ulong bufferSize = 0, [NativeTypeName("const RenderBufferStructuredView *")] RenderBufferStructuredView* bufferStructuredView = null, [NativeTypeName("const RenderBufferFormattedView *")] RenderBufferFormattedView* bufferFormattedView = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderBuffer*, ulong, RenderBufferStructuredView*, RenderBufferFormattedView*, void>)_lpVtbl[2])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, buffer, bufferSize, bufferStructuredView, bufferFormattedView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetTexture([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderTexture *")] RenderTexture* texture, [NativeTypeName("plume::RenderTextureLayout")] RenderTextureLayout textureLayout, [NativeTypeName("const RenderTextureView *")] RenderTextureView* textureView = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderTexture*, RenderTextureLayout, RenderTextureView*, void>)_lpVtbl[3])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, texture, textureLayout, textureView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetSampler([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderSampler *")] RenderSampler* sampler)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderSampler*, void>)_lpVtbl[4])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, sampler);
        }
    }
}
