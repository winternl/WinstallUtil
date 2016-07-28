using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WinstallUI
{
    public class Compiler : IDisposable
    {
        private List<string> SourceFiles { get; set; }
        private CodeDomProvider CodeProv { get; set; }
        private CompilerParameters CodeParams { get; set; }
        private List<string> TempFiles { get; set; }
        private string TempExePath { get; set; }
        public bool DebugBuild { get; set; }

        public Compiler(params string[] SrcFiles)
        {
            if (SrcFiles.Length <= 0)
                return;

            DebugBuild = false;
            SourceFiles = SrcFiles.ToList();
            TempFiles = new List<string>();

            CodeProv = CodeDomProvider.CreateProvider("CSharp");

            CodeParams = new CompilerParameters()
            {
                CompilerOptions = "/optimize+ /target:winexe /platform:x86",
                GenerateExecutable = true,
                GenerateInMemory = true,
                IncludeDebugInformation = DebugBuild,
            };
        }

        private string GetTempFile(string FileName, string Extension)
        {
            string strPath = Path.GetTempPath();
            strPath = Path.Combine(strPath, FileName);
            strPath = Path.HasExtension(strPath) ? Path.ChangeExtension(strPath, Extension) : strPath;

            File.Delete(strPath);

            return strPath;
        }

        public void AddReference(string RefName)
        {
            if (!string.IsNullOrEmpty(RefName))
                CodeParams.ReferencedAssemblies.Add(RefName);
        }

        public void AddResource(string PathToResource)
        {
            if (!string.IsNullOrEmpty(PathToResource) && File.Exists(PathToResource))
            {
                if (File.Exists(PathToResource))
                    CodeParams.EmbeddedResources.Add(PathToResource);
            }
        }
        public void AddResource(string PathToResource, string ResName)
        {
            if (!string.IsNullOrEmpty(PathToResource) && File.Exists(PathToResource))
            {
                if (File.Exists(PathToResource))
                {
                    string strTempFile = GetTempFile(ResName, Path.GetExtension(ResName));
                    CodeParams.EmbeddedResources.Add(PathToResource);
                }
            }
        }

        public void AddResource(byte[] RawResource)
        {
            if (RawResource != null && RawResource.Length > 0)
            {
                string strTempFile = Path.GetTempFileName();
                File.WriteAllBytes(strTempFile, RawResource);
                TempFiles.Add(strTempFile);

                CodeParams.EmbeddedResources.Add(strTempFile);
            }
        }

        public void AddResource(byte[] RawResource, string ResName)
        {
            if (RawResource != null && RawResource.Length > 0)
            {
                string strTempFile = GetTempFile(ResName, string.Empty);
                File.WriteAllBytes(strTempFile, RawResource);
                TempFiles.Add(strTempFile);

                CodeParams.EmbeddedResources.Add(strTempFile);
            }
        }

        public bool Compile()
        {
            TempExePath = GetTempFile(Guid.NewGuid().ToString(), ".exe");
            CodeParams.OutputAssembly = TempExePath;

            CompilerResults compRes = CodeProv.CompileAssemblyFromSource(CodeParams, SourceFiles.ToArray());

            if (compRes.Errors.Count > 0)
            {
                foreach (var err in compRes.Errors)
                    System.Windows.Forms.MessageBox.Show(err.ToString());
            }

            return compRes.Errors.Count > 0 &&
                File.Exists(TempExePath) &&
                File.ReadAllBytes(TempExePath).Length > 0
                ? false : true;
        }

        public void Save(string strSavePath)
        {
            if (File.Exists(TempExePath))
            {
                if (File.Exists(strSavePath))
                    File.Delete(strSavePath);

                File.Copy(TempExePath, strSavePath);
            }
        }

        public void Dispose()
        {
            foreach (var strTmpFile in TempFiles)
            {
                if (File.Exists(strTmpFile))
                    File.Delete(strTmpFile);
            }

            if (File.Exists(TempExePath))
                File.Delete(TempExePath);
        }
    }
}