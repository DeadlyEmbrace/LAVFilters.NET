using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("EB2CD9E6-BA08-4acb-AA0F-3D8D0DD521CA")]
    public interface IBitRateInfo
    {
        [PreserveSig]
        uint GetCurrentBitRate();

        [PreserveSig]
        uint GetAverageBitRate();
    }
}
