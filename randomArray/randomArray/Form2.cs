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
            for (int i = 0; i < 5 ; i++)
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
            /*lblCmd.Text = "";
            int count = 0;
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
            }

        }*/
    }

