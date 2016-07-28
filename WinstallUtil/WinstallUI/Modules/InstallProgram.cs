using System.Diagnostics;
using System.IO;

namespace WinstallUI.Modules
{
    public class clsInstallProgram
    {
        static bool copyToTemp(byte[] buffer, ref string tmpPath)
        {
            FileInfo fInfo = null;

            if (buffer[0] == 0x4d && buffer[1] == 0x5a)
                fInfo = new FileInfo(Path.ChangeExtension(Path.GetTempFileName(), ".exe"));
            else
                fInfo = new FileInfo(Path.ChangeExtension(Path.GetTempFileName(),    ".msi"));

            if (fInfo.Exists)
                return false;

            fInfo.Attributes = FileAttributes.Normal;

            using (FileStream fs = fInfo.OpenWrite())
            {
                fs.Write(buffer, 0, buffer.Length);
            }

            if (!fInfo.Exists)
                return false;

            tmpPath = fInfo.FullName;

            return true;
        }

        public static void Install(byte[] pInstallBuffer, bool bSilent)
        {
            string tmpPath = string.Empty;
            string strOutput = string.Empty;
            string strError = string.Empty;
            int dwExit = 0;

            if (!copyToTemp(pInstallBuffer, ref tmpPath))
            {
                return;
            }

            var psi = new ProcessStartInfo(string.Concat("\"", tmpPath, "\""));

            if (pInstallBuffer[0] != 0x4d && pInstallBuffer[1] != 0x5a)
                psi.Arguments = "/qn";

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

            System.Windows.Forms.MessageBox.Show(strError);
            System.Windows.Forms.MessageBox.Show(strOutput);
            System.Windows.Forms.MessageBox.Show(dwExit.ToString());
        }
    }
}