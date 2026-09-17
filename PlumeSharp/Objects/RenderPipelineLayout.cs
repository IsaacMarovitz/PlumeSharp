using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPipelineLayout : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPipelineLayout*, void>)LpVtbl[1])((RenderPipelineLayout*)Unsafe.AsPointer(ref this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderPipelineLayout*, void> Dispose;
        }
    }
}
