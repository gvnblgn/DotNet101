using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenBilgin_Odev2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();

        private void btnUc_Click(object sender, EventArgs e)
        {
            frm2.hangiButon = "birinci";
            frm2.Show();
            this.Hide();
        }

        private void btnDort_Click(object sender, EventArgs e)
        {
            frm2.hangiButon = "ikinci";
            frm2.Show();
            this.Hide();
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }
    }
}
