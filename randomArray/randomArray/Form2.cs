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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYanYana_Click(object sender, EventArgs e)
        {
            lblCmd.Text = "";
            for (int i = 0; i < 5; i++)
            {
                lblCmd.Text += "X";
            }
        }

        private void btnAltAlta_Click(object sender, EventArgs e)
        {
            lblCmd.Text = "";
            for (int i = 0; i < 5; i++)
            {
                lblCmd.Text += "X\n";
            }

        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            lblCmd.Text = "";
            /*int count = 0;
            for (int i = 0; i < 5; i++)
            {

                    if(i==0)
                    {
                    for (int a = 0; a < 5; a++)
                    {
                        lblCmd.Text += "X ";     
                    }
                    lblCmd.Text += "\n";
                }//end if
                    else if (i == 4)
                    {
                    for (int b = 0; b < 5; b++)
                    {
                        lblCmd.Text += "X ";
                        
                    }
                    lblCmd.Text += "\n";

                }//end else if

                    else
                    {
                        lblCmd.Text += "X           X ";
                        lblCmd.Text += "\n";

                    }
                }
            }*/


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j > 0 && j < 4) && (i > 0 && i < 4))
                    {
                        lblCmd.Text += "     ";
                    }
                    else
                    {
                        lblCmd.Text += "X  ";
                    }//end of else

                    //label1.Text += "X  ";
                }//end of 2.for
                lblCmd.Text += "\n";
            }//end of 1 for
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            //lblCmd.Text = "";

            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //if ((j > 0 && j < 4) && (i > 0 && i < 4))
                    if (j==i)
                    {
                        lblCmd.Text += "X";
                    }
                    else
                    {
                        lblCmd.Text += "     ";
                    }
                }
                lblCmd.Text = "\n";

            }*/
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    lblCmd.Text += ("X ");
                }
                lblCmd.Text += ("\n");
            }

            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    lblCmd.Text += ("X ");
                }
                    lblCmd.Text += ("\n");
            }
            */
        }

        private void txtCarpim_Click(object sender, EventArgs e)
        {
            // 3x5 =15

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {

                    //int carpim = i * j;
                    //lbEkran.Items.Add(i + "*" + j + "=" + carpim);
                    //lbEkran.Items.Add($"{i} X {j} = {i * j}");
                    lbEkran.Items.Add(string.Format("{0} * {1} = {2}", i, j, i * j));
                }
                lbEkran.Items.Add("_____________ \n\n\n");
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (j = 0; j < 100; j++)
            {
                if (j == 20)
                {
                    lbEkran.Items.Add(j);
                    break;
                }
                lbEkran.Items.Add(j);
                //lbEkran.Items.Add(j); CONTROL KC YORUM YAPAR KU YORUMDAN KURTARIR
            }
            lbEkran.Items.Add(j);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lbEkran.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int sayi = rnd.Next(1, 50);

                if (lbEkran.Items.Contains(sayi))
                {
                    i--;
                    continue; // continue bir önceki iterasyona götürüyor derleyiciyi
                }
                else
                {
                    lbEkran.Items.Add(sayi);
                }
            }
        }
    }
}
