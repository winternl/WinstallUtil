using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinstallUI.Modules.Src
{
    [TestClass]
    public static class TestCase
    {

        const string TestMessage = "This is a test method. It will verify the functionality of the selected task module.\n" +
                                          "If you would like to proceed with this test case, please select 'Yes'.\n" +
                                          "If this test exits silently, then the test was successful.";

        static bool ShowTestCase()
        {
            bool bRet = false;

            var dlgResult = MessageBox.Show(
                                            TestMessage,
                                            "Verify Module",
                                            MessageBoxButtons.YesNo
                                        );

            if (dlgResult == DialogResult.Yes)
            {
                bRet = true;
            }

            return bRet;
        }

        [TestMethod]
        public static void testCopyFile()
        {
            if (!ShowTestCase()) return;

            string currentPath = typeof(TestCase).Assembly.Location;
            string destPath = Path.Combine(Path.GetDirectoryName(currentPath), "Tests\\TestCopy.exe");

            Debug.Assert(clsCopyFile.CopyFile(currentPath, destPath, true) && File.Exists(destPath), "Test Failed - Copy File Module");

            File.Delete(destPath);
        }

        [TestMethod]
        static void testCopyDirectory()
        {
            if (!ShowTestCase()) return;
        }
    }
}
