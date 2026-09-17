using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderTextureView : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderTextureView*, void>)_lpVtbl[1])((RenderTextureView*)Unsafe.AsPointer(ref this));
        }
    }
}
