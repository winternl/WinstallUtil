using System;
using System.IO;
using System.Text;
using WinstallUI.Serialization.Templates;

namespace WinstallUI.Serialization
{
    public class SRLCopyFile : ModuleSerializer<TCopyFile>
    {
        public SRLCopyFile(TCopyFile TemplateStructure) : base(TemplateStructure) { }

        public override byte[] Serialize()
        {
            byte[] fileEntry = Encoding.Unicode.GetBytes(Template.Name);
            byte[] fileAttr = BitConverter.GetBytes(Template.Hidden);
            byte[] fileData = Template.Data;

            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(fileEntry.Length), 0, sizeof(int));
                ms.Write(fileEntry, 0, fileEntry.Length);

                ms.Write(BitConverter.GetBytes(fileAttr.Length), 0, sizeof(bool));
                ms.Write(fileAttr, 0, fileAttr.Length);

                ms.Write(BitConverter.GetBytes(fileData.Length), 0, sizeof(int));
                ms.Write(fileData, 0, fileData.Length);

                SerializedTemplate = ms.ToArray();
            }

            return SerializedTemplate;
        }
    }
}