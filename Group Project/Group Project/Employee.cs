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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Student_Information student = new Student_Information();
            student.Show();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Complain student = new Complain();
            student.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home_Page = new Home_Page();
            home_Page.Closed += (s, args) => this.Close();
            home_Page.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var facilities = new Facilities();
            facilities.Closed += (s, args) => this.Close();
            facilities.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var students = new Students();
            students.Closed += (s, args) => this.Close();
            students.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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
                var employee = new Employee();
                employee.Closed += (s, args) => this.Close();
                employee.Show();
            }
        }
    }
}
