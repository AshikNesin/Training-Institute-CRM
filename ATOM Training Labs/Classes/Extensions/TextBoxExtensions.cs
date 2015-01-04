using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public static class TextBoxExtensions
    {
        public static bool IsEmpty(this TextBox txtBox)
        {
            if (txtBox.Text.Trim() == "") { return true; }
            else { return false; }
        }
        public static bool IsNotEmpty(this TextBox txtBox)
        {
            if (txtBox.Text.Trim() != "") {return true; }
            else { return false; }
        }
       


    }
}
