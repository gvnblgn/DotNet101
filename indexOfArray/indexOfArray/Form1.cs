using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indexOfArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] renkler =
        {
            "mavi", 
            "yeşil",
            "pembe",
            "siyah",
            "beyaz",
            "turuncu",
            "kırmızı",
            "kahverengi",
            "kırmızı"}; 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            //string key = txtVar.Text.Trim().ToLower() ;
            //int index = Array.IndexOf(renkler, key);
            //int lastindex = Array.LastIndexOf(renkler, key);
            //if (index != -1 )
            //{
            //    MessageBox.Show("ürünü buldum" + key);
            //}
            //if(index!=lastindex)
            //{
            //    MessageBox.Show(" hatta ürün birden fazla var");
            //}
            //if (index == -1)
            //{
            //    MessageBox.Show("ürünü bulamadım");
            //}

            //txtVar.Clear();

            //int index = Array.IndexOf(sehirler,"izmir");

            string renk = txtVar.Text;

            if (Array.IndexOf(renkler,renk) != -1)
            {
                if (Array.IndexOf(renkler, renk) == Array.LastIndexOf(renkler, renk)
                    {
                    MessageBox.Show("aradığınız ürün birden fazla var");
                    }
                else
                {
                    MessageBox.Show("aradığınız üründen bi tane var");
                }
            }
            else
            {
                MessageBox.Show("aradığınız ürün yok");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbSort.Items.Clear();

            //Array.Sort(renkler);

            int[] sayilar = { 45, 90, 75, -1, 33 };
            Array.Sort(sayilar);

            foreach (var item in sayilar)
            {
                lbSort.Items.Add(item);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lbSort.Items.Clear();
            Array.Reverse(renkler);

            foreach (var item in renkler)
            {
                lbSort.Items.Add(item);
            }
        }
    }
}
