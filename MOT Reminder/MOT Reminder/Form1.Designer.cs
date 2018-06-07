namespace MOT_Reminder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motduenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkmessageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageDataSet = new MOT_Reminder.messageDataSet();
            this.tableTableAdapter = new MOT_Reminder.messageDataSetTableAdapters.TableTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MOT_Reminder.Properties.Resources.Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(324, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 91);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regDataGridViewTextBoxColumn,
            this.cCodeDataGridViewTextBoxColumn,
            this.motduenDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enteredDataGridViewTextBoxColumn,
            this.checkmessageDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 143);
            this.dataGridView1.TabIndex = 1;
            // 
            // regDataGridViewTextBoxColumn
            // 
            this.regDataGridViewTextBoxColumn.DataPropertyName = "reg";
            this.regDataGridViewTextBoxColumn.HeaderText = "reg";
            this.regDataGridViewTextBoxColumn.Name = "regDataGridViewTextBoxColumn";
            this.regDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCodeDataGridViewTextBoxColumn
            // 
            this.cCodeDataGridViewTextBoxColumn.DataPropertyName = "CCode";
            this.cCodeDataGridViewTextBoxColumn.HeaderText = "CCode";
            this.cCodeDataGridViewTextBoxColumn.Name = "cCodeDataGridViewTextBoxColumn";
            this.cCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motduenDataGridViewTextBoxColumn
            // 
            this.motduenDataGridViewTextBoxColumn.DataPropertyName = "mot_duen";
            this.motduenDataGridViewTextBoxColumn.HeaderText = "mot_duen";
            this.motduenDataGridViewTextBoxColumn.Name = "motduenDataGridViewTextBoxColumn";
            this.motduenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enteredDataGridViewTextBoxColumn
            // 
            this.enteredDataGridViewTextBoxColumn.DataPropertyName = "entered";
            this.enteredDataGridViewTextBoxColumn.HeaderText = "entered";
            this.enteredDataGridViewTextBoxColumn.Name = "enteredDataGridViewTextBoxColumn";
            this.enteredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkmessageDataGridViewCheckBoxColumn
            // 
            this.checkmessageDataGridViewCheckBoxColumn.DataPropertyName = "checkmessage";
            this.checkmessageDataGridViewCheckBoxColumn.HeaderText = "checkmessage";
            this.checkmessageDataGridViewCheckBoxColumn.Name = "checkmessageDataGridViewCheckBoxColumn";
            this.checkmessageDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.messageDataSetBindingSource;
            // 
            // messageDataSetBindingSource
            // 
            this.messageDataSetBindingSource.DataSource = this.messageDataSet;
            this.messageDataSetBindingSource.Position = 0;
            // 
            // messageDataSet
            // 
            this.messageDataSet.DataSetName = "messageDataSet";
            this.messageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(196, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 155);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 448);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource messageDataSetBindingSource;
        private messageDataSet messageDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private messageDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motduenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkmessageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

