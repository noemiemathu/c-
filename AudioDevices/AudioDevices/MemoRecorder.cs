using AudioDevices;

namespace AudioDevices.Devices
{
    public class MemoRecorder: AudioDevice
    {
        private MemoCartridgeType maxCartridgeType;

        public enum MemoCartridgeType
        {
            C60,
            C90Plus,
            C120,
            Unknown
        }

        public MemoRecorder(int serialId)
        {
            this.serialId = serialId;
        }

        public override string DisplayStorageCapacity()
        {
            switch (maxCartridgeType)
            {
                case MemoCartridgeType.C60:
                    return "Max capacity 60 min.";
                case MemoCartridgeType.C90Plus:
                    return "Max capacity 90 min.";
                case MemoCartridgeType.C120:
                    return "Max capacity 120 min.";
                default:
                    return "Max capacity unknown";
            }
        }
        public MemoCartridgeType MaxCartridgeType
        {
            get { return MaxCartridgeType; }
            set { MaxCartridgeType = value; }
        }
    }
}
