using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomArray
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rastgele;
        int[] array = new int[10];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                rastgele = rnd.Next(1, 100);
                array[i] = rastgele;
            }
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                lbRandom.Items.Add(array[i]); 

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbRandom.Items.Clear();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                    Controls[i].BackColor = Color.White;
                    Controls[i].ForeColor = Color.Black;
            }
              
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
           /* int cift;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 == 0)
                {
                    lbRandom.Items.Add(array[i]);
                }
            }
            */
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //formda yer alan kontrol sayısı
            MessageBox.Show(this.Controls.Count.ToString());
            for (int i = 0; i < this.Controls.Count ; i++)
            {
                if (Controls[i] is Button)
                {
                    if (Controls[i].Text != "Temizle")
                    {
                        Controls[i].BackColor = Color.Blue;
                        Controls[i].ForeColor = Color.White;
                    }
                   
                }
                else
                {
                    Controls[i].BackColor = Color.Green;
                    Controls[i].ForeColor = Color.Red;
                }
            }
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            string sayi;
            string sayi2;

            int sonuc= 0;

            sayi = txtSon.Text;

            for (int i = 0; i < sayi.Length; i++)

            {
                try
                {
                    sayi2 = sayi[i].ToString();

                    sonuc = sonuc + Convert.ToInt32(sayi2);
                }
                catch (Exception)
                {

                    //throw;
                }

                

            }

            MessageBox.Show($"sonuc : {sonuc}"); 
        }
    }
}
