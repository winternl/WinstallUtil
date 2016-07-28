using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;

namespace WinstallUI
{
    public class StubPacker
    {
        private string PathToAssembly { get; set; }
        private byte[] RawAssembly { get; set; }
        private byte[] CompressedAssembly { get; set; }

        public StubPacker(string AssemblyPath)
        {
            if (!string.IsNullOrEmpty(AssemblyPath))
            {
                if (File.Exists(AssemblyPath))
                {
                    PathToAssembly = AssemblyPath;
                    RawAssembly = File.ReadAllBytes(PathToAssembly);
                    CompressedAssembly = Packer.QuickLZ.compress(RawAssembly, 3);
                }
            }
        }

        public void Pack(string savePath)
        {
            string[] srcFiles = new string[]
            {
                Properties.Resources.Entrypoint,
                Properties.Resources.QuickLZ
            };

            using (var Stub = new Compiler(srcFiles))
            {
                Stub.AddReference("System.dll");
                Stub.AddReference("Interop.TaskScheduler.dll");

                Stub.AddResource(CompressedAssembly, "1");

                Stub.Compile();
                Stub.Save(Environment.ExpandEnvironmentVariables(savePath));
            }
        }

    }
}
