using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public static class PanelExtensions
    {
        public static string CheckedItemsToString(this Panel pnl)
        {

            string buffer = "";
            foreach (Control c in pnl.Controls)
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
        public static void StringToCheckedItems(this Panel pnl, string StringItems)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    //BEWARE.... String.Contains() might throw an Error....

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

        public static void ClearAllControls(this Panel pnl)
        {
            foreach (Control c in pnl.Controls)
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
                
                //dtp is not working properly....
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Text = null;
                }

                  // It calls the GroupBoxExtensions's ClearAllControls...
                if( c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                   gb.ClearAllControls();
                }
            }
            }

        }
          
    }

