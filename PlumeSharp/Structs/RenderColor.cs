using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plume
{
    public struct RenderColor
    {
        [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L716_C9")]
        public AnonymousEUnion Anonymous;

        [UnscopedRef]
        public Span<float> Rgba
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Anonymous.Anonymous1.Rgba;
        }

        [UnscopedRef]
        public ref float R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.Anonymous2.R;
        }

        [UnscopedRef]
        public ref float G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.Anonymous2.G;
        }

        [UnscopedRef]
        public ref float B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.Anonymous2.B;
        }

        [UnscopedRef]
        public ref float A
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Anonymous.Anonymous2.A;
        }

        public RenderColor()
        {
            Anonymous.Anonymous2.R = 0.0f;
            Anonymous.Anonymous2.G = 0.0f;
            Anonymous.Anonymous2.B = 0.0f;
            Anonymous.Anonymous2.A = 1.0f;
        }

        public RenderColor(float r, float g, float b, float a = 1.0f)
        {
            Anonymous.Anonymous2.R = r;
            Anonymous.Anonymous2.G = g;
            Anonymous.Anonymous2.B = b;
            Anonymous.Anonymous2.A = a;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct AnonymousEUnion
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L717_C13")]
            public Anonymous1EStruct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_plume_render_interface_types_L721_C13")]
            public Anonymous2EStruct Anonymous2;

            public struct Anonymous1EStruct
            {
                [NativeTypeName("float[4]")]
                public RgbaEFixedBuffer Rgba;

                [InlineArray(4)]
                public struct RgbaEFixedBuffer
                {
                    public float e0;
                }
            }

            public struct Anonymous2EStruct
            {
                public float R;

                public float G;

                public float B;

                public float A;
            }
        }
    }
}
