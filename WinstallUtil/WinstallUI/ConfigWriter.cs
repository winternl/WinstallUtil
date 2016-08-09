using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;

namespace WinstallUI
{
    public class ConfigWriter : IDisposable
    {
        private FileStream FS;
        private BinaryWriter BW;

        public ConfigWriter(string FilePath)
        {
            FS = new FileStream(FilePath, FileMode.Open);
            BW = new BinaryWriter(FS);
        }

        [Serializable]
        private struct STask
        {
            public string Name;
            public string Desc;
            public ModuleType Type;
            public TaskTrigger Trigger;
            public object[] Args;
        }

        public void Save()
        {
            byte[] retBuffer = null;
            using (MemoryStream ms = new MemoryStream())
            {
                FS.CopyTo(ms);
                retBuffer = ms.ToArray();
            }

            if (retBuffer.Length > 0)
                File.WriteAllBytes(FilePath, retBuffer);
        }

        public void WriteTask(string TaskName, string TaskDesc, ModuleType ImplType, TaskTrigger TaskTrigger, object[] TriggerArgs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            BF.AssemblyFormat = FormatterAssemblyStyle.Simple;

            STask sTask = new STask()
            {
                Name = TaskName,
                Desc = TaskDesc,
                Type = ImplType,
                Trigger = TaskTrigger,
                Args = TriggerArgs
            };

            using (MemoryStream MS = new MemoryStream())
            {
                BF.Serialize(MS, sTask);
                BW.Write(MS.ToArray());
            }
        }

        public void Dispose()
        {
            BW.Flush();
            BW.Close();
            FS.Flush();
            FS.Close();
        }
    }
}