using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plume
{
    public unsafe struct RenderTextureCopyLocation
    {
        [NativeTypeName("const RenderTexture *")]
        public RenderTexture* Texture = null;

        [NativeTypeName("const RenderBuffer *")]
        public RenderBuffer* Buffer = null;

        [NativeTypeName("plume::RenderTextureCopyType")]
        public RenderTextureCopyType Type = RenderTextureCopyType.Unknown;

        [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L1093_C9")]
        public AnonymousEUnion Anonymous;

        public RenderTextureCopyLocation() { }

        [UnscopedRef]
        public ref AnonymousEUnion.PlacedFootprintEStruct PlacedFootprint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.placedFootprint;
        }

        [UnscopedRef]
        public ref AnonymousEUnion.SubresourceEStruct Subresource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.subresource;
        }

        [return: NativeTypeName("plume::RenderTextureCopyLocation")]
        public static RenderTextureCopyLocation WithPlacedFootprint([NativeTypeName("const RenderBuffer *")] RenderBuffer* buffer, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, [NativeTypeName("uint32_t")] uint rowWidth, [NativeTypeName("uint64_t")] ulong offset = 0)
        {
            var loc = new RenderTextureCopyLocation
            {
                Buffer = buffer,
                Type = RenderTextureCopyType.PlacedFootprint
            };

            loc.Anonymous.placedFootprint.Format = format;
            loc.Anonymous.placedFootprint.Width = width;
            loc.Anonymous.placedFootprint.Height = height;
            loc.Anonymous.placedFootprint.Depth = depth;
            loc.Anonymous.placedFootprint.RowWidth = rowWidth;
            loc.Anonymous.placedFootprint.Offset = offset;
            return loc;
        }

        [return: NativeTypeName("plume::RenderTextureCopyLocation")]
        public static RenderTextureCopyLocation WithSubresource([NativeTypeName("const RenderTexture *")] RenderTexture* texture, [NativeTypeName("uint32_t")] uint mipLevel = 0, [NativeTypeName("uint32_t")] uint arrayIndex = 0)
        {
            var loc = new RenderTextureCopyLocation
            {
                Texture = texture,
                Type = RenderTextureCopyType.Subresource
            };

            loc.Anonymous.subresource.MipLevel = mipLevel;
            loc.Anonymous.subresource.ArrayIndex = arrayIndex;
            return loc;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct AnonymousEUnion
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L1094_C13")]
            public PlacedFootprintEStruct placedFootprint;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L1103_C13")]
            public SubresourceEStruct subresource;

            public struct PlacedFootprintEStruct
            {
                [NativeTypeName("plume::RenderFormat")]
                public RenderFormat Format;

                [NativeTypeName("uint32_t")]
                public uint Width;

                [NativeTypeName("uint32_t")]
                public uint Height;

                [NativeTypeName("uint32_t")]
                public uint Depth;

                [NativeTypeName("uint32_t")]
                public uint RowWidth;

                [NativeTypeName("uint64_t")]
                public ulong Offset;
            }

            public struct SubresourceEStruct
            {
                [NativeTypeName("uint32_t")]
                public uint MipLevel;

                [NativeTypeName("uint32_t")]
                public uint ArrayIndex;
            }
        }
    }
}
