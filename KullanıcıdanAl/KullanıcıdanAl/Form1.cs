using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıdanAl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            txtBirinci.Text = "0";
            txtIkinci.Text = "0";
            txtMod.Text = "0";
            txtModFark.Text = "0";
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(txtBirinci.Text);
            int sayiIki = Convert.ToInt32(txtIkinci.Text);

            int toplam = sayiBir + sayiIki;

            MessageBox.Show(" Toplam sonuç : " + toplam);
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            // ilk textbox (txtBirinci) in değerinin 19 eksiğinin 20 fazlasının 
            // 2 ye bölümünden kalan sayının karesi nedir?

            int sayi = Convert.ToInt32(txtBirinci.Text);
            sayi = ((sayi - 19) + 20) % 2;
            int sonuc = sayi * sayi;

            MessageBox.Show("Operasyon sonucu : " + sonuc);

        }

        private void btnIkinci_Click(object sender, EventArgs e)
        {
            //Girilen sayıların karelerinin toplam ile karelerinin farkının toplamı nedir?

            int sayi1 = Convert.ToInt32(txtBirinci.Text);
            int sayi2 = Convert.ToInt32(txtIkinci.Text);

            int birinciKare = sayi1 * sayi1;
            int ikinciKare = sayi2 * sayi2;

            int toplam = birinciKare + ikinciKare;
            int fark = birinciKare - ikinciKare;

            //MessageBox.Show($"Sonuc : {(birinciKare + ikinciKare) + (birinciKare - ikinciKare)}");
            MessageBox.Show($"Sonuc : {fark + toplam }");
        }

        private void btnUcuncu_Click(object sender, EventArgs e)
        {
            // Not hesaplama
            // 1.sayi vize %30;
            // 2.sayi vize %70

            double sayi1 = Convert.ToInt32(txtBirinci.Text);
            double sayi2 = Convert.ToInt32(txtIkinci.Text);

            sayi1 = (sayi1 * 30) / 100;
            sayi2 = (sayi2 * 70) / 100;

            double toplam = sayi1 + sayi2;

            //MessageBox.Show("Dönem puanınız : " + toplam);
            MessageBox.Show($"Dönem sonucunuz : {toplam}");

        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            string ad = txtBirinci.Text;
            string soyad = txtIkinci.Text;

            MessageBox.Show("Mail adresiniz : " + ad + "." + soyad + "@hotmail.com");
        }
    }
}
