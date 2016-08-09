using System;
using System.IO;
using System.Text;
using WinstallUI.Serialization.Templates;

namespace WinstallUI.Serialization
{
    public class SRLScheduledTask : ModuleSerializer<TSchedTask>
    {
        public SRLScheduledTask(TSchedTask TemplateStructure) : base(TemplateStructure) { }

        public override TSchedTask Deserialize()
        {
            throw new NotImplementedException();
        }

        public override byte[] Serialize()
        {
            byte[] taskName = Encoding.Unicode.GetBytes(Template.Name);
            byte[] taskArg = Encoding.Unicode.GetBytes(Template.FileToRun);
            byte[] taskTrigger = BitConverter.GetBytes((int)Template.Trigger);
            byte[] timeHour = null;
            byte[] timeMinute = null;

            if (Template.Trigger == TaskTrigger.DAILY
                || Template.Trigger == TaskTrigger.WEEKLY
                && Template.Hour.HasValue
                && Template.Minute.HasValue)
            {
                timeHour = BitConverter.GetBytes(Template.Hour.Value);
                timeMinute = BitConverter.GetBytes(Template.Minute.Value);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(taskName.Length), 0, sizeof(int));
                ms.Write(taskName, 0, taskName.Length);

                ms.Write(BitConverter.GetBytes(taskArg.Length), 0, sizeof(int));
                ms.Write(taskArg, 0, taskArg.Length);

                ms.Write(BitConverter.GetBytes(taskTrigger.Length), 0, sizeof(int));
                ms.Write(taskTrigger, 0, taskTrigger.Length);

                if (timeHour != null && timeMinute != null)
                {
                    ms.Write(BitConverter.GetBytes(timeHour.Length), 0, sizeof(int));
                    ms.Write(timeHour, 0, timeHour.Length);

                    ms.Write(BitConverter.GetBytes(timeMinute.Length), 0, sizeof(int));
                    ms.Write(timeMinute, 0, timeMinute.Length);
                }

                SerializedTemplate = ms.ToArray();
            }

            return SerializedTemplate;
        }
    }
}