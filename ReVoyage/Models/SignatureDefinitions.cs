using Dalamud.Utility.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReVoyage.Models
{
    internal unsafe class SignatureDefinitions
    {
        [Signature("E8 ?? ?? ?? ?? 8B 44 24 50 0F B7 D5")]
        public delegate* unmanaged<byte, byte, short, int*, int*> GetAirshipVoyageTimeAndDistanceDelegate = null!;

        public SignatureDefinitions() => SignatureHelper.Initialise(this);

        public void GetAirshipVoyageTimeAndDistance(byte a, byte b, short speed, out int time, out int distance)
        {
            
        }
    }
}
