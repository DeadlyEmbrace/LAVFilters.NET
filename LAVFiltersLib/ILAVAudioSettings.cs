using LAVFiltersLib.LAVEnums.AudioSettings;
using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    /// <summary>
    /// LAV Audio configuration interface
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("4158A22B-6553-45D0-8069-24716F8FF171")]
    public interface ILAVAudioSettings
    {
        /// <summary>
        /// Switch to Runtime Config mode. This will reset all settings to default, and no changes to the settings will be saved.
        /// You can use this to programmatically configure LAV Audio without interfering with the users settings in the registry.
        /// Subsequent calls to this function will reset all settings back to defaults, even if the mode does not change.
        /// </summary>
        /// <remarks>
        /// Note that calling this function during playback is not supported and may exhibit undocumented behaviour.
        /// For smooth operations, it must be called before LAV Audio is connected to other filters.
        /// </remarks>
        /// <param name="bRuntimeConfig"></param>
        [PreserveSig]
        int SetRuntimeConfig([MarshalAs(UnmanagedType.Bool)] bool bRuntimeConfig);

        /// <summary>
        /// Dynamic Range Compression
        /// </summary>
        /// <param name="pbDRCEnabled">The state of DRC</param>
        /// <param name="piDRCLevel">The DRC strength (0-100, 100 is maximum)</param>
        [PreserveSig]
        int GetDRC(
            [Out, MarshalAs(UnmanagedType.Bool)] out bool pbDRCEnabled,
            [Out] out int piDRCLevel
        );

        /// <summary>
        /// Set Dynamic Range Compression
        /// </summary>
        /// <param name="bDRCEnabled">The state of DRC</param>
        /// <param name="iDRCLevel">The DRC strength (0-100, 100 is maximum)</param>
        [PreserveSig]
        int SetDRC([MarshalAs(UnmanagedType.Bool)] bool bDRCEnabled, int iDRCLevel);

        /// <summary>
        /// Get configure which codecs are enabled
        /// </summary>
        /// <param name="aCodec"></param>
        /// <returns>If aCodec is invalid (possibly a version difference), will return FALSE.</returns>
        [PreserveSig]
        bool GetFormatConfiguration(LAVAudioCodec aCodec);

        /// <summary>
        /// Configure which codecs are enabled
        /// </summary>
        /// <param name="aCodec">If aCodec is invalid (possibly a version difference), will return E_FAIL.</param>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetFormatConfiguration(LAVAudioCodec aCodec, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Bitstreamings
        /// </summary>
        /// <param name="bsCodec"></param>
        /// <returns>If bsCodec is invalid (possibly a version difference), will return FALSE.</returns>
        [PreserveSig]
        bool GetBitstreamConfig(LAVBitstreamCodec bsCodec);

        /// <summary>
        /// Set Bitstreaming
        /// </summary>
        /// <param name="bsCodec">If bsCodec is invalid (possibly a version difference), will return E_FAIL.</param>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetBitstreamConfig(LAVBitstreamCodec bsCodec, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get if "normal" DTS frames be encapsulated in DTS-HD frames when bitstreaming
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetDTSHDFraming();

        /// <summary>
        /// Set if "normal" DTS frames be encapsulated in DTS-HD frames when bitstreaming
        /// </summary>
        /// <param name="bHDFraming"></param>
        [PreserveSig]
        int SetDTSHDFraming([MarshalAs(UnmanagedType.Bool)] bool bHDFraming);

        /// <summary>
        /// Get Auto A/V syncing
        /// </summary>
        /// <returns>True - enable</returns>
        [PreserveSig]
        bool GetAutoAVSync();

        /// <summary>
        /// Set Auto A/V syncing
        /// </summary>
        /// <param name="bAutoSync">True - enable</param>
        [PreserveSig]
        int SetAutoAVSync([MarshalAs(UnmanagedType.Bool)] bool bAutoSync);

        /// <summary>
        /// Get Convert all Channel Layouts to standard layouts
        /// </summary>
        /// <remarks>Standard are: Mono, Stereo, 5.1, 6.1, 7.1</remarks>
        /// <returns></returns>
        [PreserveSig]
        bool GetOutputStandardLayout();

        /// <summary>
        /// Set Convert all Channel Layouts to standard layouts
        /// </summary>
        /// <remarks>Standard are: Mono, Stereo, 5.1, 6.1, 7.1</remarks>
        /// <param name="bStdLayout"></param>
        [PreserveSig]
        int SetOutputStandardLayout([MarshalAs(UnmanagedType.Bool)] bool bStdLayout);

        /// <summary>
        /// Get Expand Mono to Stereo by simply doubling the audio
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetExpandMono();

        /// <summary>
        /// Set Expand Mono to Stereo by simply doubling the audio
        /// </summary>
        /// <param name="bExpandMono"></param>
        [PreserveSig]
        int SetExpandMono([MarshalAs(UnmanagedType.Bool)] bool bExpandMono);

        /// <summary>
        /// Get Expand 6.1 to 7.1 by doubling the back center
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetExpand61();

        /// <summary>
        /// Set Expand 6.1 to 7.1 by doubling the back center
        /// </summary>
        /// <param name="bExpand61"></param>
        [PreserveSig]
        int SetExpand61([MarshalAs(UnmanagedType.Bool)] bool bExpand61);

        /// <summary>
        /// Get Allow Raw PCM and SPDIF encoded input
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetAllowRawSPDIFInput();

        /// <summary>
        /// Set Allow Raw PCM and SPDIF encoded input
        /// </summary>
        /// <param name="bAllow"></param>
        [PreserveSig]
        int SetAllowRawSPDIFInput([MarshalAs(UnmanagedType.Bool)] bool bAllow);

        /// <summary>
        /// Get configuration which sample formats are enabled
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        [PreserveSig]
        bool GetSampleFormat(LAVAudioSampleFormat format);

        /// <summary>
        /// Configure which sample formats are enabled
        /// </summary>
        /// <param name="format"></param>
        /// <param name="bEnabled"></param>
        /// <remarks>Note: SampleFormat_Bitstream cannot be controlled by this</remarks>
        [PreserveSig]
        int SetSampleFormat(LAVAudioSampleFormat format, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get delay for the audio configuration
        /// </summary>
        /// <param name="pbEnabled"></param>
        /// <param name="pDelay">In ms</param>
        [PreserveSig]
        int GetAudioDelay(
            [Out, MarshalAs(UnmanagedType.Bool)] out bool pbEnabled,
            [Out] out int pDelay
        );

        /// <summary>
        /// Configure a delay for the audio
        /// </summary>
        /// <param name="bEnabled"></param>
        /// <param name="delay">In ms</param>
        [PreserveSig]
        int SetAudioDelay([MarshalAs(UnmanagedType.Bool)] bool bEnabled, int delay);

        /// <summary>
        /// Enable/Disable Mixing
        /// </summary>
        /// <param name="bEnabled">True - enabled</param>
        [PreserveSig]
        int SetMixingEnabled([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Mixing status
        /// </summary>
        /// <returns>True - enabled</returns>
        [PreserveSig]
        bool GetMixingEnabled();

        /// <summary>
        /// Set Mixing Layout
        /// </summary>
        /// <param name="dwLayout">LAVEnums.AudioSettings.LAVMixingLayout</param>
        [PreserveSig]
        int SetMixingLayout(uint dwLayout);

        /// <summary>
        /// Get Mixing Layout
        /// </summary>
        /// <returns>LAVEnums.AudioSettings.LAVMixingLayout</returns>
        [PreserveSig]
        uint GetMixingLayout();

        /// <summary>
        /// Set Mixing Flags
        /// </summary>
        /// <param name="dwFlags"></param>
        [PreserveSig]
        int SetMixingFlags([In] LAVMixingFlags dwFlags);

        /// <summary>
        /// Get Mixing Flags
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVMixingFlags GetMixingFlags();

        /// <summary>
        /// Set Mixing Mode
        /// </summary>
        /// <param name="mixingMode"></param>
        [PreserveSig]
        int SetMixingMode(LAVAudioMixingMode mixingMode);

        /// <summary>
        /// Get Mixing Mode
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVAudioMixingMode GetMixingMode();

        /// <summary>
        /// Set Mixing Levels
        /// </summary>
        /// <param name="dwCenterLevel">Center Mix Level</param>
        /// <param name="dwSurroundLevel">Surround Mix Level</param>
        /// <param name="dwLFELevel">LFE Mix Level</param>
        [PreserveSig]
        int SetMixingLevels(uint dwCenterLevel, uint dwSurroundLevel, uint dwLFELevel);

        /// <summary>
        /// Get Mixing Levels
        /// </summary>
        /// <param name="dwCenterLevel">Center Mix Level</param>
        /// <param name="dwSurroundLevel">Surround Mix Level</param>
        /// <param name="dwLFELevel">LFE Mix Level</param>
        [PreserveSig]
        int GetMixingLevels(
            out uint dwCenterLevel,
            out uint dwSurroundLevel,
            out uint dwLFELevel);

        /// <summary>
        /// Toggle Tray Icon
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetTrayIcon([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Tray Icon status
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetTrayIcon();

        /// <summary>
        /// Toggle Dithering for sample format conversion
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetSampleConvertDithering([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Dithering for sample format conversion status
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetSampleConvertDithering();

        /// <summary>
        /// Suppress sample format changes. This will allow channel count to increase, but not to reduce, instead adding empty channels
        /// </summary>
        /// <param name="bEnabled"></param>
        /// <remarks>This option is NOT persistent</remarks>
        [PreserveSig]
        int SetSuppressFormatChanges([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get suppression of sample format changes status
        /// </summary>
        /// <returns></returns>
        /// <remarks>This option is NOT persistent</remarks>
        [PreserveSig]
        bool GetSuppressFormatChanges();

        /// <summary>
        /// Get if 5.1 legacy layout (using back channels instead of side) is in use
        /// </summary>
        /// <returns></returns>
        bool GetOutput51LegacyLayout();

        /// <summary>
        /// Use 5.1 legacy layout (using back channels instead of side)
        /// </summary>
        /// <param name="b51Legacy"></param>
        int SetOutput51LegacyLayout([MarshalAs(UnmanagedType.Bool)] bool b51Legacy);
    }
}
