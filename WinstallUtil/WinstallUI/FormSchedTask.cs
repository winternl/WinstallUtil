using System;
using System.Windows.Forms;

namespace WinstallUI
{
    public partial class FormSchedTask : Form
    {
        private FormTask __FrmTask;

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
                case "Daily":
                    grpDateTime.Enabled = true;
                    cbDay.Enabled = false;
                    break;
                case "Weekly":
                    grpDateTime.Enabled = true;
                    cbDay.Enabled = true;
                    break;
                default:
                    grpDateTime.Enabled = false;
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
