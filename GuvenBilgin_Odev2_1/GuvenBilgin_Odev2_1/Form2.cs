using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenBilgin_Odev2_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string zorluk;
        int hak = 0;
        int hedef = 0;
        Random rnd = new Random();

        private void Form2_Load(object sender, EventArgs e)
        {
            hak = 10;
            if (zorluk=="Kolay")
            {
                txtHak.Text = hak.ToString();
                hedef = rnd.Next(0, 10);
            }
            if (zorluk == "Orta")
            {
                hak -= 2;
                txtHak.Text = (hak).ToString();
                hedef = rnd.Next(0, 50);
            }
            if (zorluk == "Zor")
            {
                hak -= 5;
                txtHak.Text = (hak).ToString();
                hedef = rnd.Next(0, 75);
            }
            if (zorluk == "Çok Zor")
            {
                hak -= 7;
                txtHak.Text = (hak).ToString();
                hedef = rnd.Next(0, 100);
            }
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            int tahmin = 0;
            tahmin = Convert.ToInt32(txtTahmin.Text);
            while (!(hak==0))
            {
                if (tahmin==hedef)
                {
                    MessageBox.Show("Tebrikler sayıyı" + (10-hak) + "denemede buldunuz ! Sayımız : " + hedef + "'idi");
                    this.Close();
                    break;
                }
                else
                {
                    if (tahmin < hedef)
                    {
                        MessageBox.Show("Hedef Sayı" + tahmin + "sayısından Daha Büyüktür ! ");
                        hak--;
                        txtHak.Text = hak.ToString();
                        break;
                    }
                    if (tahmin > hedef)
                    {
                        MessageBox.Show("Hedef Sayı" + tahmin + "sayısından Daha Küçüktür ! ");
                        hak--;
                        txtHak.Text = hak.ToString();
                        break;
                    }
                }
            }
            if (hak==0)
            {
                MessageBox.Show("Game Over :/");
                this.Close();
            }
        }
    }
}
