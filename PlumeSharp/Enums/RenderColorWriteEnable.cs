namespace Plume
{
    [Flags]
    [NativeTypeName("uint8_t")]
    public enum RenderColorWriteEnable : byte
    {
        Unknown = 0x0,
        Red = 0x1,
        Green = 0x2,
        Blue = 0x4,
        Alpha = 0x8,
        All = Red | Green | Blue | Alpha,
    }
}
