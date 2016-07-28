using System;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;

namespace WinstallUI.Packer
{
    class Entrypoint
    {
        static void Main()
        {
            using (Stream rStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("1"))
            {
                if (rStream != null && rStream.Length > 0)
                {
                    byte[] installerExe = new byte[rStream.Length];
                    rStream.Read(installerExe, 0, (int)rStream.Length);
                    installerExe = QuickLZ.decompress(installerExe);

                    Assembly.Load(installerExe).EntryPoint.Invoke(null, null);
                }
            }
        }
    }
}
