using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plume
{
    public struct RenderClearValue
    {
        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L853_C9")]
        public AnonymousEUnion Anonymous;

        [UnscopedRef]
        public ref RenderColor Color
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.color;
        }

        [UnscopedRef]
        public ref RenderDepth Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.depth;
        }

        public RenderClearValue()
        {
            Color = new RenderColor();
        }

        [return: NativeTypeName("plume::RenderClearValue")]
        public static RenderClearValue WithColor([NativeTypeName("plume::RenderColor")] RenderColor color, [NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var clear = new RenderClearValue
            {
                Format = format
            };

            clear.Anonymous.color = color;
            return clear;
        }

        [return: NativeTypeName("plume::RenderClearValue")]
        public static RenderClearValue WithDepth([NativeTypeName("plume::RenderDepth")] RenderDepth depth, [NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            var clear = new RenderClearValue
            {
                Format = format
            };

            clear.Anonymous.depth = depth;
            return clear;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct AnonymousEUnion
        {
            [FieldOffset(0)]
            [NativeTypeName("plume::RenderColor")]
            public RenderColor color;

            [FieldOffset(0)]
            [NativeTypeName("plume::RenderDepth")]
            public RenderDepth depth;
        }
    }
}
