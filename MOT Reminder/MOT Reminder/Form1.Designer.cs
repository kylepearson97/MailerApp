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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messageDataSet = new MOT_Reminder.messageDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new MOT_Reminder.messageDataSetTableAdapters.TableTableAdapter();
            this.regDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motduenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkmessageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // messageDataSet
            // 
            this.messageDataSet.DataSetName = "messageDataSet";
            this.messageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.messageDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // regDataGridViewTextBoxColumn
            // 
            this.regDataGridViewTextBoxColumn.DataPropertyName = "reg";
            this.regDataGridViewTextBoxColumn.HeaderText = "reg";
            this.regDataGridViewTextBoxColumn.Name = "regDataGridViewTextBoxColumn";
            // 
            // cCodeDataGridViewTextBoxColumn
            // 
            this.cCodeDataGridViewTextBoxColumn.DataPropertyName = "CCode";
            this.cCodeDataGridViewTextBoxColumn.HeaderText = "CCode";
            this.cCodeDataGridViewTextBoxColumn.Name = "cCodeDataGridViewTextBoxColumn";
            // 
            // motduenDataGridViewTextBoxColumn
            // 
            this.motduenDataGridViewTextBoxColumn.DataPropertyName = "mot_duen";
            this.motduenDataGridViewTextBoxColumn.HeaderText = "mot_duen";
            this.motduenDataGridViewTextBoxColumn.Name = "motduenDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // enteredDataGridViewTextBoxColumn
            // 
            this.enteredDataGridViewTextBoxColumn.DataPropertyName = "entered";
            this.enteredDataGridViewTextBoxColumn.HeaderText = "entered";
            this.enteredDataGridViewTextBoxColumn.Name = "enteredDataGridViewTextBoxColumn";
            // 
            // checkmessageDataGridViewCheckBoxColumn
            // 
            this.checkmessageDataGridViewCheckBoxColumn.DataPropertyName = "checkmessage";
            this.checkmessageDataGridViewCheckBoxColumn.HeaderText = "checkmessage";
            this.checkmessageDataGridViewCheckBoxColumn.Name = "checkmessageDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MOT_Reminder.Properties.Resources.Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(761, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 91);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

