// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.CreateLobbySearch" /> function.
	/// </summary>
	public class CreateLobbySearchOptions
	{
		/// <summary>
		/// Maximum number of results allowed from the search
		/// </summary>
		public uint MaxResults { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CreateLobbySearchOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_MaxResults;

		public uint MaxResults
		{
			set
			{
				m_MaxResults = value;
			}
		}

		public void Set(CreateLobbySearchOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyInterface.CreatelobbysearchApiLatest;
				MaxResults = other.MaxResults;
			}
		}

		public void Set(object other)
		{
			Set(other as CreateLobbySearchOptions);
		}

		public void Dispose()
		{
		}
	}
}