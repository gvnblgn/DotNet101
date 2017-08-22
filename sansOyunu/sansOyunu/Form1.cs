using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sansOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rastgeleSayi;
        List<int> sayilar = new List<int>();
        int tursayisi = 0;
        int count = 0;

        private void btnBahtiyar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rastgeleSayi = rnd.Next(1, 50);

            sayilar.Add(rastgeleSayi);
        }
    }
}
