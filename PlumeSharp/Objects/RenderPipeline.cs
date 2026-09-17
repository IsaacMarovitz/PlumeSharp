using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPipeline : IDisposable
    {
        public void** LpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPipeline*, void>)LpVtbl[1])((RenderPipeline*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderPipeline*, sbyte*, void>)LpVtbl[2])((RenderPipeline*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderPipelineProgram")]
        public readonly RenderPipelineProgram GetProgram([NativeTypeName("const char *")] sbyte* name)
        {
            RenderPipelineProgram result;
            return *((delegate* unmanaged[Thiscall]<RenderPipeline*, RenderPipelineProgram*, sbyte*, RenderPipelineProgram*>)LpVtbl[3])((RenderPipeline*)Unsafe.AsPointer(in this), &result, name);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderPipeline*, void> Dispose;

            [NativeTypeName("void (const char *)")]
            public delegate* unmanaged[Thiscall]<RenderPipeline*, sbyte*, void> SetName;

            [NativeTypeName("RenderPipelineProgram (const char *) const")]
            public delegate* unmanaged[Thiscall]<RenderPipeline*, RenderPipelineProgram*, sbyte*, RenderPipelineProgram*> GetProgram;
        }
    }
}
