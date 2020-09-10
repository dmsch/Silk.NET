// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR1")]
    public unsafe partial struct RootDescriptor1
    {
        public RootDescriptor1
        (
            uint shaderRegister = default,
            uint registerSpace = default,
            RootDescriptorFlags flags = default
        )
        {
            ShaderRegister = shaderRegister;
            RegisterSpace = registerSpace;
            Flags = flags;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ShaderRegister")]
        public uint ShaderRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RegisterSpace")]
        public uint RegisterSpace;

        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
        [NativeName("Name", "Flags")]
        public RootDescriptorFlags Flags;
    }
}