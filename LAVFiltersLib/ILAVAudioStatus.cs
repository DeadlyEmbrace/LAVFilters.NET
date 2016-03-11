using LAVFiltersLib.LAVEnums.AudioSettings;
using System.Runtime.InteropServices;
using System.Text;

namespace LAVFiltersLib
{
    /// <summary>
    /// LAV Audio Status Interface.
    /// Get the current playback stats
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A668B8F2-BA87-4F63-9D41-768F7DE9C50E")]
    public interface ILAVAudioStatus
    {
        /// <summary>
        /// Check if the given sample format is supported by the current playback chain
        /// </summary>
        /// <param name="sfCheck"></param>
        /// <returns></returns>
        [PreserveSig]
        bool IsSampleFormatSupported(LAVAudioSampleFormat sfCheck);

        /// <summary>
        /// Get details about the current decoding format
        /// </summary>
        /// <param name="pCodec"></param>
        /// <param name="pDecodeFormat"></param>
        /// <param name="pnChannels"></param>
        /// <param name="pSampleRate"></param>
        /// <param name="pChannelMask"></param>
        [PreserveSig]
        int GetDecodeDetails(
            [Out, MarshalAs(UnmanagedType.LPStr)]
            out StringBuilder pCodec,
            [Out, MarshalAs(UnmanagedType.LPStr)]
            out StringBuilder pDecodeFormat,
            out int pnChannels,
            out int pSampleRate,
            out uint pChannelMask
         );

        /// <summary>
        /// Get details about the current output format
        /// </summary>
        /// <param name="pOutputFormat"></param>
        /// <param name="pnChannels"></param>
        /// <param name="pSampleRate"></param>
        /// <param name="pChannelMask"></param>
        int GetOutputDetails(
            [Out, MarshalAs(UnmanagedType.LPStr)] out StringBuilder pOutputFormat,
            out int pnChannels,
            out int pSampleRate,
            out uint pChannelMask
        );

        /// <summary>
        /// Enable Volume measurements
        /// </summary>
        int EnableVolumeStats();

        /// <summary>
        /// Disable Volume measurements
        /// </summary>
        int DisableVolumeStats();

        /// <summary>
        /// Get Volume Average for the given channel
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="pfDb"></param>
        int GetChannelVolumeAverage(
            int channel,
            [Out] out float pfDb
        );
    }
}
