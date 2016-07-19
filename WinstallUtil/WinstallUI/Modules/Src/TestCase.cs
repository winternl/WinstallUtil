using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;

namespace WinstallUI.Modules.Src
{
    [TestClass]
    public static class TestCase
    {
        [TestMethod]
        public static void testCopyFile()
        {


            string currentPath = typeof(TestCase).Assembly.Location;
            string destPath = Path.Combine(Path.GetDirectoryName(currentPath), "Tests\\TestCopy.exe");

            Debug.Assert(clsCopyFile.CopyFile(currentPath, destPath, true) && File.Exists(destPath), "Test Failed - Copy File Module");
            File.Delete(destPath);
        }

        [TestMethod]
        static void testCopyDirectory()
        {

        }
    }
}
