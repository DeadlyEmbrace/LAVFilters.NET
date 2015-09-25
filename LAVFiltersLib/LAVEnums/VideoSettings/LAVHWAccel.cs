namespace LAVFiltersLib.LAVEnums.VideoSettings
{
    /// <summary>
    /// Type of hardware accelerations
    /// </summary>
    public enum LAVHWAccel
    {
        HWAccel_None,
        HWAccel_CUDA,
        HWAccel_QuickSync,
        HWAccel_DXVA2,
        HWAccel_DXVA2CopyBack = HWAccel_DXVA2,
        HWAccel_DXVA2Native
    }
}
