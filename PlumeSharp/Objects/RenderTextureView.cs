using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderTextureView : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderTextureView*, void>)LpVtbl[1])((RenderTextureView*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderTextureView*, void> Dispose;
        }
    }
}
