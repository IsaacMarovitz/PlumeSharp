using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderShader : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderShader*, void>)_lpVtbl[1])((RenderShader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderShader*, sbyte*, void>)_lpVtbl[2])((RenderShader*)Unsafe.AsPointer(ref this), name);
        }
    }
}
