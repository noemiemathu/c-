using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private TimeSpan length;

        public enum Category
        {
            Ambient,
            Blues,
            Country,
            Disco,
            Electro,
            Hardcore,
            HardRock,
            HeavyMetal,
            Hiphop,
            Jazz,
            Jumpstyle,
            Klassiek,
            Latin,
            Other,
            Pop,
            Punk,
            Reggae,
            Rock,
            Soul,
            Trance,
            Techno
        }

        public Track()
        {

        }
        public Track(int id)
        {
            this.id = id;
        }
        public Track(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Track(int id, string artist, string name)
        {
            this.id = id;
            this.artist = artist;
            this.name = name;
        }

        public TimeSpan GetLength()
        {
            return length;
        }
        public int GetLengthInSeconds()
        {
            return (int)length.TotalSeconds;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        public string DisplayName
        {
            get
            {
                if (!string.IsNullOrEmpty(artist) && !string.IsNullOrEmpty(name))
                {
                    return $"{artist} - {name}";
                }
                else return "unknown";
            }
        }
        public TimeSpan Length
        {
            set { length = value; }
        }
        public string DisplayLength
        {
            get { return length.ToString(@"mm\:ss"); }
        }
        public Category Style
        {
            get { return style; }
            set { style = value; }
        }
        public string AlbumSource
        {
            get { return albumSource; }
            set { albumSource = value; }
        }
    }
}
