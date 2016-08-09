using System;
using System.IO;
using WinstallUI.Serialization.Templates;

namespace WinstallUI.Serialization
{
    public class SRLInstallProgram : ModuleSerializer<TInstallProgram>
    {
        public SRLInstallProgram(TInstallProgram TemplateStructure) : base(TemplateStructure) { }

        public SRLInstallProgram(byte[] SerializedData) : base(SerializedData) { }

        public override TInstallProgram Deserialize()
        {
            TInstallProgram installProg = new TInstallProgram();

            byte[] readBuffer = null;
            int curRead = 0;

            using (MemoryStream ms = new MemoryStream(SerializedTemplate))
            {
                byte[] sizeSilentInstall = new byte[sizeof(bool)];
                byte[] sizeInstallerProg = new byte[sizeof(int)];

                ms.Read(sizeSilentInstall, 0, sizeof(bool));
                curRead = Convert.ToInt32(sizeSilentInstall[0]);
                ms.Read(readBuffer, 0, curRead);
                installProg.SilentInstall = BitConverter.ToBoolean(readBuffer, 0);

                ms.Read(sizeInstallerProg, 0, sizeof(int));
                curRead = BitConverter.ToInt32(sizeInstallerProg, 0);
                ms.Read(readBuffer, 0, curRead);
                installProg.Installer = readBuffer;

                Template = installProg;
            }

            return installProg;
        }

        public override byte[] Serialize()
        {
            byte[] installerData = Template.Installer;
            byte[] silentInstall = BitConverter.GetBytes(Template.SilentInstall);

            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(silentInstall.Length), 0, sizeof(int));
                ms.Write(silentInstall, 0, silentInstall.Length);

                ms.Write(BitConverter.GetBytes(installerData.Length), 0, sizeof(int));
                ms.Write(installerData, 0, installerData.Length);

                SerializedTemplate = ms.ToArray();
            }

            return SerializedTemplate;
        }
    }
}