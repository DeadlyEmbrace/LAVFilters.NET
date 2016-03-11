using LAVFiltersLib.LAVEnums.VideoSettings;
using System;
using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    /// <summary>
    /// LAV Video configuration interface
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("FA40D6E9-4D38-4761-ADD2-71A9EC5FD32F")]
    public interface ILAVVideoSettings
    {
        /// <summary>
        /// Switch to Runtime Config mode. This will reset all settings to default, and no changes to the settings will be saved
        /// You can use this to programmatically configure LAV Video without interfering with the users settings in the registry.
        /// Subsequent calls to this function will reset all settings back to defaults, even if the mode does not change.
        /// </summary>
        /// <remarks>
        /// Note that calling this function during playback is not supported and may exhibit undocumented behaviour. 
        /// For smooth operations, it must be called before LAV Video is connected to other filters.
        /// </remarks>
        /// <param name="bRuntimeConfig"></param>
        [PreserveSig]
        int SetRuntimeConfig([MarshalAs(UnmanagedType.Bool)] bool bRuntimeConfig);

        /// <summary>
        /// Check if codec is enabled
        /// </summary>
        /// <param name="vCodec"></param>
        /// <returns>If vCodec is invalid (possibly a version difference), will return FALSE</returns>
        [PreserveSig]
        bool GetFormatConfiguration(LAVVideoCodec vCodec);

        /// <summary>
        /// Configure which codecs are enabled
        /// </summary>
        /// <param name="vCodec">If vCodec is invalid (possibly a version difference), will return E_FAIL.</param>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetFormatConfiguration(LAVVideoCodec vCodec, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Set the number of threads to use for Multi-Threaded decoding (where available)
        /// </summary>
        /// <param name="dwNum">
        ///  0 = Auto Detect (based on number of CPU cores)
        ///  1 = 1 Thread -- No Multi-Threading
        /// >1 = Multi-Threading with the specified number of threads
        /// </param>
        [PreserveSig]
        int SetNumThreads(uint dwNum);

        /// <summary>
        /// Get the number of threads to use for Multi-Threaded decoding (where available)
        /// </summary>
        /// <returns>
        ///  0 = Auto Detect (based on number of CPU cores)
        ///  1 = 1 Thread -- No Multi-Threading
        /// >1 = Multi-Threading with the specified number of threads
        /// </returns>
        [PreserveSig]
        uint GetNumThreads();

        /// <summary>
        /// Set whether the aspect ratio encoded in the stream should be forwarded to the renderer, 
        /// or the aspect ratio specified by the source filter should be kept.
        /// </summary>
        /// <param name="bStreamAR">
        /// 0 = AR from the source filter
        /// 1 = AR from the Stream
        /// 2 = AR from stream if source is not reliable
        /// </param>
        [PreserveSig]
        int SetStreamAR(uint bStreamAR);

        /// <summary>
        /// Get whether the aspect ratio encoded in the stream should be forwarded to the renderer,
        /// or the aspect ratio specified by the source filter should be kept.
        /// </summary>
        /// <returns>
        /// 0 = AR from the source filter
        /// 1 = AR from the Stream
        /// 2 = AR from stream if source is not reliable
        /// </returns>
        [PreserveSig]
        uint GetStreamAR();

        /// <summary>
        /// Get which pixel formats are enabled for output
        /// </summary>
        /// <param name="pixFmt"></param>
        /// <returns>If pixFmt is invalid, will return FALSE</returns>
        [PreserveSig]
        bool GetPixelFormat(LAVOutPixFmts pixFmt);

        /// <summary>
        /// Configure which pixel formats are enabled for output
        /// </summary>
        /// <param name="pixFmt">If pixFmt is invalid will return E_FAIL</param>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetPixelFormat(LAVOutPixFmts pixFmt, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Set the RGB output range for the YUV->RGB conversion
        /// </summary>
        /// <param name="dwRange">
        /// 0 = Auto (same as input)
        /// 1 = Limited (16-235)
        /// 2 = Full (0-255)
        /// </param>
        [PreserveSig]
        int SetRGBOutputRange(uint dwRange);

        /// <summary>
        /// Get the RGB output range for the YUV->RGB conversion
        /// </summary>
        /// <returns>
        /// 0 = Auto (same as input)
        /// 1 = Limited (16-235)
        /// 2 = Full (0-255)
        /// </returns>
        [PreserveSig]
        uint GetRGBOutputRange();

        /// <summary>
        /// Set the deinterlacing field order of the hardware decoder
        /// </summary>
        /// <param name="fieldOrder"></param>
        [PreserveSig]
        int SetDeintFieldOrder(LAVDeintFieldOrder fieldOrder);

        /// <summary>
        /// Get the deinterlacing field order of the hardware decoder
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVDeintFieldOrder GetDeintFieldOrder();

        /// <summary>
        /// Set/get wether all frames should be deinterlaced if the stream is flagged interlaced
        /// </summary>
        /// <param name="bAggressive"></param>
        [Obsolete("Use SetDeinterlacingMode", false)]
        [PreserveSig]
        int SetDeintAggressive([MarshalAs(UnmanagedType.Bool)] bool bAggressive);

        /// <summary>
        /// Get wether all frames should be deinterlaced if the stream is flagged interlaced
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use GetDeinterlacingMode", false)]
        [PreserveSig]
        bool GetDeintAggressive();

        /// <summary>
        /// Set wether all frames should be deinterlaced, even ones marked as progressive
        /// </summary>
        /// <param name="bForce"></param>
        [Obsolete("Use SetDeinterlacingMode", false)]
        [PreserveSig]
        int SetDeintForce([MarshalAs(UnmanagedType.Bool)] bool bForce);

        /// <summary>
        /// Get wether all frames should be deinterlaced, even ones marked as progressive
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use GetDeinterlacingMode", false)]
        [PreserveSig]
        bool GetDeintForce();

        /// <summary>
        /// Check if the specified HWAccel is supported
        /// </summary>
        /// <remarks>
        /// Note: This will usually only check the availability of the required libraries (ie. for NVIDIA if a recent enough NVIDIA driver is installed)
        /// and not check actual hardware support
        /// </remarks>
        /// <param name="hwAccel"></param>
        /// <returns>
        /// 0 = Unsupported
        /// 1 = Supported
        /// 2 = Currently running
        /// </returns>
        [PreserveSig]
        uint CheckHWAccelSupport(LAVHWAccel hwAccel);

        /// <summary>
        /// Set which HW Accel method is used
        /// See LAVHWAccel for options.
        /// </summary>
        /// <param name="hwAccel"></param>
        [PreserveSig]
        int SetHWAccel(LAVHWAccel hwAccel);

        /// <summary>
        /// Get which HW Accel method is active
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVHWAccel GetHWAccel();

        /// <summary>
        /// Set which codecs should use HW Acceleration
        /// </summary>
        /// <param name="hwAccelCodec"></param>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetHWAccelCodec(LAVVideoHWCodec hwAccelCodec, [MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get which codecs should use HW Acceleration
        /// </summary>
        /// <param name="hwAccelCodec"></param>
        /// <returns></returns>
        [PreserveSig]
        bool GetHWAccelCodec(LAVVideoHWCodec hwAccelCodec);

        /// <summary>
        /// Set the deinterlacing mode used by the hardware decoder
        /// </summary>
        /// <param name="deintMode"></param>
        [PreserveSig]
        int SetHWAccelDeintMode(LAVHWDeintModes deintMode);

        /// <summary>
        /// Get the deinterlacing mode used by the hardware decoder
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVHWDeintModes GetHWAccelDeintMode();

        /// <summary>
        /// Set the deinterlacing output for the hardware decoder
        /// </summary>
        /// <param name="deintOutput"></param>
        [PreserveSig]
        int SetHWAccelDeintOutput(LAVDeintOutput deintOutput);

        /// <summary>
        /// Get the deinterlacing output for the hardware decoder
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVDeintOutput GetHWAccelDeintOutput();

        /// <summary>
        /// Set whether the hardware decoder should force high-quality deinterlacingg
        /// </summary>
        /// <remarks>
        /// Note: this option is not supported on all decoder implementations and/or all operating systems
        /// </remarks>
        /// <param name="bHQ"></param>
        [Obsolete("HQ deint is always used when available depending on platform and codec", false)]
        [PreserveSig]
        int SetHWAccelDeintHQ([MarshalAs(UnmanagedType.Bool)] bool bHQ);

        /// <summary>
        /// Get whether the hardware decoder should force high-quality deinterlacing
        /// </summary>
        /// <remarks>
        /// Note: this option is not supported on all decoder implementations and/or all operating systems
        /// </remarks>
        /// <returns></returns>
        [Obsolete("HQ deint is always used when available depending on platform and codec", false)]
        [PreserveSig]
        bool GetHWAccelDeintHQ();

        /// <summary>
        /// Set the software deinterlacing mode used
        /// </summary>
        /// <param name="deintMode"></param>
        [PreserveSig]
        int SetSWDeintMode(LAVSWDeintModes deintMode);

        /// <summary>
        /// Get the software deinterlacing mode used
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVSWDeintModes GetSWDeintMode();

        /// <summary>
        /// Set the software deinterlacing output
        /// </summary>
        /// <param name="deintOutput"></param>
        [PreserveSig]
        int SetSWDeintOutput(LAVDeintOutput deintOutput);

        /// <summary>
        /// Get the software deinterlacing output
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVDeintOutput GetSWDeintOutput();

        /// <summary>
        /// Set wether all content is treated as progressive, and any interlaced flags are ignored
        /// </summary>
        /// <param name="bEnabled"></param>
        [Obsolete("Use SetDeinterlacingMode", false)]
        [PreserveSig]
        int SetDeintTreatAsProgressive([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get wether all content is treated as progressive, and any interlaced flags are ignored
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use GetDeinterlacingMode", false)]
        [PreserveSig]
        bool GetDeintTreatAsProgressive();

        /// <summary>
        /// Set the dithering mode used
        /// </summary>
        /// <param name="ditherMode"></param>
        [PreserveSig]
        int SetDitherMode(LAVDitherMode ditherMode);

        /// <summary>
        /// Get the dithering mode used
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVDitherMode GetDitherMode();

        /// <summary>
        /// Set if the MS WMV9 DMO Decoder should be used for VC-1/WMV3
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetUseMSWMV9Decoder([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get if the MS WMV9 DMO Decoder should be used for VC-1/WMV3
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetUseMSWMV9Decoder();

        /// <summary>
        /// Set if DVD Video support is enabled
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetDVDVideoSupport([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get if DVD Video support is enabled
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetDVDVideoSupport();

        /// <summary>
        /// Set the HW Accel Resolution Flags
        /// </summary>
        /// <param name="dwFlags">flags: bitmask of LAVHWResFlag flags</param>
        [PreserveSig]
        int SetHWAccelResolutionFlags([In] LAVHWResFlag dwFlags);

        /// <summary>
        /// Get the HW Accel Resolution Flags
        /// </summary>
        /// <returns>flags: bitmask of LAVHWResFlag flags</returns>
        [PreserveSig]
        LAVHWResFlag GetHWAccelResolutionFlags();

        /// <summary>
        /// Toggle Tray Icon
        /// </summary>
        /// <param name="bEnabled"></param>
        [PreserveSig]
        int SetTrayIcon([MarshalAs(UnmanagedType.Bool)] bool bEnabled);

        /// <summary>
        /// Get Tray Icon
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        bool GetTrayIcon();

        //Set the Deint Mode
        [PreserveSig]
        int SetDeinterlacingMode(LAVDeintMode deintMode);

        /// <summary>
        /// Get the Deint Mode
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        LAVDeintMode GetDeinterlacingMode();

        /// <summary>
        /// Set the index of the GPU to be used for hardware decoding..
        /// Only supported for CUVID and DXVA2 copy-back. If the device is not valid, it'll fallback to auto-detection.
        /// Must be called before an input is connected to LAV Video, and the setting is non-persistent.
        /// </summary>
        /// <remarks>
        /// NOTE: For CUVID, the index defines the index of the CUDA capable device, while for DXVA2, the list includes all D3D9 devices
        /// </remarks>
        /// <param name="dwDevice">GPU device index within the system</param>
        [PreserveSig]
        int SetGPUDeviceIndex(uint dwDevice);

        /// <summary>
        /// Set the index of the GPU to be used for hardware decoding
        /// Only supported for CUVID and DXVA2 copy-back.If the device is not valid, it'll fallback to auto-detection
        /// Must be called before an input is connected to LAV Video, and the setting is non-persistent
        /// NOTE: For CUVID, the index defines the index of the CUDA capable device, while for DXVA2, the list includes all D3D9 devices
        /// </summary>
        /// <param name="hwAccel"></param>
        /// <returns></returns>
        [PreserveSig]
        int GetHWAccelNumDevices(LAVHWAccel hwAccel);

        /// <summary>
        /// Get a list of available HWAccel devices for the specified HWAccel
        /// </summary>
        /// <param name="hwAccel"></param>
        /// <param name="dwIndex"></param>
        /// <param name="pstrDeviceName"></param>
        /// <param name="pdwDeviceIdentifier"></param>
        /// <returns></returns>
        [PreserveSig]
        int GetHWAccelDeviceInfo(LAVHWAccel hwAccel, uint dwIndex, [Out, MarshalAs(UnmanagedType.BStr)] out string pstrDeviceName, [Out] out uint pdwDeviceIdentifier);

        /// <summary>
        /// Get the device for a specified HWAccel
        /// In contrast to SetGPUDeviceIndex, this setting is hwaccel-specific and persistent
        /// </summary>
        /// <param name="hwAccel"></param>
        /// <param name="pdwDeviceIdentifier"></param>
        /// <returns></returns>
        [PreserveSig]
        int GetHWAccelDeviceIndex(LAVHWAccel hwAccel, [Out] out uint pdwDeviceIdentifier);

        /// <summary>
        /// Set the device for a specified HWAccel
        /// In contrast to SetGPUDeviceIndex, this setting is hwaccel-specific and persistent
        /// </summary>
        /// <param name="hwAccel"></param>
        /// <param name="dwIndex"></param>
        /// <param name="dwDeviceIdentifier">dwDeviceIdentifier is an optional parameter that identifies the selected device (ie. its device id), set to 0 if not used</param>
        /// <returns></returns>
        [PreserveSig]
        int SetHWAccelDeviceIndex(LAVHWAccel hwAccel, uint dwIndex, int dwDeviceIdentifier);

        /// <summary>
        /// Temporary Override for players to disable H.264 MVC decoding
        /// This is not a permanent setting and not saved, but can be used by players to offer a "Play in 2D" option, or similar.
        /// A setting of FALSE disable MVC decoding temporarily
        /// Note that the override cannot force-enable the option if its turned off through SetFormatConfiguration
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        int SetH264MVCDecodingOverride([In, MarshalAs(UnmanagedType.Bool)]bool bEnabled);
    }
}
