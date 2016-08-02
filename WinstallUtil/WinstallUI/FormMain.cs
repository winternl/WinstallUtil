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

            // Test 1
            var linearProc = new Dictionary<ModuleCall, object[]>();
            linearProc.Add(ModuleCall.Create(ModuleType.COPY_FILE), new object[] { });

            // Test 2
            var SrcFiles = new string[]
            {
                P.Resources.Entrypoint1,
                P.Resources.ExceptionHandler,
                P.Resources.Log
            };

            using (Compiler codeCompiler = new Compiler(SrcFiles))
            {
                codeCompiler.AddReference("System.dll");
                codeCompiler.AddReference("System.Windows.Forms.dll");

                codeCompiler.Compile();

                codeCompiler.Save("%HOMEPATH%\\Desktop\\Test.exe");
            }

            StubPacker stubPacker = new StubPacker("%HOMEPATH%\\Desktop\\Test.exe");
            stubPacker.Pack("%HOMEPATH%\\Desktop\\Packed_Test.exe");

            SRLScheduledTask srl_st = new SRLScheduledTask(new TSchedTask("TaskName", "C:\\Windows\\notepad.exe", TaskTrigger.DAILY, 12, 45));
            srl_st.Serialize();

            File.WriteAllBytes("C:\\Users\\OPH-ADMIN\\Desktop\\Test2.bin", srl_st.SerializedTemplate);

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
