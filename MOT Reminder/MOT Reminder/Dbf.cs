using System;
using System.Data;
using System.Data.OleDb;
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
                string mySQL = "select * from car";  // dbf table name
                OleDbCommand MyQuery = new OleDbCommand(mySQL, connection);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(data);
                connection.Close();
            }
                return data;
        }

        public static DataTable getCustomerData()
        {
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(
            @"Provider=VFPOLEDB.1;Data Source=C:\GarageGSSL\garage\data\customer.dbf");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string mySQL = "select * from customer";  // dbf table name
                OleDbCommand MyQuery = new OleDbCommand(mySQL, connection);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataRow[] Query()
        {
            DateTime now = DateTime.Now;
            string nnow = now.ToString("MM/dd/yyyy");
            string month = now.AddMonths(1).ToString("MM/dd/yyyy");
            DataRow[] result = getCarData().Select(String.Format("mot_duen <= #{0}# AND mot_duen >= #{1}# AND CCode <> ''", month, nnow));
            return result;
        }
}
}