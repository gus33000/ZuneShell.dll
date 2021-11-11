using System.Net;
using System.Runtime.InteropServices;

namespace Microsoft.Zune.Subscription
{
	public class SubscriptonCredentialRequestArguments
	{
		private int m_subscriptionMediaId;

		private int m_lastError;

		private string m_targetUrl;

		private string m_realm;

		private string m_lastUserName;

		private AuthenticationSchemes m_authScheme;

		private bool m_isAuthSchemeSafe;

		private NetworkCredential m_networkCredential;

		private bool m_save;

		public bool Save
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
				return m_save;
			}
			[param: MarshalAs(UnmanagedType.U1)]
			set
			{
				m_save = value;
			}
		}

		public NetworkCredential Credential
		{
			get
			{
				return m_networkCredential;
			}
			set
			{
				m_networkCredential = value;
			}
		}

		public bool IsAuthenticationSchemeSafe
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
				return m_isAuthSchemeSafe;
			}
		}

		public AuthenticationSchemes AuthScheme => m_authScheme;

		public int LastError => m_lastError;

		public string LastUserName => m_lastUserName;

		public string Realm => m_realm;

		public string TargetUrl => m_targetUrl;

		public int SubscriptionMediaId => m_subscriptionMediaId;

		internal SubscriptonCredentialRequestArguments(int subscriptionMediaId, string targetUrl, AuthenticationSchemes authScheme, [MarshalAs(UnmanagedType.U1)] bool isAuthSchemeSafe, string realm, string lastUserName, int lastError)
		{
			m_subscriptionMediaId = subscriptionMediaId;
			m_targetUrl = targetUrl;
			m_authScheme = authScheme;
			m_isAuthSchemeSafe = isAuthSchemeSafe;
			m_realm = realm;
			m_lastUserName = lastUserName;
			m_lastError = lastError;
			m_save = false;
			m_networkCredential = null;
		}
	}
}
