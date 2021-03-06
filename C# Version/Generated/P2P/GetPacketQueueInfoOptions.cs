// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information needed to get the current packet queue information.
	/// </summary>
	public class GetPacketQueueInfoOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetPacketQueueInfoOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(GetPacketQueueInfoOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.GetpacketqueueinfoApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as GetPacketQueueInfoOptions);
		}

		public void Dispose()
		{
		}
	}
}