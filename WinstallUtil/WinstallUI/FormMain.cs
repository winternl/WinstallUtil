using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinstallUI
{
    public partial class FormMain : Form
    {
        private static FormTask TaskInstance;

        public FormMain()
        {
            InitializeComponent();

            TaskInstance = new FormTask();

            LocationChanged += FormMain_LocationChanged;
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
                TaskInstance = new FormTask();
            }

            TaskInstance.StartPosition = FormStartPosition.Manual;
            TaskInstance.Location = new Point(Location.X + Width + 5, Location.Y);
            TaskInstance.Show();
        }

    }
}
