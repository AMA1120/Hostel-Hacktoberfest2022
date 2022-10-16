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
    public partial class Facilities : Form
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home_Page = new Home_Page();
            home_Page.Closed += (s, args) => this.Close();
            home_Page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var facilities = new Facilities();
            facilities.Closed += (s, args) => this.Close();
            facilities.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var students = new Students();
            students.Closed += (s, args) => this.Close();
            students.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var employee = new Employee();
            employee.Closed += (s, args) => this.Close();
            employee.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var about__Us = new About__Us();
            about__Us.Closed += (s, args) => this.Close();
            about__Us.Show();
        }

        private void button12_Click(object sender, EventArgs e)
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
                var facilities = new Facilities();
                facilities.Closed += (s, args) => this.Close();
                facilities.Show();
            }
        }
    }
}
