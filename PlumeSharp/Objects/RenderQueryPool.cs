using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderQueryPool : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderQueryPool*, void>)LpVtbl[1])((RenderQueryPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void QueryResults()
        {
            ((delegate* unmanaged[Thiscall]<RenderQueryPool*, void>)LpVtbl[2])((RenderQueryPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("const uint64_t *")]
        public readonly ulong* GetResults()
        {
            return ((delegate* unmanaged[Thiscall]<RenderQueryPool*, ulong*>)LpVtbl[3])((RenderQueryPool*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderQueryPool*, uint>)LpVtbl[4])((RenderQueryPool*)Unsafe.AsPointer(in this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderQueryPool*, void> Dispose;

            [NativeTypeName("void ()")]
            public delegate* unmanaged[Thiscall]<RenderQueryPool*, void> QueryResults;

            [NativeTypeName("const uint64_t *() const")]
            public delegate* unmanaged[Thiscall]<RenderQueryPool*, ulong*> GetResults;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderQueryPool*, uint> GetCount;
        }
    }
}
