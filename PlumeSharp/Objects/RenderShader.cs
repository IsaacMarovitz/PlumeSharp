using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderShader : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderShader*, void>)LpVtbl[1])((RenderShader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderShader*, sbyte*, void>)LpVtbl[2])((RenderShader*)Unsafe.AsPointer(ref this), name);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderShader*, void> Dispose;

            [NativeTypeName("void (const char *)")]
            public delegate* unmanaged[Thiscall]<RenderShader*, sbyte*, void> SetName;
        }
    }
}
