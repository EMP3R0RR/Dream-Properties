﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CRUD
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1QBK412\\SQLEXPRESS2;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT (*) FROM Logininfo where username=@username AND password=@password ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Successful","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Homepage f1 = new Homepage();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtPasscon.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) == true)
            {
                txtUser.Focus();
                errorProvider1.SetError(this.txtUser, "Please Enter Username!");
            }
            else 
            {
                errorProvider1.Clear();
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text)== true)
            {
                txtPass.Focus();
                errorProvider2.SetError(this.txtPass, "Please Enter Password! ");

            }
            else 
            { 
                errorProvider2.Clear(); 
            }
        }

        private void txtPasscon_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text != txtPasscon.Text) 
            {
                txtPasscon.Focus();
                errorProvider3.SetError(this.txtPasscon, "Passwords are not identical");
            }
            else 
            { 
                errorProvider3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtPasscon.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration f1 = new Registration();
            f1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ADMINlogin f1 = new ADMINlogin();
            f1.Show();
            this.Hide();    
        }
    }
}
