namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Type of deinterlacing to perform
    /// </summary>
    /// <remarks>
    /// Note: Weave will always use FramePer2Field
    /// </remarks>
    public enum LAVDeintOutput
    {
        /// <summary>
        /// FramePerField re-constructs one frame from every field, resulting in 50/60 fps.
        /// </summary>
        DeintOutput_FramePerField,
        /// <summary>
        /// FramePer2Field re-constructs one frame from every 2 fields, resulting in 25/30 fps.
        /// </summary>
        DeintOutput_FramePer2Field
    }
}
