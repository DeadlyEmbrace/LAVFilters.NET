namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Supported output pixel formats
    /// </summary>
    public enum LAVOutPixFmts
    {
        LAVOutPixFmt_None = -1,
        /// <summary>
        /// 4:2:0, 8bit, planar
        /// </summary>
        LAVOutPixFmt_YV12,
        /// <summary>
        /// 4:2:0, 8bit, Y planar, U/V packed
        /// </summary>
        LAVOutPixFmt_NV12,
        /// <summary>
        /// 4:2:2, 8bit, packed
        /// </summary>
        LAVOutPixFmt_YUY2,
        /// <summary>
        /// 4:2:2, 8bit, packed
        /// </summary>
        LAVOutPixFmt_UYVY,
        /// <summary>
        /// 4:4:4, 8bit, packed
        /// </summary>
        LAVOutPixFmt_AYUV,
        /// <summary>
        /// 4:2:0, 10bit, Y planar, U/V packed
        /// </summary>
        LAVOutPixFmt_P010,
        /// <summary>
        /// 4:2:2, 10bit, Y planar, U/V packed
        /// </summary>
        LAVOutPixFmt_P210,
        /// <summary>
        /// 4:4:4, 10bit, packed
        /// </summary>
        LAVOutPixFmt_Y410,
        /// <summary>
        /// 4:2:0, 16bit, Y planar, U/V packed
        /// </summary>
        LAVOutPixFmt_P016,
        /// <summary>
        /// 4:2:2, 16bit, Y planar, U/V packed
        /// </summary>
        LAVOutPixFmt_P216,
        /// <summary>
        /// 4:4:4, 16bit, packed
        /// </summary>
        LAVOutPixFmt_Y416,
        /// <summary>
        /// 32-bit RGB (BGRA)
        /// </summary>
        LAVOutPixFmt_RGB32,
        /// <summary>
        /// 24-bit RGB (BGR)
        /// </summary>
        LAVOutPixFmt_RGB24,

        /// <summary>
        /// 4:2:2, 10bit, packed
        /// </summary>
        LAVOutPixFmt_v210,
        /// <summary>
        /// 4:4:4, 10bit, packed
        /// </summary>
        LAVOutPixFmt_v410,

        /// <summary>
        /// 4:2:2, 8-bit, planar
        /// </summary>
        LAVOutPixFmt_YV16,
        /// <summary>
        /// 4:4:4, 8-bit, planar
        /// </summary>
        LAVOutPixFmt_YV24,

        /// <summary>
        /// 48-bit RGB (16-bit per pixel, BGR)
        /// </summary>
        LAVOutPixFmt_RGB48,

        /// <summary>
        /// Number of formats
        /// </summary>
        LAVOutPixFmt_NB
    }
}
