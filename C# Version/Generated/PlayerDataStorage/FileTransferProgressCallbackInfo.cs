// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Data containing the information about a file transfer in progress (or one that has completed)
	/// </summary>
	public class FileTransferProgressCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into the file request
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the local user who initiated this request
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The file name of the file being transferred
		/// </summary>
		public string Filename { get; private set; }

		/// <summary>
		/// Amount of bytes transferred so far in this request, out of TotalFileSizeBytes
		/// </summary>
		public uint BytesTransferred { get; private set; }

		/// <summary>
		/// The total size of the file being transferred (Includes file header in addition to file contents, can be slightly more than expected)
		/// </summary>
		public uint TotalFileSizeBytes { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(FileTransferProgressCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				Filename = other.Value.Filename;
				BytesTransferred = other.Value.BytesTransferred;
				TotalFileSizeBytes = other.Value.TotalFileSizeBytes;
			}
		}

		public void Set(object other)
		{
			Set(other as FileTransferProgressCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_Filename;
		private uint m_BytesTransferred;
		private uint m_TotalFileSizeBytes;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public string Filename
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Filename, out value);
				return value;
			}
		}

		public uint BytesTransferred
		{
			get
			{
				return m_BytesTransferred;
			}
		}

		public uint TotalFileSizeBytes
		{
			get
			{
				return m_TotalFileSizeBytes;
			}
		}
	}
}