using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MOT_Reminder
{
    class AppDatabase
    {
        public static string ConString = Properties.Settings.Default.messageConnectionString;

        public static DataTable Customers()
        {
        DataTable data = new DataTable();
        SqlConnection connection = new SqlConnection(ConString);
            connection.Open();          
            string mySQL = "SELECT * FROM dbo.[Table]";
            SqlCommand MyQuery = new SqlCommand(mySQL,connection);
            SqlDataAdapter DA = new SqlDataAdapter(MyQuery);
            DA.Fill(data);
            connection.Close();

            return data;
        }

        public static DataRow[] CustomersToText()
        {
            DataRow[] result = Customers().Select("checkmessage = false");
            return result;
        }
        public static void updateMessage(string reg)
        {
            SqlConnection connection = new SqlConnection(ConString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "Update dbo.[Table] SET checkmessage = @val WHERE reg = @reg";
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@reg", reg);
            cmd.Parameters.AddWithValue("@val", true);
            cmd.ExecuteNonQuery();
        }
    }
}
