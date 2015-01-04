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
    public partial class frmInternship : Form
    {
        public string strGender = null;
        public string strTimePreferred = null, strInternshipType = null;
        public DBEntities db = new DBEntities();

        public frmInternship()
        {
            InitializeComponent();
        }

        private void frmInternship_Load(object sender, EventArgs e)
        {
            
            
            DefaultProperties();
           // DummyQuery();
           
        }
        #region ApplicationInterfaceLayer
        private void DefaultProperties()
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = false; }

        }
        private void GetNextSerialNo()
        {
            txtSerialNo.Text = txtSerialNo.GetNewSerialNo("internships");
        }

        private void AssignDefaultValues()
        {
            //Assign default values for radiobuttons
            if (rbMale.Checked == false && rbFemale.Checked == false) { rbMale.Checked = true; }
            if(rbPartTime.Checked==false&&rbFullTime.Checked==false){rbPartTime.Checked=true;}
            if (rbFreeIntern.Checked == false && rbFullTime.Checked == false) { rbFreeIntern.Checked = true; }

            
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
            strInternshipType = pnl_InternshipType.CheckedItemsToString();

            
        }


        void SaveRecord()
        {
            AssignDataToVariables();
            internship record = new internship
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
                Position=txtPosition.Text,
                JoinedDate = DateTime.Parse(dtpJoined.Text),
                ConcludeDate=DateTime.Parse(dtpConclude.Text),
                TimePreferred=strTimePreferred,
                InternshipType=strInternshipType,
                Amount=txtAmount.Text

            };

            DIL.SaveRecord(db, record);
        }
        void UpdateRecord()
        {

            AssignDataToVariables();
            int serialNo = int.Parse(txtSerialNo.Text);

            internship record = db.internships.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
            record.Name=txtName.Text;
            record.MobileNo = txtMobile.Text;
            record.Email_ID = txtEmail.Text;
            record.Gender = strGender;
            record.Address = txtAddress.Text;
            record.Notes = txtNotes.Text;
            record.CollegeName = txtCollegeName.Text;
            record.StudentMajor = txtStudentMajor.Text;
            record.YearOfPassing = int.Parse(txtYearOfPassing.Text);
            record.Position = txtPosition.Text;
            record.JoinedDate = DateTime.Parse(dtpJoined.Text);
            record.ConcludeDate = DateTime.Parse(dtpConclude.Text);
            record.TimePreferred = strTimePreferred;
            record.InternshipType = strInternshipType;
            record.Amount = txtAmount.Text;



            DIL.UpdateRecord(db, record);

        }

        void DeleteRecord()
        {
            if (MsgBox.AskYesNo("Do you want to Delete Record ?", "Confirm Delete") == DialogResult.Yes)
            {
                DIL.DeleteRecord(db, int.Parse(txtSerialNo.Text), "Internship");
            }
        }

        void ShowRecord(int serialNo)
        {
            ClearControls();
            try
            {
                internship record = db.internships.SingleOrDefault(r => r.SerialNo == serialNo);
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
                
                txtPosition.Text=record.Position;
                dtpJoined.Text = record.JoinedDate.ToString();
                dtpConclude.Text = record.ConcludeDate.ToString();
                pnlTimePreferred.StringToCheckedItems(record.TimePreferred);
                pnl_InternshipType.StringToCheckedItems(record.InternshipType);
                txtAmount.Text = record.Amount;



            }
            catch(Exception ex)
            {
                MsgBox.Error(ex.Message);
            }
        }

        void SearchRecord(string name)
        {
            string query;
           query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`internships` WHERE LOWER(CONVERT(`name` USING utf8)) LIKE '%" + name + "%'";
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
            if (txtSerialNo.IsNewRecord("internships") == true)
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
