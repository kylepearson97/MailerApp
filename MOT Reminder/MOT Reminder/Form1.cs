﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextmagicRest;
using TextmagicRest.Model;

namespace MOT_Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "SMS Sender";
            Console.WriteLine(AppDatabase.ConString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {                   
            dataGridView1.DataSource = AppDatabase.Customers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataRow row in AppDatabase.CustomersToText())
            {
                string mobile = row["mobile"].ToString().Trim().Substring(1, 10);
                mobile = "44" + mobile;
                DateTime Date = Convert.ToDateTime(row["mot_duen"]);
                var client = new Client("sammercer", "z1foJboqskng15nN4f3RnNoJNWadPL");
                var link = client.SendMessage(string.Format("Speedway Garage would like to remind you your M.O.T is Due on {0} for the registration {1} Call us today on 01724 783028", Date.ToShortDateString(), row["reg"].ToString().Trim()), mobile);
                if (link.Success)
                {
                    Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
                    richTextBox1.AppendText(Environment.NewLine + string.Format("Message ID {0} has been successfully sent", link.Id));
                    AppDatabase.updateMessage(row["reg"].ToString());
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Message was not sent due to following exception: {0}", link.ClientException.Message);
                    richTextBox1.AppendText(string.Format("Message was not sent due to following exception: {0} \n", link.ClientException.Message));
                }
                i++;
            }
            if (i < 1)
            {
                richTextBox1.AppendText("Nobody to message today!");
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine + "Finished!");
            }
        }


    }
}

