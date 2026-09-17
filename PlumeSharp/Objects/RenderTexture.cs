using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderTexture : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderTexture*, void>)_lpVtbl[1])((RenderTexture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderTextureView *")]
        public readonly RenderTextureView* CreateTextureView([NativeTypeName("const RenderTextureViewDesc &")] RenderTextureViewDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderTexture*, RenderTextureViewDesc*, RenderTextureView*>)_lpVtbl[2])((RenderTexture*)Unsafe.AsPointer(in this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderTexture*, sbyte*, void>)_lpVtbl[3])((RenderTexture*)Unsafe.AsPointer(ref this), name);
        }
    }
}
