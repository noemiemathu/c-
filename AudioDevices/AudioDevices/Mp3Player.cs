using AudioDevices.Interfaces;
using AudioDevices.Tracks;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevice, ITracklist, IDisplay
    {
        TrackList ITracklist.TrackList { get; }

        private TrackList trackList;
        private int mBSize = 0;
        private int displayWidth;
        private int displayHeight;
        
        int IDisplay.DisplayWidth { get; set; }
        int IDisplay.DisplayHeight { get; set; }
        int IDisplay.TotalPixels => displayWidth * displayHeight;

        public Mp3Player(int serialId)
        {
            this.serialId = serialId;
        }
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }
        public bool HasTracks()
        {
            if (TrackList == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddTrackList(TrackList trackList)
        {
            this.trackList = trackList;
        }

        public void RemoveTrackList()
        {
            this.trackList = null;
        }

        public string DisplayStoageCapacity()
        {
            if (mBSize == 0 || mBSize < 0)
            {
                return "Storage capacity unknown.";
            }
            else
            {
                return $"{mBSize} mB";
            }
        }

        public override string DisplayStorageCapacity()
        {
            throw new NotImplementedException();
        }

        public int MbSize { get; set; }
        public int DisplayWidth { get; set; }
        public int DisplayHeight { get; set; }
        public int TotalPixels { get; }
        public TrackList TrackList { get; }
    }
}
