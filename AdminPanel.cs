using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CRUD
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring1 = @"Data Source=DESKTOP-1QBK412\SQLEXPRESS2;Initial Catalog=adminloginDb;Integrated Security=True;TrustServerCertificate=True";
            string connectionstring2 = @"Data Source=DESKTOP-1QBK412\SQLEXPRESS2;Initial Catalog=LoginDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string connectionstring3 = @"Data Source=DESKTOP-1QBK412\SQLEXPRESS2;Initial Catalog=RegistrationDb;Integrated Security=True;TrustServerCertificate=True";
            string connectionstring4 = @"Data Source=DESKTOP-1QBK412\SQLEXPRESS2;Initial Catalog=BuySellDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using(SqlConnection sqlcon1 = new SqlConnection(connectionstring1)) 
            {
                sqlcon1.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM adminlogin",sqlcon1);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dgv1.DataSource = dt1;


            }

            using (SqlConnection sqlcon2 = new SqlConnection(connectionstring2))
            {
                sqlcon2.Open();
                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Logininfo", sqlcon2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dgv2.DataSource = dt2;


            }

            using (SqlConnection sqlcon3 = new SqlConnection(connectionstring3))
            {
                sqlcon3.Open();
                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Registrationform", sqlcon3);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                dgv4.DataSource = dt3;


            }


            using (SqlConnection sqlcon4 = new SqlConnection(connectionstring4))
            {
                sqlcon4.Open();
                SqlDataAdapter adapter4 = new SqlDataAdapter("SELECT * FROM buysell", sqlcon4);
                DataTable dt4 = new DataTable();
                adapter4.Fill(dt4);
                dgv3.DataSource = dt4;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1QBK412\\SQLEXPRESS2;Initial Catalog=adminloginDb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "insert INTO adminlogin VALUES (@username, @password)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1QBK412\\SQLEXPRESS2;Initial Catalog=adminloginDb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "UPDATE adminlogin SET username=@username, password=@password ";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUser.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                txtPass.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
            }


                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage f1 = new Homepage();
            f1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ADMINlogin f1= new ADMINlogin();
            f1.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
