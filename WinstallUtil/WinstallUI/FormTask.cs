using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinstallUI
{
    public enum ModuleType : int
    {
        [Description("Copy directory")]
        COPY_DIR,
        [Description("Copy file")]
        COPY_FILE,
        [Description("Create scheduled task")]
        SCHEDULED_TASK,
        [Description("Create user account")]
        CREATE_ACCOUNT,
        [Description("Install program")]
        INSTALL_PROG,
        [Description("Run program")]
        RUN_PROG,
        [Description("Run Updates (Windows, Office, Java, Flash)")]
        UPDATE,
        [Description("Execute Command Line")]
        EXEC_CMD
    }

    public partial class FormTask : Form
    {
        private FormMain __FormMain;
        private static FormSchedTask TriggerInstance;

        public FormTask(FormMain FrmMain)
        {
            InitializeComponent();

            __FormMain = FrmMain;

            LocationChanged += FormTask_LocationChanged;

            hidePanels();
            populateComboBox();
            cbTaskTypes.SelectedValueChanged += CbTaskTypes_SelectedValueChanged;
        }

        private void FormTask_LocationChanged(object sender, EventArgs e)
        {
            if (TriggerInstance != null)
            {
                if (!TriggerInstance.IsDisposed && TriggerInstance.IsHandleCreated)
                {
                    TriggerInstance.Invoke(new MethodInvoker(() =>
                    {
                        TriggerInstance.Location = new System.Drawing.Point(Location.X + Width + 5, Location.Y);
                    }));
                }
            }
        }

        void hidePanels()
        {
            foreach (var panel in grpParameters.Controls)
            {
                if (panel is Panel)
                {
                    var p = (Panel)panel;
                    p.Visible = false;
                    p.Enabled = false;
                }
            }
        }

        void populateComboBox()
        {
            foreach (var fldInfo in typeof(ModuleType).GetFields())
            {
                var attr = fldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attr != null && attr.Length > 0)
                {
                    cbTaskTypes.Items.Add((attr.First() as DescriptionAttribute).Description);
                }
            }
        }

        ModuleType GetTaskFromDesc(string Desc)
        {
            ModuleType? tt = null;

            foreach (var fldInfo in typeof(ModuleType).GetFields())
            {
                var attr = fldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attr != null && attr.Length > 0)
                {
                    if (string.Compare(((attr.First() as DescriptionAttribute).Description), Desc) == 0)
                    {
                        tt = (ModuleType)fldInfo.GetValue(null);
                    }
                }
            }

            return tt.GetValueOrDefault();
        }

        private void CbTaskTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            string taskDesc = cbTaskTypes.SelectedItem.ToString();

            if (string.IsNullOrEmpty(taskDesc))
                return;

            switch (GetTaskFromDesc(taskDesc))
            {
                case ModuleType.COPY_DIR:
                    {
                        panCopyDir.Visible = true;
                        panCopyDir.Enabled = true;

                        panCopyDir.BringToFront();

                        txtEmbedDir.Clear();
                        txtCopyDirDest.Clear();
                        cbCopyDir.Items.Clear();

                        foreach (var specDir in Enum.GetValues(typeof(Environment.SpecialFolder)))
                        {
                            string dirTitle = Enum.GetName(typeof(Environment.SpecialFolder), specDir);
                            cbCopyDir.Items.Add(dirTitle);
                        }

                        cbCopyDir.Sorted = true;
                    }
                    break;
                case ModuleType.COPY_FILE:
                    {
                        panCopyFile.Visible = true;
                        panCopyFile.Enabled = true;

                        panCopyFile.BringToFront();

                        txtCopyFileDest.Clear();
                        txtEmbedFile.Clear();
                        cbCopyFileRoot.Items.Clear();

                        foreach (var specDir in Enum.GetValues(typeof(Environment.SpecialFolder)))
                        {
                            string dirTitle = Enum.GetName(typeof(Environment.SpecialFolder), specDir);
                            cbCopyFileRoot.Items.Add(dirTitle);
                        }

                        cbCopyFileRoot.Sorted = true;
                    }
                    break;
                case ModuleType.INSTALL_PROG:
                    {
                        panInstall.Visible = true;
                        panInstall.Enabled = true;

                        panInstall.BringToFront();
                    }
                    break;
                case ModuleType.CREATE_ACCOUNT:
                    {
                        panCreateUser.Visible = true;
                        panCreateUser.Enabled = true;

                        panCreateUser.BringToFront();

                        txtAccUsername.Clear();
                        txtAccPassword.Clear();
                        txtAccVerifyPassword.Clear();
                    }
                    break;
                case ModuleType.SCHEDULED_TASK:
                    {
                        panSchedTask.Visible = true;
                        panSchedTask.Enabled = true;

                        panSchedTask.BringToFront();

                        txtSchedTaskName.Clear();
                        txtSchedTaskPath.Clear();
                        lvTriggers.Items.Clear();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnTestTask_Click(object sender, EventArgs e)
        {
            Modules.ScheduledTask.Schedule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtEmbedFile.Text = ofd.FileName;
                }
            }
        }

        private void btnEmbedDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(fbd.SelectedPath))
                    {
                        if (Directory.Exists(fbd.SelectedPath))
                        {
                            txtEmbedDir.Text = fbd.SelectedPath;
                        }
                    }
                }
            }
        }

        private void btnBrowseInstall_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Portable Executable|*.exe|Windows Installer|*.msi", CheckFileExists = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtInstallerPath.Text = ofd.FileName;
                }
            }
        }


        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
            if (TriggerInstance != null && !TriggerInstance.IsDisposed)
            {
                TriggerInstance.BringToFront();
                TriggerInstance.Focus();
            }
            else
            {
                TriggerInstance = new FormSchedTask(this);
                TriggerInstance.Show();
            }
        }

        private void btnRemoveTrigger_Click(object sender, EventArgs e)
        {
            int arr = lvTriggers.SelectedItems.Count;

            if (arr > 0)
            {
                foreach (var i in lvTriggers.SelectedItems)
                    lvTriggers.Items.Remove((ListViewItem)i);
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
                return;

            __FormMain.Invoke(
                new MethodInvoker(
                    () =>
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = txtTaskName.Text;
                lvi.SubItems.Add(txtTaskDescription.Text);

                __FormMain.lvTaskItems.Items.Add(lvi);
                __FormMain.lvTaskItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }));

            txtTaskName.Clear();
            txtTaskDescription.Clear();
        }
    }
}
