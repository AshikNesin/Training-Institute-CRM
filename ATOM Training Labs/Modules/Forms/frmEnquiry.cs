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
    public partial class frmEnquiry : Form
    {
        public string strGender = null;
        public string strProfession = null;
        public string strCollegeName=null, strStudentMajor = null;
        public string strCompanyName = null, strEmployeeDesignation = null;
        public string strInterested=null, strTimePreferred=null, strReferrals=null;
        public string strEnrollmentStatus = null;
        public DBEntities db = new DBEntities();
        public frmEnquiry()
        {
            InitializeComponent();
        }

  

    
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEnquiry_Load(object sender, EventArgs e)
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
            txtSerialNo.Text = txtSerialNo.GetNewSerialNo("enquiries");
        }

        private void AssignDefaultValues()
        {

            //Assign default values for radiobuttons
            if (rbMale.Checked == false && rbFemale.Checked == false) { rbMale.Checked = true; }
            if (cmbProfession.SelectedText.Equals(string.Empty)) { cmbProfession.Text = "Student"; }
            if (rbJoined.Checked == false && rbNotJoined.Checked == false) { rbJoined.Checked = true; }
            if (rbJoined.Checked == false && rbNotJoined.Checked == false) { rbNotJoined.Checked = true; }
        }

        private void ClearControls()
        {
            splitContainer.Panel2.ClearAllControls();
        }

        //================================== CONTROLS =========================================================//
        private void cmbProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProfession.Text)
            {


                case "Student":
                    {
                        whatProfession(true, false, false);

                        break;
                    }
                case "Employee":
                    {
                        whatProfession(false, true, false);
                        break;
                    }
                case "Others":
                    {
                        whatProfession(false, false, true);
                        break;
                    }
            }
        }

        void whatProfession(bool isStudent, bool isEmployee, bool isOthers)
        {
            txtCollegeName.Enabled = isStudent;
            txtStudentMajor.Enabled = isStudent;
            txtCompanyName.Enabled = isEmployee;
            txtEmpDesignation.Enabled = isEmployee;


        }

        #endregion

        #region DataInterfaceLayer
        public void AssignDataToVariables()
        {
            //Analyze the radiobutton & assign it to variables

            
            strGender = pnlGender.CheckedItemsToString();
            strProfession = cmbProfession.Text;

            if (txtCollegeName.IsNotEmpty()) { strCollegeName = txtCollegeName.Text; }
            if (txtStudentMajor.IsNotEmpty()) { strStudentMajor = txtStudentMajor.Text; }
            if (txtCompanyName.IsNotEmpty()) { strCompanyName = txtCompanyName.Text; }
            if (txtEmpDesignation.IsNotEmpty()) { strEmployeeDesignation = txtEmpDesignation.Text; }

            strEnrollmentStatus = pnlEnrollmentStatus.CheckedItemsToString();
            strInterested = pnlInterested.CheckedItemsToString();
            strReferrals = pnlReferral.CheckedItemsToString();
            

        }

        void SaveRecord()
        {
            AssignDataToVariables();
            enquiry record = new enquiry
            {
                SerialNo=int.Parse(txtSerialNo.Text),
                DateOfEnquiry=DateTime.Parse(dtpEnquiry.Text),
                Name=txtName.Text,
                MobileNo=txtMobile.Text,
                Email_ID=txtEmail.Text,
                Gender=strGender,
                Address=txtAddress.Text,
                Mode=cmbMode.Text,
                Notes=txtNotes.Text,
                Interested=strInterested,
                Referrals=strReferrals,
                Profession=strProfession,
                CollegeName=strCollegeName,
                StudentMajor=strStudentMajor,
                CompanyName=strCompanyName,
                EmpDesignation=strEmployeeDesignation,
                WhoTheyMet=cmbWhoTheyMet.Text,
                Discussion=txtDiscussion.Text,
                EnrollmentStatus=strEnrollmentStatus,
                TimePreferred=cmbTimePreferred.Text,
                FollowUp=cmbFollowUp.Text
                

            };
            DIL.SaveRecord(db, record);

        }
        void UpdateRecord()
        {
            AssignDataToVariables();
            int serialNo = int.Parse(txtSerialNo.Text);

            enquiry record = db.enquiries.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
            record.DateOfEnquiry=DateTime.Parse(dtpEnquiry.Text);
            record.Name = txtName.Text;
            record.MobileNo = txtMobile.Text;
            record.Email_ID = txtEmail.Text;
            record.Gender = strGender;
            record.Address = txtAddress.Text;
            record.Mode = cmbMode.Text;
            record.Notes = txtNotes.Text;
            record.Interested = strInterested;
            record.Referrals = strReferrals;
            record.Profession = strProfession;
            record.CollegeName = strCollegeName;
            record.StudentMajor = strStudentMajor;
            record.CompanyName = strCompanyName;
            record.EmpDesignation = strEmployeeDesignation;
            record.WhoTheyMet = cmbWhoTheyMet.Text;
            record.Discussion = txtDiscussion.Text;
            record.EnrollmentStatus = strEnrollmentStatus;
            record.TimePreferred = cmbTimePreferred.Text;
            record.FollowUp = cmbFollowUp.Text;
            DIL.UpdateRecord(db, record);    
            
        }

        void DeleteRecord()
        {

            if (MsgBox.AskYesNo("Do you want to Delete Record ?", "Confirm Delete") == DialogResult.Yes)
            {
                DIL.DeleteRecord(db, int.Parse(txtSerialNo.Text), "Enquiry");
            }
        }
        void ShowRecord(int serialNo)
        {

            enquiry record = db.enquiries.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
            txtSerialNo.Text = record.SerialNo.ToString();
            dtpEnquiry.Text = record.DateOfEnquiry.ToString();
            txtName.Text = record.Name;
            txtMobile.Text = record.MobileNo;
            txtEmail.Text = record.Email_ID;
            pnlGender.StringToCheckedItems(record.Gender);

            record.Address = txtAddress.Text = record.Address;
            record.Mode = cmbMode.Text = record.Mode;
            record.Notes = txtNotes.Text = record.Notes;

            pnlInterested.StringToCheckedItems(record.Interested);
            pnlReferral.StringToCheckedItems(record.Referrals);

            cmbProfession.Text = record.Profession;
            txtCollegeName.Text = record.CollegeName;
            txtStudentMajor.Text = record.StudentMajor;

            txtCompanyName.Text = record.CompanyName;
            txtEmpDesignation.Text = record.EmpDesignation;

            cmbWhoTheyMet.Text = record.WhoTheyMet;
            txtDiscussion.Text = record.Discussion;

            pnlEnrollmentStatus.StringToCheckedItems(record.EnrollmentStatus);

            cmbTimePreferred.Text = record.TimePreferred;
            cmbFollowUp.Text = record.FollowUp;
        }

        private void SearchRecord(string name)
        {
            string query;
            query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`enquiries` WHERE LOWER(CONVERT(`name` USING utf8)) LIKE '%" + name + "%'";
            
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
            enquiry dummy = db.enquiries.SingleOrDefault(p => p.SerialNo == 0);
        }

        #endregion

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.IsEmpty()) { MsgBox.Error("Please Enter your Name.", "TextBox is Empty"); txtName.Focus(); return; }
            if (txtSerialNo.IsNewRecord("enquiries") == true)
            {
                SaveRecord();
            }
            else
            {
                UpdateRecord();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();

        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = true; }
            GetNextSerialNo();
            ClearControls();
            AssignDefaultValues();
       
        }

        #endregion

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtSearchBox.Text);
            if (txtSearchBox.IsEmpty())
            {
                dgvResults.DataSource = null;
                dgvResults.Refresh();

            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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



    }
}
