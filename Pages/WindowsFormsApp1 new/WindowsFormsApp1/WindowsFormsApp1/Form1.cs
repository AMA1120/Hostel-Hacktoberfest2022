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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\login\DB2\DB2.mdf;Integrated Security=True;Connect Timeout=30");
            string student_name = txtname.Text;
            int student_id =int.Parse(txtid.Text);
            int phone_number=int.Parse(txtphone.Text);
            float Batch = float.Parse(txtbatch.Text);
            string Email = txtemail.Text;
            string Msg=txtmsg.Text;

            string qry= "INSERT INTO stdcomplaints values('" + student_name + "','"+ student_id + "','"+ phone_number + "','"+ Batch + "','"+Email+"','"+Msg+"')";
            SqlCommand cmd=new SqlCommand(qry, con);

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
