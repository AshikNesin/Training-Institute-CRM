using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATOM
{
    public partial class frmLogin : Form
    {
        string connString = "server=localhost;port=3306;username=root;password=root";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM atom.userdetails WHERE username='" + txtUserName.Text + "' AND password='" + txtPassword.Text + "';";
                MySqlConnection myConn = new MySqlConnection(connString);
                

                MySqlCommand SelectCommand= new MySqlCommand(query,myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while(myReader.Read())
                {
                    count = count + 1;
                }
                if(count==1)
                {
                    frmDashboard fd = new frmDashboard();
                    this.Hide();
                    fd.ShowDialog();
                    
                }

                else if(count>1)
                {
                    MessageBox.Show("Access Denied!.... Duplicate Username Found!");
                }
                else
                {
                    MessageBox.Show("Invalid UserName & Password!");
                }
                myConn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
