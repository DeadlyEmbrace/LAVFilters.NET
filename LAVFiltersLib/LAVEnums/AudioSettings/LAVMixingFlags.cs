using System;

namespace LAVFiltersLib.LAVEnums.AudioSettings
{
    [Flags]
    public enum LAVMixingFlags
    {
        LAV_MIXING_FLAG_UNTOUCHED_STEREO = 0x0001,
        LAV_MIXING_FLAG_NORMALIZE_MATRIX = 0x0002,
        LAV_MIXING_FLAG_CLIP_PROTECTION = 0x0004
    }
}
