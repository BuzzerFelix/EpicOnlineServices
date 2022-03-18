// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="UIInterface.ShowFriends" />
	/// </summary>
	/// <param name="data">A <see cref="ShowFriendsCallbackInfo" /> containing the output information and result</param>
	public delegate void OnShowFriendsCallback(ShowFriendsCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnShowFriendsCallbackInternal(System.IntPtr data);
}