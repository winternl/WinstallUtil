using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinstallUI.Serialization;
using WinstallUI.Serialization.Templates;
using P = WinstallUI.Properties;

namespace WinstallUI
{
    public partial class FormMain : Form
    {
        private static FormTask TaskInstance;

        public FormMain()
        {
            InitializeComponent();

            TaskInstance = new FormTask(this);

            LocationChanged += FormMain_LocationChanged;

            SRLScheduledTask srl_st = new SRLScheduledTask(new TSchedTask("TaskName", "C:\\Windows\\notepad.exe", TaskTrigger.DAILY, 12, 45));
            srl_st.Serialize();

            File.WriteAllBytes("C:\\Users\\OPH-ADMIN\\Desktop\\Test2.bin", srl_st.SerializedTemplate);

            var codeGen = LCG.CreateFromContext(new LCGContext(P.Resources.Entrypoint, "Main"));
            codeGen.EmitCall(ModuleTemplates.CopyFile, new object[] { "hi", "one", false });
            codeGen.Push();
            MessageBox.Show(codeGen.Pull());
            codeGen.EmitCall(ModuleTemplates.CopyFile, new object[] { "hello", "world", true });
            codeGen.Push();
            MessageBox.Show(codeGen.Pull());
        }

        private void FormMain_LocationChanged(object sender, EventArgs e)
        {
            if (TaskInstance != null)
            {
                if (!TaskInstance.IsDisposed && TaskInstance.IsHandleCreated)
                {
                    TaskInstance.Invoke(new MethodInvoker(() =>
                    {
                        TaskInstance.Location = new Point(Location.X + Width + 5, Location.Y);
                    }));
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (TaskInstance.IsDisposed)
            {
                TaskInstance = new FormTask(this);
            }

            TaskInstance.BringToFront();
            TaskInstance.StartPosition = FormStartPosition.Manual;
            TaskInstance.Location = new Point(Location.X + Width + 5, Location.Y);
            TaskInstance.Show();
        }

    }
}
