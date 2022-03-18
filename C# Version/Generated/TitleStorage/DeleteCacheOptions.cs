// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Input data for the <see cref="TitleStorageInterface.DeleteCache" /> function
	/// </summary>
	public class DeleteCacheOptions
	{
		/// <summary>
		/// Product User ID of the local user who is deleting his cache (optional)
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DeleteCacheOptionsInternal : ISettable, System.IDisposable
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

		public void Set(DeleteCacheOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = TitleStorageInterface.DeletecacheoptionsApiLatest;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as DeleteCacheOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}