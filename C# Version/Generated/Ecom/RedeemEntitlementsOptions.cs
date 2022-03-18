// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.RedeemEntitlements" /> function.
	/// </summary>
	public class RedeemEntitlementsOptions
	{
		/// <summary>
		/// The Epic Account ID of the user who is redeeming Entitlements
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The array of Entitlements to redeem
		/// </summary>
		public string[] EntitlementIds { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct RedeemEntitlementsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private uint m_EntitlementIdCount;
		private System.IntPtr m_EntitlementIds;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string[] EntitlementIds
		{
			set
			{
				Helper.TryMarshalSet(ref m_EntitlementIds, value, out m_EntitlementIdCount);
			}
		}

		public void Set(RedeemEntitlementsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.RedeementitlementsApiLatest;
				LocalUserId = other.LocalUserId;
				EntitlementIds = other.EntitlementIds;
			}
		}

		public void Set(object other)
		{
			Set(other as RedeemEntitlementsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_EntitlementIds);
		}
	}
}