// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Input parameters for the <see cref="FriendsInterface.AddNotifyFriendsUpdate" /> function.
	/// </summary>
	public class AddNotifyFriendsUpdateOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyFriendsUpdateOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(AddNotifyFriendsUpdateOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = FriendsInterface.AddnotifyfriendsupdateApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyFriendsUpdateOptions);
		}

		public void Dispose()
		{
		}
	}
}