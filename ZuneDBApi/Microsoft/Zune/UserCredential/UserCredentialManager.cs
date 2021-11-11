using System;
using System.Threading;

namespace Microsoft.Zune.UserCredential
{
	public class UserCredentialManager
	{
		private static UserCredentialManager sm_instance = null;

		private static object sm_lock = new object();

		public static UserCredentialManager Instance
		{
			get
			{
				if (sm_instance == null)
				{
					try
					{
						Monitor.Enter(sm_lock);
						if (sm_instance == null)
						{
							UserCredentialManager userCredentialManager = new UserCredentialManager();
							Thread.MemoryBarrier();
							sm_instance = userCredentialManager;
						}
					}
					finally
					{
						Monitor.Exit(sm_lock);
					}
				}
				return sm_instance;
			}
		}

		public unsafe int SetCredentialHandler(UserCredentialHandler credentialHandler)
		{
			//IL_0029: Expected I, but got I8
			//IL_0038: Expected I, but got I8
			//IL_006e: Expected I, but got I8
			//IL_0083: Expected I, but got I8
			//IL_0087: Expected I, but got I8
			//IL_009b: Expected I, but got I8
			if (null == credentialHandler)
			{
				return -2147467261;
			}
			int num = 0;
			CUserCredentialProviderProxy* ptr = (CUserCredentialProviderProxy*)_003CModule_003E.@new(24uL);
			CUserCredentialProviderProxy* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Microsoft_002EZune_002EUserCredential_002ECUserCredentialProviderProxy_002E_007Bctor_007D(ptr));
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr);
				throw;
			}
			CUserCredentialProviderProxy* ptr3 = ptr2;
			IUserCredentialManager* ptr4 = null;
			try
			{
				if (ptr2 == null)
				{
					return -2147024882;
				}
				num = _003CModule_003E.GetSingleton((_GUID)_003CModule_003E._GUID_41c80590_c50b_4d27_b860_7c87f3f0cb54, (void**)(&ptr4));
				if (num >= 0)
				{
					num = _003CModule_003E.Microsoft_002EZune_002EUserCredential_002ECUserCredentialProviderProxy_002EInitialize(ptr2, credentialHandler);
					if (num >= 0)
					{
						IUserCredentialManager* intPtr = ptr4;
						return ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, IUserCredentialManagerProvider*, int>)(*(ulong*)(*(long*)ptr4 + 24)))((nint)intPtr, (IUserCredentialManagerProvider*)ptr2);
					}
					return num;
				}
				return num;
			}
			finally
			{
				if (0L != (nint)ptr4)
				{
					IUserCredentialManager* intPtr2 = ptr4;
					((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, uint>)(*(ulong*)(*(long*)intPtr2 + 16)))((nint)intPtr2);
					ptr4 = null;
				}
				if (0L != (nint)ptr3)
				{
					((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, uint>)(*(ulong*)(*(long*)ptr3 + 16)))((nint)ptr3);
				}
			}
		}

		private UserCredentialManager()
		{
		}
	}
}
