// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// <see cref="ModIdentifier" /> is used to identify a mod.
	/// </summary>
	public class ModIdentifier : ISettable
	{
		/// <summary>
		/// Product namespace id in which this mod item exists
		/// </summary>
		public string NamespaceId { get; set; }

		/// <summary>
		/// Item id of the Mod
		/// </summary>
		public string ItemId { get; set; }

		/// <summary>
		/// Artifact id of the Mod
		/// </summary>
		public string ArtifactId { get; set; }

		/// <summary>
		/// Represent mod item title.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Represent mod item version.
		/// </summary>
		public string Version { get; set; }

		internal void Set(ModIdentifierInternal? other)
		{
			if (other != null)
			{
				NamespaceId = other.Value.NamespaceId;
				ItemId = other.Value.ItemId;
				ArtifactId = other.Value.ArtifactId;
				Title = other.Value.Title;
				Version = other.Value.Version;
			}
		}

		public void Set(object other)
		{
			Set(other as ModIdentifierInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ModIdentifierInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_NamespaceId;
		private System.IntPtr m_ItemId;
		private System.IntPtr m_ArtifactId;
		private System.IntPtr m_Title;
		private System.IntPtr m_Version;

		public string NamespaceId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_NamespaceId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_NamespaceId, value);
			}
		}

		public string ItemId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_ItemId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_ItemId, value);
			}
		}

		public string ArtifactId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_ArtifactId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_ArtifactId, value);
			}
		}

		public string Title
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Title, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_Title, value);
			}
		}

		public string Version
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Version, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_Version, value);
			}
		}

		public void Set(ModIdentifier other)
		{
			if (other != null)
			{
				m_ApiVersion = ModsInterface.ModIdentifierApiLatest;
				NamespaceId = other.NamespaceId;
				ItemId = other.ItemId;
				ArtifactId = other.ArtifactId;
				Title = other.Title;
				Version = other.Version;
			}
		}

		public void Set(object other)
		{
			Set(other as ModIdentifier);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_NamespaceId);
			Helper.TryMarshalDispose(ref m_ItemId);
			Helper.TryMarshalDispose(ref m_ArtifactId);
			Helper.TryMarshalDispose(ref m_Title);
			Helper.TryMarshalDispose(ref m_Version);
		}
	}
}