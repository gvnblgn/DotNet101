using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boyutDegistirenForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer tmr = new Timer();
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr.Interval = 1000;
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Width = rnd.Next(100,500);
            this.Height = rnd.Next(100, 500);
            Point p = new Point(rnd.Next(0, 500), rnd.Next(0, 500));
            this.Location = p;

            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));


        }
    }
}
