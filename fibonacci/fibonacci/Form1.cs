using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Fibonacci Index";
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            int sayi1 = 0;
            int sayi2 = 1;
            int toplam = 0;
            int index = 0;
            int sayac = 0;

            lbFibonacci.ForeColor = Color.Green;
            lbFibonacci.BackColor = Color.LightBlue;

            index = Convert.ToInt32(txtIndex.Text);


            for (int i = 1; i <= index; i++)
            {
                if (i == 1)
                { 
                    toplam = 0;
                    lbFibonacci.Items.Add(toplam);
                    sayac++;
                }
                else if (i==2)
                {
                    toplam = sayi1 + sayi2;
                    lbFibonacci.Items.Add(toplam);
                    sayac++;
                }
                else if(i>2)
                {
                    toplam = sayi1 + sayi2;
                    lbFibonacci.Items.Add(toplam);
                    sayi1 = sayi2;
                    sayi2 = toplam;
                    sayac++;
                }

            }//end of for
            MessageBox.Show("Fibonacci sonucu : " + lbFibonacci.Items[sayac-1]);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbFibonacci.Items.Clear();
            lbFibonacci.ForeColor = Color.Black;
            lbFibonacci.BackColor = Color.White;
        }
    }
}
