// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Common settings associated with a single session
	/// </summary>
	public class SessionDetailsSettings : ISettable
	{
		/// <summary>
		/// The main indexed parameter for this session, can be any string (ie "Region:GameMode")
		/// </summary>
		public string BucketId { get; set; }

		/// <summary>
		/// Number of total players allowed in the session
		/// </summary>
		public uint NumPublicConnections { get; set; }

		/// <summary>
		/// Are players allowed to join the session while it is in the "in progress" state
		/// </summary>
		public bool AllowJoinInProgress { get; set; }

		/// <summary>
		/// Permission level describing allowed access to the session when joining or searching for the session
		/// </summary>
		public OnlineSessionPermissionLevel PermissionLevel { get; set; }

		/// <summary>
		/// Are players allowed to send invites for the session
		/// </summary>
		public bool InvitesAllowed { get; set; }

		/// <summary>
		/// Are sanctioned players allowed to join - sanctioned players will be rejected if set to true
		/// </summary>
		public bool SanctionsEnabled { get; set; }

		internal void Set(SessionDetailsSettingsInternal? other)
		{
			if (other != null)
			{
				BucketId = other.Value.BucketId;
				NumPublicConnections = other.Value.NumPublicConnections;
				AllowJoinInProgress = other.Value.AllowJoinInProgress;
				PermissionLevel = other.Value.PermissionLevel;
				InvitesAllowed = other.Value.InvitesAllowed;
				SanctionsEnabled = other.Value.SanctionsEnabled;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionDetailsSettingsInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionDetailsSettingsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_BucketId;
		private uint m_NumPublicConnections;
		private int m_AllowJoinInProgress;
		private OnlineSessionPermissionLevel m_PermissionLevel;
		private int m_InvitesAllowed;
		private int m_SanctionsEnabled;

		public string BucketId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_BucketId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_BucketId, value);
			}
		}

		public uint NumPublicConnections
		{
			get
			{
				return m_NumPublicConnections;
			}

			set
			{
				m_NumPublicConnections = value;
			}
		}

		public bool AllowJoinInProgress
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_AllowJoinInProgress, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_AllowJoinInProgress, value);
			}
		}

		public OnlineSessionPermissionLevel PermissionLevel
		{
			get
			{
				return m_PermissionLevel;
			}

			set
			{
				m_PermissionLevel = value;
			}
		}

		public bool InvitesAllowed
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_InvitesAllowed, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_InvitesAllowed, value);
			}
		}

		public bool SanctionsEnabled
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_SanctionsEnabled, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_SanctionsEnabled, value);
			}
		}

		public void Set(SessionDetailsSettings other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionDetails.SessiondetailsSettingsApiLatest;
				BucketId = other.BucketId;
				NumPublicConnections = other.NumPublicConnections;
				AllowJoinInProgress = other.AllowJoinInProgress;
				PermissionLevel = other.PermissionLevel;
				InvitesAllowed = other.InvitesAllowed;
				SanctionsEnabled = other.SanctionsEnabled;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionDetailsSettings);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_BucketId);
		}
	}
}