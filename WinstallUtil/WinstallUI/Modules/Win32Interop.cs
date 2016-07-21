using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinstallUI.Modules
{
    public static class Win32Interop
    {
        [DllImport("ole32.dll")]
        private static extern IntPtr CoInitializeEx(IntPtr pvReserved, uint dwCoInit);

        [DllImport("ole32.dll")]
        private static extern void CoUninitialize();

        [DllImport("ole32.dll")]
        private static extern IntPtr CoInitializeSecurity(
                                                IntPtr pSecDesc, 
                                                int cAuthSvc, 
                                                IntPtr asAuthSvc,
                                                IntPtr pReserved1, 
                                                uint dwAuthnLevel, 
                                                uint dwImpLevel, 
                                                IntPtr pAuthList,
                                                uint dwCapabilities,
                                                IntPtr pReserved3
            );

        //HRESULT CoCreateInstance(
        //      _In_ REFCLSID  rclsid,
        //      _In_ LPUNKNOWN pUnkOuter,
        //      _In_ DWORD     dwClsContext,
        //      _In_ REFIID    riid,
        //      _Out_ LPVOID    *ppv
        //    );



    }
}
