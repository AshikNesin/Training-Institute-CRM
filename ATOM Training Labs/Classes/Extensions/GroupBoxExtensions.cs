using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM

{
    public static class GroupBoxExtensions
    {

        public static string CheckedItemsToString(this GroupBox gb)
        {
            string buffer = "";
            foreach (Control c in gb.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked)
                    {
                        // WARNING.... Need to replace String.Contains() function because it can't handle null exception.
                        if (buffer.Contains(c.Text) == false)
                        {
                            buffer = buffer + c.Text + ", ";
                        }
                    }
                    else
                    {
                        buffer = buffer.Replace(c.Text, "");

                    }
                    int bufferLength = buffer.Length;
                    if (!buffer.Equals("")) { buffer = buffer.Substring(0, bufferLength - 2); }
                }
                if (c is RadioButton)
                {
                    RadioButton temp = (RadioButton)c;
                    if (temp.Checked)
                    {
                        buffer = temp.Text;

                    }
                }

            }

            return buffer;
        }

        //For Checkbox & RadioButtons
        public static void StringToCheckedItems(this GroupBox gb, string StringItems)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (StringItems.Contains(temp.Text))
                    {
                        temp.Checked = true;
                    }
                    else
                    {
                        temp.Checked = false;

                    }
                }

                if (c is RadioButton)
                {
                    RadioButton temp = (RadioButton)c;
                    if (StringItems.Contains(temp.Text))
                    {
                        temp.Checked = true;
                    }
                    else
                    {
                        temp.Checked = false;

                    }
                }

            }


        }
        public static void ClearAllControls(this GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked)
                    {
                        temp.Checked = false;
                    }
                }
                if (c is TextBox)
                {
                    TextBox temp = (TextBox)c;
                    temp.Clear();
                }

                if (c is RadioButton)
                {
                    RadioButton temp = (RadioButton)c;
                    if (temp.Checked)
                    {
                        temp.Checked = false;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox temp = (ComboBox)c;
                    temp.ResetText();
                }
                
                // It calls the PanelExtensions's ClearAllControls...
                if( c is Panel)
                {
                    Panel pnl = (Panel)c;
                    pnl.ClearAllControls();
                }

                //dtp is not working    properly....
                if(c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Text=string.Empty;
                }
            }

        }

    }
}
