// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.SetSessionId" /> function.
	/// </summary>
	public class SessionSearchSetSessionIdOptions
	{
		/// <summary>
		/// Search sessions for a specific session ID, returning at most one session
		/// </summary>
		public string SessionId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionSearchSetSessionIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionId;

		public string SessionId
		{
			set
			{
				Helper.TryMarshalSet(ref m_SessionId, value);
			}
		}

		public void Set(SessionSearchSetSessionIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionSearch.SessionsearchSetsessionidApiLatest;
				SessionId = other.SessionId;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionSearchSetSessionIdOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionId);
		}
	}
}