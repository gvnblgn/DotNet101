using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modIki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //    int sayiGelen = Convert.ToInt32(txtMod.Text);
            //    double sonuc = 0;
            //    double i = 0.10;

            //    if (sayiGelen == 0)
            //    {
            //        MessageBox.Show("Sonuç     :" + sayiGelen);
            //    }

            //    else if (sayiGelen != 0)
            //    {
            //        while (sayiGelen != 0)
            //        {
            //            if (sayiGelen % 2 == 0)
            //            {
            //                sonuc += (0 * (i * 10));
            //                i *= 10;
            //                sayiGelen /= 2;
            //            }
            //            else
            //            {
            //                sonuc += (1 * (i * 10));
            //                i *= 10;
            //                sayiGelen /= 2;
            //            }

            //            if (sayiGelen == 0)
            //            {
            //                MessageBox.Show("Sonuc :" + sonuc);
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Düzgün bir sayı gir");
            //    }
            //}

            int sayi = int.Parse(txtMod.Text);
            int sonuc = 0;
            int basamak = 1;

            while (sayi >  0)
            {
                sonuc += (sayi%2) *basamak;
                basamak *= 10;
                sayi /= 2;
            }
            MessageBox.Show("Sonucunuz :    " + sonuc);
        }

        int sayac = 1;
        private void btnOyun_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtMod.Text);
            
            if(sayi == tahmin)
            {
                Text = "TEBRİKLER";
                sayac = 0;
            }
            else
            {
                Text = "OLMADI BİR DAHA DENE";
            }
            sayac++;
        }

        int tahmin;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tahmin = rnd.Next(1, 101);
        }
    }
}
