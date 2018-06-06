﻿using System;
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
            Dbf.addToAppDatabase();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in AppDatabase.CustomersToText())
            {
                AppDatabase.updateMessage(row["reg"].ToString());
            }
        }
    }
}
