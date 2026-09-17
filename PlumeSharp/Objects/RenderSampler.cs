using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderSampler : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderSampler*, void>)LpVtbl[1])((RenderSampler*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderSampler*, void> Dispose;
        }
    }
}
