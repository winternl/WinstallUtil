using System;
using System.IO;
using WinstallUI.Serialization.Templates;

namespace WinstallUI.Serialization
{
    public class SRLInstallProgram : ModuleSerializer<TInstallProgram>
    {
        public SRLInstallProgram(TInstallProgram TemplateStructure) : base(TemplateStructure) { }

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