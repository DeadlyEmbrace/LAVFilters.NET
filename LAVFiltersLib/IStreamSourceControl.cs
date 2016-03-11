using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    //const Guid IID_IStreamSourceControl = new Guid("C0BE9565-4C05-4644-9492-57547A4048DC");				 
    /// <summary>
    /// Interface for high-level streaming source filters
    /// The source can implement proper seeking and duration retrieval based on its underlying protocol.
    /// This interface should be exposed on the output pin or the filter itself of the streaming source, similar to the IAsyncReader interface
    /// </summary>
    /// <remarks>
    /// NOTICE: This interface is still experimental and may change in the future. Do NOT use it yet unless you absolutely know what you are doing.
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("C0BE9565-4C05-4644-9492-57547A4048DC")]
    public interface IStreamSourceControl
    {
        /// <summary>
        /// Get the duration of the stream being played.
        /// </summary>
        /// <param name="prtDuration">Duration is in DirectShow reference time, 100ns units.</param>
        /// <returns></returns>
        [PreserveSig]
        int GetStreamDuration([Out] out long prtDuration);

        /// <summary>
        /// Seek the stream to a specified time
        /// </summary>
        /// <param name="rtPosition">Position is in DirectShow reference time, 100ns units.</param>
        /// <remarks>
        /// If the source returns a failure code, the demuxer will do byte-based seeking itself (ie. when the stream supports this)
        /// On success, it'll re-open the stream and start reading from the start (byte position 0).
        /// </remarks>
        [PreserveSig]
        int SeekStream([In] long rtPosition);
    }
}
