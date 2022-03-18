// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Callback for when <see cref="TitleStorageInterface.QueryFileList" /> completes
	/// </summary>
	public delegate void OnQueryFileListCompleteCallback(QueryFileListCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnQueryFileListCompleteCallbackInternal(System.IntPtr data);
}