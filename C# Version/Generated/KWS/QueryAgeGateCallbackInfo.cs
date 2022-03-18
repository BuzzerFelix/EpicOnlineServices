// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.KWS
{
	/// <summary>
	/// Output parameters for the <see cref="KWSInterface.QueryAgeGate" /> Function. These parameters are received through the callback provided to <see cref="KWSInterface.QueryAgeGate" />
	/// </summary>
	public class QueryAgeGateCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="KWSInterface.QueryAgeGate" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// Country code determined for this request based on the local client's ip address that the backend resolves
		/// </summary>
		public string CountryCode { get; private set; }

		/// <summary>
		/// Age of consent in the given country
		/// </summary>
		public uint AgeOfConsent { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(QueryAgeGateCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				CountryCode = other.Value.CountryCode;
				AgeOfConsent = other.Value.AgeOfConsent;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryAgeGateCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryAgeGateCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_CountryCode;
		private uint m_AgeOfConsent;

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

		public string CountryCode
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_CountryCode, out value);
				return value;
			}
		}

		public uint AgeOfConsent
		{
			get
			{
				return m_AgeOfConsent;
			}
		}
	}
}