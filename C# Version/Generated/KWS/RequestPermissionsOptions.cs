// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.KWS
{
	/// <summary>
	/// Input parameters for the <see cref="KWSInterface.RequestPermissions" /> function.
	/// </summary>
	public class RequestPermissionsOptions
	{
		/// <summary>
		/// Local user requesting new permisssions
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Names of the permissions to request (Setup with KWS)
		/// </summary>
		public string[] PermissionKeys { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct RequestPermissionsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private uint m_PermissionKeyCount;
		private System.IntPtr m_PermissionKeys;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string[] PermissionKeys
		{
			set
			{
				Helper.TryMarshalSet(ref m_PermissionKeys, value, out m_PermissionKeyCount, true);
			}
		}

		public void Set(RequestPermissionsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = KWSInterface.RequestpermissionsApiLatest;
				LocalUserId = other.LocalUserId;
				PermissionKeys = other.PermissionKeys;
			}
		}

		public void Set(object other)
		{
			Set(other as RequestPermissionsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_PermissionKeys);
		}
	}
}