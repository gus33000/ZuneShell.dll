using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace Microsoft.Zune.Service
{
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[NativeCppClass]
	internal struct GetAccountCallbackWrapper
	{
		private long _003Calignment_0020member_003E;
	}
}