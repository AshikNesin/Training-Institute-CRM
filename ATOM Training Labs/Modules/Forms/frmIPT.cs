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
    public partial class frmIPT : Form
    {
        public string strGender = null;
        public string strTimePreferred = null;
        public DBEntities db = new DBEntities();

        public frmIPT()
        {
            InitializeComponent();
        }

        private void frmIPT_Load(object sender, EventArgs e)
        {
            
            
            DefaultProperties();
            //DummyQuery();
           
        }
        #region ApplicationInterfaceLayer
        private void DefaultProperties()
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = false; }

        }
        private void GetNextSerialNo()
        {
            txtSerialNo.Text = txtSerialNo.GetNewSerialNo("ipts");
        }

        private void AssignDefaultValues()
        {
            //Assign default values for radiobuttons
            if (rbMale.Checked == false && rbFemale.Checked == false) { rbMale.Checked = true; }
            if(rbPartTime.Checked==false&&rbFullTime.Checked==false){rbPartTime.Checked=true;}


            
        }

        private void ClearControls()
        {
            splitContainer.Panel2.ClearAllControls();
        }

        #endregion


        #region DataInterfaceLayer
        public void AssignDataToVariables()
        {
            //Analyze the radiobutton & assign it to variables

            strGender = pnlGender.CheckedItemsToString();
            strTimePreferred = pnlTimePreferred.CheckedItemsToString();


            
        }


        void SaveRecord()
        {
            AssignDataToVariables();
            ipt record = new ipt
            {
                SerialNo=int.Parse(txtSerialNo.Text),
                Name=txtName.Text,
                MobileNo=txtMobile.Text,
                Email_ID=txtEmail.Text,
                Gender=strGender,
                Address=txtAddress.Text,
                Notes=txtNotes.Text,
                CollegeName=txtCollegeName.Text,
                StudentMajor=txtStudentMajor.Text,
                YearOfPassing=int.Parse(txtYearOfPassing.Text),
                JoinedDate = DateTime.Parse(dtpJoined.Text),
                ConcludeDate=DateTime.Parse(dtpConclude.Text),
                TimePreferred=strTimePreferred

            };

            DIL.SaveRecord(db, record);
        }
        void UpdateRecord()
        {

            AssignDataToVariables();
            int serialNo = int.Parse(txtSerialNo.Text);

            ipt record = db.ipts.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
            record.Name=txtName.Text;
            record.MobileNo = txtMobile.Text;
            record.Email_ID = txtEmail.Text;
            record.Gender = strGender;
            record.Address = txtAddress.Text;
            record.Notes = txtNotes.Text;
            record.CollegeName = txtCollegeName.Text;
            record.StudentMajor = txtStudentMajor.Text;
            record.YearOfPassing = int.Parse(txtYearOfPassing.Text);
            record.JoinedDate = DateTime.Parse(dtpJoined.Text);
            record.ConcludeDate = DateTime.Parse(dtpConclude.Text);
            record.TimePreferred = strTimePreferred;



            DIL.UpdateRecord(db, record);

        }

        void DeleteRecord()
        {
            if (MsgBox.AskYesNo("Do you want to Delete Record ?", "Confirm Delete") == DialogResult.Yes)
            {
                DIL.DeleteRecord(db, int.Parse(txtSerialNo.Text), "IPT");
            }
        }

        void ShowRecord(int serialNo)
        {
            ClearControls();
            try
            {
                ipt record = db.ipts.SingleOrDefault(r => r.SerialNo == serialNo);
                txtSerialNo.Text = record.SerialNo.ToString();
                txtName.Text=record.Name;
                txtMobile.Text=record.MobileNo;
                txtEmail.Text=record.Email_ID;
                pnlGender.StringToCheckedItems(record.Gender);
                txtAddress.Text=record.Address;
                txtNotes.Text=record.Notes;
                txtCollegeName.Text=record.CollegeName;
                txtStudentMajor.Text= record.StudentMajor ;
                txtYearOfPassing.Text=record.YearOfPassing.ToString();
                
                dtpJoined.Text = record.JoinedDate.ToString();
                dtpConclude.Text = record.ConcludeDate.ToString();
                pnlTimePreferred.StringToCheckedItems(record.TimePreferred);




            }
            catch(Exception ex)
            {
                MsgBox.Error(ex.Message);
            }
        }

        void SearchRecord(string name)
        {
            string query;
           query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`ipts` WHERE LOWER(CONVERT(`name` USING utf8)) LIKE '%" + name + "%'";
            try
            {
                MySqlConnection myConn = new MySqlConnection(DIL.connString);
                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();


                myConn.Open();

                sda.SelectCommand = SelectCommand;
                DataTable myDataSet = new DataTable();
                sda.Fill(myDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = myDataSet;
                dgvResults.DataSource = bSource;
                dgvResults.Columns["SerialNo"].Visible = false;
                dgvResults.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvResults.AutoResizeColumns();
                sda.Update(myDataSet);

            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
            }


        }
        public void DummyQuery()
        {
            internship dummy = db.internships.SingleOrDefault(p => p.SerialNo == 0);
        }

        

        #endregion



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.IsEmpty()) { MsgBox.Error("Please Enter your Name.", "TextBox is Empty"); txtName.Focus(); return; }
            if (txtSerialNo.IsNewRecord("ipts") == true)
            {
                SaveRecord();
            }
            else
            {
                UpdateRecord();
            }
 

        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = true; }
            GetNextSerialNo();
            ClearControls();
            AssignDefaultValues();
        
        }

        

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearControls();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvResults.Rows[e.RowIndex];
                int SerialNo = int.Parse(row.Cells["SerialNo"].Value.ToString());
                foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = true; }
                ShowRecord(SerialNo);



            }
       
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtSearchBox.Text);
            if (txtSearchBox.IsEmpty())
            {
                dgvResults.DataSource = null;
                dgvResults.Refresh();

            }
        }

      

    }
}
