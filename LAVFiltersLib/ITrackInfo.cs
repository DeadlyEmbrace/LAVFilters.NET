using LAVFiltersLib.LAVStructs.TrackInfo;
using System;
using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    /// <summary>
    /// ITrackInfo is an interface to obtain additional information about the streams in a file.
    /// The order to query the streams is the same as returned by IAMStreamSelect::Info
    /// </summary>
    /// <remarks>
    /// Implemented by LAV Splitter
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("03E98D51-DDE7-43aa-B70C-42EF84A3A23D")]
    public interface ITrackInfo
    {
        /// <summary>
        /// Get number of tracks
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        uint GetTrackCount();

        /// <summary>
        /// Get TrackElement
        /// </summary>
        /// <param name="aTrackIdx">The track index (from 0 to GetTrackCount()-1)</param>
        /// <param name="pStructureToFill"></param>
        /// <returns></returns>
        [PreserveSig]
        bool GetTrackInfo([In] uint aTrackIdx, [Out] out TrackElement pStructureToFill);

        /// <summary>
        /// Get an extended information struct relative to the track type
        /// </summary>
        /// <param name="aTrackIdx">The track index (from 0 to GetTrackCount()-1)</param>
        /// <param name="pStructureToFill">TrackExtendedInfoAudio \ TrackExtendedInfoVideo structure</param>
        /// <example>
        /// int structureSize = Marshal.SizeOf(typeof(TrackExtendedInfoVideo));
        /// IntPtr resultPointer = Marshal.AllocCoTaskMem(structureSize);
        /// bool success = SomeTrackInfoCOMObject.GetTrackExtendedInfo(0, resultPointer);
        /// if(success)
        ///     var result = (TrackExtendedInfoVideo)Marshal.PtrToStructure(p, typeof(TrackExtendedInfoVideo));
        /// </example>
        /// <returns></returns>
        [PreserveSig]
        bool GetTrackExtendedInfo([In] uint aTrackIdx, [In, Out] IntPtr pStructureToFill);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetTrackCodecID([In] uint aTrackIdx);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetTrackName([In] uint aTrackIdx);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetTrackCodecName([In] uint aTrackIdx);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetTrackCodecInfoURL([In] uint aTrackIdx);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetTrackCodecDownloadURL([In] uint aTrackIdx);
    }
}
