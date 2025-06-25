using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class TrackList
    {
        private List<Track> tracks;

        public TrackList()
        {
            this.tracks = new List<Track>();
        }
        public TrackList(List<Track> track)
        {
            this.tracks = track;

        }
        public void showAll()
        {

            Console.WriteLine("in deze tracklist staan:");
            foreach (Track track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }

        public void Add(Track t)
        {
            this.tracks.Add(t);
        }
        public void Remove(Track t)
        {
            this.tracks.Remove(t);
        }
        public void Clear()
        {
            this.tracks.Clear();
        }
        public void GetAllTracks()
        {
            foreach (Track t in this.tracks)
            {
                Console.WriteLine(t.Name);
            }
        }
        public List<Track> Shuffle()
        {
            List<Track> rtn = new List<Track>();
            Random random = new Random();

            List<Track> kopie = this.tracks;
            for (int i = 0; i < this.tracks.Count; i++)
            {
                //eerst random index
                int index = random.Next(kopie.Count);
                //dan waarde uit kopie halen
                Track t = kopie[index];
                //dan waarde in rtn stoppen
                rtn.Add(t);
                //dan waarde uit kopie verwijderen
                kopie.Remove(t);
            }

            return rtn;
        }
        public int Count
        {
            get { return this.tracks.Count; }
        }
        public TimeSpan TotalTime
        {
            get
            {
                TimeSpan totaletijd = TimeSpan.Zero;

                foreach (Track track in this.tracks)
                {
                    totaletijd = track.GetLength() + totaletijd;
                }
                return totaletijd;
            }
        }

    }
}
