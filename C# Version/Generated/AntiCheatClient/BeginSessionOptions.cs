// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public class BeginSessionOptions
	{
		/// <summary>
		/// Logged in user identifier from earlier call to <see cref="Connect.ConnectInterface.Login" /> family of functions
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Operating mode
		/// </summary>
		public AntiCheatClientMode Mode { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct BeginSessionOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private AntiCheatClientMode m_Mode;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public AntiCheatClientMode Mode
		{
			set
			{
				m_Mode = value;
			}
		}

		public void Set(BeginSessionOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatClientInterface.BeginsessionApiLatest;
				LocalUserId = other.LocalUserId;
				Mode = other.Mode;
			}
		}

		public void Set(object other)
		{
			Set(other as BeginSessionOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}