namespace Plume
{
    public struct RenderComponentMapping
    {
        [NativeTypeName("plume::RenderSwizzle")]
        public RenderSwizzle R = RenderSwizzle.Identity;

        [NativeTypeName("plume::RenderSwizzle")]
        public RenderSwizzle G = RenderSwizzle.Identity;

        [NativeTypeName("plume::RenderSwizzle")]
        public RenderSwizzle B = RenderSwizzle.Identity;

        [NativeTypeName("plume::RenderSwizzle")]
        public RenderSwizzle A = RenderSwizzle.Identity;

        public RenderComponentMapping() { }

        public RenderComponentMapping([NativeTypeName("plume::RenderSwizzle")] RenderSwizzle r, [NativeTypeName("plume::RenderSwizzle")] RenderSwizzle g, [NativeTypeName("plume::RenderSwizzle")] RenderSwizzle b, [NativeTypeName("plume::RenderSwizzle")] RenderSwizzle a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
    }
}
