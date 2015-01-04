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
    public partial class frmAdmission : Form
    {
        string strGender = null,strCertificateStatus = null;
        public  string strProfession = null;
        public string strCollegeName=null, strStudentMajor = null;
        public  string strCompanyName = null, strEmployeeDesignation = null;
        public  DBEntities db = new DBEntities();
        public frmAdmission()
        {
            InitializeComponent();
        }

        
        private void frmAdmission_Load(object sender, EventArgs e)
        {
            DefaultProperties();
            //DummyQuery();
            
              
        }

        #region ApplicationInterfaceLayer
        private void DefaultProperties()
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = false; }

        }
        private void GetNextSerialNo() { 
            txtSerialNo.Text = txtSerialNo.GetNewSerialNo("admissions"); }

        private void AssignDefaultValues()
        {

            //Assign default values for radiobuttons
            if (rbCertificateNotRecieved.Checked == false && rbCertificateRecieved.Checked == false) { rbCertificateNotRecieved.Checked = true; }
            if (rbMale.Checked == false && rbFemale.Checked == false) { rbMale.Checked = true; }
            if (cmbProfession.SelectedText.Equals(string.Empty)) { cmbProfession.Text = "Student"; }
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

            strCertificateStatus = pnlCertificateStatus.CheckedItemsToString();
            strGender = pnlGender.CheckedItemsToString();
            strProfession = cmbProfession.Text;

            if (txtCollegeName.IsNotEmpty()) { strCollegeName = txtCollegeName.Text; }
            if (txtStudentMajor.IsNotEmpty()) { strStudentMajor = txtStudentMajor.Text; }
            if (txtCompanyName.IsNotEmpty()) { strCompanyName = txtCompanyName.Text; }
            if (txtEmpDesignation.IsNotEmpty()) { strEmployeeDesignation = txtEmpDesignation.Text; }

        }
        public void SaveRecord()
        {

            
            AssignDataToVariables();

            admission record = new admission
            {

                SerialNo = int.Parse(txtSerialNo.Text),
                DateOfJoining = DateTime.Parse(dtpDOJ.Text),
                Name = txtName.Text,
                MobileNo = txtMobile.Text,
                Email_ID = txtEmail.Text,
                Gender = strGender,
                DOB = DateTime.Parse(dtpDOB.Text),
                Address = txtAddress.Text,
                Notes = txtNotes.Text,
                WhatProfession = strProfession,
                CollegeName = txtCollegeName.Text,
                StudentMajor = txtStudentMajor.Text,
                CompanyName = strCompanyName,
                EmployeeDesignation = strEmployeeDesignation,
                CourseTaken = txtCourseTaken.Text,
                CourseFee = txtCourseFee.Text,
                CertificateStatus = strCertificateStatus,
                CourseEnd = DateTime.Parse(dtpCourseEnd.Text),
                BreakOfStudy = txtBreakOfStudy.Text
            };

            DIL.SaveRecord(db, record);

            
        }
        public void UpdateRecord()
        {
            AssignDataToVariables();
            int serialNo = int.Parse(txtSerialNo.Text);
   
            admission record = db.admissions.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
            record.DateOfJoining = DateTime.Parse(dtpDOJ.Text);
            record.Name = txtName.Text;
            record.MobileNo = txtMobile.Text;
            record.Email_ID = txtEmail.Text;
            record.Gender = strGender;
            record.DOB = DateTime.Parse(dtpDOB.Text);
            record.Address = txtAddress.Text;
            record.Notes = txtNotes.Text;
            record.WhatProfession = strProfession;
            record.CollegeName = strCollegeName;
            record.StudentMajor = strStudentMajor;
            record.CompanyName = strCompanyName;
            record.EmployeeDesignation = strEmployeeDesignation;
            record.CourseTaken = txtCourseTaken.Text;
            record.CourseFee = txtCourseFee.Text;
            record.CertificateStatus = strCertificateStatus;
            record.CourseEnd = DateTime.Parse(dtpCourseEnd.Text);
            record.BreakOfStudy = txtBreakOfStudy.Text;
            DIL.UpdateRecord(db,record);
            }

        private void ShowRecord(int serialNo)
        {
            DBEntities db = new DBEntities();
            ClearControls();
            try
            {
                admission record = db.admissions.SingleOrDefault(r => r.SerialNo == serialNo);
                txtSerialNo.Text = record.SerialNo.ToString();
                dtpDOJ.Text = record.DateOfJoining.ToString();
                txtName.Text = record.Name;
                txtMobile.Text = record.MobileNo;
                txtEmail.Text = record.Email_ID;
                pnlGender.StringToCheckedItems(record.Gender);
                dtpDOB.Text = record.DOB.ToString();
                txtAddress.Text = record.Address;
                txtNotes.Text = record.Notes;
                cmbProfession.Text= (record.WhatProfession);
                txtCollegeName.Text = record.CollegeName;
                txtStudentMajor.Text = record.StudentMajor;
                txtCompanyName.Text = record.CompanyName;
                txtEmpDesignation.Text = record.EmployeeDesignation;
                txtCourseTaken.Text = record.CourseTaken;
                txtCourseFee.Text = record.CourseFee;
                txtBreakOfStudy.Text = record.BreakOfStudy;
                dtpCourseEnd.Text = record.CourseEnd.ToString();
                pnlCertificateStatus.StringToCheckedItems(record.CertificateStatus);

            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
            }

        }
        private void SearchRecord(string name)
        {
            string query;
            if (rbStudentNameSearch.Checked == true)
            {
                query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`admissions` WHERE LOWER(CONVERT(`name` USING utf8)) LIKE '%" + name + "%'";
            }
            else {
                query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`admissions` WHERE LOWER(CONVERT(`CollegeName` USING utf8)) LIKE '%" + name + "%'";
            }
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
            admission dummy = db.admissions.SingleOrDefault(p => p.SerialNo == 0);
        }

        #endregion


        #region Buttons
        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer.Panel2.Controls) { c.Enabled = true; }
            GetNextSerialNo();
            ClearControls();
            AssignDefaultValues();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (MsgBox.AskYesNo("Do you want to Delete Record ?", "Confirm Delete") == DialogResult.Yes)
            {
                DIL.DeleteRecord(db, int.Parse(txtSerialNo.Text), "Admission");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.IsEmpty()) { MsgBox.Error("Please Enter your Name.","TextBox is Empty"); txtName.Focus(); return;}
            if (txtSerialNo.IsNewRecord("admissions") == true)
            {
                SaveRecord();
            }
            else
            {
                UpdateRecord();
            }
        }

        #endregion

        private void btnEmail_Click(object sender, EventArgs e)
        {
            

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

        private void gbPersonalProfile_Enter(object sender, EventArgs e)
        {

        }













        



        

        





    }
}

       
    

