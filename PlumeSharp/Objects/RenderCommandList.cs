using System.Runtime.CompilerServices;

namespace Plume
{
    public unsafe struct RenderCommandList : IDisposable
    {
        private void** _lpVtbl;

        public void Barriers(RenderBarrierStages stages, in RenderBufferBarrier barrier)
        {
            fixed (RenderBufferBarrier* pBarrier = &barrier)
            {
                Barriers(stages, pBarrier, 1, null, 0);
            }
        }

        public void Barriers(RenderBarrierStages stages, in RenderTextureBarrier barrier)
        {
            fixed (RenderTextureBarrier* pBarrier = &barrier)
            {
                Barriers(stages, null, 0, pBarrier, 1);
            }
        }

        public void Barriers(RenderBarrierStages stages, in RenderBufferBarrier bufferBarrier, in RenderTextureBarrier textureBarrier)
        {
            fixed (RenderBufferBarrier* pBufferBarrier = &bufferBarrier)
            fixed (RenderTextureBarrier* pTextureBarrier = &textureBarrier)
            {
                Barriers(stages, pBufferBarrier, 1, pTextureBarrier, 1);
            }
        }

        public void Barriers(RenderBarrierStages stages, ReadOnlySpan<RenderBufferBarrier> bufferBarriers)
        {
            fixed (RenderBufferBarrier* pBufferBarriers = bufferBarriers)
            {
                Barriers(stages, pBufferBarriers, (uint)bufferBarriers.Length, null, 0);
            }
        }

        public void Barriers(RenderBarrierStages stages, ReadOnlySpan<RenderTextureBarrier> textureBarriers)
        {
            fixed (RenderTextureBarrier* pTextureBarriers = textureBarriers)
            {
                Barriers(stages, null, 0, pTextureBarriers, (uint)textureBarriers.Length);
            }
        }

        public void Barriers(RenderBarrierStages stages, ReadOnlySpan<RenderBufferBarrier> bufferBarriers, ReadOnlySpan<RenderTextureBarrier> textureBarriers)
        {
            fixed (RenderBufferBarrier* pBufferBarriers = bufferBarriers)
            fixed (RenderTextureBarrier* pTextureBarriers = textureBarriers)
            {
                Barriers(stages, pBufferBarriers, (uint)bufferBarriers.Length, pTextureBarriers, (uint)textureBarriers.Length);
            }
        }

        public void SetViewports(in RenderViewport viewport)
        {
            fixed (RenderViewport* pViewport = &viewport)
            {
                SetViewports(pViewport, 1);
            }
        }

        public void SetViewports(ReadOnlySpan<RenderViewport> viewports)
        {
            fixed (RenderViewport* pViewports = viewports)
            {
                SetViewports(pViewports, (uint)viewports.Length);
            }
        }

        public void SetScissors(in RenderRect scissorRect)
        {
            fixed (RenderRect* pScissor = &scissorRect)
            {
                SetScissors(pScissor, 1);
            }
        }

        public void SetScissors(ReadOnlySpan<RenderRect> scissorRects)
        {
            fixed (RenderRect* pScissors = scissorRects)
            {
                SetScissors(pScissors, (uint)scissorRects.Length);
            }
        }

        public void ClearDepth(bool clearDepth = true, float depthValue = 1.0f, ReadOnlySpan<RenderRect> clearRects = default)
        {
            fixed (RenderRect* pClearRects = clearRects)
            {
                ClearDepthStencil(clearDepth, false, depthValue, 0, pClearRects, (uint)clearRects.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void Dispose()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)_lpVtbl[1])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void Begin()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)_lpVtbl[2])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void End()
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, void>)_lpVtbl[3])((RenderCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Barriers([NativeTypeName("plume::RenderBarrierStages")] RenderBarrierStages stages, [NativeTypeName("const RenderBufferBarrier *")] RenderBufferBarrier* bufferBarriers, [NativeTypeName("uint32_t")] uint bufferBarriersCount, [NativeTypeName("const RenderTextureBarrier *")] RenderTextureBarrier* textureBarriers, [NativeTypeName("uint32_t")] uint textureBarriersCount)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBarrierStages, RenderBufferBarrier*, uint, RenderTextureBarrier*, uint, void>)_lpVtbl[4])((RenderCommandList*)Unsafe.AsPointer(ref this), stages, bufferBarriers, bufferBarriersCount, textureBarriers, textureBarriersCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void Dispatch([NativeTypeName("uint32_t")] uint threadGroupCountX, [NativeTypeName("uint32_t")] uint threadGroupCountY, [NativeTypeName("uint32_t")] uint threadGroupCountZ)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, void>)_lpVtbl[5])((RenderCommandList*)Unsafe.AsPointer(ref this), threadGroupCountX, threadGroupCountY, threadGroupCountZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void DrawInstanced([NativeTypeName("uint32_t")] uint vertexCountPerInstance, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint startVertexLocation, [NativeTypeName("uint32_t")] uint startInstanceLocation)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, uint, void>)_lpVtbl[7])((RenderCommandList*)Unsafe.AsPointer(ref this), vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void DrawIndexedInstanced([NativeTypeName("uint32_t")] uint indexCountPerInstance, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint startIndexLocation, [NativeTypeName("int32_t")] int baseVertexLocation, [NativeTypeName("uint32_t")] uint startInstanceLocation)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, uint, uint, int, uint, void>)_lpVtbl[8])((RenderCommandList*)Unsafe.AsPointer(ref this), indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void SetPipeline([NativeTypeName("const RenderPipeline *")] RenderPipeline* pipeline)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipeline*, void>)_lpVtbl[9])((RenderCommandList*)Unsafe.AsPointer(ref this), pipeline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void SetComputePipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)_lpVtbl[10])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetComputePushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)_lpVtbl[11])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void SetComputeDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)_lpVtbl[12])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void SetGraphicsPipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)_lpVtbl[13])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void SetGraphicsPushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)_lpVtbl[14])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void SetGraphicsDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)_lpVtbl[15])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void SetGraphicsRootDescriptor([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference bufferReference, [NativeTypeName("uint32_t")] uint rootDescriptorIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, uint, void>)_lpVtbl[16])((RenderCommandList*)Unsafe.AsPointer(ref this), bufferReference, rootDescriptorIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void SetRaytracingPipelineLayout([NativeTypeName("const RenderPipelineLayout *")] RenderPipelineLayout* pipelineLayout)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderPipelineLayout*, void>)_lpVtbl[17])((RenderCommandList*)Unsafe.AsPointer(ref this), pipelineLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void SetRaytracingPushConstants([NativeTypeName("uint32_t")] uint rangeIndex, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint offset = 0, [NativeTypeName("uint32_t")] uint size = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, void*, uint, uint, void>)_lpVtbl[18])((RenderCommandList*)Unsafe.AsPointer(ref this), rangeIndex, data, offset, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void SetRaytracingDescriptorSet([NativeTypeName("plume::RenderDescriptorSet *")] RenderDescriptorSet* descriptorSet, [NativeTypeName("uint32_t")] uint setIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderDescriptorSet*, uint, void>)_lpVtbl[19])((RenderCommandList*)Unsafe.AsPointer(ref this), descriptorSet, setIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void SetIndexBuffer([NativeTypeName("const RenderIndexBufferView *")] RenderIndexBufferView* view)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderIndexBufferView*, void>)_lpVtbl[20])((RenderCommandList*)Unsafe.AsPointer(ref this), view);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetVertexBuffers([NativeTypeName("uint32_t")] uint startSlot, [NativeTypeName("const RenderVertexBufferView *")] RenderVertexBufferView* views, [NativeTypeName("uint32_t")] uint viewCount, [NativeTypeName("const RenderInputSlot *")] RenderInputSlot* inputSlots)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderVertexBufferView*, uint, RenderInputSlot*, void>)_lpVtbl[21])((RenderCommandList*)Unsafe.AsPointer(ref this), startSlot, views, viewCount, inputSlots);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void SetViewports([NativeTypeName("const RenderViewport *")] RenderViewport* viewports, [NativeTypeName("uint32_t")] uint count)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderViewport*, uint, void>)_lpVtbl[22])((RenderCommandList*)Unsafe.AsPointer(ref this), viewports, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void SetScissors([NativeTypeName("const RenderRect *")] RenderRect* scissorRects, [NativeTypeName("uint32_t")] uint count)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderRect*, uint, void>)_lpVtbl[23])((RenderCommandList*)Unsafe.AsPointer(ref this), scissorRects, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void SetFramebuffer([NativeTypeName("const RenderFramebuffer *")] RenderFramebuffer* framebuffer)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderFramebuffer*, void>)_lpVtbl[24])((RenderCommandList*)Unsafe.AsPointer(ref this), framebuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void SetDepthBias(float depthBias, float depthBiasClamp, float slopeScaledDepthBias)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, float, float, float, void>)_lpVtbl[25])((RenderCommandList*)Unsafe.AsPointer(ref this), depthBias, depthBiasClamp, slopeScaledDepthBias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void ClearColor([NativeTypeName("uint32_t")] uint attachmentIndex = 0, [NativeTypeName("plume::RenderColor")] RenderColor? colorValue = null, [NativeTypeName("const RenderRect *")] RenderRect* clearRects = null, [NativeTypeName("uint32_t")] uint clearRectsCount = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, uint, RenderColor, RenderRect*, uint, void>)_lpVtbl[26])((RenderCommandList*)Unsafe.AsPointer(ref this), attachmentIndex, colorValue ?? new RenderColor(), clearRects, clearRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void ClearDepthStencil(bool clearDepth = true, bool clearStencil = true, float depthValue = 1.0f, [NativeTypeName("uint32_t")] uint stencilValue = 0, [NativeTypeName("const RenderRect *")] RenderRect* clearRects = null, [NativeTypeName("uint32_t")] uint clearRectsCount = 0)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, bool, bool, float, uint, RenderRect*, uint, void>)_lpVtbl[27])((RenderCommandList*)Unsafe.AsPointer(ref this), clearDepth, clearStencil, depthValue, stencilValue, clearRects, clearRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void CopyBufferRegion([NativeTypeName("plume::RenderBufferReference")] RenderBufferReference dstBuffer, [NativeTypeName("plume::RenderBufferReference")] RenderBufferReference srcBuffer, [NativeTypeName("uint64_t")] ulong size)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBufferReference, RenderBufferReference, ulong, void>)_lpVtbl[28])((RenderCommandList*)Unsafe.AsPointer(ref this), dstBuffer, srcBuffer, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void CopyTextureRegion([NativeTypeName("const RenderTextureCopyLocation &")] RenderTextureCopyLocation* dstLocation, [NativeTypeName("const RenderTextureCopyLocation &")] RenderTextureCopyLocation* srcLocation, [NativeTypeName("uint32_t")] uint dstX = 0, [NativeTypeName("uint32_t")] uint dstY = 0, [NativeTypeName("uint32_t")] uint dstZ = 0, [NativeTypeName("const RenderBox *")] RenderBox* srcBox = null)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTextureCopyLocation*, RenderTextureCopyLocation*, uint, uint, uint, RenderBox*, void>)_lpVtbl[29])((RenderCommandList*)Unsafe.AsPointer(ref this), dstLocation, srcLocation, dstX, dstY, dstZ, srcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void CopyBuffer([NativeTypeName("const RenderBuffer *")] RenderBuffer* dstBuffer, [NativeTypeName("const RenderBuffer *")] RenderBuffer* srcBuffer)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderBuffer*, RenderBuffer*, void>)_lpVtbl[30])((RenderCommandList*)Unsafe.AsPointer(ref this), dstBuffer, srcBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void CopyTexture([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void>)_lpVtbl[31])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, srcTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void ResolveTexture([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, RenderTexture*, void>)_lpVtbl[32])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, srcTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void ResolveTextureRegion([NativeTypeName("const RenderTexture *")] RenderTexture* dstTexture, [NativeTypeName("uint32_t")] uint dstX, [NativeTypeName("uint32_t")] uint dstY, [NativeTypeName("const RenderTexture *")] RenderTexture* srcTexture, [NativeTypeName("const RenderRect *")] RenderRect* srcRect = null, [NativeTypeName("plume::RenderResolveMode")] RenderResolveMode resolveMode = RenderResolveMode.Average)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, uint, uint, RenderTexture*, RenderRect*, RenderResolveMode, void>)_lpVtbl[33])((RenderCommandList*)Unsafe.AsPointer(ref this), dstTexture, dstX, dstY, srcTexture, srcRect, resolveMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void DiscardTexture([NativeTypeName("const RenderTexture *")] RenderTexture* texture)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderTexture*, void>)_lpVtbl[36])((RenderCommandList*)Unsafe.AsPointer(ref this), texture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void ResetQueryPool([NativeTypeName("const RenderQueryPool *")] RenderQueryPool* queryPool, [NativeTypeName("uint32_t")] uint queryFirstIndex, [NativeTypeName("uint32_t")] uint queryCount)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, uint, void>)_lpVtbl[37])((RenderCommandList*)Unsafe.AsPointer(ref this), queryPool, queryFirstIndex, queryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void WriteTimestamp([NativeTypeName("const RenderQueryPool *")] RenderQueryPool* queryPool, [NativeTypeName("uint32_t")] uint queryIndex)
        {
            ((delegate* unmanaged[Thiscall]<RenderCommandList*, RenderQueryPool*, uint, void>)_lpVtbl[38])((RenderCommandList*)Unsafe.AsPointer(ref this), queryPool, queryIndex);
        }
    }
}
