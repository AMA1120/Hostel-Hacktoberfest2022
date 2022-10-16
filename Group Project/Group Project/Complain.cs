using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_Project
{
    public partial class Complain : Form
    {
        public Complain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Group Project\EmployeeDatabase\Empdata.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From emptable where USERNAME='" + txt1.Text + "' and PASSWORD = '" + txt2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                var student = new StudentComplain();
                student.Closed += (s, args) => this.Close();
                student.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Complain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}

