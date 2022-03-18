// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Input parameters for the <see cref="LeaderboardsInterface.QueryLeaderboardRanks" /> function.
	/// <seealso cref="Definition" />
	/// </summary>
	public class QueryLeaderboardRanksOptions
	{
		/// <summary>
		/// The ID of the leaderboard whose information you want to retrieve.
		/// </summary>
		public string LeaderboardId { get; set; }

		/// <summary>
		/// Product User ID for user who is querying ranks.
		/// Must be set when using a client policy that requires a valid logged in user.
		/// Not used for Dedicated Server where no user is available.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryLeaderboardRanksOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LeaderboardId;
		private System.IntPtr m_LocalUserId;

		public string LeaderboardId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LeaderboardId, value);
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(QueryLeaderboardRanksOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LeaderboardsInterface.QueryleaderboardranksApiLatest;
				LeaderboardId = other.LeaderboardId;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryLeaderboardRanksOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LeaderboardId);
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}