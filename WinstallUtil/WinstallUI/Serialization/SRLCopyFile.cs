using System;
using System.IO;
using System.Text;
using WinstallUI.Serialization.Templates;

namespace WinstallUI.Serialization
{
    public class SRLCopyFile : ModuleSerializer<TCopyFile>
    {
        public SRLCopyFile(TCopyFile TemplateStructure) : base(TemplateStructure) { }

        public SRLCopyFile(byte[] SerializedTemplate) : base(SerializedTemplate) { }

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

        public override TCopyFile Deserialize()
        {
            TCopyFile copyFile = new TCopyFile();

            byte[] readBuffer = null;
            int curRead = 0;

            using (MemoryStream ms = new MemoryStream(SerializedTemplate))
            {
                byte[] sizeFileName = new byte[sizeof(int)];
                byte[] sizeFileAttr = new byte[sizeof(bool)];
                byte[] sizeFileData = new byte[sizeof(int)];

                ms.Read(sizeFileName, 0, sizeof(int));
                curRead = BitConverter.ToInt32(sizeFileName, 0);
                readBuffer = new byte[curRead];
                ms.Read(readBuffer, 0, curRead);
                copyFile.Name = Encoding.Unicode.GetString(readBuffer);

                ms.Read(sizeFileAttr, 0, sizeof(bool));
                curRead = Convert.ToInt32(sizeFileAttr[0]);
                readBuffer = new byte[curRead];
                ms.Read(readBuffer, 0, curRead);
                copyFile.Hidden = BitConverter.ToBoolean(readBuffer, 0);

                ms.Read(sizeFileData, 0, sizeof(int));
                curRead = BitConverter.ToInt32(sizeFileData, 0);
                readBuffer = new byte[curRead];
                ms.Read(readBuffer, 0, curRead);
                copyFile.Data = readBuffer;

                Template = copyFile;
            }

            return copyFile;
        }
    }
}