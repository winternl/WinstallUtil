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
                    cbTaskTypes.Items.Add((attr.First() as DescriptionAttribute).Description);
                }
            }
        }

        TaskType GetTaskFromDesc(string Desc)
        {
            TaskType? tt = null;

            foreach (var fldInfo in typeof(TaskType).GetFields())
            {
                var attr = fldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attr != null && attr.Length > 0)
                {
                    if (string.Compare(((attr.First() as DescriptionAttribute).Description), Desc) == 0)
                    {
                        tt = (TaskType)fldInfo.GetValue(null);
                    }
                }
            }

            return tt.GetValueOrDefault();
        }

        private void CbTaskTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            string taskDesc = cbTaskTypes.SelectedItem.ToString();
            grpParameters.Controls.Clear();

            int m_X = 10;
            int m_Y = 30;
            int m_Padding = 5;

            int txt_Width = 200;
            int txt_Height = 23;

            // Dynamic Controls in GroupBox
            // -- Control Location offset by parent, not form.

            switch (GetTaskFromDesc(taskDesc))
            {
                case TaskType.COPY_DIR:
                    {
                        var ctrl_1 = new Label()
                        {
                            Location = new Point(m_X, m_Y),
                            Text = "Source Directory:"
                        };

                        var ctrl_2 = new TextBox()
                        {
                            Location = new Point(m_X, m_Y + ctrl_1.Height + m_Padding),
                            Size = new Size(txt_Width, txt_Height)
                        };

                        grpParameters.Controls.AddRange(new Control[] { ctrl_1, ctrl_2 });
                    }
                    break;

                case TaskType.COPY_FILE:
                    {

                    }
                    break;

                default:
                    break;
            }
        }

        private void btnTestTask_Click(object sender, EventArgs e)
        {
            TestCase.testCopyFile();
        }
    }
}
