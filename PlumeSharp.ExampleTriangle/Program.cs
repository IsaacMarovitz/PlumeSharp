using System.Runtime.InteropServices;
using Plume;
using SDL3;

namespace PlumeSharp.ExampleTriangle
{
    internal static class Program
    {
        private static unsafe int Main()
        {
            if (!SDL.Init(SDL.InitFlags.Video))
            {
                Console.WriteLine($"SDL.Init Error: {SDL.GetError()}");
                return 1;
            }

            var flags = SDL.WindowFlags.Resizable;
            flags |= SDL.WindowFlags.Metal;

            var window = SDL.CreateWindow("Plume Example", 1280, 720, flags);
            if (window == IntPtr.Zero)
            {
                Console.WriteLine($"SDL.CreateWindow Error: {SDL.GetError()}");
                SDL.Quit();
                return 1;
            }

            var renderInterface = CreateRenderInterface(out var apiName);
            if (renderInterface == (RenderInterface*)IntPtr.Zero)
            {
                Console.WriteLine("Failed to create interface");
                SDL.DestroyWindow(window);
                SDL.Quit();
                return 1;
            }

            RenderInterfaceTest(renderInterface, window, apiName);

            SDL.DestroyWindow(window);
            SDL.Quit();
            return 0;
        }

        private static unsafe RenderInterface* CreateRenderInterface(out string apiName)
        {
            const bool useVulkan = false;

            if (!useVulkan)
            {
                if (OperatingSystem.IsWindows())
                {
                    apiName = "D3D12";
                    return GlobalMethods.CreateD3D12Interface();
                }
                else if (OperatingSystem.IsMacOS())
                {
                    apiName = "Metal";
                    return GlobalMethods.CreateMetalInterface();
                }
            }

            apiName = "Vulkan";
            return GlobalMethods.CreateVulkanInterface();
        }

        private static unsafe void CreateFramebuffers(ref TestContext ctx)
        {
            // Create framebuffers for each swap chain image
            ctx.Framebuffers.Clear();

            for (uint i = 0; i < ctx.SwapChain->GetTextureCount(); i++)
            {
                var colorAttachment = ctx.SwapChain->GetTexture(i);

                var fbDesc = new RenderFramebufferDesc
                {
                    ColorAttachments = &colorAttachment,
                    ColorAttachmentsCount = 1,
                    DepthAttachment = (RenderTexture*)IntPtr.Zero,
                };

                var framebuffer = ctx.Device->CreateFramebuffer(&fbDesc);
                ctx.Framebuffers.Add((IntPtr)framebuffer);
            }
        }

        private static unsafe void CreatePipeline(ref TestContext ctx)
        {
            // Create a pipeline layout (without any descriptor sets or push constants)
            var layoutDesc = new RenderPipelineLayoutDesc
            {
                AllowInputLayout = true
            };

            ctx.PipelineLayout = ctx.Device->CreatePipelineLayout(&layoutDesc);

            // Get the shader format from the render interface
            var shaderFormat = ctx.RenderInterface->GetCapabilities()->ShaderFormat;

            // Create shader objects
            var vertexShader = (RenderShader*)IntPtr.Zero;
            var fragmentShader = (RenderShader*)IntPtr.Zero;

            var vertEntry = Marshal.StringToCoTaskMemUTF8("VSMain");
            var fragEntry = Marshal.StringToCoTaskMemUTF8("PSMain");

            byte[] vertSource = [];
            byte[] fragSource = [];

            switch (shaderFormat)
            {
                case RenderShaderFormat.Metal:
                    vertSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleVert.hlsl.metallib");
                    fragSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleFrag.hlsl.metallib");

                    fixed (void* vertData = vertSource)
                    fixed (void* fragData = fragSource)
                    {
                        vertexShader = ctx.Device->CreateShader(vertData, (ulong)vertSource.Length,
                            (sbyte*)vertEntry, RenderShaderFormat.Metal);
                        fragmentShader = ctx.Device->CreateShader(fragData, (ulong)fragSource.Length,
                            (sbyte*)fragEntry, RenderShaderFormat.Metal);
                    }
                    break;
                case RenderShaderFormat.Spirv:
                    vertSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleVert.hlsl.spirv");
                    fragSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleFrag.hlsl.spirv");

                    fixed (void* vertData = vertSource)
                    fixed (void* fragData = fragSource)
                    {
                        vertexShader = ctx.Device->CreateShader(vertData, (ulong)vertSource.Length,
                            (sbyte*)vertEntry, RenderShaderFormat.Spirv);
                        fragmentShader = ctx.Device->CreateShader(fragData, (ulong)fragSource.Length,
                            (sbyte*)fragEntry, RenderShaderFormat.Spirv);
                    }
                    break;
                case RenderShaderFormat.Dxil:
                    vertSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleVert.hlsl.dxil");
                    fragSource = EmbeddedResources.ReadAllBytes("PlumeSharp.ExampleTriangle/Shaders/triangleFrag.hlsl.dxil");

                    fixed (void* vertData = vertSource)
                    fixed (void* fragData = fragSource)
                    {
                        vertexShader = ctx.Device->CreateShader(vertData, (ulong)vertSource.Length,
                            (sbyte*)vertEntry, RenderShaderFormat.Dxil);
                        fragmentShader = ctx.Device->CreateShader(fragData, (ulong)fragSource.Length,
                            (sbyte*)fragEntry, RenderShaderFormat.Dxil);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Marshal.ZeroFreeCoTaskMemUTF8(vertEntry);
            Marshal.ZeroFreeCoTaskMemUTF8(fragEntry);

            // Define vertex input layout
            // The vertex format has position (vec3) and color (vec4)
            ctx.InputSlot = new RenderInputSlot(0, sizeof(float) * 7);

            var positionSemantic = Marshal.StringToCoTaskMemUTF8("POSITION");
            var colorSemantic = Marshal.StringToCoTaskMemUTF8("COLOR");

            Span<RenderInputElement> inputElements = stackalloc RenderInputElement[2];
            inputElements[0] = new RenderInputElement((sbyte*)positionSemantic, 0, 0, RenderFormat.R32G32B32Float, 0, 0);
            inputElements[1] = new RenderInputElement((sbyte*)colorSemantic, 0, 1, RenderFormat.R32G32B32A32Float, 0, sizeof(float) * 3);

            fixed (RenderInputElement* elements = inputElements)
            fixed (RenderInputSlot* inputSlot = &ctx.InputSlot)
            {
                // Create graphics pipeline
                var pipelineDesc = new RenderGraphicsPipelineDesc
                {
                    InputSlots = inputSlot,
                    InputSlotsCount = 1,
                    InputElements = elements,
                    InputElementsCount = (uint)inputElements.Length,
                    PipelineLayout = ctx.PipelineLayout,
                    VertexShader = vertexShader,
                    PixelShader = fragmentShader,
                    RenderTargetCount = 1
                };

                pipelineDesc.RenderTargetFormat[0] = RenderFormat.B8G8R8A8Unorm;
                pipelineDesc.RenderTargetBlend[0] = RenderBlendDesc.Copy();

                ctx.Pipeline = ctx.Device->CreateGraphicsPipeline(&pipelineDesc);
            }

            Marshal.ZeroFreeCoTaskMemUTF8(positionSemantic);
            Marshal.ZeroFreeCoTaskMemUTF8(colorSemantic);
        }

        private static unsafe void CreateVertexBuffer(ref TestContext ctx)
        {
            // Define triangle vertices: position (x, y, z) and color (r, g, b, a)
            float[] vertices = [
                 0.0f,  0.5f, 0.0f,    1.0f, 0.0f, 0.0f, 1.0f, // Top vertex (red)
                -0.5f, -0.5f, 0.0f,    0.0f, 1.0f, 0.0f, 1.0f, // Bottom left vertex (green)
                 0.5f, -0.5f, 0.0f,    0.0f, 0.0f, 1.0f, 1.0f  // Bottom right vertex (blue)
            ];

            // Create vertex buffer
            var desc = RenderBufferDesc.VertexBuffer((ulong)(sizeof(float) * vertices.Length), RenderHeapType.Upload);
            ctx.VertexBuffer = ctx.Device->CreateBuffer(&desc);

            // Map buffer and copy vertex data
            Marshal.Copy(vertices, 0, (IntPtr)ctx.VertexBuffer->Map(), vertices.Length);
            ctx.VertexBuffer->Unmap();

            // Create vertex buffer view
            ctx.VertexBufferView = new RenderVertexBufferView
            {
                Buffer = new RenderBufferReference
                {
                    Ref = ctx.VertexBuffer
                },
                Size = (uint)(sizeof(float) * vertices.Length),
            };
        }

        private static unsafe void InitializeRenderResources(ref TestContext ctx, RenderInterface* renderInterface)
        {
            // Create device
            var preferredDeviceName = Marshal.StringToCoTaskMemUTF8("");
            ctx.Device = renderInterface->CreateDevice((sbyte*)preferredDeviceName);
            Marshal.ZeroFreeCoTaskMemUTF8(preferredDeviceName);

            // Create command queue for graphics
            ctx.CommandQueue = ctx.Device->CreateCommandQueue(RenderCommandListType.Direct);

            // Create a command fence
            ctx.Fence = ctx.Device->CreateCommandFence();

            // Create a swap chain for the window using the render window from init
            var desc = new RenderSwapChainDesc
            {
                RenderWindow = ctx.RenderWindow,
                Format = RenderFormat.B8G8R8A8Unorm,
                TextureCount = 2
            };
            ctx.SwapChain = ctx.CommandQueue->CreateSwapChain(&desc);

            // Explicitly resize the swapchain to create the textures
            ctx.SwapChain->Resize();

            // Create command list
            ctx.CommandList = ctx.CommandQueue->CreateCommandList();

            // Create acquire semaphore for swap chain synchronization
            ctx.AcquireSemaphore = ctx.Device->CreateCommandSemaphore();

            // Create command fence for synchronization
            ctx.CommandFence = ctx.Device->CreateCommandFence();

            // Create framebuffers for each swap chain image
            CreateFramebuffers(ref ctx);

            // Create the graphics pipeline
            CreatePipeline(ref ctx);

            // Create the vertex buffer with triangle data
            CreateVertexBuffer(ref ctx);
        }

        private static unsafe void CreateContext(ref TestContext ctx, RenderInterface* renderInterface, RenderWindow window,
            string apiName)
        {
            ctx.RenderInterface = renderInterface;
            ctx.RenderWindow = window;
            ctx.ApiName = apiName;

            InitializeRenderResources(ref ctx, renderInterface);
        }

        private static unsafe void Resize(ref TestContext ctx, int width, int height)
        {
            Console.WriteLine($"Resizing triangle example to {width}x{height}");

            // Simply resize the swapchain
            if (ctx.SwapChain != null)
            {
                // Clear old framebuffers
                ctx.Framebuffers.Clear();

                // Resize the swap chain
                var resized = ctx.SwapChain->Resize();
                if (!resized)
                {
                    Console.WriteLine($"Failed to resize swap chain");
                    return;
                }

                // Recreate framebuffers for the resized swap chain
                CreateFramebuffers(ref ctx);
            }
        }

        private static int _counter;

        private static unsafe void Render(ref TestContext ctx)
        {
            if (_counter++ % 60 == 0)
            {
                Console.WriteLine($"Rendering frame {_counter} using {ctx.ApiName} backend");
            }

            // Acquire the next swapchain image
            uint imageIndex = 0;
            ctx.SwapChain->AcquireTexture(ctx.AcquireSemaphore, &imageIndex);

            // Begin command recording
            ctx.CommandList->Begin();

            // Get the current swap chain texture and transition to render target
            var swapChainTexture = ctx.SwapChain->GetTexture(imageIndex);
            ctx.CommandList->Barriers(RenderBarrierStages.Graphics, new RenderTextureBarrier(swapChainTexture, RenderTextureLayout.ColorWrite));

            // Get the current swapchain framebuffer
            var framebuffer = (RenderFramebuffer*)ctx.Framebuffers[(int)imageIndex];
            ctx.CommandList->SetFramebuffer(framebuffer);

            // Set up viewport and scissor
            var width = ctx.SwapChain->GetWidth();
            var height = ctx.SwapChain->GetHeight();

            ctx.CommandList->SetViewports(new RenderViewport(0.0f, 0.0f, width, height));
            ctx.CommandList->SetScissors(new RenderRect(0, 0, (int)width, (int)height));

            // Clear with a dark blue color
            var clearColor = new RenderColor(0.0f, 0.0f, 0.2f);
            ctx.CommandList->ClearColor(0, clearColor);

            // Bind the pipeline and vertex buffer
            ctx.CommandList->SetGraphicsPipelineLayout(ctx.PipelineLayout);
            ctx.CommandList->SetPipeline(ctx.Pipeline);
            fixed (RenderVertexBufferView* vertexBufferView = &ctx.VertexBufferView)
            fixed (RenderInputSlot* inputSlot = &ctx.InputSlot)
            {
                ctx.CommandList->SetVertexBuffers(0, vertexBufferView, 1, inputSlot);
            }

            // Draw the triangle
            ctx.CommandList->DrawInstanced(3, 1, 0, 0);

            // Transition to present layout
            ctx.CommandList->Barriers(RenderBarrierStages.None, new RenderTextureBarrier(swapChainTexture, RenderTextureLayout.Present));

            // End command recording
            ctx.CommandList->End();

            // Create semaphores if needed
            while (ctx.ReleaseSemaphores.Count < ctx.SwapChain->GetTextureCount())
            {
                ctx.ReleaseSemaphores.Add((nint)ctx.Device->CreateCommandSemaphore());
            }

            // Submit and present
            var signalSemaphore = (RenderCommandSemaphore*)ctx.ReleaseSemaphores[(int)imageIndex];

            fixed (RenderCommandList** commandList = &ctx.CommandList)
            fixed (RenderCommandSemaphore** acquireSemaphore = &ctx.AcquireSemaphore)
            {
                ctx.CommandQueue->ExecuteCommandLists(commandList, 1, acquireSemaphore, 1, &signalSemaphore, 1, ctx.Fence);
            }

            // Present the frame
            ctx.SwapChain->Present(imageIndex, &signalSemaphore, 1);
            ctx.CommandQueue->WaitForCommandFence(ctx.Fence);
        }

        private static unsafe void RenderInterfaceTest(RenderInterface* renderInterface, nint window, string apiName)
        {
            var windowTitle = $"Plume Example ({apiName})";
            SDL.SetWindowTitle(window, windowTitle);

            var ctx = new TestContext();
            var view = SDL.MetalCreateView(window);
            CreateContext(ref ctx, renderInterface, new RenderWindow
            {
                Window = (void*)SDL.GetPointerProperty(SDL.GetWindowProperties(window), SDL.Props.WindowCocoaWindowPointer, IntPtr.Zero),
                View = (void*)SDL.MetalGetLayer(view),
            }, apiName);

            var running = true;
            while (running)
            {
                while (SDL.PollEvent(out var sdlEvent))
                {
                    switch (sdlEvent.Type)
                    {
                        case (uint)SDL.EventType.Quit:
                            running = false;
                            break;
                        case (uint)SDL.EventType.WindowResized:
                            var width = sdlEvent.Window.Data1;
                            var height = sdlEvent.Window.Data2;

                            Resize(ref ctx, width, height);
                            break;
                    }
                }

                Render(ref ctx);
            }
        }

        private unsafe struct TestContext
        {
            public RenderInterface* RenderInterface;
            public string ApiName;
            public RenderWindow RenderWindow;
            public RenderDevice* Device;
            public RenderCommandQueue* CommandQueue;
            public RenderCommandList* CommandList;
            public RenderCommandFence* Fence;
            public RenderSwapChain* SwapChain;
            public RenderCommandSemaphore* AcquireSemaphore;
            public readonly List<nint> ReleaseSemaphores;
            public RenderCommandFence* CommandFence;
            public readonly List<nint> Framebuffers;

            // Pipeline and buffer resources
            public RenderPipeline* Pipeline;
            public RenderPipelineLayout* PipelineLayout;
            public RenderBuffer* VertexBuffer;
            public RenderVertexBufferView VertexBufferView;
            public RenderInputSlot InputSlot;

            public TestContext()
            {
                ApiName = "";
                ReleaseSemaphores = [];
                Framebuffers = [];
            }
        }
    }
}
