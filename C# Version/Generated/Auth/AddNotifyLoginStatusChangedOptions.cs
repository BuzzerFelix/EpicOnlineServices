// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.AddNotifyLoginStatusChanged" /> Function.
	/// </summary>
	public class AddNotifyLoginStatusChangedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(AddNotifyLoginStatusChangedOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AuthInterface.AddnotifyloginstatuschangedApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyLoginStatusChangedOptions);
		}

		public void Dispose()
		{
		}
	}
}