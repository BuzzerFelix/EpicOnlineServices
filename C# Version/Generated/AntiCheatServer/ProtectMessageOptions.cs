// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatServer
{
	public class ProtectMessageOptions
	{
		/// <summary>
		/// Locally unique value describing the remote user to whom the message will be sent
		/// </summary>
		public System.IntPtr ClientHandle { get; set; }

		/// <summary>
		/// The data to encrypt
		/// </summary>
		public byte[] Data { get; set; }

		/// <summary>
		/// The size in bytes of OutBuffer
		/// </summary>
		public uint OutBufferSizeBytes { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ProtectMessageOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_ClientHandle;
		private uint m_DataLengthBytes;
		private System.IntPtr m_Data;
		private uint m_OutBufferSizeBytes;

		public System.IntPtr ClientHandle
		{
			set
			{
				m_ClientHandle = value;
			}
		}

		public byte[] Data
		{
			set
			{
				Helper.TryMarshalSet(ref m_Data, value, out m_DataLengthBytes);
			}
		}

		public uint OutBufferSizeBytes
		{
			set
			{
				m_OutBufferSizeBytes = value;
			}
		}

		public void Set(ProtectMessageOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatServerInterface.ProtectmessageApiLatest;
				ClientHandle = other.ClientHandle;
				Data = other.Data;
				OutBufferSizeBytes = other.OutBufferSizeBytes;
			}
		}

		public void Set(object other)
		{
			Set(other as ProtectMessageOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ClientHandle);
			Helper.TryMarshalDispose(ref m_Data);
		}
	}
}