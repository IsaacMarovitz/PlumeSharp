using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

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

        public RenderDeviceDescription()
        {
            Name = default;
            Span<sbyte> name = Name;
            "Unknown"u8.CopyTo(MemoryMarshal.AsBytes(name));
        }

        public string GetName()
        {
            ReadOnlySpan<sbyte> name = Name;
            var bytes = MemoryMarshal.AsBytes(name);
            var length = bytes.IndexOf((byte)0);
            return Encoding.UTF8.GetString(length < 0 ? bytes : bytes[..length]);
        }

        [InlineArray(256)]
        public struct NameEFixedBuffer
        {
            public sbyte e0;
        }
    }
}
