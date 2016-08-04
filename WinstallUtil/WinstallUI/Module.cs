using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinstallUI
{
    public static class EPGen
    {
        private static string OriginalSource { get; set; }
        private static string InstanceSource { get; set; }

        static EPGen()
        {
            OriginalSource = Properties.Resources.Entrypoint;
        }

        private static void EmitCall(ModuleCall Call, params string[] Args)
        {
            StringBuilder sb = new StringBuilder();

            switch (Call.Type)
            {
                case ModuleType.COPY_DIR:
                    // proto: public static bool CopyFile(string srcPath, string dstPath, bool bOverwrite)
                    break;
                case ModuleType.COPY_FILE:
                    break;
                case ModuleType.SCHEDULED_TASK:
                    break;
                case ModuleType.CREATE_ACCOUNT:
                    break;
                case ModuleType.INSTALL_PROG:
                    break;
                case ModuleType.RUN_PROG:
                    break;
                case ModuleType.UPDATE:
                    break;
                case ModuleType.EXEC_CMD:
                    break;
                default:
                    break;
            }
        }

        public static void EmitLinearProcedure(IDictionary<ModuleCall, object[]> KeyValCallArgs)
        {

        }
    }

    public class ModuleCall
    {
        public ModuleType Type { get; set; }

        internal ModuleCall(ModuleType _Type)
        {
            Type = _Type;
        }

        public static ModuleCall Create(ModuleType Type)
        {
            return new ModuleCall(Type);
        }
    }
}
