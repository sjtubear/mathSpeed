using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathSpeed
{
    public partial class mathSpeed : Form
    {
        public mathSpeed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mathSpeed_Load(object sender, EventArgs e)
        {

        }

        private void tbAnswer_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("entered!");
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter!");
            }
        }
    }
}
