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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page ss = new Home_Page();
            ss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            Facilities f1 = new Facilities();
            f1.Show();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            About__Us about__Us = new About__Us();
            about__Us.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Employee = new Employee();
            Employee.Closed += (s, args) => this.Close();
            Employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var students = new Students();
            students.Closed += (s, args) => this.Close();
            students.Show();

        }

        private void label2_Click(object sender, EventArgs e)
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
                var home_Page = new Home_Page();
                home_Page.Closed += (s, args) => this.Close();
                home_Page.Show();
            }
        }
    }
}
