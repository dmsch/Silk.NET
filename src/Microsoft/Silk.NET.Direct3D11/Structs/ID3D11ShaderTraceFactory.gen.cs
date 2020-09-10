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
    [NativeName("Name", "ID3D11ShaderTraceFactory")]
    public unsafe partial struct ID3D11ShaderTraceFactory
    {
        public ID3D11ShaderTraceFactory
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(Silk.NET.Core.Runtime.Windows.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTrace);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(Silk.NET.Core.Runtime.Windows.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTracePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(Silk.NET.Core.Runtime.Windows.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTrace);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(Silk.NET.Core.Runtime.Windows.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                {
                    fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTracePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(ref Silk.NET.Core.Runtime.Windows.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTrace);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(ref Silk.NET.Core.Runtime.Windows.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pShaderPtr = &pShader)
                {
                    fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTracePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(ref Silk.NET.Core.Runtime.Windows.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pShaderPtr = &pShader)
                {
                    fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTrace);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateShaderTrace(ref Silk.NET.Core.Runtime.Windows.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            fixed (ID3D11ShaderTraceFactory* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pShaderPtr = &pShader)
                {
                    fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                    {
                        fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                        {
                            ret = ((delegate* cdecl<ID3D11ShaderTraceFactory*, Silk.NET.Core.Runtime.Windows.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTracePtr);
                        }
                    }
                }
                return ret;
            }
        }

    }
}