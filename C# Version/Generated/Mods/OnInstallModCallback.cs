// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="ModsInterface.InstallMod" />
	/// </summary>
	/// <param name="data">A <see cref="InstallModCallbackInfo" /> containing the output information and result</param>
	public delegate void OnInstallModCallback(InstallModCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnInstallModCallbackInternal(System.IntPtr data);
}