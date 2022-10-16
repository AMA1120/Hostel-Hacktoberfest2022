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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var employee = new Employee();
            employee.Closed += (s, args) => this.Close();
            employee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var about__Us = new About__Us();
            about__Us.Closed += (s, args) => this.Close();
            about__Us.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Pages\WindowsFormsApp1 new\WindowsFormsApp1\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string student_name = txtname.Text;
            int student_id = int.Parse(txtid.Text);
            int phone_number = int.Parse(txtphone.Text);
            float Batch = float.Parse(txtbatch.Text);
            string Email = txtmail.Text;
            string Msg = txtmsg.Text;

            string qry = "INSERT INTO students values('" + student_name + "','" + student_id + "','" + phone_number + "','" + Batch + "','" + Email + "','" + Msg + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home_Page = new Home_Page();
            home_Page.Closed += (s, args) => this.Close();
            home_Page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var facilities = new Facilities();
            facilities.Closed += (s, args) => this.Close();
            facilities.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to log out ??", "Confirm log out!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            { // If 'Yes', do something here. } else { // If 'No', do something here. }
                this.Hide();
                var form2 = new Login();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                this.Hide();
                var students = new Students();
                students.Closed += (s, args) => this.Close();
                students.Show();
            }
        }

    }
}
