using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderSwapChain : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, void>)_lpVtbl[1])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public bool Present([NativeTypeName("uint32_t")] uint textureIndex, RenderCommandSemaphore** waitSemaphores, [NativeTypeName("uint32_t")] uint waitSemaphoreCount)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderCommandSemaphore**, uint, bool>)_lpVtbl[2])((RenderSwapChain*)Unsafe.AsPointer(ref this), textureIndex, waitSemaphores, waitSemaphoreCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Wait()
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, void>)_lpVtbl[3])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public bool Resize()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)_lpVtbl[4])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public readonly bool NeedsResize()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)_lpVtbl[5])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetVsyncEnabled(bool vsyncEnabled)
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool, void>)_lpVtbl[6])((RenderSwapChain*)Unsafe.AsPointer(ref this), vsyncEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public readonly bool IsVsyncEnabled()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)_lpVtbl[7])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetWidth()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)_lpVtbl[8])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetHeight()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)_lpVtbl[9])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* GetTexture([NativeTypeName("uint32_t")] uint textureIndex)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderTexture*>)_lpVtbl[10])((RenderSwapChain*)Unsafe.AsPointer(ref this), textureIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetTextureCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)_lpVtbl[11])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public bool AcquireTexture([NativeTypeName("plume::RenderCommandSemaphore *")] RenderCommandSemaphore* signalSemaphore, [NativeTypeName("uint32_t *")] uint* textureIndex)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderCommandSemaphore*, uint*, bool>)_lpVtbl[12])((RenderSwapChain*)Unsafe.AsPointer(ref this), signalSemaphore, textureIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("plume::RenderWindow")]
        public readonly RenderWindow GetWindow()
        {
            RenderWindow result;
            return *((delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderWindow*, RenderWindow*>)_lpVtbl[13])((RenderSwapChain*)Unsafe.AsPointer(in this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public readonly bool IsEmpty()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)_lpVtbl[14])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetRefreshRate()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)_lpVtbl[15])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }
    }
}
