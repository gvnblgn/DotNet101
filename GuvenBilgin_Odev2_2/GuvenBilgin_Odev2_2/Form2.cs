using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenBilgin_Odev2_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hangiButon;

        private void Form2_Load(object sender, EventArgs e)
        {
            if (hangiButon=="birinci")
            {
                txtSayi4.Visible = false;
                txtSayi5.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (hangiButon == "ikinci")
            {
                txtSayi5.Visible = false;
                label5.Visible = false;
            }
        }

        int EnbuyuguBul(List<int> numbers)
        {
            int sonuc = 0;
            sonuc = numbers[0];
            foreach (var item in numbers)
            {
                if (sonuc >= item)
                {
                    continue;
                }
                else
                {
                    sonuc = item;
                }
            }
            return sonuc;
        }

        List<int> sayilar = new List<int>();

        private void btnBul_Click(object sender, EventArgs e)
        {
            sayilar.Clear();
            int sayi1=0, sayi2=0, sayi3=0, sayi4=0, sayi5=0, enbuyukSayi = 0;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sayi3 = Convert.ToInt32(txtSayi3.Text);
            sayi4 = Convert.ToInt32(txtSayi4.Text);
            sayi5 = Convert.ToInt32(txtSayi5.Text);



            sayilar.AddRange(new int[] { sayi1, sayi2, sayi3, sayi4, sayi5 });
            
            enbuyukSayi = EnbuyuguBul(sayilar);
            MessageBox.Show($"Girdiğiniz sayıların en büyüğü : { enbuyukSayi}");
            txtSayi1.Text = "0";
            txtSayi2.Text = "0";
            txtSayi3.Text = "0";
            txtSayi4.Text = "0";
            txtSayi5.Text = "0";
        }

    }
}
