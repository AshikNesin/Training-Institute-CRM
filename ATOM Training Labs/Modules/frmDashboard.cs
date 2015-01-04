using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public partial class frmDashboard : Form
    {  
        public frmDashboard()
        {
            InitializeComponent();
        }

        
        
        //private void ShowFormInPanel(Form FormToShow)
        //{
        //    FormToShow.TopLevel = false;
        //    FormToShow.AutoScroll = true;
        //    //Remove the  windows borders and max/min buttons etc..
        //    FormToShow.FormBorderStyle = FormBorderStyle.None;
        //    //Display the form in the panel
        //    pnlContainer.Container.Add(FormToShow);
        //    FormToShow.Show();
        //    this.Text = FormToShow.Text;
        //}

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            pnlContainer.Top = pnlHeader.Bottom+20;
                     

        }

        

        

            private void lblMeetup_Click(object sender, EventArgs e)
            {
            Form ClientForm = Application.OpenForms.OfType<Form>().Where(frm => frm.GetType() == typeof(frmMeetup)).FirstOrDefault();
            if (ClientForm == null) 
            {
                ClientForm = new frmMeetup(); 
            }
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            if (ClientForm == null)
            {
                pnlContainer.Controls.Clear();
            }
            else
            {
                this.Text = "M E E T U P";

                pnlContainer.Controls.Clear();
                if (pnlContainer.Controls.Count > 0 && ClientForm.GetType() != pnlContainer.Controls[0].GetType())
                {
                    pnlContainer.Controls.Clear();
                }
                ClientForm.Text = "";
                ClientForm.TopLevel = false;
                ClientForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ClientForm.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ClientForm);
                ClientForm.Show();
                ClientForm.AutoScroll = true;
                ClientForm.Focus();
            }
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                
        }

            private void lblIPT_Click(object sender, EventArgs e)
            {
                Form ClientForm = Application.OpenForms.OfType<Form>().Where(frm => frm.GetType() == typeof(frmIPT)).FirstOrDefault();
                if (ClientForm == null)
                {
                    ClientForm = new frmIPT();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                if (ClientForm == null)
                {
                    pnlContainer.Controls.Clear();
                }
                else
                {
                    this.Text = "I P T";

                    pnlContainer.Controls.Clear();
                    if (pnlContainer.Controls.Count > 0 && ClientForm.GetType() != pnlContainer.Controls[0].GetType())
                    {
                        pnlContainer.Controls.Clear();
                    }
                    ClientForm.Text = "";
                    ClientForm.TopLevel = false;
                    ClientForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    ClientForm.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ClientForm);
                    ClientForm.Show();
                    ClientForm.Focus();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            }

            private void lblEnquiry_Click(object sender, EventArgs e)
            {
                Form ClientForm = Application.OpenForms.OfType<Form>().Where(frm => frm.GetType() == typeof(frmEnquiry)).FirstOrDefault();
                if (ClientForm == null)
                {
                    ClientForm = new frmEnquiry();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                if (ClientForm == null)
                {
                    pnlContainer.Controls.Clear();
                }
                else
                {
                    this.Text = "E N Q U I R Y";

                    pnlContainer.Controls.Clear();
                    if (pnlContainer.Controls.Count > 0 && ClientForm.GetType() != pnlContainer.Controls[0].GetType())
                    {
                        pnlContainer.Controls.Clear();
                    }
                    ClientForm.Text = "";
                    ClientForm.TopLevel = false;
                    ClientForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    ClientForm.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ClientForm);
                    ClientForm.Show();
                    ClientForm.Focus();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            
            }

            private void lblAdmission_Click(object sender, EventArgs e)
            {
                Form ClientForm = Application.OpenForms.OfType<Form>().Where(frm => frm.GetType() == typeof(frmAdmission)).FirstOrDefault();
                if (ClientForm == null)
                {
                    ClientForm = new frmAdmission();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                if (ClientForm == null)
                {
                    pnlContainer.Controls.Clear();
                }
                else
                {
                    this.Text = "A D M I S S I O N";

                    pnlContainer.Controls.Clear();
                    if (pnlContainer.Controls.Count > 0 && ClientForm.GetType() != pnlContainer.Controls[0].GetType())
                    {
                        pnlContainer.Controls.Clear();
                    }
                    ClientForm.Text = "";
                    ClientForm.TopLevel = false;
                    ClientForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    ClientForm.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ClientForm);
                    ClientForm.Show();
                    ClientForm.Focus();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            
            }

            private void lblInternship_Click(object sender, EventArgs e)
            {
                Form ClientForm = Application.OpenForms.OfType<Form>().Where(frm => frm.GetType() == typeof(frmInternship)).FirstOrDefault();
                if (ClientForm == null)
                {
                    ClientForm = new frmInternship();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                if (ClientForm == null)
                {
                    pnlContainer.Controls.Clear();
                }
                else
                {
                    this.Text = "E N Q U I R Y";

                    pnlContainer.Controls.Clear();
                    if (pnlContainer.Controls.Count > 0 && ClientForm.GetType() != pnlContainer.Controls[0].GetType())
                    {
                        pnlContainer.Controls.Clear();
                    }
                    ClientForm.Text = "";
                    ClientForm.TopLevel = false;
                    ClientForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    ClientForm.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ClientForm);
                    ClientForm.Show();
                    ClientForm.Focus();
                }
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            
            }

            private void pnlHeader_Paint(object sender, PaintEventArgs e)
            {

            }

        

        
            
        }
        
    }

