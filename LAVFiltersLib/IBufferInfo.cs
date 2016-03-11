using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("46070104-1318-4A82-8822-E99AB7CD15C1")]
    public interface IBufferInfo
    {
        /// <summary>
        /// Get Number of Buffers
        /// </summary>
        /// <returns>Number of Buffers</returns>
        [PreserveSig]
        int GetCount();

        /// <summary>
        /// Get Info about Buffer "i" (0-based index up to count)
        /// </summary>
        /// <param name="i"></param>
        /// <param name="samples">number of frames in the buffer</param>
        /// <param name="size">total size in bytes of the buffer</param>
        /// <returns></returns>
        [PreserveSig]
        int GetStatus(int i, [Out]out int samples, [Out]out int size);

        /// <summary>
        /// Get priority of the demuxing thread
        /// </summary>
        /// <returns></returns>
        uint GetPriority();
    }
}
