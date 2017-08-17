using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outReffParams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GeriyeDegerDon(int sayi, out double firlatilanSonuc) //herhangi bir return olmamasına rağmen out variable diğer taraftan yakalanabiliniyor.
        {
            firlatilanSonuc = Math.Pow(sayi, 2);
        }

        void Hesapla(int sayi1, int sayi2, out int toplam,out int cikarma, out long carpma, out double bolme, out byte mod)
        {
            toplam = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            mod = (byte) (sayi1 % sayi2); 
        }

        double FiyatHesapla(params double[] fiyatlar)
        {
            double toplamFiyat = 0;
            foreach (var item in fiyatlar)
            {
                toplamFiyat += item;
            }
            return toplamFiyat;
        }

        void Arttir(ref int sayi)
        {
            sayi++;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            double yakanalanSonuc;
            GeriyeDegerDon(12, out yakanalanSonuc);
            MessageBox.Show(yakanalanSonuc.ToString()); // değişken return olmamasına rağmen burda yakalanıyor.
        }

        private void btnOut_2_Click(object sender, EventArgs e)
        {
            int toplam, cikarma;
            long carpma;
            double bolme;
            byte mod;

            Hesapla(8, 3, out toplam, out cikarma, out carpma, out bolme, out mod);
        }

        private void btnOut_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FiyatHesapla(193.20,56.55,68.74,123.54).ToString());
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int number = 0;
            Arttir(ref number);
            MessageBox.Show(number.ToString());
        }
    }
}
