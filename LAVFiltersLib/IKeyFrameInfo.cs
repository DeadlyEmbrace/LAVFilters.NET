using System;
using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    /// <summary>
    /// IKeyFrameInfo allows players to query the position of key frames, so they can redirect seeking 
    /// requests to those positions for very smooth seek events. Only fully supported on MKV files.
    /// </summary>
    /// <remarks>
    /// Implemented by LAV Splitter
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("01A5BBD3-FE71-487C-A2EC-F585918A8724")]
    public interface IKeyFrameInfo
    {
        /// <summary>
        /// Get the number of (known) keyframes in the file
        /// </summary>
        /// <param name="nKFs">Returns S_FALSE when every frame is a keyframe</param>
        [PreserveSig]
        void GetKeyFrameCount([Out] out uint nKFs);

        /// <summary>
        /// Get the times of the key frames, if available.
        /// </summary>
        /// <param name="pFormat">GUID of the time format (see http://msdn.microsoft.com/en-us/library/dd407205(v=vs.85).aspx, usually TIME_FORMAT_MEDIA_TIME)</param>
        /// <param name="pKFs">Caller allocated memory for the timestamps of the keyframes (should be sizeof(REFERENCE_TIME) * nKFs at least!)</param>
        /// <param name="nKFs">Number of keyframes requested/returned - no more then nKFs key frames will be returned.</param>
        /// <example>
        /// // 7b785574-8c82-11cf-bc0c-00aa00ac74f6 TIME_FORMAT_MEDIA_TIME
        /// Guid MediaTime = new Guid(0x7b785574, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6);
        /// uint nkfs = 10;
        /// var pkfsArray = new long[nkfs];
        /// SomeKeyFrameInfoCOMObject.GetKeyFrames(MediaTime, pkfsArray, ref nkfs);
        /// </example>
        [PreserveSig]
        void GetKeyFrames([In, MarshalAs(UnmanagedType.LPStruct)] Guid pFormat, 
                          [In, Out, MarshalAs(UnmanagedType.LPArray)] long[] pKFs, 
                          [In, Out] ref uint nKFs);
    }
}
