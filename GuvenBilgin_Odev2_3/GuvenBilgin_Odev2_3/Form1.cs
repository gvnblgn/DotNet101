using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenBilgin_Odev2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tursayisiSaniye = 0;
        int tursayisiDakika = 0;
        int tursayisiSaat = 0;
        int gun = 0;
        int control = 0;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = tursayisiSaniye.ToString();
            tursayisiSaniye += 1;
            if (tursayisiSaniye == 100)
            {
                tursayisiDakika += 1;
                tursayisiSaniye = 0;
            }
            if (tursayisiDakika == 60)
            {
                tursayisiSaat += 1;
                tursayisiDakika = 0;
            }
            if (tursayisiSaat == 24)
            {
                gun += 1;
                tursayisiSaat = 0;
            }

            txtSaniye.Text = tursayisiSaniye.ToString();
            txtDakika.Text = tursayisiDakika.ToString();
            txtSaat.Text = tursayisiSaat.ToString();
            txtGun.Text = gun.ToString();

        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
