using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public static class FormExtensions
    {
        static DBEntities db;

        #region ConfirmQuit
        public static void ConfirmQuit(this Form frm)
        {
            frm.FormClosing -= frm_FormClosing;
            frm.FormClosing += frm_FormClosing;
        }

        
        public static void ConfirmQuit(this Form frm , DBEntities database)
        {
            // Need to WRITE code here....
            db = database;
           
            frm.FormClosing -= frm_FormClosing;
            frm.FormClosing += frm_FormClosing;
        }
        static void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBox.AskYesNo("Do You want to Quit ?", "Quit") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
        public static bool AlreadyOpen(this Form frm)
        {
            if (Application.OpenForms[frm.Name] != null)
            {
              
                return true;
            }
            else
            {
                return false;
            }
        }

            
      
    }
}
