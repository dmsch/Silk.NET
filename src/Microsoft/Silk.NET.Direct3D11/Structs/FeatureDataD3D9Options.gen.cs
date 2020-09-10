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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D9_OPTIONS")]
    public unsafe partial struct FeatureDataD3D9Options
    {
        public FeatureDataD3D9Options
        (
            int fullNonPow2TextureSupport = default
        )
        {
            FullNonPow2TextureSupport = fullNonPow2TextureSupport;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FullNonPow2TextureSupport")]
        public int FullNonPow2TextureSupport;
    }
}