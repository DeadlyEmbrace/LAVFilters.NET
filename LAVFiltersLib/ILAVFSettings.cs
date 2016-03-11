using LAVFiltersLib.LAVEnums.SplitterSettings;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LAVFiltersLib
{
    /// <summary>
    /// LAV Splitter configuration interface
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("774A919D-EA95-4A87-8A1E-F48ABE8499C7")]
    public interface ILAVFSettings
    {
        /// <summary>
        /// Switch to Runtime Config mode. This will reset all settings to default, and no changes to the settings will be saved.
        /// You can use this to programmatically configure LAV Splitter without interfering with the users settings in the registry.
        /// Subsequent calls to this function will reset all settings back to defaults, even if the mode does not change.
        /// </summary>
        /// <remarks>
        /// Note that calling this function during playback is not supported and may exhibit undocumented behaviour. 
        /// For smooth operations, it must be called before LAV Splitter opens a file.
        /// </remarks>
        /// <param name="bRuntimeConfig"></param>
        [PreserveSig]
        int SetRuntimeConfig([MarshalAs(UnmanagedType.Bool)] bool bRuntimeConfig);

        /// <summary>
        /// Retrieve the preferred languages as ISO 639-2 language codes, comma separated
        /// </summary>
        /// <param name="ppLanguages">If the result is NULL, no language has been set</param>
        [PreserveSig]
        int GetPreferredLanguages([Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder ppLanguages);

        /// <summary>
        /// Set the preferred languages as ISO 639-2 language codes, comma separated.
        /// To reset to no preferred language, pass NULL or the empty string.
        /// </summary>
        /// <param name="pLanguages"></param>
        [PreserveSig]
        int SetPreferredLanguages([MarshalAs(UnmanagedType.LPWStr)] string pLanguages);

        /// <summary>
        /// Retrieve the preferred subtitle languages as ISO 639-2 language codes, comma separated.
        /// </summary>
        /// <param name="ppLanguages">If the result is NULL, no language has been set</param>
        /// <remarks>
        /// If no subtitle language is set, the main language preference is used.
        /// </remarks>
        [PreserveSig]
        int GetPreferredSubtitleLanguages([Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder ppLanguages);

        /// <summary>
        /// Set the preferred subtitle languages as ISO 639-2 language codes, comma separated.
        /// </summary>
        /// <param name="pLanguages">To reset to no preferred language, pass NULL or the empty string.</param>
        /// <remarks>
        /// If no subtitle language is set, the main language preference is used.
        /// </remarks>
        [PreserveSig]
        int SetPreferredSubtitleLanguages([MarshalAs(UnmanagedType.LPWStr)] string pLanguages);

        /// <summary>
        /// Get the current subtitle mode
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVSubtitleMode GetSubtitleMode();

        /// <summary>
        /// Set the current subtitle mode
        /// </summary>
        /// <param name="mode"></param>
        [PreserveSig]
        int SetSubtitleMode([In] LAVSubtitleMode mode);

        /// <summary>
        /// Get the subtitle matching language flag
        /// </summary>
        /// <returns>TRUE = Only subtitles with a language in the preferred list will be used; FALSE = All subtitles will be used</returns>
        [Obsolete("Do not use anymore, deprecated and non-functional, replaced by advanced subtitle mode", true)]
        [PreserveSig]
        bool GetSubtitleMatchingLanguage();

        /// <summary>
        /// Set the subtitle matching language flag
        /// </summary>
        /// <param name="dwMode">TRUE = Only subtitles with a language in the preferred list will be used; FALSE = All subtitles will be used</param>
        [Obsolete("Do not use anymore, deprecated and non-functional, replaced by advanced subtitle mode", true)]
        [PreserveSig]
        int SetSubtitleMatchingLanguage([MarshalAs(UnmanagedType.Bool)] bool dwMode);

        /// <summary>
        /// Control whether a special "Forced Subtitles" stream will be created for PGS subs
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetPGSForcedStream();

        /// <summary>
        /// Control whether a special "Forced Subtitles" stream will be created for PGS subs
        /// </summary>
        /// <param name="bFlag"></param>
        [PreserveSig]
        int SetPGSForcedStream([MarshalAs(UnmanagedType.Bool)] bool bFlag);

        /// <summary>
        /// Get the PGS forced subs config
        /// </summary>
        /// <returns>TRUE = only forced PGS frames will be shown, FALSE = all frames will be shown</returns>
        [PreserveSig]
        bool GetPGSOnlyForced();

        /// <summary>
        /// Set the PGS forced subs config
        /// </summary>
        /// <param name="bForced">TRUE = only forced PGS frames will be shown, FALSE = all frames will be shown</param>
        [PreserveSig]
        int SetPGSOnlyForced([MarshalAs(UnmanagedType.Bool)] bool bForced);

        /// <summary>
        /// Get the VC-1 Timestamp Processing mode
        /// </summary>
        /// <returns>0 - No Timestamp Correction, 1 - Always Timestamp Correction, 2 - Auto (Correction for Decoders that need it)</returns>
        [PreserveSig]
        int GetVC1TimestampMode();

        /// <summary>
        /// Set the VC-1 Timestamp Processing mode
        /// </summary>
        /// <param name="iMode">0 - No Timestamp Correction, 1 - Always Timestamp Correction, 2 - Auto (Correction for Decoders that need it)</param>
        [PreserveSig]
        int SetVC1TimestampMode(int iMode);

        /// <summary>
        /// Set whether substreams (AC3 in TrueHD, for example) should be shown as a separate stream
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetSubstreamsEnabled();

        /// <summary>
        /// Check whether substreams (AC3 in TrueHD, for example) should be shown as a separate stream
        /// </summary>
        /// <param name="bSubStreams"></param>
        [PreserveSig]
        int SetSubstreamsEnabled([MarshalAs(UnmanagedType.Bool)] bool bSubStreams);

        [Obsolete("No longer required", false)]
        [PreserveSig]
        int SetVideoParsingEnabled([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        [Obsolete("No longer required", false)]
        [PreserveSig]
        bool GetVideoParsingEnabled();

        /// <summary>
        /// Set if LAV Splitter should try to fix broken HD-PVR streams
        /// </summary>
        /// <param name="bEnabled"></param>
        [Obsolete("No longer required", false)]
        [PreserveSig]
        int SetFixBrokenHDPVR([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Query if LAV Splitter should try to fix broken HD-PVR streams
        /// </summary>
        /// <returns></returns>
        [Obsolete("No longer required", false)]
        [PreserveSig]
        bool GetFixBrokenHDPVR();

        /// <summary>
        /// Control whether the given format is enabled
        /// </summary>
        /// <param name="strFormat"></param>
        /// <param name="bEnabled"></param>
        /// <returns>HRESULT</returns>
        [PreserveSig]
        int SetFormatEnabled(
            [MarshalAs(UnmanagedType.LPStr)] string strFormat,
            [MarshalAs(UnmanagedType.Bool)] bool bEnabled
        );

        /// <summary>
        /// Check if the given format is enabled
        /// </summary>
        /// <param name="strFormat"></param>
        /// <returns></returns>
        [PreserveSig]
        bool IsFormatEnabled([MarshalAs(UnmanagedType.LPStr)] string strFormat);

        /// <summary>
        /// Set if LAV Splitter should always completely remove the filter connected to its Audio Pin when the audio stream is changed
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetStreamSwitchRemoveAudio([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Query if LAV Splitter should always completely remove the filter connected to its Audio Pin when the audio stream is changed
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetStreamSwitchRemoveAudio();

        /// <summary>
        /// Advanced Subtitle configuration. Refer to the documention for details.
        /// </summary>
        /// <param name="ppAdvancedConfig">If no advanced config exists, will be NULL.</param>
        [PreserveSig]
        int GetAdvancedSubtitleConfig([Out, MarshalAs(UnmanagedType.LPStr)] out StringBuilder ppAdvancedConfig);

        /// <summary>
        /// Advanced Subtitle configuration. Refer to the documention for details.
        /// </summary>
        /// <param name="pAdvancedConfig">To reset the config, pass NULL or the empty string.</param>
        /// <remarks>If no subtitle language is set, the main language preference is used.</remarks>
        int SetAdvancedSubtitleConfig([MarshalAs(UnmanagedType.LPStr)] string pAdvancedConfig);

        /// <summary>
        /// Set if LAV Splitter should prefer audio streams for the hearing or visually impaired
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetUseAudioForHearingVisuallyImpaired([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get if LAV Splitter should prefer audio streams for the hearing or visually impaired
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetUseAudioForHearingVisuallyImpaired();

        /// <summary>
        /// Set the maximum queue size, in megabytes
        /// </summary>
        /// <param name="dwMaxSize">Value in megabytes</param>
        [PreserveSig]
        int SetMaxQueueMemSize(uint dwMaxSize);

        /// <summary>
        /// Get the maximum queue size, in megabytes
        /// </summary>
        /// <returns>Value in megabytes</returns>
        [PreserveSig]
        uint GetMaxQueueMemSize();

        /// <summary>
        /// Toggle Tray Icon
        /// </summary>
        /// <param name="bEnabled">True - enable</param>
        [PreserveSig]
        int SetTrayIcon([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Tray Icon
        /// </summary>
        /// <returns>True - enabled</returns>
        [PreserveSig]
        bool GetTrayIcon();

        /// <summary>
        /// Toggle whether higher quality audio streams are preferred
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetPreferHighQualityAudioStreams(bool bEnabled);

        /// <summary>
        /// Toggle whether higher quality audio streams are preferred
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetPreferHighQualityAudioStreams();

        /// <summary>
        /// Toggle whether Matroska Linked Segments should be loaded from other files
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetLoadMatroskaExternalSegments(bool bEnabled);

        /// <summary>
        /// Get whether Matroska Linked Segments should be loaded from other files
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetLoadMatroskaExternalSegments();

        /// <summary>
        /// Get the list of available formats
        /// </summary>
        /// <param name="formats"></param>
        /// <param name="nFormats"></param>
        [PreserveSig]
        int GetFormats([Out, MarshalAs(UnmanagedType.LPTStr)] string formats, uint nFormats);

        /// <summary>
        /// Set the duration (in ms) of analysis for network streams (to find the streams and codec parameters)
        /// </summary>
        /// <param name="dwDuration">Duration in milliseconds</param>
        [PreserveSig]
        int SetNetworkStreamAnalysisDuration(uint dwDuration);

        /// <summary>
        /// // Get the duration (in ms) of analysis for network streams (to find the streams and codec parameters)
        /// </summary>
        /// <returns>Duration in milliseconds</returns>
        [PreserveSig]
        uint GetNetworkStreamAnalysisDuration();

        /// <summary>
        /// Set the maximum queue size, in number of packets
        /// </summary>
        /// <param name="dwMaxSize"></param>
        [PreserveSig]
        int SetMaxQueueSize(uint dwMaxSize);

        /// <summary>
        /// Get the maximum queue size, in number of packets
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        uint GetMaxQueueSize();
    }
}
