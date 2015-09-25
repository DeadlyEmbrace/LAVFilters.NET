namespace LAVFiltersLib.LAVEnums.AudioSettings
{
    /// <summary>
    /// Supported Sample Formats in LAV Audio
    /// </summary>
    public enum LAVAudioSampleFormat
    {
        SampleFormat_None = -1,
        SampleFormat_16,
        SampleFormat_24,
        SampleFormat_32,
        SampleFormat_U8,
        SampleFormat_FP32,
        SampleFormat_Bitstream,

        /// <summary>
        /// Number of entries
        /// </summary>
        SampleFormat_NB
    }
}
