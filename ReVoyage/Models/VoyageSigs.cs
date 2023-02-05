using Dalamud.Utility.Signatures;

namespace ReVoyage.Models
{
    public unsafe class VoyageSigs
    {
        [Signature("E8 ?? ?? ?? ?? 8B 44 24 50 0F B7 D5")]
        public delegate* unmanaged<byte, byte, short, int*, int*, int> GetAirshipVoyageTimeAndDistanceDelegate = null!;

        [Signature("E8 ?? ?? ?? ?? 01 43 10 8B CE")]
        public delegate* unmanaged<byte, short, uint> GetAirshipSurveyDurationDelegate = null!;

        [Signature("E8 ?? ?? ?? ?? 8B 4D EB 4D 8B 47 08")]
        public delegate* unmanaged<byte, byte, short, uint> GetSubmarineVoyageTimeDelegate = null!;

        [Signature("E8 ?? ?? ?? ?? 01 7B 10")]
        public delegate* unmanaged<byte, byte, uint> GetSubmarineVoyageDistanceDelegate = null!;

        [Signature("E8 ?? ?? ?? ?? 01 43 10 8B CD")]
        public delegate* unmanaged<byte, short, uint> GetSubmarineSurveyDurationDelegate = null!;

        public VoyageSigs() => SignatureHelper.Initialise(this);

        public void GetAirshipVoyageTimeAndDistance(byte a, byte b, short speed, out uint time, out uint distance)
        {
            var tp = 0;
            var dp = 0;
            GetAirshipVoyageTimeAndDistanceDelegate(a, b, speed, &tp, &dp);
            time = (uint)tp;
            distance = (uint)dp;
        }

        public void GetAirshipSurveyDuration(byte point, short speed, out uint time)
        {
            time = GetAirshipSurveyDurationDelegate(point, speed);
        }

        public void GetSubmarineVoyageTime(byte a, byte b, short speed, out uint time)
        {
            time = GetSubmarineVoyageTimeDelegate(a, b, speed);
        }

        public void GetSubmarineVoyageDistance(byte a, byte b, out uint distance)
        {
            distance = GetSubmarineVoyageDistanceDelegate(a, b);
        }

        public void GetSubmarineSurveyDuration(byte point, short speed, out uint time)
        {
            time = GetSubmarineSurveyDurationDelegate(point, speed);
        }
    }
}
