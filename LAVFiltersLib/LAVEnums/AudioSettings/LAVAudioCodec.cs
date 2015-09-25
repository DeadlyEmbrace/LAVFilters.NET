namespace LAVFiltersLib.LAVEnums.AudioSettings
{
    /// <summary>
    /// Codecs supported in the LAV Audio configuration.
    /// </summary>
    /// <remarks>
    /// Codecs not listed here cannot be turned off.
    /// </remarks>
    public enum LAVAudioCodec
    {
        Codec_AAC,
        Codec_AC3,
        Codec_EAC3,
        Codec_DTS,
        Codec_MP2,
        Codec_MP3,
        Codec_TRUEHD,
        Codec_FLAC,
        Codec_VORBIS,
        Codec_LPCM,
        Codec_PCM,
        Codec_WAVPACK,
        Codec_TTA,
        Codec_WMA2,
        Codec_WMAPRO,
        Codec_Cook,
        Codec_RealAudio,
        Codec_WMALL,
        Codec_ALAC,
        Codec_Opus,
        Codec_AMR,
        Codec_Nellymoser,
        Codec_MSPCM,
        Codec_Truespeech,
        Codec_TAK,
        Codec_ATRAC,

        /// <summary>
        /// Number of entries
        /// </summary>
        Codec_AudioNB
    }
}
