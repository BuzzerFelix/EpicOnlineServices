// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Contains information about a single stat to query with user scores.
	/// </summary>
	public class UserScoresQueryStatInfo : ISettable
	{
		/// <summary>
		/// The name of the stat to query.
		/// </summary>
		public string StatName { get; set; }

		/// <summary>
		/// Aggregation used to sort the cached user scores.
		/// </summary>
		public LeaderboardAggregation Aggregation { get; set; }

		internal void Set(UserScoresQueryStatInfoInternal? other)
		{
			if (other != null)
			{
				StatName = other.Value.StatName;
				Aggregation = other.Value.Aggregation;
			}
		}

		public void Set(object other)
		{
			Set(other as UserScoresQueryStatInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UserScoresQueryStatInfoInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_StatName;
		private LeaderboardAggregation m_Aggregation;

		public string StatName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_StatName, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_StatName, value);
			}
		}

		public LeaderboardAggregation Aggregation
		{
			get
			{
				return m_Aggregation;
			}

			set
			{
				m_Aggregation = value;
			}
		}

		public void Set(UserScoresQueryStatInfo other)
		{
			if (other != null)
			{
				m_ApiVersion = LeaderboardsInterface.UserscoresquerystatinfoApiLatest;
				StatName = other.StatName;
				Aggregation = other.Aggregation;
			}
		}

		public void Set(object other)
		{
			Set(other as UserScoresQueryStatInfo);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_StatName);
		}
	}
}