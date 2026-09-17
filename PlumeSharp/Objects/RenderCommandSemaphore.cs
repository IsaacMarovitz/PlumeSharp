using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandSemaphore : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandSemaphore*, void>)_lpVtbl[1])((RenderCommandSemaphore*)Unsafe.AsPointer(ref this));
        }
    }
}
