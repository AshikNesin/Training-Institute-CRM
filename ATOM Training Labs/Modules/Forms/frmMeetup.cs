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
    public partial class frmMeetup : Form
    {
        public string strGender = null,strIntrested=null;
        public DBEntities db = new DBEntities();
        public frmMeetup()
        {
            InitializeComponent();
        }

        

        private void frmMeetup_Load(object sender, EventArgs e)
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
            txtSerialNo.Text = txtSerialNo.GetNewSerialNo("meetups");
        }

        private void AssignDefaultValues()
        {
            //Assign default values for radiobuttons
            if (rbMale.Checked == false && rbFemale.Checked == false) { rbMale.Checked = true; }
            


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
            strIntrested = pnl_Intrested.CheckedItemsToString();


        }

         void SaveRecord()
        {
            AssignDataToVariables();
            meetup record = new meetup
            {
                SerialNo = int.Parse(txtSerialNo.Text),
                Name = txtName.Text,
                MobileNo = txtMobile.Text,
                Email_ID = txtEmail.Text,
                Gender = strGender,
                Address = txtAddress.Text,
                Interested=strIntrested, 
                CollegeName = txtCollegeName.Text,
                StudentMajor = txtStudentMajor.Text,
                YearOfPassing = int.Parse(txtYearOfPassing.Text),
                //Event 1
                Event1Date=DateTime.Parse(dtpEvent1.Text),
                Event1Topic=txtEvent1_Topic.Text,
                Event1Notes=txtEvent1_Notes.Text,
                //Event 2
                Event2Date = DateTime.Parse(dtpEvent2.Text),
                Event2Topic = txtEvent2_Topic.Text,
                Event2Notes = txtEvent2_Notes.Text,
                //Event 3
                Event3Date = DateTime.Parse(dtpEvent3.Text),
                Event3Topic = txtEvent3_Topic.Text,
                Event3Notes = txtEvent3_Notes.Text,

               

            };

            DIL.SaveRecord(db, record);
        }
         void UpdateRecord()
         {

             AssignDataToVariables();
             int serialNo = int.Parse(txtSerialNo.Text);

             meetup record = db.meetups.SingleOrDefault(srlNo => srlNo.SerialNo == serialNo);
             record.Name = txtName.Text;
             record.MobileNo = txtMobile.Text;
             record.Email_ID = txtEmail.Text;
             record.Gender = strGender;
             record.Address = txtAddress.Text;
             record.CollegeName = txtCollegeName.Text;
             record.StudentMajor = txtStudentMajor.Text;
             record.YearOfPassing = int.Parse(txtYearOfPassing.Text);
     
             //Event 1
             record.Event1Date = DateTime.Parse(dtpEvent1.Text);
             record.Event1Topic = txtEvent1_Topic.Text;
             record.Event1Notes = txtEvent1_Notes.Text;
             //Event2
             record.Event2Date = DateTime.Parse(dtpEvent2.Text);
             record.Event2Topic = txtEvent2_Topic.Text;
             record.Event2Notes = txtEvent2_Notes.Text;
             //Event 3
             record.Event3Date = DateTime.Parse(dtpEvent3.Text);
             record.Event3Topic = txtEvent3_Topic.Text;
             record.Event3Notes = txtEvent3_Notes.Text;

             DIL.UpdateRecord(db, record);

         }

         void DeleteRecord()
         {
             if (MsgBox.AskYesNo("Do you want to Delete Record ?", "Confirm Delete") == DialogResult.Yes)
             {
                 DIL.DeleteRecord(db, int.Parse(txtSerialNo.Text), "Meetup");
             }
         }

         void ShowRecord(int serialNo)
         {
             ClearControls();
             try
             {
                 meetup record = db.meetups.SingleOrDefault(r => r.SerialNo == serialNo);
                 txtSerialNo.Text = record.SerialNo.ToString();
                 txtName.Text = record.Name;
                 txtMobile.Text = record.MobileNo;
                 txtEmail.Text = record.Email_ID;
                 pnlGender.StringToCheckedItems(record.Gender);
                 txtAddress.Text = record.Address;
                 txtCollegeName.Text = record.CollegeName;
                 txtStudentMajor.Text = record.StudentMajor;
                 txtYearOfPassing.Text = record.YearOfPassing.ToString();
                 //Event 1
                 txtEvent1_Topic.Text = record.Event1Topic;
                 txtEvent1_Notes.Text = record.Event1Notes;
                 dtpEvent1.Text = record.Event1Date.ToString();
                 //Event 2
                 txtEvent2_Topic.Text = record.Event2Topic;
                 txtEvent2_Notes.Text = record.Event2Notes;
                 dtpEvent2.Text = record.Event2Date.ToString();
                 //Event 3
                 txtEvent3_Topic.Text = record.Event3Topic;
                 txtEvent3_Notes.Text = record.Event3Notes;
                 dtpEvent3.Text = record.Event3Date.ToString();

                 pnl_Intrested.StringToCheckedItems(record.Interested);

             }
             catch (Exception ex)
             {
                 MsgBox.Error(ex.Message);
             }
         }

         void SearchRecord(string name)
         {
             string query;
             query = "SELECT SerialNo,Name,CollegeName FROM `ATOM`.`meetups` WHERE LOWER(CONVERT(`name` USING utf8)) LIKE '%" + name + "%'";
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

         private void dtpEvent1_ValueChanged(object sender, EventArgs e)
         {

         }

   

      










    }
}
