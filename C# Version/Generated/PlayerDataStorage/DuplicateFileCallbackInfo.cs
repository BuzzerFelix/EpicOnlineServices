// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Data containing the result information for a duplicate file request
	/// </summary>
	public class DuplicateFileCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful request, other codes indicate an error
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Client-specified data passed into the file duplicate request
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the local user who initiated this request
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(DuplicateFileCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as DuplicateFileCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DuplicateFileCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

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
	}
}