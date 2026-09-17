using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderBufferFormattedView : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderBufferFormattedView*, void>)_lpVtbl[1])((RenderBufferFormattedView*)Unsafe.AsPointer(ref this));
        }
    }
}
