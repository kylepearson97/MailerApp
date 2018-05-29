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
           
                      
        }

        public void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.messageDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DOES NOT WORK
             DataRow[] newrows = Dbf.addToAppDatabase();
            foreach (DataRow row in newrows)
            {
                this.messageDataSet.Table.ImportRow(row);
            }
            this.tableTableAdapter.Update(this.messageDataSet.Table);
            this.tableTableAdapter.Fill(this.messageDataSet.Table);

        }
    }
}
