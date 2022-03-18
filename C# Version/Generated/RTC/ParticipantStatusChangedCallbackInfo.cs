// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCInterface.AddNotifyParticipantStatusChanged" /> registered event.
	/// </summary>
	public class ParticipantStatusChangedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCInterface.AddNotifyParticipantStatusChanged" />.
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The room associated with this event.
		/// </summary>
		public string RoomName { get; private set; }

		/// <summary>
		/// The participant whose status changed.
		/// </summary>
		public ProductUserId ParticipantId { get; private set; }

		/// <summary>
		/// What status change occurred
		/// </summary>
		public RTCParticipantStatus ParticipantStatus { get; private set; }

		/// <summary>
		/// The participant metadata items.
		/// This is only set if ParticipantStatus is <see cref="RTCParticipantStatus.Joined" />
		/// </summary>
		public ParticipantMetadata[] ParticipantMetadata { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ParticipantStatusChangedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				ParticipantId = other.Value.ParticipantId;
				ParticipantStatus = other.Value.ParticipantStatus;
				ParticipantMetadata = other.Value.ParticipantMetadata;
			}
		}

		public void Set(object other)
		{
			Set(other as ParticipantStatusChangedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ParticipantStatusChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_ParticipantId;
		private RTCParticipantStatus m_ParticipantStatus;
		private uint m_ParticipantMetadataCount;
		private System.IntPtr m_ParticipantMetadata;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public string RoomName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_RoomName, out value);
				return value;
			}
		}

		public ProductUserId ParticipantId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_ParticipantId, out value);
				return value;
			}
		}

		public RTCParticipantStatus ParticipantStatus
		{
			get
			{
				return m_ParticipantStatus;
			}
		}

		public ParticipantMetadata[] ParticipantMetadata
		{
			get
			{
				ParticipantMetadata[] value;
				Helper.TryMarshalGet<ParticipantMetadataInternal, ParticipantMetadata>(m_ParticipantMetadata, out value, m_ParticipantMetadataCount);
				return value;
			}
		}
	}
}