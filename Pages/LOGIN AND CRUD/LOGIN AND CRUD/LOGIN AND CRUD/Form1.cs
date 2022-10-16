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

namespace LOGIN_AND_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\login\DB\LOGIN.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM EMPINFO WHERE USERNAME = '" + txtUsername.Text + "' AND PASSWORD = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
 
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form4 ss = new Form4();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
        }
    }
}
