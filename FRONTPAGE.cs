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
    public partial class FRONTPAGE : Form
    {
        public FRONTPAGE()
        {
            InitializeComponent();
        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN f1 = new LOGIN();
            f1.Show();
            this.Hide();
        }
    }
}
