using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Plume
{
    public static unsafe class GlobalMethods
    {
        [SupportedOSPlatform("windows")]
        [DllImport("native/libplume.a", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateD3D12InterfaceRaw")]
        [return: NativeTypeName("plume::RenderInterface *")]
        public static extern RenderInterface* CreateD3D12Interface();

        [SupportedOSPlatform("macos")]
        [DllImport("native/libplume.a", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateMetalInterfaceRaw")]
        [return: NativeTypeName("plume::RenderInterface *")]
        public static extern RenderInterface* CreateMetalInterface();

        [DllImport("native/libplume.a", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateVulkanInterfaceRaw")]
        [return: NativeTypeName("plume::RenderInterface *")]
        public static extern RenderInterface* CreateVulkanInterface();

        [return: NativeTypeName("uint32_t")]
        public static uint RenderFormatSize([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return format switch
            {
                RenderFormat.R32G32B32A32Typeless or RenderFormat.R32G32B32A32Float or RenderFormat.R32G32B32A32Uint
                    or RenderFormat.R32G32B32A32Sint => 16,
                RenderFormat.R32G32B32Typeless or RenderFormat.R32G32B32Float or RenderFormat.R32G32B32Uint
                    or RenderFormat.R32G32B32Sint => 12,
                RenderFormat.R16G16B16A16Typeless or RenderFormat.R16G16B16A16Float or RenderFormat.R16G16B16A16Unorm
                    or RenderFormat.R16G16B16A16Uint or RenderFormat.R16G16B16A16Snorm or RenderFormat.R16G16B16A16Sint
                    or RenderFormat.R32G32Typeless or RenderFormat.R32G32Float or RenderFormat.R32G32Uint
                    or RenderFormat.R32G32Sint or RenderFormat.D32FloatS8Uint => 8,
                RenderFormat.R8G8B8A8Typeless or RenderFormat.R8G8B8A8Unorm or RenderFormat.R8G8B8A8Uint
                    or RenderFormat.R8G8B8A8Snorm or RenderFormat.R8G8B8A8Sint or RenderFormat.B8G8R8A8Unorm
                    or RenderFormat.R16G16Typeless or RenderFormat.R16G16Float or RenderFormat.R16G16Unorm
                    or RenderFormat.R16G16Uint or RenderFormat.R16G16Snorm or RenderFormat.R16G16Sint
                    or RenderFormat.R32Typeless or RenderFormat.D32Float or RenderFormat.R32Float
                    or RenderFormat.R32Uint or RenderFormat.R32Sint => 4,
                RenderFormat.R8G8Typeless or RenderFormat.R8G8Unorm or RenderFormat.R8G8Uint or RenderFormat.R8G8Snorm
                    or RenderFormat.R8G8Sint or RenderFormat.R16Typeless or RenderFormat.R16Float
                    or RenderFormat.D16Unorm or RenderFormat.R16Unorm or RenderFormat.R16Uint or RenderFormat.R16Snorm
                    or RenderFormat.R16Sint => 2,
                RenderFormat.R8Typeless or RenderFormat.R8Unorm or RenderFormat.R8Uint or RenderFormat.R8Snorm
                    or RenderFormat.R8Sint => 1,
                RenderFormat.Bc1Unorm or RenderFormat.Bc1UnormSrgb or RenderFormat.Bc1Typeless or RenderFormat.Bc4Unorm
                    or RenderFormat.Bc4Snorm or RenderFormat.Bc4Typeless => 8,
                RenderFormat.Bc2Unorm or RenderFormat.Bc2UnormSrgb or RenderFormat.Bc2Typeless or RenderFormat.Bc3Unorm
                    or RenderFormat.Bc3UnormSrgb or RenderFormat.Bc3Typeless or RenderFormat.Bc5Unorm
                    or RenderFormat.Bc5Snorm or RenderFormat.Bc6HUf16 or RenderFormat.Bc6HSf16 or RenderFormat.Bc7Unorm
                    or RenderFormat.Bc7UnormSrgb => 16,
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };
        }

        [return: NativeTypeName("uint32_t")]
        public static uint RenderFormatBlockWidth([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return format switch
            {
                RenderFormat.R32G32B32A32Typeless or RenderFormat.R32G32B32A32Float or RenderFormat.R32G32B32A32Uint
                    or RenderFormat.R32G32B32A32Sint or RenderFormat.R32G32B32Typeless or RenderFormat.R32G32B32Float
                    or RenderFormat.R32G32B32Uint or RenderFormat.R32G32B32Sint or RenderFormat.R16G16B16A16Typeless
                    or RenderFormat.R16G16B16A16Float or RenderFormat.R16G16B16A16Unorm or RenderFormat.R16G16B16A16Uint
                    or RenderFormat.R16G16B16A16Snorm or RenderFormat.R16G16B16A16Sint or RenderFormat.R32G32Typeless
                    or RenderFormat.R32G32Float or RenderFormat.R32G32Uint or RenderFormat.R32G32Sint
                    or RenderFormat.R8G8B8A8Typeless or RenderFormat.R8G8B8A8Unorm or RenderFormat.R8G8B8A8Uint
                    or RenderFormat.R8G8B8A8Snorm or RenderFormat.R8G8B8A8Sint or RenderFormat.B8G8R8A8Unorm
                    or RenderFormat.R16G16Typeless or RenderFormat.R16G16Float or RenderFormat.R16G16Unorm
                    or RenderFormat.R16G16Uint or RenderFormat.R16G16Snorm or RenderFormat.R16G16Sint
                    or RenderFormat.R32Typeless or RenderFormat.D32Float or RenderFormat.D32FloatS8Uint
                    or RenderFormat.R32Float or RenderFormat.R32Uint or RenderFormat.R32Sint
                    or RenderFormat.R8G8Typeless or RenderFormat.R8G8Unorm or RenderFormat.R8G8Uint
                    or RenderFormat.R8G8Snorm or RenderFormat.R8G8Sint or RenderFormat.R16Typeless
                    or RenderFormat.R16Float or RenderFormat.D16Unorm or RenderFormat.R16Unorm or RenderFormat.R16Uint
                    or RenderFormat.R16Snorm or RenderFormat.R16Sint or RenderFormat.R8Typeless or RenderFormat.R8Unorm
                    or RenderFormat.R8Uint or RenderFormat.R8Snorm or RenderFormat.R8Sint => 1,
                RenderFormat.Bc1Typeless or RenderFormat.Bc1Unorm or RenderFormat.Bc1UnormSrgb
                    or RenderFormat.Bc2Typeless or RenderFormat.Bc2Unorm or RenderFormat.Bc2UnormSrgb
                    or RenderFormat.Bc3Typeless or RenderFormat.Bc3Unorm or RenderFormat.Bc3UnormSrgb
                    or RenderFormat.Bc4Typeless or RenderFormat.Bc4Unorm or RenderFormat.Bc4Snorm
                    or RenderFormat.Bc5Typeless or RenderFormat.Bc5Unorm or RenderFormat.Bc5Snorm
                    or RenderFormat.Bc6HTypeless or RenderFormat.Bc6HUf16 or RenderFormat.Bc6HSf16
                    or RenderFormat.Bc7Typeless or RenderFormat.Bc7Unorm or RenderFormat.Bc7UnormSrgb => 4,
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };
        }

        public static bool RenderFormatIsDepth([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return format switch
            {
                RenderFormat.D16Unorm or RenderFormat.D32Float or RenderFormat.D32FloatS8Uint => true,
                _ => false
            };
        }

        public static bool RenderFormatIsStencil([NativeTypeName("plume::RenderFormat")] RenderFormat format)
        {
            return format == RenderFormat.D32FloatS8Uint;
        }

        [return: NativeTypeName("plume::RenderTextureViewDimension")]
        public static RenderTextureViewDimension RenderTextureDimensionToView([NativeTypeName("const RenderTextureDimension")] RenderTextureDimension dimension)
        {
            return dimension switch
            {
                RenderTextureDimension.Unknown => RenderTextureViewDimension.Unknown,
                RenderTextureDimension.Texture1D => RenderTextureViewDimension.Texture1D,
                RenderTextureDimension.Texture2D => RenderTextureViewDimension.Texture2D,
                RenderTextureDimension.Texture3D => RenderTextureViewDimension.Texture3D,
                _ => throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null)
            };
        }
    }
}
