using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections.Generic;

namespace faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "FAKTORIYEL HESAPLAMA";
        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = 1;
                int deger = 1;

                deger = int.Parse(txtFaktoriyel.Text);

                for (int i = deger; i > 0; i--)
                {
                    sonuc *= i;
                }

                txtSonuc.Text = Convert.ToString(sonuc);
            }
            catch (Exception)
            {

                MessageBox.Show("Lutfen bir rakam giriniz ! ");
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFaktoriyel.Text = "";
            txtSonuc.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
