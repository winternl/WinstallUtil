using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace WinstallUI.Modules
{
    public class InstallProgram
    {
        /* static bool copyToTemp(byte[] buffer, ref string tmpPath)
         {

         }
         */

        public static void Install(byte[] pInstallBuffer, bool bSilent)
        {
            string tmpPath = string.Empty;
            string strOutput = string.Empty;
            string strError = string.Empty;
            int dwExit = 0;

            var psi = new ProcessStartInfo(string.Concat(tmpPath, " \\qn"));
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            using (Process proc = Process.Start(psi))
            {
                proc.WaitForExit();

                strOutput = proc.StandardOutput.ReadToEnd();
                strError = proc.StandardError.ReadToEnd();

                dwExit = proc.ExitCode;
            }

            if (string.IsNullOrEmpty(strError))
            {
                
            }
        }
    }
}
