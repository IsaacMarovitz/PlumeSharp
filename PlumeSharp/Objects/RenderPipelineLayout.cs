using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPipelineLayout : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPipelineLayout*, void>)_lpVtbl[1])((RenderPipelineLayout*)Unsafe.AsPointer(ref this));
        }
    }
}
