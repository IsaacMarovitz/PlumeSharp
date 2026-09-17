namespace Plume
{
    public struct RenderBox
    {
        [NativeTypeName("int32_t")]
        public int Left = 0;

        [NativeTypeName("int32_t")]
        public int Top = 0;

        [NativeTypeName("int32_t")]
        public int Front = 0;

        [NativeTypeName("int32_t")]
        public int Right = 0;

        [NativeTypeName("int32_t")]
        public int Bottom = 0;

        [NativeTypeName("int32_t")]
        public int Back = 0;

        public RenderBox() { }

        public RenderBox([NativeTypeName("int32_t")] int left, [NativeTypeName("int32_t")] int top, [NativeTypeName("int32_t")] int right, [NativeTypeName("int32_t")] int bottom, [NativeTypeName("int32_t")] int front = 0, [NativeTypeName("int32_t")] int back = 1)
        {
            Left = left;
            Top = top;
            Front = front;
            Right = right;
            Bottom = bottom;
            Back = back;
        }
    }
}
