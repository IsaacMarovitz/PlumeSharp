using System.Runtime.CompilerServices;
using static Plume.RenderResolveMode;

namespace Plume
{
    public unsafe struct RenderCommandList : IDisposable
    {
        public void** LpVtbl;

        public void Barriers(RenderBarrierStages stages, RenderBufferBarrier* barrier)
        {
            Barriers(stages, barrier, 1, null, 0);
        }

        public void Barriers(RenderBarrierStages stages, RenderTextureBarrier* barrier)
        {
            Barriers(stages, null, 0, barrier, 1);
        }

        public void Barriers(RenderBarrierStages stages, RenderBufferBarrier* bufferBarrier, RenderTextureBarrier* textureBarrier)
        {
            Barriers(stages, bufferBarrier, 1, textureBarrier, 1);
        }

        public void Barriers(RenderBarrierStages stages, RenderBufferBarrier* bufferBarriers, uint bufferBarriersCount)
        {
            Barriers(stages, bufferBarriers, bufferBarriersCount, null, 0);
        }

        // TODO: Deal with this
        // public void Barriers(RenderBarrierStages stages, List<RenderBufferBarrier> bufferBarriers)
        // {
        //     Barriers(stages, bufferBarriers, bufferBarriers.Count, null, 0);
        // }

        public void Barriers(RenderBarrierStages stages, RenderTextureBarrier* textureBarriers, uint textureBarriersCount)
        {
            Barriers(stages, null, 0, textureBarriers, textureBarriersCount);
        }

        // TODO: Deal with this
        // public void Barriers(RenderBarrierStages stages, vector<RenderTextureBarrier>* textureBarriers)
        // {
        //     Barriers(stages, null, 0, textureBarriers->data(), unchecked((uint)(textureBarriers->size())));
        // }
        //
        // public void Barriers(RenderBarrierStages stages, vector<RenderBufferBarrier>* bufferBarriers, vector<RenderTextureBarrier>* textureBarriers)
        // {
        //     Barriers(stages, bufferBarriers->data(), unchecked((uint)(bufferBarriers->size())), textureBarriers->data(), unchecked((uint)(textureBarriers->size())));
        // }

        public void SetViewports(RenderViewport* viewport)
        {
            SetViewports(viewport, 1);
        }

        public void SetScissors(RenderRect* scissorRect)
        {
            SetScissors(scissorRect, 1);
        }

        public void ClearDepth(bool clearDepth = true, float depthValue = 1.0f, RenderRect* clearRects = null, uint clearRectsCount = 0)
        {
            ClearDepthStencil(clearDepth, false, depthValue, 0, clearRects, clearRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)LpVtbl[1])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void Begin()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)LpVtbl[2])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void End()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)LpVtbl[3])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Barriers([NativeTypeName("plume::RenderBarrierStages")] RenderBarrierStages stages, [NativeTypeName("const RenderBufferBarrier *")] RenderBufferBarrier* bufferBarriers, [NativeTypeName("uint32_t")] uint bufferBarriersCount, [NativeTypeName("const RenderTextureBarrier *")] RenderTextureBarrier* textureBarriers, [NativeTypeName("uint32_t")] uint textureBarriersCount)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBarrierStages, RenderBufferBarrier*, uint, RenderTextureBarrier*, uint, void>)LpVtbl[4])((RenderCommandList*)Unsafe.AsPointer(ref this), stages, bufferBarriers, bufferBarriersCount, textureBarriers, textureBarriersCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void Dispatch([NativeTypeName("uint32_t")] uint threadGroupCountX, [NativeTypeName("uint32_t")] uint threadGroupCountY, [NativeTypeName("uint32_t")] uint threadGroupCountZ)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, void>)LpVtbl[5])((RenderCommandList*)Unsafe.AsPointer(ref this), threadGroupCountX, threadGroupCountY, threadGroupCountZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void DrawInstanced([NativeTypeName("uint32_t")] uint vertexCountPerInstance, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint startVertexLocation, [NativeTypeName("uint32_t")] uint startInstanceLocation)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, uint, void>)LpVtbl[7])((RenderCommandList*)Unsafe.AsPointer(ref this), vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void DrawIndexedInstanced([NativeTypeName("uint32_t")] uint indexCountPerInstance, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint startIndexLocation, [NativeTypeName("int32_t")] int baseVertexLocation, [NativeTypeName("uint32_t")] uint startInstanceLocation)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, int, uint, void>)LpVtbl[8])((RenderCommandList*)Unsafe.AsPointer(ref this), indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void SetPipeline([NativeTypeName("const RenderPipeline *")] RenderPipeline* pipeline)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipeline*, void>)LpVtbl[9])((RenderCommandList*)Unsafe.AsPointer(ref this), pipeline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void SetComputePipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)LpVtbl[10])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetComputePushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)LpVtbl[11])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void SetComputeDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)LpVtbl[12])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void SetGraphicsPipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)LpVtbl[13])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void SetGraphicsPushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)LpVtbl[14])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void SetGraphicsDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)LpVtbl[15])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void SetGraphicsRootDescriptor([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference bufferReference, [NativeTypeName("uint32_t")] uint rootDescriptorIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, uint, void>)LpVtbl[16])((RenderCommandList*)Unsafe.AsPointer(ref this), bufferReference, rootDescriptorIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void SetRaytracingPipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)LpVtbl[17])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void SetRaytracingPushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)LpVtbl[18])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void SetRaytracingDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)LpVtbl[19])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void SetIndexBuffer([NativeTypeName("const RenderIndexBufferView *")] RenderIndexBufferView* view)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderIndexBufferView*, void>)LpVtbl[20])((RenderCommandList*)Unsafe.AsPointer(ref this), view);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetVertexBuffers([NativeTypeName("uint32_t")] uint startSlot, [NativeTypeName("const RenderVertexBufferView *")] RenderVertexBufferView* views, [NativeTypeName("uint32_t")] uint viewCount, [NativeTypeName("const RenderInputSlot *")] RenderInputSlot* inputSlots)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderVertexBufferView*, uint, RenderInputSlot*, void>)LpVtbl[21])((RenderCommandList*)Unsafe.AsPointer(ref this), startSlot, views, viewCount, inputSlots);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void SetViewports([NativeTypeName("const RenderViewport *")] RenderViewport* viewports, [NativeTypeName("uint32_t")] uint count)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderViewport*, uint, void>)LpVtbl[22])((RenderCommandList*)Unsafe.AsPointer(ref this), viewports, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void SetScissors([NativeTypeName("const RenderRect *")] RenderRect* scissorRects, [NativeTypeName("uint32_t")] uint count)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderRect*, uint, void>)LpVtbl[23])((RenderCommandList*)Unsafe.AsPointer(ref this), scissorRects, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void SetFramebuffer([NativeTypeName("const RenderFramebuffer *")] RenderFramebuffer* framebuffer)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderFramebuffer*, void>)LpVtbl[24])((RenderCommandList*)Unsafe.AsPointer(ref this), framebuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void SetDepthBias(float depthBias, float depthBiasClamp, float slopeScaledDepthBias)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, float, float, float, void>)LpVtbl[25])((RenderCommandList*)Unsafe.AsPointer(ref this), depthBias, depthBiasClamp, slopeScaledDepthBias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void ClearColor([NativeTypeName("uint32_t")] uint attachmentIndex = 0, [NativeTypeName("plume::RenderColor")] RenderColor colorValue = default, [NativeTypeName("const RenderRect *")] RenderRect* clearRects = null, [NativeTypeName("uint32_t")] uint clearRectsCount = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderColor, RenderRect*, uint, void>)LpVtbl[26])((RenderCommandList*)Unsafe.AsPointer(ref this), attachmentIndex, colorValue, clearRects, clearRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void ClearDepthStencil(bool clearDepth = true, bool clearStencil = true, float depthValue = 1.0f, [NativeTypeName("uint32_t")] uint stencilValue = 0, [NativeTypeName("const RenderRect *")] RenderRect* clearRects = null, [NativeTypeName("uint32_t")] uint clearRectsCount = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, bool, bool, float, uint, RenderRect*, uint, void>)LpVtbl[27])((RenderCommandList*)Unsafe.AsPointer(ref this), clearDepth, clearStencil, depthValue, stencilValue, clearRects, clearRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void CopyBufferRegion([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference dstBuffer, [NativeTypeName("plume::RenderBufferReference")] RenderBufferReference srcBuffer, [NativeTypeName("uint64_t")] ulong size)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, RenderBufferReference, ulong, void>)LpVtbl[28])((RenderCommandList*)Unsafe.AsPointer(ref this), dstBuffer, srcBuffer, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void CopyTextureRegion([NativeTypeName("const RenderTextureCopyLocation &")] RenderTextureCopyLocation* dstLocation, [NativeTypeName("const RenderTextureCopyLocation &")] RenderTextureCopyLocation* srcLocation, [NativeTypeName("uint32_t")] uint dstX = 0, [NativeTypeName("uint32_t")] uint dstY = 0, [NativeTypeName("uint32_t")] uint dstZ = 0, [NativeTypeName("const RenderBox *")] RenderBox* srcBox = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTextureCopyLocation*, RenderTextureCopyLocation*, uint, uint, uint, RenderBox*, void>)LpVtbl[29])((RenderCommandList*)Unsafe.AsPointer(ref this), dstLocation, srcLocation, dstX, dstY, dstZ, srcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void CopyBuffer([NativeTypeName("const RenderBuffer *")] RenderBuffer* dstBuffer, [NativeTypeName("const RenderBuffer *")] RenderBuffer* srcBuffer)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBuffer*, RenderBuffer*, void>)LpVtbl[30])((RenderCommandList*)Unsafe.AsPointer(ref this), dstBuffer, srcBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void CopyTexture([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void>)LpVtbl[31])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, srcTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void ResolveTexture([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void>)LpVtbl[32])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, srcTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void ResolveTextureRegion([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("uint32_t")] uint dstX, [NativeTypeName("uint32_t")] uint dstY, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture, [NativeTypeName("const RenderRect *")] RenderRect* srcRect = null, [NativeTypeName("plume::RenderResolveMode")] RenderResolveMode resolveMode = Average)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, uint, uint, RenderTexture*, RenderRect*, RenderResolveMode, void>)LpVtbl[33])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, dstX, dstY, srcTexture, srcRect, resolveMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void DiscardTexture([NativeTypeName("const RenderTexture *")] RenderTexture* texture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, void>)LpVtbl[36])((RenderCommandList*)Unsafe.AsPointer(ref this), texture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void ResetQueryPool([NativeTypeName("const RenderQueryPool *")] RenderQueryPool* queryPool, [NativeTypeName("uint32_t")] uint queryFirstIndex, [NativeTypeName("uint32_t")] uint queryCount)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, uint, void>)LpVtbl[37])((RenderCommandList*)Unsafe.AsPointer(ref this), queryPool, queryFirstIndex, queryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void WriteTimestamp([NativeTypeName("const RenderQueryPool *")] RenderQueryPool* queryPool, [NativeTypeName("uint32_t")] uint queryIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, void>)LpVtbl[38])((RenderCommandList*)Unsafe.AsPointer(ref this), queryPool, queryIndex);
        }

        public struct Vtbl
        {
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, void> Dispose;

            [NativeTypeName("void ()")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, void> Begin;

            [NativeTypeName("void ()")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, void> End;

            [NativeTypeName("void (RenderBarrierStages, const RenderBufferBarrier *, uint32_t, const RenderTextureBarrier *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderBufferBarrier*, uint, RenderTextureBarrier*, uint, void> Barriers8;

            [NativeTypeName("void (uint32_t, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, void> Dispatch;

            [NativeTypeName("void (uint32_t, uint32_t, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, uint, void> DrawInstanced;

            [NativeTypeName("void (uint32_t, uint32_t, uint32_t, int32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

            [NativeTypeName("void (const RenderPipeline *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipeline*, void> SetPipeline;

            [NativeTypeName("void (const RenderPipelineLayout *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void> SetComputePipelineLayout;

            [NativeTypeName("void (uint32_t, const void *, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void> SetComputePushConstants;

            [NativeTypeName("void (RenderDescriptorSet *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void> SetComputeDescriptorSet;

            [NativeTypeName("void (const RenderPipelineLayout *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void> SetGraphicsPipelineLayout;

            [NativeTypeName("void (uint32_t, const void *, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void> SetGraphicsPushConstants;

            [NativeTypeName("void (RenderDescriptorSet *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void> SetGraphicsDescriptorSet;

            [NativeTypeName("void (RenderBufferReference, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, uint, void> SetGraphicsRootDescriptor;

            [NativeTypeName("void (const RenderPipelineLayout *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void> SetRaytracingPipelineLayout;

            [NativeTypeName("void (uint32_t, const void *, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void> SetRaytracingPushConstants;

            [NativeTypeName("void (RenderDescriptorSet *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void> SetRaytracingDescriptorSet;

            [NativeTypeName("void (const RenderIndexBufferView *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderIndexBufferView*, void> SetIndexBuffer;

            [NativeTypeName("void (uint32_t, const RenderVertexBufferView *, uint32_t, const RenderInputSlot *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderVertexBufferView*, uint, RenderInputSlot*, void> SetVertexBuffers;

            [NativeTypeName("void (const RenderViewport *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderViewport*, uint, void> SetViewports1;

            [NativeTypeName("void (const RenderRect *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderRect*, uint, void> SetScissors1;

            [NativeTypeName("void (const RenderFramebuffer *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderFramebuffer*, void> SetFramebuffer;

            [NativeTypeName("void (float, float, float)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, float, float, float, void> SetDepthBias;

            [NativeTypeName("void (uint32_t, RenderColor, const RenderRect *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderColor, RenderRect*, uint, void> ClearColor;

            [NativeTypeName("void (bool, bool, float, uint32_t, const RenderRect *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, bool, bool, float, uint, RenderRect*, uint, void> ClearDepthStencil;

            [NativeTypeName("void (RenderBufferReference, RenderBufferReference, uint64_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, RenderBufferReference, ulong, void> CopyBufferRegion;

            [NativeTypeName("void (const RenderTextureCopyLocation &, const RenderTextureCopyLocation &, uint32_t, uint32_t, uint32_t, const RenderBox *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTextureCopyLocation*, RenderTextureCopyLocation*, uint, uint, uint, RenderBox*, void> CopyTextureRegion;

            [NativeTypeName("void (const RenderBuffer *, const RenderBuffer *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBuffer*, RenderBuffer*, void> CopyBuffer;

            [NativeTypeName("void (const RenderTexture *, const RenderTexture *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void> CopyTexture;

            [NativeTypeName("void (const RenderTexture *, const RenderTexture *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void> ResolveTexture;

            [NativeTypeName("void (const RenderTexture *, uint32_t, uint32_t, const RenderTexture *, const RenderRect *, RenderResolveMode)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, uint, uint, RenderTexture*, RenderRect*, RenderResolveMode, void> ResolveTextureRegion;

            [NativeTypeName("void (const RenderTexture *)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, void> DiscardTexture;

            [NativeTypeName("void (const RenderQueryPool *, uint32_t, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, uint, void> ResetQueryPool;

            [NativeTypeName("void (const RenderQueryPool *, uint32_t)")]
            public delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, void> WriteTimestamp;
        }
    }
}
