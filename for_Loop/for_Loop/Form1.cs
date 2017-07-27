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
            /*for(int i = 1 ,  y=1000; i <= y && i< 400; i= i*10) // i = i + 2 yerine i += 2 yazabiliriz :))
            {
                lbEkran.Items.Add(i);
            }
            */

            int a = 5;       // bu işlemde b ye hemen 5 atanır a sonra 6 olur ++ solda olduğu için a7olduktan sonra bye 7 atanır.
            int b = a++;
            int c = ++a;

        }
    }
}
