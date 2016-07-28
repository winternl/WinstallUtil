using System;
using System.Windows.Forms;

namespace WinstallUI
{
    public partial class FormSchedTask : Form
    {
        private FormTask __FrmTask;
        private string Desc;

        public FormSchedTask(FormTask FrmTask)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;

            __FrmTask = FrmTask;
            __FrmTask.Disposed += __FrmTask_Disposed;

            Location = new System.Drawing.Point(__FrmTask.Location.X + __FrmTask.Width + 5, __FrmTask.Location.Y);

            cbSchedTaskType.Sorted = true;
            cbSchedTaskType.SelectedValueChanged += CbSchedTaskType_SelectedValueChanged;
        }

        private void __FrmTask_Disposed(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CbSchedTaskType_SelectedValueChanged(object sender, EventArgs e)
        {
            string sTaskType = cbSchedTaskType.SelectedItem.ToString();

            switch (sTaskType)
            {
                case "On logon":
                    grpDateTime.Enabled = false;
                    Desc = "Task will occur at logon.";
                    break;
                case "At startup":
                    grpDateTime.Enabled = false;
                    Desc = "Task will occur at startup.";
                    break;
                case "On idle":
                    grpDateTime.Enabled = false;
                    Desc = "Task will occur on idle.";
                    break;
                case "Daily":
                    grpDateTime.Enabled = true;
                    cbDay.Enabled = false;
                    Desc = "Task will occur daily at ";
                    break;
                case "Weekly":
                    grpDateTime.Enabled = true;
                    cbDay.Enabled = true;
                    Desc = "Task will occur weekly on ";
                    break;
                default:
                    grpDateTime.Enabled = false;
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbSchedTaskType.SelectedItem != null &&
                !string.IsNullOrEmpty(cbSchedTaskType.SelectedItem.ToString()))
            {
                __FrmTask.Invoke(
                    new MethodInvoker(() =>
                   {
                       var lvi = new ListViewItem();
                       lvi.Text = cbSchedTaskType.SelectedItem.ToString();

                       if (grpDateTime.Enabled)
                       {
                           if (Desc.Contains("daily"))
                               Desc += numHR.Value.ToString() + ":" + numMN.Value.ToString() + ".";
                           else
                               Desc += cbDay.SelectedItem.ToString() + "s" + " at" + numHR.Value.ToString() + ":" + numMN.Value.ToString() + ".";
                       }

                       lvi.SubItems.Add(Desc);
                       __FrmTask.lvTriggers.Items.Add(lvi);
                   }));
            }
        }
    }
}
