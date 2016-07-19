using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinstallUI.Modules
{
    class clsCopyFile
    {
        public static bool CopyFile(string srcPath, string dstPath, bool bOverwrite)
        {
            bool bRet = false;

            do
            {
                if (!File.Exists(srcPath))
                    break;

                var dirInfo = new DirectoryInfo(Path.GetDirectoryName(dstPath));

                if (!dirInfo.Exists)
                {
                    try
                    {
                        Directory.CreateDirectory(dirInfo.FullName);
                    }
                    catch (Exception Ex)
                    {
                        Src.ExceptionHandler.ShowDialog(Ex);
                        break;
                    }
                }

                try
                {
                    File.Copy(srcPath, dstPath, bOverwrite);
                }
                catch (Exception Ex)
                {
                    Src.ExceptionHandler.ShowDialog(Ex);
                    break;
                }

                bRet = true;

            } while (false);

            return bRet;
        }
    }
}
