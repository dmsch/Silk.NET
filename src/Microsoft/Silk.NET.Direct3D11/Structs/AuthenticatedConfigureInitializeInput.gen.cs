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
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT")]
    public unsafe partial struct AuthenticatedConfigureInitializeInput
    {
        public AuthenticatedConfigureInitializeInput
        (
            AuthenticatedConfigureInput parameters = default,
            uint startSequenceQuery = default,
            uint startSequenceConfigure = default
        )
        {
            Parameters = parameters;
            StartSequenceQuery = startSequenceQuery;
            StartSequenceConfigure = startSequenceConfigure;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedConfigureInput Parameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartSequenceQuery")]
        public uint StartSequenceQuery;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartSequenceConfigure")]
        public uint StartSequenceConfigure;
    }
}