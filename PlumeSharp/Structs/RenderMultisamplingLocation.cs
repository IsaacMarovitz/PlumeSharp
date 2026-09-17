namespace Plume
{
    public struct RenderMultisamplingLocation : IEquatable<RenderMultisamplingLocation>
    {
        [NativeTypeName("int8_t")]
        public sbyte X = 0;

        [NativeTypeName("int8_t")]
        public sbyte Y = 0;

        public RenderMultisamplingLocation() { }

        public bool Equals(RenderMultisamplingLocation other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderMultisamplingLocation other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }
    }
}
