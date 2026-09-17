namespace Plume
{
    public struct RenderDeviceCapabilities
    {
        public bool GeometryShader = false;

        public bool Raytracing = false;

        public bool RaytracingStateUpdate = false;

        public bool SampleLocations = false;

        public bool ResolveRegion = false;

        public bool ResolveModes = false;

        public bool DescriptorIndexing = false;

        public bool ScalarBlockLayout = false;

        public bool BufferDeviceAddress = false;

        public bool SamplerMirrorClampToEdge = false;

        public bool PresentWait = false;

        public bool DisplayTiming = false;

        [NativeTypeName("uint64_t")]
        public ulong MaxTextureSize = 0;

        public bool PreferHdr = false;

        public bool TriangleFan = false;

        public bool DynamicDepthBias = false;

        public bool Uma = false;

        public bool GpuUploadHeap = false;

        public bool QueryPools = false;

        public RenderDeviceCapabilities() { }
    }
}
