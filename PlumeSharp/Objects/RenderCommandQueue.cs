using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandQueue : IDisposable
    {
        private void** _lpVtbl;

        public void ExecuteCommandLists(RenderCommandList* commandList, RenderCommandFence* signalFence = null)
        {
            ExecuteCommandLists(&commandList, 1, null, 0, null, 0, signalFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandQueue*, void>)_lpVtbl[1])((RenderCommandQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("plume::RenderCommandList *")]
        public RenderCommandList* CreateCommandList()
        {
            return ((delegate* unmanaged[Thiscall]<RenderCommandQueue*, RenderCommandList*>)_lpVtbl[2])((RenderCommandQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderSwapChain *")]
        public RenderSwapChain* CreateSwapChain([NativeTypeName("const RenderSwapChainDesc &")] RenderSwapChainDesc* desc)
        {
            return ((delegate* unmanaged[Thiscall]<RenderCommandQueue*, RenderSwapChainDesc*, RenderSwapChain*>)_lpVtbl[3])((RenderCommandQueue*)Unsafe.AsPointer(ref this), desc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ExecuteCommandLists([NativeTypeName("const RenderCommandList **")] RenderCommandList** commandLists, [NativeTypeName("uint32_t")] uint commandListCount, RenderCommandSemaphore** waitSemaphores = null, [NativeTypeName("uint32_t")] uint waitSemaphoreCount = 0, RenderCommandSemaphore** signalSemaphores = null, [NativeTypeName("uint32_t")] uint signalSemaphoreCount = 0, [NativeTypeName("plume::RenderCommandFence *")] RenderCommandFence* signalFence = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandQueue*, RenderCommandList**, uint, RenderCommandSemaphore**, uint, RenderCommandSemaphore**, uint, RenderCommandFence*, void>)_lpVtbl[4])((RenderCommandQueue*)Unsafe.AsPointer(ref this), commandLists, commandListCount, waitSemaphores, waitSemaphoreCount, signalSemaphores, signalSemaphoreCount, signalFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void WaitForCommandFence([NativeTypeName("plume::RenderCommandFence *")] RenderCommandFence* fence)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandQueue*, RenderCommandFence*, void>)_lpVtbl[5])((RenderCommandQueue*)Unsafe.AsPointer(ref this), fence);
        }
    }
}
