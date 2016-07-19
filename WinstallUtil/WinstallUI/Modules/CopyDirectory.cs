using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinstallUI.Modules
{
    public enum CopyDirResult : ushort
    {
            SUCCESS,
            PARTIAL_COPY,
            FAILURE
    }

    class clsCopyDirectory
    {
        public static CopyDirResult CopyDirectory(string srcPath, string dstPath, bool bRecurse)
        {
            CopyDirResult fRet = CopyDirResult.SUCCESS;

            do
            {
                var dirInfo = new DirectoryInfo(srcPath);

                if (!dirInfo.Exists)
                {
                    fRet = CopyDirResult.FAILURE;
                    break;
                }

                if (!Directory.Exists(dstPath))
                {
                    try
                    {
                        Directory.CreateDirectory(dstPath);
                    }
                    catch (Exception Ex)
                    {
                        Src.ExceptionHandler.ShowDialog(Ex);
                        fRet = CopyDirResult.FAILURE;
                        break;
                    }
                }

                var nestedDirs = dirInfo.GetDirectories();

                List<FileInfo> dirContents = dirInfo.GetFiles().ToList();

                foreach (var fEntry in dirContents)
                {
                    try
                    {
                        fEntry.CopyTo(Path.Combine(dstPath, fEntry.Name));
                    }
                    catch (Exception Ex)
                    {
                        Src.ExceptionHandler.ShowDialog(Ex);
                        fRet = CopyDirResult.PARTIAL_COPY;
                        continue;
                    }
                }

                if (bRecurse)
                {
                    foreach (var dirEntry in nestedDirs)
                    {
                        fRet = CopyDirectory(
                                             dirEntry.FullName,
                                             Path.Combine(dstPath, dirEntry.Name),
                                             true
                                         );
                    }
                }

            } while (false);

            return fRet;
        }
    }
}
