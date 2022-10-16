namespace WindowsFormsApp1
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
            this.search_btn = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentdataDataSet = new WindowsFormsApp1.studentdataDataSet();
            this.hostelstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hostelstudentTableAdapter = new WindowsFormsApp1.studentdataDataSetTableAdapters.hostelstudentTableAdapter();
            this.hostelstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_btn.Location = new System.Drawing.Point(1099, 560);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(155, 66);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "REFRESH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Location = new System.Drawing.Point(213, 324);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(242, 47);
            this.txtphone.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(213, 240);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(242, 42);
            this.txtNumber.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Location = new System.Drawing.Point(213, 148);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(242, 48);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(213, 58);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 49);
            this.txtname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 346);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 171);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.update_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.update_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Location = new System.Drawing.Point(465, 588);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(151, 68);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(35, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn.Location = new System.Drawing.Point(251, 586);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(162, 68);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.panel2.Location = new System.Drawing.Point(26, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 421);
            this.panel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1234, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "LOG OUT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1107, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.nsbm_logo_favicon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdnameDataGridViewTextBoxColumn,
            this.stdidDataGridViewTextBoxColumn,
            this.stdroomDataGridViewTextBoxColumn,
            this.stdphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hostelstudentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(519, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(846, 417);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 102);
            this.panel1.TabIndex = 12;
            // 
            // studentdataDataSet
            // 
            this.studentdataDataSet.DataSetName = "studentdataDataSet";
            this.studentdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostelstudentBindingSource1
            // 
            this.hostelstudentBindingSource1.DataMember = "hostelstudent";
            this.hostelstudentBindingSource1.DataSource = this.studentdataDataSet;
            // 
            // hostelstudentTableAdapter
            // 
            this.hostelstudentTableAdapter.ClearBeforeFill = true;
            // 
            // hostelstudentBindingSource
            // 
            this.hostelstudentBindingSource.DataMember = "hostelstudent";
            // 
            // stdnameDataGridViewTextBoxColumn
            // 
            this.stdnameDataGridViewTextBoxColumn.DataPropertyName = "stdname";
            this.stdnameDataGridViewTextBoxColumn.HeaderText = "NAME OF STUDENT";
            this.stdnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stdnameDataGridViewTextBoxColumn.Name = "stdnameDataGridViewTextBoxColumn";
            this.stdnameDataGridViewTextBoxColumn.Width = 400;
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "stdid";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "STUDENT ID";
            this.stdidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.Width = 150;
            // 
            // stdroomDataGridViewTextBoxColumn
            // 
            this.stdroomDataGridViewTextBoxColumn.DataPropertyName = "stdroom";
            this.stdroomDataGridViewTextBoxColumn.HeaderText = "ROOM NUMBER";
            this.stdroomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stdroomDataGridViewTextBoxColumn.Name = "stdroomDataGridViewTextBoxColumn";
            this.stdroomDataGridViewTextBoxColumn.Width = 150;
            // 
            // stdphoneDataGridViewTextBoxColumn
            // 
            this.stdphoneDataGridViewTextBoxColumn.DataPropertyName = "stdphone";
            this.stdphoneDataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER";
            this.stdphoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stdphoneDataGridViewTextBoxColumn.Name = "stdphoneDataGridViewTextBoxColumn";
            this.stdphoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 695);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelstudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.BindingSource hostelstudentBindingSource;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private studentdataDataSet studentdataDataSet;
        private System.Windows.Forms.BindingSource hostelstudentBindingSource1;
        private studentdataDataSetTableAdapters.hostelstudentTableAdapter hostelstudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdphoneDataGridViewTextBoxColumn;
    }
}

