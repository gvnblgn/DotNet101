using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // output console da bişi bastırmak için kullanıyoruz.

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sayi1 = 38;
            int sayi2 = 83;

            int toplam = sayi1 + sayi2;

            MessageBox.Show(toplam.ToString());
            MessageBox.Show("Toplam : " + toplam);

            MessageBox.Show("Toplam : " + (sayi1 + sayi2));
            MessageBox.Show("Toplam : " + sayi1 + sayi2);

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int sayi1 = 93;
            int sayi2 = 39;

            int fark = sayi2 - sayi1;

            MessageBox.Show("Fark : " + fark);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayi1 = 14;
            int sayi2 = 15;

            int carpma = sayi1 * sayi2;

            MessageBox.Show("çarpım : " + carpma); 
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double sayi1 = 55;
            double sayi2 = 6;

            double bolme = sayi1 / sayi2;
            
            MessageBox.Show("bölüm " + bolme);

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int sayi1 = 15;
            int sayi2 = 4;

            int mod = sayi1 % sayi2 ;

            //messagebox.show("mod = " + mod);
            Debug.WriteLine("Mod = {0}", mod);
            Debug.WriteLine("{0} mod {1} = {2}", sayi1, sayi2, mod);
        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            int sayi = 84;
            sayi++;

            MessageBox.Show(sayi.ToString());

        }

        private void btnAz_Click(object sender, EventArgs e)
        {
            int sayi = 84;
            sayi--;

            MessageBox.Show(sayi.ToString());
        }
    }
}
