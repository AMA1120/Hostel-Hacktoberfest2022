namespace WindowsFormsApp3
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dB2DataSet = new WindowsFormsApp3.DB2DataSet();
            this.stdcomplaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdcomplaintsTableAdapter = new WindowsFormsApp3.DB2DataSetTableAdapters.stdcomplaintsTableAdapter();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdcomplaintsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.nsbm_logo_favicon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1008, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnameDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.msgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stdcomplaintsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Suggestions and Complaints";
            // 
            // dB2DataSet
            // 
            this.dB2DataSet.DataSetName = "DB2DataSet";
            this.dB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdcomplaintsBindingSource
            // 
            this.stdcomplaintsBindingSource.DataMember = "stdcomplaints";
            this.stdcomplaintsBindingSource.DataSource = this.dB2DataSet;
            // 
            // stdcomplaintsTableAdapter
            // 
            this.stdcomplaintsTableAdapter.ClearBeforeFill = true;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Student name";
            this.studentnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // msgDataGridViewTextBoxColumn
            // 
            this.msgDataGridViewTextBoxColumn.DataPropertyName = "Msg";
            this.msgDataGridViewTextBoxColumn.HeaderText = "Complaint";
            this.msgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.msgDataGridViewTextBoxColumn.Name = "msgDataGridViewTextBoxColumn";
            this.msgDataGridViewTextBoxColumn.Width = 500;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1164, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdcomplaintsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DB2DataSet dB2DataSet;
        private System.Windows.Forms.BindingSource stdcomplaintsBindingSource;
        private DB2DataSetTableAdapters.stdcomplaintsTableAdapter stdcomplaintsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgDataGridViewTextBoxColumn;
    }
}