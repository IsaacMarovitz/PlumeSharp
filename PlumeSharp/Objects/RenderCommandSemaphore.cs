using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandSemaphore : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandSemaphore*, void>)LpVtbl[1])((RenderCommandSemaphore*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderCommandSemaphore*, void> Dispose;
        }
    }
}
