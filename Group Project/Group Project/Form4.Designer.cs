namespace Group_Project
{
    partial class Form4
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTDnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentinfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empdataDataSet = new Group_Project.empdataDataSet();
            this.delete_btn = new System.Windows.Forms.Button();
            this.studentinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hostelstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinfoTableAdapter = new Group_Project.empdataDataSetTableAdapters.studentinfoTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkViolet;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(478, 628);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 55);
            this.button4.TabIndex = 40;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtphone);
            this.panel2.Controls.Add(this.txtNumber);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 510);
            this.panel2.TabIndex = 35;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Location = new System.Drawing.Point(203, 335);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(397, 45);
            this.txtphone.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(203, 250);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(397, 47);
            this.txtNumber.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Location = new System.Drawing.Point(203, 171);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(397, 47);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(203, 97);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(397, 37);
            this.txtname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number  :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID      :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 83);
            this.panel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1328, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_Project.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.update_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Location = new System.Drawing.Point(338, 628);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(125, 55);
            this.update_btn.TabIndex = 38;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(41, 630);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 55);
            this.button3.TabIndex = 36;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDnameDataGridViewTextBoxColumn,
            this.sTDidDataGridViewTextBoxColumn,
            this.sTDroomDataGridViewTextBoxColumn,
            this.sTDphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentinfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(647, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(845, 510);
            this.dataGridView1.TabIndex = 39;
            // 
            // sTDnameDataGridViewTextBoxColumn
            // 
            this.sTDnameDataGridViewTextBoxColumn.DataPropertyName = "STDname";
            this.sTDnameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.sTDnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDnameDataGridViewTextBoxColumn.Name = "sTDnameDataGridViewTextBoxColumn";
            this.sTDnameDataGridViewTextBoxColumn.Width = 350;
            // 
            // sTDidDataGridViewTextBoxColumn
            // 
            this.sTDidDataGridViewTextBoxColumn.DataPropertyName = "STDid";
            this.sTDidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.sTDidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDidDataGridViewTextBoxColumn.Name = "sTDidDataGridViewTextBoxColumn";
            this.sTDidDataGridViewTextBoxColumn.Width = 210;
            // 
            // sTDroomDataGridViewTextBoxColumn
            // 
            this.sTDroomDataGridViewTextBoxColumn.DataPropertyName = "STDroom";
            this.sTDroomDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.sTDroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDroomDataGridViewTextBoxColumn.Name = "sTDroomDataGridViewTextBoxColumn";
            this.sTDroomDataGridViewTextBoxColumn.Width = 210;
            // 
            // sTDphoneDataGridViewTextBoxColumn
            // 
            this.sTDphoneDataGridViewTextBoxColumn.DataPropertyName = "STDphone";
            this.sTDphoneDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.sTDphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDphoneDataGridViewTextBoxColumn.Name = "sTDphoneDataGridViewTextBoxColumn";
            this.sTDphoneDataGridViewTextBoxColumn.Width = 210;
            // 
            // studentinfoBindingSource2
            // 
            this.studentinfoBindingSource2.DataMember = "studentinfo";
            this.studentinfoBindingSource2.DataSource = this.empdataDataSet;
            // 
            // empdataDataSet
            // 
            this.empdataDataSet.DataSetName = "empdataDataSet";
            this.empdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn.Location = new System.Drawing.Point(184, 628);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(135, 55);
            this.delete_btn.TabIndex = 37;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // studentinfoBindingSource1
            // 
            this.studentinfoBindingSource1.DataMember = "studentinfo";
            // 
            // hostelstudentBindingSource1
            // 
            this.hostelstudentBindingSource1.DataMember = "hostelstudent";
            // 
            // studentinfoBindingSource
            // 
            this.studentinfoBindingSource.DataMember = "studentinfo";
            // 
            // hostelstudentBindingSource
            // 
            this.hostelstudentBindingSource.DataMember = "hostelstudent";
            // 
            // studentinfoTableAdapter
            // 
            this.studentinfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 701);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hostelstudentBindingSource1;
        private System.Windows.Forms.BindingSource studentinfoBindingSource;
        private System.Windows.Forms.BindingSource studentinfoBindingSource1;
        private System.Windows.Forms.BindingSource hostelstudentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_btn;
        private empdataDataSet empdataDataSet;
        private System.Windows.Forms.BindingSource studentinfoBindingSource2;
        private empdataDataSetTableAdapters.studentinfoTableAdapter studentinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDphoneDataGridViewTextBoxColumn;
    }
}