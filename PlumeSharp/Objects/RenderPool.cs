using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPool : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPool*, void>)_lpVtbl[1])((RenderPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderBuffer *")]
        public RenderBuffer* CreateBuffer([NativeTypeName("const RenderBufferDesc &")] RenderBufferDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderPool*, RenderBufferDesc*, RenderBuffer*>)_lpVtbl[2])((RenderPool*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* CreateTexture([NativeTypeName("const RenderTextureDesc &")] RenderTextureDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderPool*, RenderTextureDesc*, RenderTexture*>)_lpVtbl[3])((RenderPool*)Unsafe.AsPointer(ref this), desc);
        }
    }
}
