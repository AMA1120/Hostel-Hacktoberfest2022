using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class StudentComplain : Form
    {
        public StudentComplain()
        {
            InitializeComponent();
        }

        private void StudentComplain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;// TODO: This line of code loads data into the 'databaseDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.databaseDataSet.students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home_Page = new Home_Page();
            home_Page.Closed += (s, args) => this.Close();
            home_Page.Show();
        }
    }
}

