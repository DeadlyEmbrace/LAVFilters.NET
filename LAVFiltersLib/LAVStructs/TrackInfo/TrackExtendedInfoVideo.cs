using System.Runtime.InteropServices;

namespace LAVFiltersLib.LAVStructs.TrackInfo
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TrackExtendedInfoVideo
    {
        /// <summary>
        /// Size of this structure
        /// </summary>
        public ushort Size;
        /// <summary>
        /// Set if the video is interlaced.
        /// </summary>
        public bool Interlaced;
        /// <summary>
        /// Width of the encoded video frames in pixels.
        /// </summary>
        public uint PixelWidth;
        /// <summary>
        /// Height of the encoded video frames in pixels.
        /// </summary>
        public uint PixelHeight;
        /// <summary>
        /// Width of the video frames to display.
        /// </summary>
        public uint DisplayWidth;
        /// <summary>
        /// Height of the video frames to display.
        /// </summary>
        public uint DisplayHeight;
        /// <summary>
        /// Type of the unit for DisplayWidth/Height (0: pixels, 1: centimeters, 2: inches).
        /// </summary>
        public byte DisplayUnit;
        /// <summary>
        /// Specify the possible modifications to the aspect ratio (0: free resizing, 1: keep aspect ratio, 2: fixed).
        /// </summary>
        public byte AspectRatioType;
    }
}
