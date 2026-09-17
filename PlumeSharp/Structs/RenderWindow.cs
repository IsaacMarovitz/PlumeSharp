namespace Plume
{
    public unsafe struct RenderWindow : IEquatable<RenderWindow>
    {
        public void* Window;

        public void* View;

        public bool Equals(RenderWindow other)
        {
            return Window == other.Window && View == other.View;
        }

        public override bool Equals(object? obj)
        {
            return obj is RenderWindow other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (unchecked((int)(long)Window) * 397) ^ unchecked((int)(long)View);
            }
        }
    }
}
