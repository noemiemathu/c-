using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Interfaces
{
    public interface IDisplay
    {
        string GetResolutionInfo();

        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }
    }

    public interface ITracklist
    {
        bool HasTracks();
        void AddTrackList(TrackList tracklist);
        void RemoveTrackList();

        TrackList TrackList { get; }
    }
}
