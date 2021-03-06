// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceModification.DeleteData" /> function.
	/// </summary>
	public class PresenceModificationDeleteDataOptions
	{
		/// <summary>
		/// The pointer to start of a sequential array
		/// </summary>
		public PresenceModificationDataRecordId[] Records { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceModificationDeleteDataOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private int m_RecordsCount;
		private System.IntPtr m_Records;

		public PresenceModificationDataRecordId[] Records
		{
			set
			{
				Helper.TryMarshalSet<PresenceModificationDataRecordIdInternal, PresenceModificationDataRecordId>(ref m_Records, value, out m_RecordsCount);
			}
		}

		public void Set(PresenceModificationDeleteDataOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = PresenceModification.PresencemodificationDeletedataApiLatest;
				Records = other.Records;
			}
		}

		public void Set(object other)
		{
			Set(other as PresenceModificationDeleteDataOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Records);
		}
	}
}