using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;

            return toplam;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int number1 = (int)num1.Value;
            int number2 = (int)num2.Value;
            //int toplam = Topla(number1, number2);

            MessageBox.Show($"Girdiğiniz sayıların toplamı :  {Topla(number1,number2)} ");
        }
    }
}
