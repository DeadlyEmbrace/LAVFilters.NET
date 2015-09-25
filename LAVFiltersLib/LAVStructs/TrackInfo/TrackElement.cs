using LAVFiltersLib.LAVEnums.TrackInfo;
using System.Runtime.InteropServices;

namespace LAVFiltersLib.LAVStructs.TrackInfo
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TrackElement
    {
        /// <summary>
        /// Size of this structure
        /// </summary>
        public ushort Size;
        /// <summary>
        /// See TrackType
        /// </summary>
        public TrackType Type;
        /// <summary>
        /// Set if the track is the default for its TrackType.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool FlagDefault;
        /// <summary>
        /// Set if that track MUST be used during playback.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]        
        public bool FlagForced;
        /// <summary>
        /// Set if the track may contain blocks using lacing.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool FlagLacing;
        /// <summary>
        /// The minimum number of frames a player should be able to cache during playback.
        /// </summary>
        public uint MinCache;
        /// <summary>
        /// The maximum cache size required to store referenced frames in and the current frame. 0 means no cache is needed.
        /// </summary>
        public uint MaxCache;

        /// <summary>
        /// // Specifies the language of the track, in the ISO-639-2 form. (end with '\0')
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Language;
    }
}
