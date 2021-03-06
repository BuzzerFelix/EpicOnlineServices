// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about who would like notifications about closed connections, and for which socket.
	/// </summary>
	public class AddNotifyPeerConnectionClosedOptions
	{
		/// <summary>
		/// The Product User ID of the local user who would like notifications
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The optional socket ID to listen for to be closed. If NULL, this handler will be called for all closed connections
		/// </summary>
		public SocketId SocketId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyPeerConnectionClosedOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_SocketId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public SocketId SocketId
		{
			set
			{
				Helper.TryMarshalSet<SocketIdInternal, SocketId>(ref m_SocketId, value);
			}
		}

		public void Set(AddNotifyPeerConnectionClosedOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.AddnotifypeerconnectionclosedApiLatest;
				LocalUserId = other.LocalUserId;
				SocketId = other.SocketId;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyPeerConnectionClosedOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_SocketId);
		}
	}
}