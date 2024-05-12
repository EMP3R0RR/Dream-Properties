using CRUD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Homepage : Form
    {
        
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            buy1.Show();
            buy1.BringToFront();    
            sell1.Hide();         
            aboutUs1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sell1.Hide();
            aboutUs1.Hide();
            buy1.Show();
            buy1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buy1.Hide();
            aboutUs1.Hide();
            sell1.Show();
            sell1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buy1.Hide();
            sell1.Hide();
            aboutUs1.Show();
            aboutUs1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LOGIN f1 = new LOGIN();
            f1.Show();
            this.Hide();
        }
    }
}
