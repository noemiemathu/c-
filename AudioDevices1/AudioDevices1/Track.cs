
namespace AudioDevices1.Tracks
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private TimeSpan length;

        enum Category
        {
            Ambient,
            Blues,
            Country,
            Disco,
            Electro,
            Hardcore,
            Hardrock,
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

        public Track() { }
        public Track(int id) { }
        public Track(int id, string name) { }
        public Track(int id, string artist, string name) { }

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
                if (name == null || artist == null)
                {
                    return "unknown";
                }
                else
                {
                    return $"{artist} - {name}";
                } 
            }
        }
        public TimeSpan Length
        {
            set { length = value; }
        }
        public string DisplayLengthb
        {
            get { return length.ToString(); }
        }
        public Category Style
        {
            get { return style; }
            set { style = value; }
        }
        public string AlbumSource
        {
            get { return albumSource; }
            set {  albumSource = value; }
        }
    }
}
