using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public static class MsgBox
    {
        public static void Error(string Message, string Caption="Error")
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show(string Message, string Caption="Info")
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult AskYesNo(string Message, string Caption)
        {
            return MessageBox.Show(Message, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
