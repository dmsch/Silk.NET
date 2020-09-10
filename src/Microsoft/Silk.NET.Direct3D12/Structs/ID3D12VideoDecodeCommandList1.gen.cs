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
    [NativeName("Name", "ID3D12VideoDecodeCommandList1")]
    public unsafe partial struct ID3D12VideoDecodeCommandList1
    {
        public ID3D12VideoDecodeCommandList1
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
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public CommandListType GetType()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                CommandListType ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, CommandListType>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Close()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, int>)LpVtbl[9])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                int ret = default;
                fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearState()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, void>)LpVtbl[11])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
            }
        }

        /// <summary>To be added.</summary>
        public void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (DiscardRegion* pRegionPtr = &pRegion)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, T0*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, T0*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void EndEvent()
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, void>)LpVtbl[20])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                        {
                            ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
                {
                    fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoDecodeCommandList1* @this = &this)
            {
                fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                        {
                            ((delegate* cdecl<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
                    }
                }
            }
        }

    }
}