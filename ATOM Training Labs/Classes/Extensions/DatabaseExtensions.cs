using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace ATOM
{
    public static class  DatabaseExtensions
    {
        public static DBEntities db = new DBEntities();
        public static string  connString = "server=localhost;user id=root;password=root;database=atom;";

        public static int RetrieveLastSerialNo(this TextBox txtBox, string tableName, string columnName)
        {
            //creating connection with MySQL server.
            MySqlConnection myConn = new MySqlConnection(connString);
            string query = "SELECT " + columnName + " FROM " + tableName;
            //defining Datadater
            MySqlDataAdapter sda = new MySqlDataAdapter(query, myConn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);
            int SerialNo;
            //this condition checks that table is empty
            // or not if table is empty that serial no is 1000
            if (ds.Tables[0].Rows.Count == 0)
            {
                SerialNo = 1000;
            }
            else
            {
                string s = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][columnName].ToString();
                SerialNo = int.Parse(s);
            }
            return SerialNo;
        }
        
    }
}
