using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderBuffer : IDisposable
    {
        public void** LpVtbl;

        [return: NativeTypeName("plume::RenderBufferReference")]
        public readonly RenderBufferReference At([NativeTypeName("uint64_t")] ulong offset)
        {
            return new RenderBufferReference((RenderBuffer*)Unsafe.AsPointer(in this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, void>)LpVtbl[1])((RenderBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void* Map([NativeTypeName("uint32_t")] uint subresource = 0, [NativeTypeName("const RenderRange *")] RenderRange* readRange = null)
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void*>)LpVtbl[2])((RenderBuffer*)Unsafe.AsPointer(ref this), subresource, readRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Unmap([NativeTypeName("uint32_t")] uint subresource = 0, [NativeTypeName("const RenderRange *")] RenderRange* writtenRange = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void>)LpVtbl[3])((RenderBuffer*)Unsafe.AsPointer(ref this), subresource, writtenRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("plume::RenderBufferFormattedView *")]
        public RenderBufferFormattedView* CreateBufferFormattedViewRaw([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, RenderFormat, RenderBufferFormattedView*>)LpVtbl[4])((RenderBuffer*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderBuffer*, sbyte*, void>)LpVtbl[5])((RenderBuffer*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("uint64_t")]
        public readonly ulong GetDeviceAddress()
        {
            return ((delegate* unmanaged[Thiscall]<RenderBuffer*, ulong>)LpVtbl[6])((RenderBuffer*)Unsafe.AsPointer(in this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, void> Dispose;

            [NativeTypeName("void *(uint32_t, const RenderRange *)")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void*> Map;

            [NativeTypeName("void (uint32_t, const RenderRange *)")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, uint, RenderRange*, void> Unmap;

            [NativeTypeName("RenderBufferFormattedView *(RenderFormat)")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, RenderFormat, RenderBufferFormattedView*> CreateBufferFormattedViewRaw;

            [NativeTypeName("void (const char *)")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, sbyte*, void> SetName;

            [NativeTypeName("uint64_t () const")]
            public delegate* unmanaged[Thiscall]<RenderBuffer*, ulong> GetDeviceAddress;
        }
    }
}
