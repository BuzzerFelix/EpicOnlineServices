// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Output parameters for the <see cref="AuthInterface.LinkAccount" /> Function.
	/// </summary>
	public class LinkAccountCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="AuthInterface.LinkAccount" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Epic Account ID of the local user whose account has been linked during login
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// Optional data returned when ResultCode is <see cref="Result.AuthPinGrantCode" />.
		/// 
		/// Once the user has logged in with their Epic Online Services account, the account will be linked with the external account supplied when <see cref="AuthInterface.Login" /> was called.
		/// <see cref="OnLinkAccountCallback" /> will be fired again with ResultCode in <see cref="LinkAccountCallbackInfo" /> set to <see cref="Result.Success" />.
		/// </summary>
		public PinGrantInfo PinGrantInfo { get; private set; }

		/// <summary>
		/// The Epic Account ID that has been previously selected to be used for the current application.
		/// Applications should use this ID to authenticate with online backend services that store game-scoped data for users.
		/// 
		/// Note: This ID may be different from LocalUserId if the user has previously merged Epic accounts into the account
		/// represented by LocalUserId, and one of the accounts that got merged had game data associated with it for the application.
		/// </summary>
		public EpicAccountId SelectedAccountId { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(LinkAccountCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				PinGrantInfo = other.Value.PinGrantInfo;
				SelectedAccountId = other.Value.SelectedAccountId;
			}
		}

		public void Set(object other)
		{
			Set(other as LinkAccountCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_PinGrantInfo;
		private System.IntPtr m_SelectedAccountId;

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

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public PinGrantInfo PinGrantInfo
		{
			get
			{
				PinGrantInfo value;
				Helper.TryMarshalGet<PinGrantInfoInternal, PinGrantInfo>(m_PinGrantInfo, out value);
				return value;
			}
		}

		public EpicAccountId SelectedAccountId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_SelectedAccountId, out value);
				return value;
			}
		}
	}
}