// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.AddAttribute" /> function.
	/// </summary>
	public class SessionModificationAddAttributeOptions
	{
		/// <summary>
		/// Key/Value pair describing the attribute to add to the session
		/// </summary>
		public AttributeData SessionAttribute { get; set; }

		/// <summary>
		/// Is this attribution advertised with the backend or simply stored locally
		/// </summary>
		public SessionAttributeAdvertisementType AdvertisementType { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationAddAttributeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionAttribute;
		private SessionAttributeAdvertisementType m_AdvertisementType;

		public AttributeData SessionAttribute
		{
			set
			{
				Helper.TryMarshalSet<AttributeDataInternal, AttributeData>(ref m_SessionAttribute, value);
			}
		}

		public SessionAttributeAdvertisementType AdvertisementType
		{
			set
			{
				m_AdvertisementType = value;
			}
		}

		public void Set(SessionModificationAddAttributeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionModification.SessionmodificationAddattributeApiLatest;
				SessionAttribute = other.SessionAttribute;
				AdvertisementType = other.AdvertisementType;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionModificationAddAttributeOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionAttribute);
		}
	}
}