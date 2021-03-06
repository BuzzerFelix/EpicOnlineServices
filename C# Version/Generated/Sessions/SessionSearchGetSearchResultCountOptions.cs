// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.GetSearchResultCount" /> function.
	/// </summary>
	public class SessionSearchGetSearchResultCountOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionSearchGetSearchResultCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(SessionSearchGetSearchResultCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionSearch.SessionsearchGetsearchresultcountApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionSearchGetSearchResultCountOptions);
		}

		public void Dispose()
		{
		}
	}
}