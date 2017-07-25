using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = (sayi1 + sayi2) / 2 ;

            if (toplam<100)
            {
                txtToplam.Text = toplam.ToString();
                MessageBox.Show("Dönem ortalamanız : " + toplam);

            }
            else
            {
                MessageBox.Show("Girdiğiniz değer geçersizdir!!!");
            }

            txtSayi1.Clear();
            txtSayi2.Clear();
            txtToplam.Clear();
            txtSayi1.Focus();

            /*if (txtSayi1.Text.ToLower() == "admin") ; //toTrim yaparsan hem küçültür hem boşlukları siler
            {
                MessageBox.Show("Hoşgeldin admin");
            }
            else
	        {
                MessageBox.Show("Tanıyamadım kimsin?");
            }
            */
        }

        private void txtSayi1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnHesapla_Click(sender, e);
                txtSayi2.Focus();
            }
            else
            {
                //this.Text == txtSayi1.Text;
            }
        }

        private void txtSayi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHesapla_Click(sender, e);
                txtSayi1.Focus();
            }
        }
    }
}
