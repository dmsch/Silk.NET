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
    [NativeName("Name", "ID3D11LibraryReflection")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public ID3D11LibraryReflection
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
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11LibraryReflection*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11LibraryReflection*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(LibraryDesc* pDesc)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref LibraryDesc pDesc)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (LibraryDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            fixed (ID3D11LibraryReflection* @this = &this)
            {
                ID3D11FunctionReflection* ret = default;
                ret = ((delegate* cdecl<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
                return ret;
            }
        }

    }
}