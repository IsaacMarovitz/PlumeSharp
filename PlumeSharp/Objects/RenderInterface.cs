using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderInterface : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderInterface*, void>)_lpVtbl[1])((RenderInterface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderDevice *")]
        public RenderDevice* CreateDevice([NativeTypeName("const char *")] sbyte* preferredDeviceName = null)
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, sbyte*, RenderDevice*>)_lpVtbl[2])((RenderInterface*)Unsafe.AsPointer(ref this), preferredDeviceName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetDeviceCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, uint>)_lpVtbl[3])((RenderInterface*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("const char *")]
        public readonly sbyte* GetDeviceName([NativeTypeName("uint32_t")] uint index)
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, uint, sbyte*>)_lpVtbl[4])((RenderInterface*)Unsafe.AsPointer(in this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("const RenderInterfaceCapabilities &")]
        public readonly RenderInterfaceCapabilities* GetCapabilities()
        {
            return ((delegate* unmanaged[Thiscall]<RenderInterface*, RenderInterfaceCapabilities*>)_lpVtbl[5])((RenderInterface*)Unsafe.AsPointer(in this));
        }
    }
}
