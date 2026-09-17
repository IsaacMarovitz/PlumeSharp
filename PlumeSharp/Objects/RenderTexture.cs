using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderTexture : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderTexture*, void>)LpVtbl[1])((RenderTexture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderTextureView *")]
        public readonly RenderTextureView* CreateTextureView([NativeTypeName("const RenderTextureViewDesc &")] RenderTextureViewDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderTexture*, RenderTextureViewDesc*, RenderTextureView*>)LpVtbl[2])((RenderTexture*)Unsafe.AsPointer(in this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderTexture*, sbyte*, void>)LpVtbl[3])((RenderTexture*)Unsafe.AsPointer(ref this), name);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderTexture*, void> Dispose;

            [NativeTypeName("RenderTextureView *(const RenderTextureViewDesc &) const")]
            public delegate* unmanaged[Thiscall]<RenderTexture*, RenderTextureViewDesc*, RenderTextureView*> CreateTextureViewRaw;

            [NativeTypeName("void (const char *)")]
            public delegate* unmanaged[Thiscall]<RenderTexture*, sbyte*, void> SetName;
        }
    }
}
