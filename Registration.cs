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

namespace CRUD
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(string.IsNullOrEmpty(control.Text)) 
                    { 
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if(control is DateTimePicker) 
                {
                    if(((DateTimePicker)control).Value==null)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                    
                }
                else if(control is ComboBox) 
                {
                    if(((ComboBox)control).SelectedIndex ==-1) 
                    { 
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("One or more fields are empty , please fill up the form properly!   Thank You!");
            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1QBK412\\SQLEXPRESS2;Initial Catalog=RegistrationDb;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "insert INTO Registrationform VALUES (@fname, @lname, @email, @username, @password, @country, @gender, @phone, @dob)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@country", txtCon.Text);
                cmd.Parameters.AddWithValue("@gender", cmbG.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Succesfull.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Homepage f1 = new Homepage();
                f1.Show();
                this.Hide();
            }

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtconPass.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtconPass.Clear();
            txtCon.Clear();
            txtEmail.Clear();
            txtFname.Clear();
            txtLname.Clear();   
            txtPhone.Clear();   
            cmbG.Text=string.Empty;

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text) == true)
            {
                txtPass.Focus();
                errorProvider5.SetError(this.txtPass, "Please Enter Password!");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text) == true)
            {
                txtFname.Focus();
                errorProvider1.SetError(this.txtFname, "Please Enter First Name!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtLname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLname.Text) == true)
            {
                txtLname.Focus();
                errorProvider2.SetError(this.txtLname, "Please Enter Last Name!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                txtEmail.Focus();
                errorProvider3.SetError(this.txtEmail, "Please Enter Email!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) == true)
            {
                txtUser.Focus();
                errorProvider4.SetError(this.txtUser, "Please Enter User!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtconPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtconPass.Text)
            {
                txtconPass.Focus();
                errorProvider6.SetError(this.txtconPass, "Passwords are not identical");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtCon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text) == true)
            {
                txtCon.Focus();
                errorProvider7.SetError(this.txtCon, "Please Enter Country!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                txtPhone.Focus();
                errorProvider8.SetError(this.txtPhone, "Please Enter Phone!");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOGIN f1 = new LOGIN();
            f1.Show();
            this.Hide();
        }
    }
}
