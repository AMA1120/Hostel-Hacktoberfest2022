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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\DB\studentdata.mdf;Integrated Security=True;Connect Timeout=30");
         


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stdname=txtname.Text;
            int stdid=int.Parse(txtid.Text);
            string stdroom = txtNumber.Text;
            string stdphone=txtphone.Text;

            string qry = "INSERT Into hostelstudent values('" + stdname + "','" + stdid + "','"+stdroom+"','"+stdphone+"') ";
            SqlCommand cmd = new SqlCommand(qry, con);
            MessageBox.Show("Data insert sucessfully!");
            


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentdataDataSet.hostelstudent' table. You can move, or remove it, as needed.
            this.hostelstudentTableAdapter.Fill(this.studentdataDataSet.hostelstudent);

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string stdname = txtname.Text;
            int stdid = int.Parse(txtid.Text);
            string stdroom = txtNumber.Text;
            string stdphone = txtNumber.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\DB\studentdata.mdf;Integrated Security=True;Connect Timeout=30");
            string del = "DELETE FROM hostelstudent Where Stdname='" + stdname + "' AND stdid='" + stdid + "' AND stdroom='" + stdroom + "' AND stdphone='"+stdphone+"'";
            SqlCommand cmd =new SqlCommand(del, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("REcords Deletd succfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string stdname = txtname.Text;
            int stdid = int.Parse(txtid.Text);
            string stdroom = txtNumber.Text;
            string stdphone = txtNumber.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\DB\studentdata.mdf;Integrated Security=True;Connect Timeout=30");
            string del = "UPDATE hostelstudent SET Stdname='" + stdname + "' AND stdid='" + stdid + "' AND stdroom='" + stdroom + "' AND stdphone='" + stdphone + "'";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("REcords updated succfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
