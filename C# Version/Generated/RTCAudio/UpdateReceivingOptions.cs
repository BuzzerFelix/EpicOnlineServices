// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCAudioInterface.UpdateReceiving" />.
	/// </summary>
	public class UpdateReceivingOptions
	{
		/// <summary>
		/// The Product User ID of the user trying to request this operation.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room this settings should be applied on.
		/// </summary>
		public string RoomName { get; set; }

		/// <summary>
		/// The participant to modify or null to update the global configuration
		/// </summary>
		public ProductUserId ParticipantId { get; set; }

		/// <summary>
		/// Mute or unmute audio track
		/// </summary>
		public bool AudioEnabled { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateReceivingOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_ParticipantId;
		private int m_AudioEnabled;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string RoomName
		{
			set
			{
				Helper.TryMarshalSet(ref m_RoomName, value);
			}
		}

		public ProductUserId ParticipantId
		{
			set
			{
				Helper.TryMarshalSet(ref m_ParticipantId, value);
			}
		}

		public bool AudioEnabled
		{
			set
			{
				Helper.TryMarshalSet(ref m_AudioEnabled, value);
			}
		}

		public void Set(UpdateReceivingOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAudioInterface.UpdatereceivingApiLatest;
				LocalUserId = other.LocalUserId;
				RoomName = other.RoomName;
				ParticipantId = other.ParticipantId;
				AudioEnabled = other.AudioEnabled;
			}
		}

		public void Set(object other)
		{
			Set(other as UpdateReceivingOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_RoomName);
			Helper.TryMarshalDispose(ref m_ParticipantId);
		}
	}
}