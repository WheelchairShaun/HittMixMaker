using System;
using System.Collections.Generic;
using System.Text;

namespace WheelchairShaun.HittMixMaker.Core
{
	public class AACFile : ISong, IEquatable<AACFile>
	{

		private const string FILE_EXTENSION = "aac";

		public AACFile() { }

		public AACFile(string filePath, string fileName)
		{
			FilePath = filePath;
			FileName = fileName;
		}

		public AACFile(string filePath, string fileName, string title, int lengthInSeconds, string artist, string album)
		{
			FilePath = filePath;
			FileName = fileName;
			Title = title;
			LengthInSeconds = lengthInSeconds;
			Artist = artist;
			Album = album;
		}

		public string FilePath { get; set; }
		public string FileName { get; set; }
		public string FileExtension { get { return FILE_EXTENSION; } }
		public string Title { get; set; }
		public int LengthInSeconds { get; set; }
		public string Artist { get; set; }
		public string Album { get; set; }
		public string AlbumArtist { get; set; }
		public string Composer { get; set; }
		public string Grouping { get; set; }
		public string Genre { get; set; }
		public int Year { get; set; }
		public int Track { get; set; }
		public int AlbumTracks { get; set; }
		public int Disc { get; set; }
		public int AlbumDiscs { get; set; }
		public bool Compilation { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			ISong objAsISong = obj as ISong;
			if (objAsISong == null) return false;
			else return Equals(objAsISong);
		}

		public bool Equal(ISong other)
		{
			if (other == null) return false;
			if (!other.Title.Equals(this.Title)) return false;
			if (!other.Artist.Equals(this.Artist)) return false;
			if (!other.Album.Equals(this.Album)) return false;
			if (!other.LengthInSeconds.Equals(this.LengthInSeconds)) return false;
			return true;
		}

		public bool Equals(AACFile other)
		{
			if (other == null) return false;
			ISong objAsISong = other as ISong;
			if (objAsISong == null) return false;
			return Equals(objAsISong);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
