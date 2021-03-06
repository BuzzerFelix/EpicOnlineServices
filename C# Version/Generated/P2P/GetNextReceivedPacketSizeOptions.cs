// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about who would like to receive a packet.
	/// </summary>
	public class GetNextReceivedPacketSizeOptions
	{
		/// <summary>
		/// The Product User ID of the local user who is receiving the packet
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// An optional channel to request the data for. If NULL, we're retrieving the size of the next packet on any channel.
		/// </summary>
		public byte? RequestedChannel { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RequestedChannel;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public byte? RequestedChannel
		{
			set
			{
				Helper.TryMarshalSet(ref m_RequestedChannel, value);
			}
		}

		public void Set(GetNextReceivedPacketSizeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.GetnextreceivedpacketsizeApiLatest;
				LocalUserId = other.LocalUserId;
				RequestedChannel = other.RequestedChannel;
			}
		}

		public void Set(object other)
		{
			Set(other as GetNextReceivedPacketSizeOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_RequestedChannel);
		}
	}
}