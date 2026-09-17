using System.Runtime.CompilerServices;

namespace Plume
{
    public struct RenderMultisampling
    {
        [NativeTypeName("plume::RenderSampleCounts")]
        public RenderSampleCounts SampleCount = RenderSampleCounts.Count1;

        [NativeTypeName("RenderMultisamplingLocation[16]")]
        public SampleLocationsEFixedBuffer SampleLocations = new();

        public bool SampleLocationsEnabled = false;

        public RenderMultisampling() { }

        public RenderMultisampling([NativeTypeName("plume::RenderSampleCounts")] RenderSampleCounts sampleCount)
        {
            SampleCount = sampleCount;
        }

        [InlineArray(16)]
        public struct SampleLocationsEFixedBuffer
        {
            public RenderMultisamplingLocation e0;
        }
    }
}
