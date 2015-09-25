using System.Runtime.InteropServices;

namespace LAVFiltersLib.LAVStructs.TrackInfo
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TrackExtendedInfoAudio
    {
        /// <summary>
        /// Size of this structure
        /// </summary>
        public ushort Size;
        /// <summary>
        /// Sampling frequency in Hz.
        /// </summary>
        public double SamplingFreq;
        /// <summary>
        /// Real output sampling frequency in Hz (used for SBR techniques).
        /// </summary>
        public double OutputSamplingFrequency;
        /// <summary>
        /// Numbers of channels in the track.
        /// </summary>
        public uint Channels;
        /// <summary>
        /// Bits per sample, mostly used for PCM.
        /// </summary>
        public uint BitDepth;
    }
}
