// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about the data being sent and to which player
	/// </summary>
	public class SendPacketOptions
	{
		/// <summary>
		/// The Product User ID of the local user who is sending this packet
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The Product User ID of the Peer you would like to send a packet to
		/// </summary>
		public ProductUserId RemoteUserId { get; set; }

		/// <summary>
		/// The socket ID for data you are sending in this packet
		/// </summary>
		public SocketId SocketId { get; set; }

		/// <summary>
		/// Channel associated with this data
		/// </summary>
		public byte Channel { get; set; }

		/// <summary>
		/// The data to be sent to the RemoteUser
		/// </summary>
		public byte[] Data { get; set; }

		/// <summary>
		/// If false and we do not already have an established connection to the peer, this data will be dropped
		/// </summary>
		public bool AllowDelayedDelivery { get; set; }

		/// <summary>
		/// Setting to control the delivery reliability of this packet
		/// </summary>
		public PacketReliability Reliability { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SendPacketOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RemoteUserId;
		private System.IntPtr m_SocketId;
		private byte m_Channel;
		private uint m_DataLengthBytes;
		private System.IntPtr m_Data;
		private int m_AllowDelayedDelivery;
		private PacketReliability m_Reliability;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ProductUserId RemoteUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_RemoteUserId, value);
			}
		}

		public SocketId SocketId
		{
			set
			{
				Helper.TryMarshalSet<SocketIdInternal, SocketId>(ref m_SocketId, value);
			}
		}

		public byte Channel
		{
			set
			{
				m_Channel = value;
			}
		}

		public byte[] Data
		{
			set
			{
				Helper.TryMarshalSet(ref m_Data, value, out m_DataLengthBytes);
			}
		}

		public bool AllowDelayedDelivery
		{
			set
			{
				Helper.TryMarshalSet(ref m_AllowDelayedDelivery, value);
			}
		}

		public PacketReliability Reliability
		{
			set
			{
				m_Reliability = value;
			}
		}

		public void Set(SendPacketOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.SendpacketApiLatest;
				LocalUserId = other.LocalUserId;
				RemoteUserId = other.RemoteUserId;
				SocketId = other.SocketId;
				Channel = other.Channel;
				Data = other.Data;
				AllowDelayedDelivery = other.AllowDelayedDelivery;
				Reliability = other.Reliability;
			}
		}

		public void Set(object other)
		{
			Set(other as SendPacketOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_RemoteUserId);
			Helper.TryMarshalDispose(ref m_SocketId);
			Helper.TryMarshalDispose(ref m_Data);
		}
	}
}