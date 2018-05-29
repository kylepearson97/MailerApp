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
            Dbf.addToAppDatabase();
            this.tableTableAdapter.Fill(this.messageDataSet.Table);

        }
    }
}
