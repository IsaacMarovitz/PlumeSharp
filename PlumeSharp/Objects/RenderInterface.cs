using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderInterface : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderInterface*, void>)LpVtbl[1])((RenderInterface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderDevice *")]
        public RenderDevice* CreateDeviceRaw([NativeTypeName("const char *")] sbyte* preferredDeviceName = null)
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, sbyte*, RenderDevice*>)LpVtbl[2])((RenderInterface*)Unsafe.AsPointer(ref this), preferredDeviceName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetDeviceCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, uint>)LpVtbl[3])((RenderInterface*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("const char *")]
        public readonly sbyte* GetDeviceName([NativeTypeName("uint32_t")] uint index)
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, uint, sbyte*>)LpVtbl[4])((RenderInterface*)Unsafe.AsPointer(in this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("const RenderInterfaceCapabilities &")]
        public readonly RenderInterfaceCapabilities* GetCapabilities()
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, RenderInterfaceCapabilities*>)LpVtbl[5])((RenderInterface*)Unsafe.AsPointer(in this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderInterface*, void> Dispose;

            [NativeTypeName("RenderDevice *(const char *)")]
            public delegate* unmanaged[Thiscall]<RenderInterface*, sbyte*, RenderDevice*> CreateDeviceRaw;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderInterface*, uint> GetDeviceCount;

            [NativeTypeName("const char *(uint32_t) const")]
            public delegate* unmanaged[Thiscall]<RenderInterface*, uint, sbyte*> GetDeviceName;

            [NativeTypeName("const RenderInterfaceCapabilities &() const")]
            public delegate* unmanaged[Thiscall]<RenderInterface*, RenderInterfaceCapabilities*> GetCapabilities;
        }
    }
}
