using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace MOT_Reminder
{
    static class Dbf
    {
        public static DataTable getCarData()
        {
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(
            @"Provider=VFPOLEDB.1;Data Source=C:\GarageGSSL\garage\data\car.dbf");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string mySQL = "select reg, ccode, mot_duen from car";  // dbf table name
                OleDbCommand MyQuery = new OleDbCommand(mySQL, connection);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(data);
                connection.Close();
            }
                return data;
        }

        
        public static DataRow getCustomerData(string ccode)
        {
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(
            @"Provider=VFPOLEDB.1;Data Source=C:\GarageGSSL\garage\data\customer.dbf");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string mySQL = string.Format("select mobile, email from customer WHERE CCode ='{0}'",ccode);  // dbf table name
                OleDbCommand MyQuery = new OleDbCommand(mySQL, connection);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(data);
                connection.Close();
            }
            return data.Rows[0];
        }
        public static DataRow[] motQuery()
        {
            DateTime now = DateTime.Now;
            string nnow = now.ToString("MM/dd/yyyy");
            string month = now.AddMonths(1).ToString("MM/dd/yyyy");
            DataRow[] result = getCarData().Select(String.Format("mot_duen <= #{0}# AND mot_duen >= #{1}# AND CCode <> ''", month, nnow));
            return result;
        }

        public static void addToAppDatabase()
        {

            DataRow[] data = Dbf.motQuery();
            List<DataRow> newrows = new List<DataRow>();
            var connectionstring = Properties.Settings.Default.messageConnectionString;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connection.ConnectionString = connectionstring;
            connection.Open();
            foreach (DataRow row in data)
            {
                DataRow custinfo = Dbf.getCustomerData(row[1].ToString());
                string custmo = custinfo["mobile"].ToString();
                if (custmo.Contains("0"))
                {
                    

                    string reg = row[0].ToString().Trim();
                    string ccode = row[1].ToString().Trim();
                    string mot = DateTime.Parse(row[2].ToString()).ToShortDateString();
                    string mobile = custmo.Trim();
                    string email = "NA";
                    string now = DateTime.Now.ToShortDateString();
                    bool txted =  false;
                    string sql = string.Format("INSERT INTO [dbo].[Table] (reg, CCode, mot_duen, mobile, email, entered, checkmessage) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6})", reg, ccode, mot, mobile, email, now, txted);
                    cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }

            }
            
        }


}
}