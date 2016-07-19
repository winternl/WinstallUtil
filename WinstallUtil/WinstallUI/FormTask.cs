using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WinstallUI.Modules.Src;

namespace WinstallUI
{
    public enum TaskType : int
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
        UPDATE
    }

    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();

            populateComboBox();
            cbTaskTypes.SelectedValueChanged += CbTaskTypes_SelectedValueChanged;
        }

        void populateComboBox()
        {
            foreach (var fldInfo in typeof(TaskType).GetFields())
            {
                var attr = fldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attr != null && attr.Length > 0)
                {
                    cbTaskTypes.Items.Add(((DescriptionAttribute)attr.First()).Description);
                }
            }
        }
       
        private void CbTaskTypes_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTestTask_Click(object sender, EventArgs e)
        {
            TestCase.testCopyFile();
        }
    }
}
