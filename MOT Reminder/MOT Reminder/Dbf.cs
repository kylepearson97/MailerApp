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
                    DateTime mot = DateTime.Parse(row[2].ToString());
                    string mobile = custmo.Trim();
                    string email = "NA";
                    DateTime now = DateTime.Now;
                    bool txted =  false;
                    string sql = "INSERT INTO[dbo].[Table]([reg], [CCode], [mot_duen], [mobile], [email], [entered], [checkmessage]) VALUES(@reg, @CCode, @mot_duen, @mobile, @email, @entered, @checkmessage);";
        cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@reg",reg);
                    cmd.Parameters.AddWithValue("@CCode",ccode);
                    cmd.Parameters.AddWithValue("@mot_duen",mot);
                    cmd.Parameters.AddWithValue("@mobile",mobile);
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@entered",now);
                    cmd.Parameters.AddWithValue("@checkmessage",txted);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Record Already In Database");
                    }
                }

            }
            
        }


}
}