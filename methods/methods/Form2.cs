using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        void RenkDegistir(string color)
        {
            BackColor = Color.FromName(color);
        }

        void RenkDegistir()  // parametresizi overload
        {
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            BackColor = Color.FromArgb(red, green, blue);
        }

        Color RenkBul()
        {
            return BackColor;
        }

        int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;

            return toplam;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int number1 = (int)num1.Value;
            int number2 = (int)num2.Value;
            //int toplam = Topla(number1, number2);

            MessageBox.Show($"Girdiğiniz sayıların toplamı :  {Topla(number1,number2)} ");
        }

        string TekCift(int sayi)
        {
            if (sayi %2 == 0)
            {
                return "çift";
            }
            else
            {
                return "tek";
            }
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TekCift(int.Parse(txtSayi.Text)));
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
           
            int sayi = rnd.Next(1, 10000);

            if (TekCift(sayi)== "Tek")
            {
                MessageBox.Show($"(sayi) çift olduğundan kaybettiniz!");
            }
            else
            {
                MessageBox.Show($"(sayi) tek olduğundan kazandınız!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenkDegistir(comboBox1.SelectedItem.ToString());
        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            RenkDegistir();
        }

        private void btnRenkBul_Click(object sender, EventArgs e)
        {
            //Text = RenkBul().Name ;
            Color c = RenkBul();
            MessageBox.Show(c.Name);
            System.Diagnostics.Process.Start("http://www.yavuzgedik.com");
        }
    }
}
