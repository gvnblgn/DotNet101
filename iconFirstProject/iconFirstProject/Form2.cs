using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconFirstProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString());   
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "YIL :" + Math.Floor(DateTime.Now.Subtract(dateTimePicker1.Value).TotalDays / 365)
                + "\n AY :" + Math.Floor(DateTime.Now.Subtract(dateTimePicker1.Value).TotalDays / 30)
                + "\n GÜN : " + DateTime.Now.Subtract(dateTimePicker1.Value).TotalDays
                );
        }
    }
}
