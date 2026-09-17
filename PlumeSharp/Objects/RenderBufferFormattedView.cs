using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderBufferFormattedView : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderBufferFormattedView*, void>)LpVtbl[1])((RenderBufferFormattedView*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderBufferFormattedView*, void> Dispose;
        }
    }
}
