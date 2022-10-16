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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Pages 2\DB student info DB\DB\empdata.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into studentinfo values (@STDname,@STDid,@STDroom,@STDphone )", con);
            cmd.Parameters.AddWithValue("@STDname", txtname.Text);
            cmd.Parameters.AddWithValue("@STDid", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@STDroom", txtNumber.Text);
            cmd.Parameters.AddWithValue("@STDphone", txtphone.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data is Sucssfully insert");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Pages 2\DB student info DB\DB\empdata.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete studentinfo where  STDid=@STDid ", con);

            cmd.Parameters.AddWithValue("@STDid", int.Parse(txtid.Text));



            con.Close();
            MessageBox.Show("Successfully DELETED");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Pages 2\DB student info DB\DB\empdata.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update studentinfo set STDname=@STDname where STDid=@STDid ", con);
            cmd.Parameters.AddWithValue("@STDname", txtname.Text);
            cmd.Parameters.AddWithValue("@STDid", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@STDroom", txtNumber.Text);
            cmd.Parameters.AddWithValue("@STDphone", txtphone.Text);
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\YEAR 01\SEMESTER 02 - YEAR 01\C#\Group project\Pages 2\DB student info DB\DB\empdata.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select *from studentinfo where  STDid=@STDid ", con);
            cmd.Parameters.AddWithValue("@STDid", int.Parse(txtid.Text));
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;// TODO: This line of code loads data into the 'empdataDataSet.studentinfo' table. You can move, or remove it, as needed.
            this.studentinfoTableAdapter.Fill(this.empdataDataSet.studentinfo);

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
