// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Input data for the <see cref="TitleStorageInterface.QueryFile" /> function
	/// </summary>
	public class QueryFileOptions
	{
		/// <summary>
		/// Product User ID of the local user requesting file metadata (optional)
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The requested file's name
		/// </summary>
		public string Filename { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryFileOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_Filename;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string Filename
		{
			set
			{
				Helper.TryMarshalSet(ref m_Filename, value);
			}
		}

		public void Set(QueryFileOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = TitleStorageInterface.QueryfileoptionsApiLatest;
				LocalUserId = other.LocalUserId;
				Filename = other.Filename;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryFileOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_Filename);
		}
	}
}