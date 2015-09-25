using System;

namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Deinterlace algorithms offered by the hardware decoders
    /// </summary>
    public enum LAVHWDeintModes
    {
        HWDeintMode_Weave,
        [Obsolete]
        HWDeintMode_BOB,
        HWDeintMode_Hardware
    }
}
