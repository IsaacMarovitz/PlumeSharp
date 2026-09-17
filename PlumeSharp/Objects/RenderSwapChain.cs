using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderSwapChain : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, void>)LpVtbl[1])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public bool Present([NativeTypeName("uint32_t")] uint textureIndex, RenderCommandSemaphore** waitSemaphores, [NativeTypeName("uint32_t")] uint waitSemaphoreCount)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderCommandSemaphore**, uint, bool>)LpVtbl[2])((RenderSwapChain*)Unsafe.AsPointer(ref this), textureIndex, waitSemaphores, waitSemaphoreCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Wait()
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, void>)LpVtbl[3])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public bool Resize()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)LpVtbl[4])((RenderSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public readonly bool NeedsResize()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)LpVtbl[5])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetVsyncEnabled(bool vsyncEnabled)
        {
            ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool, void>)LpVtbl[6])((RenderSwapChain*)Unsafe.AsPointer(ref this), vsyncEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public readonly bool IsVsyncEnabled()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)LpVtbl[7])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetWidth()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)LpVtbl[8])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetHeight()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)LpVtbl[9])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("plume::RenderTexture *")]
        public RenderTexture* GetTexture([NativeTypeName("uint32_t")] uint textureIndex)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderTexture*>)LpVtbl[10])((RenderSwapChain*)Unsafe.AsPointer(ref this), textureIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetTextureCount()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)LpVtbl[11])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public bool AcquireTexture([NativeTypeName("plume::RenderCommandSemaphore *")] RenderCommandSemaphore* signalSemaphore, [NativeTypeName("uint32_t *")] uint* textureIndex)
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderCommandSemaphore*, uint*, bool>)LpVtbl[12])((RenderSwapChain*)Unsafe.AsPointer(ref this), signalSemaphore, textureIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("plume::RenderWindow")]
        public readonly RenderWindow GetWindow()
        {
            RenderWindow result;
            return *((delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderWindow*, RenderWindow*>)LpVtbl[13])((RenderSwapChain*)Unsafe.AsPointer(in this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public readonly bool IsEmpty()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, bool>)LpVtbl[14])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("uint32_t")]
        public readonly uint GetRefreshRate()
        {
            return ((delegate* unmanaged[Thiscall]<RenderSwapChain*, uint>)LpVtbl[15])((RenderSwapChain*)Unsafe.AsPointer(in this));
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, void> Dispose;

            [NativeTypeName("bool (uint32_t, RenderCommandSemaphore **, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderCommandSemaphore**, uint, bool> Present;

            [NativeTypeName("void ()")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, void> Wait;

            [NativeTypeName("bool ()")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, bool> Resize;

            [NativeTypeName("bool () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, bool> NeedsResize;

            [NativeTypeName("void (bool)")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, bool, void> SetVsyncEnabled;

            [NativeTypeName("bool () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, bool> IsVsyncEnabled;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint> GetWidth;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint> GetHeight;

            [NativeTypeName("RenderTexture *(uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint, RenderTexture*> GetTexture;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint> GetTextureCount;

            [NativeTypeName("bool (RenderCommandSemaphore *, uint32_t *)")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderCommandSemaphore*, uint*, bool> AcquireTexture;

            [NativeTypeName("RenderWindow () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, RenderWindow*, RenderWindow*> GetWindow;

            [NativeTypeName("bool () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, bool> IsEmpty;

            [NativeTypeName("uint32_t () const")]
            public delegate* unmanaged[Thiscall]<RenderSwapChain*, uint> GetRefreshRate;
        }
    }
}
