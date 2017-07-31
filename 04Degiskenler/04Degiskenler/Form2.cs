using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Degiskenler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] takimlar =
           {
                "Fenerbahçe",
                "Galatasaray",
                "Beşiktaş",
                "Trabzonspor",
                "Başakşehir",
                "Alanyaspor",
                "Bursaspor",
                "Kasımpaşa",
                "Bucaspor",
                "Gençlerbirliği",
                "Akhisar",
                "Antalyaspor",
                "Gençlerbirliği",
                "Orduspor",
            };

        int[] sayilar = { 38, 83, 45, 50, 60, 89, 56, 32 };
        int countTek = 0;
        int countCift = 0;
        int[] cift;
        int[] tek;
        int x = 0, y = 0;

        private void btnTakımlar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < takimlar.Length; i++)
            {
                lbTakımlar.Items.Add(takimlar[i]);
            }

            Text = lbTakımlar.Items.Count.ToString(); // listbox boyutunu form'un text yerine yazar.

            lbTakımlar.SelectedIndex = 0; // default olarak 0 getiricek index i
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbTakımlar.Items.Clear();
            // listbox boyutunu form'un text yerine yazar.
            Text = lbTakımlar.Items.Count.ToString();
        }

        private void lbTakımlar_Click(object sender, EventArgs e)
        {
            int index = lbTakımlar.SelectedIndex;
            lbTakımlar.Items.RemoveAt(index);
            // listbox boyutunu form'un text yerine yazar.
            Text = lbTakımlar.Items.Count.ToString();
            //MessageBox.Show(index + "");
        }

        private void btnGez_Click(object sender, EventArgs e)
        {
            if(lbTakımlar.Items.Count != 0)
            { 
                for (int i = 0; i < lbTakımlar.Items.Count; i++)
                {
                    lbTakımlar.SelectedIndex = i;
                    Thread.Sleep(100);
                
                }
            }
            else
            {
                MessageBox.Show("Listbox Boş");
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int sayi = rnd.Next(0, 101);
            int rastgele;

            for (int i = 0; i < 10; i++)
            {
                rastgele = rnd.Next(0, 11);
                lbTakımlar.Items.Add(rastgele);
            }
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayilar[i] %2 == 0)
                {
                    
                    countCift++;
                    cift[x] = sayilar[i];
                    x++;
                    
                }
                else
                {
                    countTek++;
                    tek[y] = sayilar[i];
                    y++;
                    //lbTakımlar.Items.Add(sayilar[i]);
                }
            }
            for (int i = 0; i < cift.Length; i++)
            {
                lbTakımlar.Items.Add(cift[i]);
            }

            for (int i = 0; i < tek.Length; i++)
            {
                lbTakımlar.Items.Add(tek[i]);
            }
            
        }
    }
}
