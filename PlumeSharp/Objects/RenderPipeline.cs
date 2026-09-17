using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderPipeline : IDisposable
    {
        private void** _lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderPipeline*, void>)_lpVtbl[1])((RenderPipeline*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void SetName([NativeTypeName("const char *")] sbyte* name)
        {
            ((delegate* unmanaged[Thiscall]<RenderPipeline*, sbyte*, void>)_lpVtbl[2])((RenderPipeline*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("plume::RenderPipelineProgram")]
        public readonly RenderPipelineProgram GetProgram([NativeTypeName("const char *")] sbyte* name)
        {
            RenderPipelineProgram result;
            return *((delegate* unmanaged[Thiscall]<RenderPipeline*, RenderPipelineProgram*, sbyte*, RenderPipelineProgram*>)_lpVtbl[3])((RenderPipeline*)Unsafe.AsPointer(in this), &result, name);
        }
    }
}
