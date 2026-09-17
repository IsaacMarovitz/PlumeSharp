namespace Plume
{
    public unsafe struct RenderBufferReference : IEquatable<RenderBufferReference>
    {
        [NativeTypeName("const RenderBuffer *")]
        public RenderBuffer* Ref = null;

        [NativeTypeName("uint64_t")]
        public ulong Offset = 0;

        public RenderBufferReference() { }

        public RenderBufferReference([NativeTypeName("const RenderBuffer *")] RenderBuffer* @ref)
        {
            Ref = @ref;
            Offset = 0;
        }

        public RenderBufferReference([NativeTypeName("const RenderBuffer *")] RenderBuffer* @ref, [NativeTypeName("uint64_t")] ulong offset)
        {
            Ref = @ref;
            Offset = offset;
        }

        public bool Equals(RenderBufferReference other)
        {
            return Ref == other.Ref && Offset == other.Offset;
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderBufferReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (unchecked((int)(long)Ref) * 397) ^ Offset.GetHashCode();
            }
        }
    }
}
