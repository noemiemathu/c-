using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        protected int serialId;
        protected string model;
        protected string make;
        protected decimal priceExBtw;
        protected DateTime creationDate;
        protected readonly static double btwPercentage = 21.0;

        public string DisplayIdentity()
        {
            return $"Serial: [serialId]";
        }
        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string identity = $"Serial: {serialId}";

            if (makeInfo)
            {
                identity += $" Make: {make}";
            }

            if (modelInfo)
            {
                identity += $" Model: {model}";
            }

            return identity;
        }
        public string GetDeviceLifeTime()
        {
            if (creationDate != DateTime.MinValue)
            {
                TimeSpan diff = DateTime.Now.Subtract(creationDate);
                return $"Lifetime {diff.Days} days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }
        public abstract string DisplayStorageCapacity();

        public int SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public decimal PriceExBtw
        {
            get { return priceExBtw; }
            set { priceExBtw = value; }
        }
        public decimal ConsumerPrice
        {
            get { return ConsumerPrice; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
    }
}
