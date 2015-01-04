using System;
using System.Data;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data.Objects;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATOM
{
    /// <summary>
    /// Data Interface Layer
    /// </summary>
    public static class DIL
    {

        
        public static DBEntities GetEntity()
        {
            DBEntities db = new DBEntities();
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Port = 3306;
            sb.UserID = "root";
            sb.Password = "root";
            return db;
        }

        public static string connString = "server=localhost;user id=root;password=root;database=atom;";


        public static string GetNewSerialNo(this TextBox txtBox, string tableName, string columnName = "SerialNo")
        {
            string SerialNo;

            SerialNo = (string)(DatabaseExtensions.RetrieveLastSerialNo(txtBox, tableName, columnName) + 1).ToString();
            return SerialNo;
        }
        #region SaveToDB
        public static bool SaveRecord(DBEntities db, admission myRecord)
        {
            try
            {
                db.admissions.Add(myRecord);
                db.SaveChanges();
                
                MsgBox.Show("Record has been Saved!");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        public static bool UpdateRecord(DBEntities db, admission myRecord)
        {
            try
            {
                db.SaveChanges();
                MsgBox.Show("Record has been Updated to Database", "Info");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }

        public static bool SaveRecord(DBEntities db, enquiry EnquiryRecord)
        {
            try
            {
                db.enquiries.Add(EnquiryRecord);
                db.SaveChanges();
                MsgBox.Show("Record has been Saved!");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        public static bool UpdateRecord(DBEntities db, enquiry EnquiryRecord)
        {
            try
            {
                
                db.SaveChanges();
                MsgBox.Show("Record has been Updated to Database", "Info");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        public static bool SaveRecord(DBEntities db, internship InternshipRecord)
        {
            try
            {
                db.internships.Add(InternshipRecord);
                db.SaveChanges();
                MsgBox.Show("Record has been Saved!");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }

        public static bool UpdateRecord(DBEntities db, internship InternshipRecord)
        {
            try
            {
                
                db.SaveChanges();
                MsgBox.Show("Record has been Updated to Database", "Info");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }

        public static bool SaveRecord(DBEntities db, ipt iptRecord)
        {
            try
            {
                db.ipts.Add(iptRecord);
                db.SaveChanges();
                MsgBox.Show("Record has been Saved!");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        public static bool UpdateRecord(DBEntities db, ipt iptRecord)
        {
            try
            {
               
                db.SaveChanges();
                MsgBox.Show("Record has been Updated to Database", "Info");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        public static bool SaveRecord(DBEntities db, meetup MeetupRecord)
        {
            try
            {
                db.meetups.Add(MeetupRecord);
                db.SaveChanges();
                MsgBox.Show("Record has been Saved!");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }

        public static bool UpdateRecord(DBEntities db, meetup MeetupRecord)
        {
            try
            {
                
                db.SaveChanges();
                MsgBox.Show("Record has been Updated to Database", "Info");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                return false;
            }
        }
        #endregion

        public static bool IsNewRecord(this TextBox SerialNo,string TableName)
        {
            string query="SELECT * FROM "+TableName+" WHERE SerialNo = "+SerialNo.Text;
            MySqlConnection myConn= new MySqlConnection(connString);
            MySqlCommand SelectCommand= new MySqlCommand(query,myConn);
            MySqlDataReader myReader;
            int count=0;
            myConn.Open();
            myReader=SelectCommand.ExecuteReader();
            while(myReader.Read())
            {
                count=count+1;
            }
            
            if (count==1) { return false;}
            else { return true; }

        }




        public static bool DeleteRecord(DBEntities db, int SerialNo, string TableName)
        {

            switch(TableName)
            {

                case "Admission":
                    {
                        try
                        {
                            admission data = db.admissions.SingleOrDefault(atom => atom.SerialNo == SerialNo);
                            db.admissions.Remove(data);
                            db.SaveChanges();
                            MsgBox.Show("Record has been Deleted!", "Info");
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Error(ex.Message);
                            return false;
                        }
                        
                    }
                case "Enquiry":
                    {
                        try
                        {
                            enquiry data = db.enquiries.SingleOrDefault(atom => atom.SerialNo == SerialNo);
                            db.enquiries.Remove(data);
                            db.SaveChanges();
                            MsgBox.Show("Record has been Deleted!", "Info");
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Error(ex.Message);
                            return false;
                        }
                    }
               case "Internship":
                    {
                        try
                        {
                            internship data = db.internships.SingleOrDefault(atom => atom.SerialNo == SerialNo);
                            db.internships.Remove(data);
                            db.SaveChanges();
                            MsgBox.Show("Record has been Deleted!", "Info");
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Error(ex.Message);
                            return false;
                        }
                        
                    }
               case "IPT":
                    {
                        try
                        {
                            ipt data = db.ipts.SingleOrDefault(atom => atom.SerialNo == SerialNo);
                            db.ipts.Remove(data);
                            db.SaveChanges();
                            MsgBox.Show("Record has been Deleted!", "Info");
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Error(ex.Message);
                            return false;
                        }
                    }
               case "Meetup":
                    {
                        try
                        {
                            meetup data = db.meetups.SingleOrDefault(atom => atom.SerialNo == SerialNo);
                            db.meetups.Remove(data);
                            db.SaveChanges();
                            MsgBox.Show("Record has been Deleted!", "Info");
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Error(ex.Message);
                            return false;
                        }
                    }
              default:
                    {
                        return false;
                    }
                    }
         } 
            
  

           }
    
    }

