using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderFramebuffer : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, void>)LpVtbl[1])((RenderFramebuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetWidth()
        {
            return ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint>)LpVtbl[2])((RenderFramebuffer*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetHeight()
        {
            return ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint>)LpVtbl[3])((RenderFramebuffer*)Unsafe.AsPointer(in this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderFramebuffer*, void> Dispose;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint> GetWidth;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint> GetHeight;
        }
    }
}
