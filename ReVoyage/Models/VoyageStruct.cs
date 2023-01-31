using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using FFXIVClientStructs.Interop.Attributes;

namespace ReVoyage.Models
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public unsafe struct AirshipVoyageStruct
    {
        [MemberFunction("E8 ?? ?? ?? ?? 8B 44 24 50 0F B7 D5")]
        public void GetAirshipVoyageTimeAndDistance()
        {

        }

        [MemberFunction("E8 ?? ?? ?? ?? 01 43 10 8B CE")]
        public void GetAirshipSurveyDuration()
        {

        }
    }

	[StructLayout(LayoutKind.Explicit, Size = 0x38)]
	public unsafe struct SubmarineVoyageStruct
    {
        [MemberFunction("E8 ?? ?? ?? ?? 8B 4D EB 4D 8B 47 08")]
        public void GetSubmarineVoyageTime()
        {

        }

        [MemberFunction("E8 ?? ?? ?? ?? 01 7B 10")]
        public void GetSubmarineVoyageDistance()
        {

        }

        [MemberFunction("E8 ?? ?? ?? ?? 01 43 10 8B CD")]
        public void GetSubmarineSurveyDuration()
        {

        }
    }
}
