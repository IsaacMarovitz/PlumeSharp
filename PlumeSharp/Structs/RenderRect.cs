namespace Plume
{
    public struct RenderRect : IEquatable<RenderRect>
    {
        [NativeTypeName("int32_t")]
        public int Left = 0;

        [NativeTypeName("int32_t")]
        public int Top = 0;

        [NativeTypeName("int32_t")]
        public int Right = 0;

        [NativeTypeName("int32_t")]
        public int Bottom = 0;

        public RenderRect() { }

        public RenderRect([NativeTypeName("int32_t")] int left, [NativeTypeName("int32_t")] int top, [NativeTypeName("int32_t")] int right, [NativeTypeName("int32_t")] int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public readonly bool IsEmpty()
        {
            return Left >= Right || Top >= Bottom;
        }

        public bool Equals(RenderRect other)
        {
            return Left == other.Left && Top == other.Top && Right == other.Right && Bottom == other.Bottom;
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderRect other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Left;
                hashCode = (hashCode * 397) ^ Top;
                hashCode = (hashCode * 397) ^ Right;
                hashCode = (hashCode * 397) ^ Bottom;
                return hashCode;
            }
        }
    }
}
