// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Function prototype definition for callbacks passed into <see cref="ConnectInterface.VerifyIdToken" />.
	/// </summary>
	/// <param name="data">A <see cref="VerifyIdTokenCallbackInfo" /> containing the output information and result.</param>
	public delegate void OnVerifyIdTokenCallback(VerifyIdTokenCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnVerifyIdTokenCallbackInternal(System.IntPtr data);
}