using System;
using System.Collections.Generic;
using System.Text;

namespace WheelchairShaun.HittMixMaker.Core
{
	public class Playlist
	{
		private const string FILE_EXTENSION = "m3u";
		private const string FILE_HEADER = "#EXTM3U";
		private const string EXTENDED_INFO = "#EXTINF:";

		private IList<ISong> _songs;

		public Playlist()
		{
			_songs = new List<ISong>();
		}

		public Playlist(IList<ISong> songs)
		{
			_songs = songs;
		}

		public Playlist(string filePath, string name)
		{
			_songs = new List<ISong>();
			FilePath = filePath;
			Name = name;
		}

		public Playlist(IList<ISong> songs, string filePath, string name)
		{
			_songs = songs;
			FilePath = filePath;
			Name = name;
		}

		public string FilePath { get; set; }
		public string FileExtension { get { return FILE_EXTENSION; } }
		public string FileHeader { get { return FILE_HEADER; } }
		public string ExtendedInfo { get { return EXTENDED_INFO; } }
		public string Name { get; set; }

		public void Add(ISong song)
		{
			_songs.Add(song);
		}

		public void Clear()
		{
			_songs.Clear();
		}

		public bool Contains(ISong song)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			return _songs.Count;
		}

		public void Insert(int position, ISong song)
		{
			if (position < 0 || position > _songs.Count) throw new ArgumentOutOfRangeException();

			_songs.Insert(position, song);
		}

		public void RemoveAt(int position)
		{
			if (position < 0 || position >= _songs.Count) throw new ArgumentOutOfRangeException();

			_songs.RemoveAt(position);
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
