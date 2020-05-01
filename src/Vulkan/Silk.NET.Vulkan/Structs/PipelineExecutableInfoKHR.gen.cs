// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineExecutableInfoKHR
    {
        public PipelineExecutableInfoKHR
        (
            StructureType sType = StructureType.PipelineExecutableInfoKhr,
            void* pNext = default,
            Pipeline pipeline = default,
            uint executableIndex = default
        )
        {
           SType = sType;
           PNext = pNext;
           Pipeline = pipeline;
           ExecutableIndex = executableIndex;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Pipeline Pipeline;
/// <summary></summary>
        public uint ExecutableIndex;
    }
}
