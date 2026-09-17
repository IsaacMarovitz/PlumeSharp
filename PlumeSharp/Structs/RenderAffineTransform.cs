using System.Runtime.CompilerServices;

namespace Plume
{
    public struct RenderAffineTransform
    {
        [NativeTypeName("float[3][4]")]
        public MeFixedBuffer M;

        public RenderAffineTransform()
        {
            M[3 * 0 + 0] = 1.0f;
            M[3 * 1 + 1] = 1.0f;
            M[3 * 2 + 2] = 1.0f;
        }

        [InlineArray(3 * 4)]
        public struct MeFixedBuffer
        {
            public float e0_0;
        }
    }
}
