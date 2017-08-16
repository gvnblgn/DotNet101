using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double KuvvetHesapla(long sayi1, long sayi2)
        {
            double sonuc ;
            //for (int i = 1; i < sayi2; i++)
            //{
            //    sonuc *=  sayi1;

            //}

            //return sonuc;
            sonuc = Math.Pow(sayi1, sayi2);
            return sonuc;
        }

        string piDondur()
        {
            string pi;
            pi = Math.PI.ToString();
            return pi.Substring(0, 6);
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtPi.Text = piDondur();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            txtPi.Text = Math.Floor(12.98).ToString();
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            txtPi.Text = Math.Ceiling(12.98).ToString();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            txtPi.Text = Math.Round(12.98).ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            txtPi.Text = Math.Max(12, 98).ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtPi.Text = Math.Min(12, 98).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sayi3 = int.Parse(txtPi.Text);
            long sayi4 = int.Parse(txtKuvvet.Text);
            MessageBox.Show("" + KuvvetHesapla(sayi3, sayi4));     
        }
    }
}
