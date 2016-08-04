using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace WinstallUI
{
    public struct LCGContext
    {
        public string Source;
        public string MethodName;

        public LCGContext(string Source, string MethodName)
        {
            this.Source = Source;
            this.MethodName = MethodName;
        }
    }

    /// <summary>
    /// Linear Code Generator
    /// </summary>
    public class LCG
    {
        private StringBuilder Code { get; set; }
        private LCGContext Context { get; set; }
        private Dictionary<int, List<string>> Map { get; set; }

        private const int LO = 0, MI = 1, HI = 2;

        private LCG(LCGContext context)
        {
            Context = context;
            Code = new StringBuilder();
            Map = new Dictionary<int, List<string>>();
            Map[LO] = new List<string>();
            Map[MI] = new List<string>();
            Map[HI] = new List<string>();

            string Source = Context.Source;
            string MtdName = Context.MethodName;

            string[] SourceLines = Regex.Split(Source, Environment.NewLine);
            int nOccurences = 0;
            int ii = 0;

            for (int i = 0; i < SourceLines.Length; i++)
            {
                if (SourceLines[i].Contains(MtdName))
                {
                    nOccurences++;

                    if (SourceLines[i].Contains("{"))
                        ii = i + 1;
                    else
                        ii = i + 2;
                }
            }

            if (nOccurences != 1)
                throw new Exception("Too lazy to implement correctly.");

            for (int i = 0; i < ii; i++)
                Map[LO].Add(SourceLines[i]);

            Map[LO].Add(Environment.NewLine);

            for (int i = ii; i < SourceLines.Length; i++)
                Map[HI].Add(SourceLines[i]);
        }

        public static LCG CreateFromContext(LCGContext Context)
        {
            return new LCG(Context);
        }

        private bool VerifyArgs(ICollection<Type> TArray, object[] Args)
        {
            if (TArray.Count != Args.Length)
                return false;

            bool bReturn = true;
            var localArr = TArray.ToArray();

            for (int i = 0; i < localArr.Length; i++)
            {
                if (localArr[i] != Args[i].GetType())
                    bReturn = false;
            }

            return bReturn;
        }

        public void EmitCall(ModuleTemplate Template, params object[] Args)
        {
            if (!VerifyArgs(Template.GetParameters(), Args))
                throw new ArgumentException("Parameters do not match the specified template.");

            var tType = Template.GetModuleType();
            var tArgs = Template.GetParameters().ToArray();

            StringBuilder sb = new StringBuilder();

            List<object> TTArgs = new List<object>();

            for (int i = 0; i < Args.Length; i++)
                TTArgs.Add(Convert.ChangeType(Args[i], tArgs[i]));

            switch (tType)
            {
                case ModuleType.COPY_DIR:
                    sb.Append("clsCopyDirectory.CopyDir(");
                    break;
                case ModuleType.COPY_FILE:
                    sb.Append("clsCopyFile.CopyFile(");
                    break;
                case ModuleType.SCHEDULED_TASK:
                    sb.Append("clsScheduledTask.CopyFile(");
                    break;
                case ModuleType.CREATE_ACCOUNT:
                    sb.Append("clsCreateAccount.CopyFile(");
                    break;
                case ModuleType.INSTALL_PROG:
                    sb.Append("clsInstallProgram.CopyFile(");
                    break;
                case ModuleType.RUN_PROG:
                    sb.Append("clsRunProgram.CopyFile(");
                    break;
                case ModuleType.UPDATE:
                    sb.Append("clsUpdate.CopyFile(");
                    break;
                case ModuleType.EXEC_CMD:
                    sb.Append("clsExecCommand.CopyFile(");
                    break;
                default:
                    throw new Exception("Module type not found.");
            }

            bool bCheckLast = false;

            for (int i = 0; i < TTArgs.Count; i++)
            {
                if (i == TTArgs.Count - 1)
                    bCheckLast = true;

                if (TTArgs[i].GetType() == typeof(string))
                    sb.Append(string.Concat("\"", Convert.ToString(TTArgs[i]), "\""));
                else if (TTArgs[i].GetType() == typeof(bool))
                    sb.Append(Convert.ToString(TTArgs[i]).ToLower());
                else sb.Append(Convert.ToString(TTArgs[i]));

                if (!bCheckLast)
                    sb.Append(", ");
            }

            sb.Append(");");
            Code.AppendLine(sb.ToString());
        }

        /// <summary>
        /// Retrieves all emitted elements that have been pushed.
        /// </summary>
        /// <returns></returns>
        public string Pull()
        {
            return string.Concat(string.Join(Environment.NewLine, Map[LO].ToArray()),
                                    string.Join(Environment.NewLine, Map[MI].ToArray()),
                                    string.Join(Environment.NewLine, Map[HI].ToArray()));
        }

        /// <summary>
        /// Pushes any emitted elements and clears internal state.
        /// </summary>
        public void Push()
        {
            if (Code.Length > 0)
            {
                string CodeRet = Code.ToString();
                string[] CodeLines = Regex.Split(CodeRet, Environment.NewLine);
                Map[MI].AddRange(CodeLines);
                Code = new StringBuilder();
            }
        }
    }

    public static class ModuleTemplates
    {
        public static MCopyFile CopyFile;

        static ModuleTemplates()
        {
            CopyFile = new MCopyFile();
        }
    }

    public abstract class ModuleTemplate
    {
        public abstract ModuleType GetModuleType();
        public abstract ICollection<Type> GetParameters();
    }

    public class MCopyFile : ModuleTemplate
    {
        public override ModuleType GetModuleType()
        {
            return ModuleType.COPY_FILE;
        }

        public override ICollection<Type> GetParameters()
        {
            return new Type[] { typeof(string), typeof(string), typeof(bool) };
        }
    }

}
