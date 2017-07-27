using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirBin_Click(object sender, EventArgs e)
        {
            /*
            for(int i = 1 ,  y=1000; i <= y && || i< 400; i= i*10) // i = i + 2 yerine i += 2 yazabiliriz :))
            {
                lbEkran.Items.Add(i);
            }
            */

            /*for (int i = 1 ; i < 100; ++i)
            {
                lbEkran.Items.Add(i);
            }
            */
            for (int i = 1000; i >= 0; i--)
            {
                lbEkran.Items.Add(i);
            }

            lbEkran.Items.Clear();

            /*
            int a = 5;       // bu işlemde b ye hemen 5 atanır a sonra 6 olur ++ solda olduğu için a7olduktan sonra bye 7 atanır.
            int b = a++;
            int c = ++a;
            */
        }

        private void bntAz_Click(object sender, EventArgs e)
        {
            /*
             * char c= 'A';
             * char c2 = 'a';
             * 
             * MessageBox.Show(Convert.ToInt32(c) + "-" + Convert.ToInt32(c2);
             */

            /*for(char i ='A'; i < 'Z'; i++ )
            {
                for (char y = 'a' ; y < 'z' ; y++)
                {
                    lbEkran.Items.Add(i + "- " + Convert.ToInt32(i) + "-" + y + Convert.ToInt32(y));
                }
            }
            */

            

            for(int i=65; i<94; i++)
            {
                lbEkran.Items.Add(" " + Convert.ToString(i));
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // MessageBox.Show((100*101)/2 +""); Carl Friedrich Gauss
        
            int y = 0;
            for(int i =0; i<=100; i++)
            {
               
                y += i;
                //y++;

                lbEkran.Items.Add(y);
            }
        }
    }
}
