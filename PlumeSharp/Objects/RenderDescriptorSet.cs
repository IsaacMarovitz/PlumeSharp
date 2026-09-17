using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderDescriptorSet : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, void>)LpVtbl[1])((RenderDescriptorSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetBuffer([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderBuffer *")] RenderBuffer* buffer, [NativeTypeName("uint64_t")] ulong bufferSize = 0, [NativeTypeName("const RenderBufferStructuredView *")] RenderBufferStructuredView* bufferStructuredView = null, [NativeTypeName("const RenderBufferFormattedView *")] RenderBufferFormattedView* bufferFormattedView = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderBuffer*, ulong, RenderBufferStructuredView*, RenderBufferFormattedView*, void>)LpVtbl[2])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, buffer, bufferSize, bufferStructuredView, bufferFormattedView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetTexture([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderTexture *")] RenderTexture* texture, [NativeTypeName("plume::RenderTextureLayout")] RenderTextureLayout textureLayout, [NativeTypeName("const RenderTextureView *")] RenderTextureView* textureView = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderTexture*, RenderTextureLayout, RenderTextureView*, void>)LpVtbl[3])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, texture, textureLayout, textureView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetSampler([NativeTypeName("uint32_t")] uint descriptorIndex, [NativeTypeName("const RenderSampler *")] RenderSampler* sampler)
        {
            ((delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderSampler*, void>)LpVtbl[4])((RenderDescriptorSet*)Unsafe.AsPointer(ref this), descriptorIndex, sampler);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderDescriptorSet*, void> Dispose;

            [NativeTypeName("void (uint32_t, const RenderBuffer *, uint64_t, const RenderBufferStructuredView *, const RenderBufferFormattedView *)")]
            public delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderBuffer*, ulong, RenderBufferStructuredView*, RenderBufferFormattedView*, void> SetBuffer;

            [NativeTypeName("void (uint32_t, const RenderTexture *, RenderTextureLayout, const RenderTextureView *)")]
            public delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderTexture*, RenderTextureLayout, RenderTextureView*, void> SetTexture;

            [NativeTypeName("void (uint32_t, const RenderSampler *)")]
            public delegate* unmanaged[Thiscall]<RenderDescriptorSet*, uint, RenderSampler*, void> SetSampler;
        }
    }
}
