// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Reports
{
	/// <summary>
	/// Input parameters for the <see cref="ReportsInterface.SendPlayerBehaviorReport" /> function.
	/// </summary>
	public class SendPlayerBehaviorReportOptions
	{
		/// <summary>
		/// Product User ID of the reporting player
		/// </summary>
		public ProductUserId ReporterUserId { get; set; }

		/// <summary>
		/// Product User ID of the reported player.
		/// </summary>
		public ProductUserId ReportedUserId { get; set; }

		/// <summary>
		/// Category for the player report.
		/// </summary>
		public PlayerReportsCategory Category { get; set; }

		/// <summary>
		/// Optional plain text string associated with the report as UTF-8 encoded null-terminated string.
		/// 
		/// The length of the message can be at maximum up to <see cref="ReportsInterface.ReportmessageMaxLength" /> bytes
		/// and any excess characters will be truncated upon sending the report.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Optional JSON string associated with the report as UTF-8 encoded null-terminated string.
		/// This is intended as a way to associate arbitrary structured context information with a report.
		/// 
		/// This string needs to be valid JSON, report will fail otherwise.
		/// The length of the context can be at maximum up to <see cref="ReportsInterface.ReportcontextMaxLength" /> bytes, not including the null terminator, report will fail otherwise.
		/// </summary>
		public string Context { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SendPlayerBehaviorReportOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_ReporterUserId;
		private System.IntPtr m_ReportedUserId;
		private PlayerReportsCategory m_Category;
		private System.IntPtr m_Message;
		private System.IntPtr m_Context;

		public ProductUserId ReporterUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_ReporterUserId, value);
			}
		}

		public ProductUserId ReportedUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_ReportedUserId, value);
			}
		}

		public PlayerReportsCategory Category
		{
			set
			{
				m_Category = value;
			}
		}

		public string Message
		{
			set
			{
				Helper.TryMarshalSet(ref m_Message, value);
			}
		}

		public string Context
		{
			set
			{
				Helper.TryMarshalSet(ref m_Context, value);
			}
		}

		public void Set(SendPlayerBehaviorReportOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ReportsInterface.SendplayerbehaviorreportApiLatest;
				ReporterUserId = other.ReporterUserId;
				ReportedUserId = other.ReportedUserId;
				Category = other.Category;
				Message = other.Message;
				Context = other.Context;
			}
		}

		public void Set(object other)
		{
			Set(other as SendPlayerBehaviorReportOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ReporterUserId);
			Helper.TryMarshalDispose(ref m_ReportedUserId);
			Helper.TryMarshalDispose(ref m_Message);
			Helper.TryMarshalDispose(ref m_Context);
		}
	}
}