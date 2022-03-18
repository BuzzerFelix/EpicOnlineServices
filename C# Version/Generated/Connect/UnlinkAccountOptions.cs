// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Input parameters for the <see cref="ConnectInterface.UnlinkAccount" /> Function.
	/// </summary>
	public class UnlinkAccountOptions
	{
		/// <summary>
		/// Existing logged in product user that is subject for the unlinking operation.
		/// The external account that was used to login to the product user will be unlinked from the owning keychain.
		/// 
		/// On a successful operation, the product user will be logged out as the external account used to authenticate the user was unlinked from the owning keychain.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UnlinkAccountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(UnlinkAccountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ConnectInterface.UnlinkaccountApiLatest;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as UnlinkAccountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}