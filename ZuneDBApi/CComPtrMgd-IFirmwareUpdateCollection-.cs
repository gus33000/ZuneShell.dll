using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class CComPtrMgd_003CIFirmwareUpdateCollection_003E : IDisposable
{
	public unsafe IFirmwareUpdateCollection* p = null;

	private void _007ECComPtrMgd_003CIFirmwareUpdateCollection_003E()
	{
		Release();
	}

	private void _0021CComPtrMgd_003CIFirmwareUpdateCollection_003E()
	{
		Release();
	}

	public unsafe void Release()
	{
		//IL_0014: Expected I, but got I8
		//IL_0021: Expected I, but got I8
		IFirmwareUpdateCollection* ptr = p;
		IFirmwareUpdateCollection* ptr2 = ptr;
		if (ptr != null)
		{
			p = null;
			((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, uint>)(*(ulong*)(*(long*)ptr2 + 16)))((nint)ptr2);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			Release();
			return;
		}
		try
		{
			Release();
		}
		finally
		{
			base.Finalize();
		}
	}

	public sealed override void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	~CComPtrMgd_003CIFirmwareUpdateCollection_003E()
	{
		Dispose(false);
	}

	public unsafe implicit operator IFirmwareUpdateCollection*()
	{
		return p;
	}

	[SpecialName]
	public unsafe IFirmwareUpdateCollection* op_MemberSelection()
	{
		return p;
	}

	[SpecialName]
	public unsafe IFirmwareUpdateCollection* op_Assign(IFirmwareUpdateCollection* lp)
	{
		//IL_001c: Expected I, but got I8
		Release();
		p = lp;
		if (lp != null)
		{
			((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, uint>)(*(ulong*)(*(long*)lp + 8)))((nint)lp);
		}
		return p;
	}
}
