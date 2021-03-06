// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.SetHostAddress" /> function.
	/// </summary>
	public class SessionModificationSetHostAddressOptions
	{
		/// <summary>
		/// A string representing the host address for the session, its meaning is up to the application
		/// </summary>
		public string HostAddress { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationSetHostAddressOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_HostAddress;

		public string HostAddress
		{
			set
			{
				Helper.TryMarshalSet(ref m_HostAddress, value);
			}
		}

		public void Set(SessionModificationSetHostAddressOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionModification.SessionmodificationSethostaddressApiLatest;
				HostAddress = other.HostAddress;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionModificationSetHostAddressOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_HostAddress);
		}
	}
}