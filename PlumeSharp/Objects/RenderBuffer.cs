using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderBuffer : IDisposable
    {
        private void** _lpVtbl;

        [return: NativeTypeName("plume::RenderBufferReference")]
        public readonly RenderBufferReference At([NativeTypeName("uint64_t")] ulong offset)
        {
            return new RenderBufferReference((RenderBuffer*)Unsafe.AsPointer(in this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, void>)_lpVtbl[1])((RenderBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void* Map([NativeTypeName("uint32_t")] uint subresource = 0, [NativeTypeName("const RenderRange *")] RenderRange* readRange = null)
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void*>)_lpVtbl[2])((RenderBuffer*)Unsafe.AsPointer(ref this), subresource, readRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Unmap([NativeTypeName("uint32_t")] uint subresource = 0, [NativeTypeName("const RenderRange *")] RenderRange* writtenRange = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void>)_lpVtbl[3])((RenderBuffer*)Unsafe.AsPointer(ref this), subresource, writtenRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("plume::RenderBufferFormattedView *")]
        public RenderBufferFormattedView* CreateBufferFormattedView([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, RenderFormat, RenderBufferFormattedView*>)_lpVtbl[4])((RenderBuffer*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, sbyte*, void>)_lpVtbl[5])((RenderBuffer*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("uint64_t")]
        public readonly ulong GetDeviceAddress()
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, ulong>)_lpVtbl[6])((RenderBuffer*)Unsafe.AsPointer(in this));
        }
    }
}
