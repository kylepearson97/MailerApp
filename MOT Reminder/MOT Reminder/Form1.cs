using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOT_Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataRow[] data = Dbf.motQuery();
            if (data.Length > 0)
                {
            DataTable display = data.CopyToDataTable();
                dataGridView1.DataSource = display;
            }
            DataTable customers = new DataTable();
            customers.Columns.Add("reg",typeof(string));
            customers.Columns.Add("CCode", typeof(string));
            customers.Columns.Add("mot_duen", typeof(DateTime));
            customers.Columns.Add("mobile", typeof(string));
            customers.Columns.Add("email", typeof(string));
            customers.Columns.Add("entered", typeof(DateTime));
            foreach (DataRow row in data)
                {
                DataRow custinfo = Dbf.getCustomerData(row[1].ToString());
                    Console.WriteLine(custinfo["mobile"]);
                }
                      
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.messageDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messageDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.messageDataSet.Table);

        }
    }
}
