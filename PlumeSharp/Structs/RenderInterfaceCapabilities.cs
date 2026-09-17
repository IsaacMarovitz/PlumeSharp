namespace Plume
{
    public struct RenderInterfaceCapabilities
    {
        [NativeTypeName("plume::RenderShaderFormat")]
        public RenderShaderFormat ShaderFormat = RenderShaderFormat.Unknown;

        public RenderInterfaceCapabilities() { }
    }
}
