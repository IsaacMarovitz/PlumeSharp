using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderFramebuffer : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, void>)_lpVtbl[1])((RenderFramebuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetWidth()
        {
            return ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint>)_lpVtbl[2])((RenderFramebuffer*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetHeight()
        {
            return ((delegate* unmanaged[Thiscall]<RenderFramebuffer*, uint>)_lpVtbl[3])((RenderFramebuffer*)Unsafe.AsPointer(in this));
        }
    }
}
