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
    [NativeName("Name", "D3D11_TEX2DMS_RTV")]
    public unsafe partial struct Tex2DmsRtv
    {
        public Tex2DmsRtv
        (
            uint unusedFieldNothingToDefine = default
        )
        {
            UnusedFieldNothingToDefine = unusedFieldNothingToDefine;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "UnusedField_NothingToDefine")]
        public uint UnusedFieldNothingToDefine;
    }
}