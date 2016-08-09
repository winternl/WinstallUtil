using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinstallUI.Serialization;
using WinstallUI.Serialization.Templates;
using P = WinstallUI.Properties;
using MaterialSkin.Controls;

namespace WinstallUI
{
    public partial class FormMain : Form
    {
        private static FormTask TaskInstance;

        public FormMain()
        {
            InitializeComponent();

            Icon = P.Resources.SoftwareInstall;

            TaskInstance = new FormTask(this);

            LocationChanged += FormMain_LocationChanged;

            //SRLScheduledTask srl_st = new SRLScheduledTask(new TSchedTask("TaskName", "C:\\Windows\\notepad.exe", TaskTrigger.DAILY, 12, 45));
            //srl_st.Serialize();

            SRLCopyFile srl_cf = new SRLCopyFile(new TCopyFile("C:\\Users\\OPH-ADMIN\\Desktop\\BSC Master.xlsx", false));
            srl_cf.Serialize();

            File.WriteAllBytes("C:\\Users\\OPH-ADMIN\\Desktop\\Test2.bin", srl_cf.SerializedTemplate);

            srl_cf = new SRLCopyFile(File.ReadAllBytes("C:\\Users\\OPH-ADMIN\\Desktop\\Test2.bin"));
            var test2 = srl_cf.Deserialize();

            File.WriteAllBytes("C:\\Users\\OPH-ADMIN\\Desktop\\Test2.xlsx", test2.Data);

            using (ConfigWriter cfg = new ConfigWriter("C:\\Users\\OPH-ADMIN\\Desktop\\Config.WTSK"))
            {
                cfg.WriteTask("hi", "test", ModuleType.CREATE_ACCOUNT, TaskTrigger.DAILY, new object[] { });
                cfg.Save();
            }


            //var codeGen = LCG.CreateFromContext(new LCGContext(P.Resources.Entrypoint, "Main"));
            //codeGen.EmitCall(ModuleTemplates.CopyFile, new object[] { "hi", "one", false });
            //codeGen.Push();
            //MessageBox.Show(codeGen.Pull());
            //codeGen.EmitCall(ModuleTemplates.CopyFile, new object[] { "hello", "world", true });
            //codeGen.Push();
            //MessageBox.Show(codeGen.Pull());
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

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            int c = lvTaskItems.SelectedItems.Count;

            if (c > 0)
            {
                foreach (var i in lvTaskItems.SelectedItems)
                    lvTaskItems.Items.Remove((ListViewItem)i);
            }
        }

        private void btnOpenExisting_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "WTSK|*.WTSK" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
