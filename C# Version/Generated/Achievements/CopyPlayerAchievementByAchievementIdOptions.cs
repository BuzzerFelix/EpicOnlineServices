// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.CopyPlayerAchievementByAchievementId" /> function.
	/// </summary>
	public class CopyPlayerAchievementByAchievementIdOptions
	{
		/// <summary>
		/// The Product User ID for the user whose achievement is to be retrieved.
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Achievement ID to search for when retrieving player achievement data from the cache.
		/// </summary>
		public string AchievementId { get; set; }

		/// <summary>
		/// The Product User ID for the user who is querying for a player achievement. For a Dedicated Server this should be null.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyPlayerAchievementByAchievementIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_TargetUserId;
		private System.IntPtr m_AchievementId;
		private System.IntPtr m_LocalUserId;

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public string AchievementId
		{
			set
			{
				Helper.TryMarshalSet(ref m_AchievementId, value);
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(CopyPlayerAchievementByAchievementIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AchievementsInterface.CopyplayerachievementbyachievementidApiLatest;
				TargetUserId = other.TargetUserId;
				AchievementId = other.AchievementId;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyPlayerAchievementByAchievementIdOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_TargetUserId);
			Helper.TryMarshalDispose(ref m_AchievementId);
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}