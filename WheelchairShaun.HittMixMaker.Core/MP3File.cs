using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WheelchairShaun.HittMixMaker.Core
{
	public class MP3File : ISong
	{
		private const string FILE_EXTENSION = "mp3";

		public MP3File() { }

		public MP3File(string filePath)
		{
			FilePath = filePath;
		}

		public MP3File(string filePath, string song, int length, string artist, string album)
		{
			FilePath = filePath;
			Song = song;
			Length = length;
			Artist = artist;
			Album = album;
		}

		public string FilePath { get; set; }
		public string FileExtension { get { return FILE_EXTENSION; } }
		public string Song { get; set; }
		public int Length { get; set; }
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
	}
}
