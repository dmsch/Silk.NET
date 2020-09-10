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
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_TABLE1")]
    public unsafe partial struct RootDescriptorTable1
    {
        public RootDescriptorTable1
        (
            uint numDescriptorRanges = default,
            DescriptorRange1* pDescriptorRanges = default
        )
        {
            NumDescriptorRanges = numDescriptorRanges;
            PDescriptorRanges = pDescriptorRanges;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescriptorRanges")]
        public uint NumDescriptorRanges;

        [NativeName("Type", "const D3D12_DESCRIPTOR_RANGE1 *")]
        [NativeName("Type.Name", "const D3D12_DESCRIPTOR_RANGE1 *")]
        [NativeName("Name", "pDescriptorRanges")]
        public DescriptorRange1* PDescriptorRanges;
    }
}