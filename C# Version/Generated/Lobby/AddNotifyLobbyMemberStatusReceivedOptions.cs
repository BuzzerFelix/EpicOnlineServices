// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" /> function.
	/// </summary>
	public class AddNotifyLobbyMemberStatusReceivedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyLobbyMemberStatusReceivedOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(AddNotifyLobbyMemberStatusReceivedOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyInterface.AddnotifylobbymemberstatusreceivedApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyLobbyMemberStatusReceivedOptions);
		}

		public void Dispose()
		{
		}
	}
}