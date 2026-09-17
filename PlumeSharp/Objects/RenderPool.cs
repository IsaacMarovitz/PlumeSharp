using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPool : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPool*, void>)LpVtbl[1])((RenderPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderBuffer *")]
        public RenderBuffer* CreateBuffer([NativeTypeName("const RenderBufferDesc &")] RenderBufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderPool*, RenderBufferDesc*, RenderBuffer*>)LpVtbl[2])((RenderPool*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* CreateTexture([NativeTypeName("const RenderTextureDesc &")] RenderTextureDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderPool*, RenderTextureDesc*, RenderTexture*>)LpVtbl[3])((RenderPool*)Unsafe.AsPointer(ref this), desc);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderPool*, void> Dispose;

            [NativeTypeName("RenderBuffer *(const RenderBufferDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderPool*, RenderBufferDesc*, RenderBuffer*> CreateBufferRaw;

            [NativeTypeName("RenderTexture *(const RenderTextureDesc &)")]
            public delegate* unmanaged[Thiscall]<RenderPool*, RenderTextureDesc*, RenderTexture*> CreateTextureRaw;
        }
    }
}
