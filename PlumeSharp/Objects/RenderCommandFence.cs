using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandFence : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandFence*, void>)_lpVtbl[1])((RenderCommandFence*)Unsafe.AsPointer(ref this));
        }
    }
}
