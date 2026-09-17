using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderSampler : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderSampler*, void>)_lpVtbl[1])((RenderSampler*)Unsafe.AsPointer(ref this));
        }
    }
}
