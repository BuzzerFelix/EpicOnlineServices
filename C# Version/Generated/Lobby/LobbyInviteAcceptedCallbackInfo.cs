// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="OnLobbyInviteAcceptedCallback" /> Function.
	/// </summary>
	public class LobbyInviteAcceptedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.AddNotifyLobbyInviteAccepted" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The invite ID
		/// </summary>
		public string InviteId { get; private set; }

		/// <summary>
		/// The Product User ID of the local user who received the invitation
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The Product User ID of the user who sent the invitation
		/// </summary>
		public ProductUserId TargetUserId { get; private set; }

		/// <summary>
		/// Lobby ID that the user has been invited to
		/// </summary>
		public string LobbyId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(LobbyInviteAcceptedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				InviteId = other.Value.InviteId;
				LocalUserId = other.Value.LocalUserId;
				TargetUserId = other.Value.TargetUserId;
				LobbyId = other.Value.LobbyId;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbyInviteAcceptedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_InviteId;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;
		private System.IntPtr m_LobbyId;

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

		public string InviteId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_InviteId, out value);
				return value;
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

		public ProductUserId TargetUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public string LobbyId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_LobbyId, out value);
				return value;
			}
		}
	}
}