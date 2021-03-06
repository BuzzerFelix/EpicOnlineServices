// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Input parameters for the <see cref="UIInterface.SetToggleFriendsKey" /> function.
	/// </summary>
	public class SetToggleFriendsKeyOptions
	{
		/// <summary>
		/// The new key combination which will be used to toggle the friends overlay.
		/// The combination can be any set of modifiers and one key.
		/// A value of <see cref="KeyCombination.None" /> will cause the key to revert to the default.
		/// </summary>
		public KeyCombination KeyCombination { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetToggleFriendsKeyOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private KeyCombination m_KeyCombination;

		public KeyCombination KeyCombination
		{
			set
			{
				m_KeyCombination = value;
			}
		}

		public void Set(SetToggleFriendsKeyOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = UIInterface.SettogglefriendskeyApiLatest;
				KeyCombination = other.KeyCombination;
			}
		}

		public void Set(object other)
		{
			Set(other as SetToggleFriendsKeyOptions);
		}

		public void Dispose()
		{
		}
	}
}