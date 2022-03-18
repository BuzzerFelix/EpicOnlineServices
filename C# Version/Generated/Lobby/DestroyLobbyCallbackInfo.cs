// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="LobbyInterface.DestroyLobby" /> function.
	/// </summary>
	public class DestroyLobbyCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.DestroyLobby" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The destroyed lobby's ID
		/// </summary>
		public string LobbyId { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(DestroyLobbyCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LobbyId = other.Value.LobbyId;
			}
		}

		public void Set(object other)
		{
			Set(other as DestroyLobbyCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DestroyLobbyCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LobbyId;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

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