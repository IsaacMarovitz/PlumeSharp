namespace Plume
{
    public struct RenderRange
    {
        [NativeTypeName("uint64_t")]
        public ulong Begin = 0;

        [NativeTypeName("uint64_t")]
        public ulong End = 0;

        public RenderRange() { }

        public RenderRange([NativeTypeName("uint64_t")] ulong begin, [NativeTypeName("uint64_t")] ulong end)
        {
            Begin = begin;
            End = end;
        }
    }
}
