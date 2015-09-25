namespace LAVFiltersLib.LAVEnums.AudioSettings
{
    /// <summary>
    /// Audio Mixing Layout
    /// </summary>
    /// <remarks>
    /// This is not part of the LAV official developer API and values might change in a future.
    /// Use on your on risk.
    /// </remarks>
    public enum LAVMixingLayout : uint
    {
        Mono = 4,
        Stereo = 3,
        Surround_4_0 = 1539,
        Surround_5_1 = 63,
        Surround_6_1 = 1807,
        Surround_7_1 = 1599
    }
}
