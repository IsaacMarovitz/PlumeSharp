using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderQueryPool : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderQueryPool*, void>)_lpVtbl[1])((RenderQueryPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void QueryResults()
        {
            ((delegate* unmanaged[Thiscall]<RenderQueryPool*, void>)_lpVtbl[2])((RenderQueryPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("const uint64_t *")]
        public readonly ulong* GetResults()
        {
            return ((delegate* unmanaged[Thiscall]<RenderQueryPool*, ulong*>)_lpVtbl[3])((RenderQueryPool*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderQueryPool*, uint>)_lpVtbl[4])((RenderQueryPool*)Unsafe.AsPointer(in this));
        }
    }
}
