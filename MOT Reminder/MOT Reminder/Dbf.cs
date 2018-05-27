using System;
using System.Data;
using System.Data.OleDb;
namespace MOT_Reminder
{
    static class Dbf
    {
        public static DataTable getData()
        {
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(
            @"Provider=VFPOLEDB.1;Data Source=C:\Users\Sam\Desktop\car.dbf");

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
        
        
       
    }
}