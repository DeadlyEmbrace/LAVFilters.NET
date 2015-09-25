namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Codecs with hardware acceleration
    /// </summary>
    public enum LAVVideoHWCodec
    {
        HWCodec_H264 = LAVVideoCodec.Codec_H264,
        HWCodec_VC1 = LAVVideoCodec.Codec_VC1,
        HWCodec_MPEG2 = LAVVideoCodec.Codec_MPEG2,
        HWCodec_MPEG4 = LAVVideoCodec.Codec_MPEG4,
        HWCodec_MPEG2DVD,
        HWCodec_HEVC,

        HWCodec_NB = HWCodec_HEVC + 1
    };
}
