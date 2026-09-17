namespace Plume
{
    public struct RenderViewport : IEquatable<RenderViewport>
    {
        public float X = 0.0f;

        public float Y = 0.0f;

        public float Width = 0.0f;

        public float Height = 0.0f;

        public float MinDepth = 0.0f;

        public float MaxDepth = 1.0f;

        public RenderViewport() { }

        public RenderViewport(float x, float y, float width, float height, float minDepth = 0.0f, float maxDepth = 1.0f)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            MinDepth = minDepth;
            MaxDepth = maxDepth;
        }

        public readonly bool IsEmpty()
        {
            return Width <= 0.0f || Height <= 0.0f;
        }

        public bool Equals(RenderViewport other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Width.Equals(other.Width) && Height.Equals(other.Height) && MinDepth.Equals(other.MinDepth) && MaxDepth.Equals(other.MaxDepth);
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderViewport other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Width.GetHashCode();
                hashCode = (hashCode * 397) ^ Height.GetHashCode();
                hashCode = (hashCode * 397) ^ MinDepth.GetHashCode();
                hashCode = (hashCode * 397) ^ MaxDepth.GetHashCode();
                return hashCode;
            }
        }
    }
}
