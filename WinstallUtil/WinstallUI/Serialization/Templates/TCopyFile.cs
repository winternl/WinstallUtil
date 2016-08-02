using System.IO;

namespace WinstallUI.Serialization.Templates
{
    public struct TCopyFile
    {
        public string Name;
        public byte[] Data;
        public bool Hidden;

        public TCopyFile(string Name, bool Hidden)
        {
            this.Name = Name;
            this.Hidden = Hidden;
            Data = File.ReadAllBytes(this.Name);
        }
    }
}