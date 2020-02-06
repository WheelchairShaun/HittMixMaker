using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WheelchairShaun.HittMixMaker.Core
{
	public interface ISong
	{
		public string FilePath { get; set; }
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
