using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBir_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = txtBir.Text;
        }

        private void txtBir_MouseEnter(object sender, EventArgs e)
        {
            txtBir.BackColor = Color.Orange;
            txtBir.ForeColor = Color.Maroon;
        }

        private void txtBir_MouseLeave(object sender, EventArgs e)
        {
            txtBir.BackColor = Color.White;
            txtBir.ForeColor = Color.Black;
        }

        private void txtBir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("you double clicked to the box");
        }
    }
}
