using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandFence : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandFence*, void>)LpVtbl[1])((RenderCommandFence*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderCommandFence*, void> Dispose;
        }
    }
}
