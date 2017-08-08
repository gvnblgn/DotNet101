using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler=
        {
            "Ankara",
            "İzmir",
            "İstanbul",
            "Manisan",
            "Muş",
            "Iğdır",
            "Rize",
            "Çorum"
        };

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (string str in sehirler)
            {
                lbEkle.Items.Add(str);
            }

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    lbEkle.Items.Add(sehirler[i]);
            //}

        }
        int setIndex2 = 0;
        int setIndex3 = 0;

        private void btnIki_Click(object sender, EventArgs e)
        {
            int[] sayilar = {123, 66, 45, 56, 876, 753, 734, 11, 9, 2017 };
            // hem 2 ye hem 3 e bölünebilen kaç sayı var mesaj box a yaz
            // 2 ye bölünenleri listbox 1 e 
            // 3 e bölünenleri listbox 2 ye ekleyin
            int combo = 0;
            int index2 = 0;
            int index3 = 0;


            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    lbEkle.Items.Add(sayi);
                    index2++;
                }
                if (sayi % 3 == 0)
                {
                    lbIki.Items.Add(sayi);
                    index3++;
                }
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    try
                    {
                        combo++;
                        setIndex2 = index2;
                        setIndex3 = index3;
                        
                    }
                    catch (Exception)
                    {

                    }
                   
                }
            }

            lbEkle.SelectedIndex = setIndex2-1;
            lbIki.SelectedIndex = setIndex3-1;

            //foreach (int sayi in sayilar)
            //{
            //    // && ve işareti solundaki ve sağındaki iki duruma sağlandığında
            //    if ( sayi%2 == 0 && sayi%3==0)
            //    {
            //        combo++;
            //    }

            //    #region 2ye3ebölünenANDsiz
            //    //if (sayi % 2 == 0)
            //    //{
            //    //    if (sayi % 3 == 0)
            //    //    {
            //    //        combo++;
            //    //    }
            //    //}

            //    #endregion

            //}

            MessageBox.Show("Hem 3 e hem de 2 ye ikisini de bölünen item sayısı" + combo);
        }
    }
}
