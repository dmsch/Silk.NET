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
    public unsafe struct PhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public PhysicalDeviceFragmentDensityMapPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt,
            void* pNext = default,
            Extent2D minFragmentDensityTexelSize = default,
            Extent2D maxFragmentDensityTexelSize = default,
            Bool32 fragmentDensityInvocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           MinFragmentDensityTexelSize = minFragmentDensityTexelSize;
           MaxFragmentDensityTexelSize = maxFragmentDensityTexelSize;
           FragmentDensityInvocations = fragmentDensityInvocations;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Extent2D MinFragmentDensityTexelSize;
/// <summary></summary>
        public Extent2D MaxFragmentDensityTexelSize;
/// <summary></summary>
        public Bool32 FragmentDensityInvocations;
    }
}
