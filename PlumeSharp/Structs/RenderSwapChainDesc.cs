namespace Plume
{
    public struct RenderSwapChainDesc
    {
        [NativeTypeName("plume::RenderWindow")]
        public RenderWindow RenderWindow = default;

        [NativeTypeName("plume::RenderFormat")]
        public RenderFormat Format = RenderFormat.Unknown;

        [NativeTypeName("uint32_t")]
        public uint TextureCount = 0;

        public bool EnablePresentWait = false;

        [NativeTypeName("uint32_t")]
        public uint MaxFrameLatency = 0;

        public RenderSwapChainDesc() { }

        public RenderSwapChainDesc([NativeTypeName("plume::RenderWindow")] RenderWindow renderWindow, [NativeTypeName("plume::RenderFormat")] RenderFormat format, [NativeTypeName("uint32_t")] uint textureCount, bool enablePresentWait = false, [NativeTypeName("uint32_t")] uint maxFrameLatency = 0)
        {
            RenderWindow = renderWindow;
            Format = format;
            TextureCount = textureCount;
            EnablePresentWait = enablePresentWait;
            MaxFrameLatency = maxFrameLatency;
        }
    }
}
