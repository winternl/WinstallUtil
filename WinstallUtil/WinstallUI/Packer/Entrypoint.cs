using System;
using System.IO;
using System.Reflection;

namespace WinstallUI.Packer
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            Stream rStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Installer");

            if (rStream != null && rStream.Length > 0)
            {
                byte[] installerExe = new byte[rStream.Length];
                installerExe = QuickLZ.decompress(installerExe);

                Assembly asm = Assembly.Load(installerExe);

                Type t = asm.EntryPoint.DeclaringType;
                object o = Activator.CreateInstance(t);
                t.InvokeMember(asm.EntryPoint.Name, BindingFlags.Static, null, t, new object[] { });
            }

            rStream.Close();
        }
    }
}
