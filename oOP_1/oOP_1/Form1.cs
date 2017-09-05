using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araba a1 = new Araba();
            a1.plaka = txtPlaka.Text;
            a1.marka = txtMarka.Text;
            a1.fiyat = (double)numFiyat.Value;
            a1.renk = cbRenk.SelectedItem.ToString();

            lbAraclar.Items.Add(a1);
            Temizle();
        }



        void Temizle()
        {
            txtMarka.Clear();
            txtPlaka.Clear();
            cbRenk.SelectedIndex = 0;
            numFiyat.Value = 100;
        }

        private void lbAraclar_Click(object sender, EventArgs e)
        {
            Araba car = (Araba)lbAraclar.SelectedItem;
            txtMarka.Text = car.marka;
            txtPlaka.Text = car.plaka;
            numFiyat.Value = (decimal)car.fiyat;
            int index = cbRenk.Items.IndexOf(car.renk);
            cbRenk.SelectedIndex = index;

        }
    }
}
