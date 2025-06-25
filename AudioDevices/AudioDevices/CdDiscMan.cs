using AudioDevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AudioDevices.Devices
{
    public class CdDiscMan : IDisplay
    {
        private int mBSize = 700;
        private int MBSize;
        private int displayHeight;
        private bool IsEjected = false;

        public CdDiscMan(int serialId) { }

        int IDisplay.DisplayWidth { get; set; }
        int IDisplay.DisplayHeight { get; set; }
        int IDisplay.TotalPixels => DisplayWidth * DisplayHeight;

        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }
        public string DisplayStorageCapacity()
        {
            string capacity = mBSize.ToString();
            return $"{capacity} mB";
        }
        public void Eject()
        {
            if (IsEjected == false)
            {
                IsEjected = true;
            }
            if (IsEjected == true)
            {
                IsEjected = false;
            }
            IsEjected = isEjected;
        }
        
        int MbSize { get; }
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }
        bool isEjected { get; }
    }
}
