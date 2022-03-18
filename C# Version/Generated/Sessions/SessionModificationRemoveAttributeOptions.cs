// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.RemoveAttribute" /> function.
	/// </summary>
	public class SessionModificationRemoveAttributeOptions
	{
		/// <summary>
		/// Session attribute to remove from the session
		/// </summary>
		public string Key { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationRemoveAttributeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Key;

		public string Key
		{
			set
			{
				Helper.TryMarshalSet(ref m_Key, value);
			}
		}

		public void Set(SessionModificationRemoveAttributeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionModification.SessionmodificationRemoveattributeApiLatest;
				Key = other.Key;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionModificationRemoveAttributeOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Key);
		}
	}
}