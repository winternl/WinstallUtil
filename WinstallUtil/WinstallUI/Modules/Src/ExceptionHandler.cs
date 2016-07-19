using System;
using System.Windows.Forms;

namespace WinstallUI.Modules.Src
{
    public static class ExceptionHandler
    {
        public static void ShowDialog(Exception Ex)
        {
            if (Ex == null)
                return;

            string strMessage = Ex.Message;

            if (string.IsNullOrEmpty(strMessage))
            {
                var dlgResult = MessageBox.Show(
                        "An unhandled exception was thrown. No message available. To view stack trace, click 'Ok'.",
                        "Exception",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error
                    );

                if (dlgResult == DialogResult.OK)
                {
                    MessageBox.Show(Ex.StackTrace);
                }
            }
            else
            {
                var dlgResult = MessageBox.Show(
                       "An unhandled exception was thrown. To view stack trace, click 'Ok'.\n" + strMessage,
                       "Exception",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );

                if (dlgResult == DialogResult.OK)
                {
                    MessageBox.Show(Ex.StackTrace);
                }
            }
        }
    }
}