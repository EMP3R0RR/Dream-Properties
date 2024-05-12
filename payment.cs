using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRUD
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) == true)
            {
                txtCode.Focus();
                errorProvider2.SetError(this.txtCode, "Please Enter Code for Property!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtAcno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAcno.Text) == true)
            {
                txtAcno.Focus();
                errorProvider3.SetError(this.txtAcno, "Please Enter Account Number!");
            }
            else
            {
                errorProvider3.Clear();
            }

        }

        private void txtPin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPin.Text) == true)
            {
                txtPin.Focus();
                errorProvider4.SetError(this.txtPin, "Please Enter PIN!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtCode.Clear();
            txtAcno.Clear();
            txtPin.Clear();
            cmb1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage f1 = new Homepage();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
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
                MessageBox.Show("Payment Succesfull.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtUser.Text = "";
            txtCode.Text = "";
            txtAcno.Text = "";
            txtPin.Text = "";
            

        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            txtPin.PasswordChar = cbx1.Checked ? '\0' : '*';
        }
    }
}
