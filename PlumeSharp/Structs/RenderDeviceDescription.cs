using System.Runtime.CompilerServices;

namespace Plume
{
    public struct RenderDeviceDescription
    {
        [NativeTypeName("char[256]")]
        public NameEFixedBuffer Name;

        [NativeTypeName("plume::RenderDeviceType")]
        public RenderDeviceType Type = RenderDeviceType.Unknown;

        [NativeTypeName("plume::RenderDeviceVendor")]
        public RenderDeviceVendor Vendor = RenderDeviceVendor.Unknown;

        [NativeTypeName("uint64_t")]
        public ulong DriverVersion = 0;

        [NativeTypeName("uint64_t")]
        public ulong DedicatedVideoMemory = 0;

        public RenderDeviceDescription() {
            // TODO: This should default to "Unknown"
            Name = default;
        }

        [InlineArray(256)]
        public struct NameEFixedBuffer
        {
            public sbyte e0;
        }
    }
}
