using System;

namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Flags for HW Resolution support
    /// </summary>
    [Flags]
    public enum LAVHWResFlag
    {
        LAVHWResFlag_SD = 0x0001,
        LAVHWResFlag_HD = 0x0002,
        LAVHWResFlag_UHD = 0x0004
    }
}
