// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.CustomInvites
{
	/// <summary>
	/// Function prototype definition for notifications that comes from <see cref="CustomInvitesInterface.AddNotifyCustomInviteAccepted" />
	/// </summary>
	/// <param name="data">A <see cref="OnCustomInviteAcceptedCallbackInfo" /> containing the output information and result</param>
	public delegate void OnCustomInviteAcceptedCallback(OnCustomInviteAcceptedCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnCustomInviteAcceptedCallbackInternal(System.IntPtr data);
}