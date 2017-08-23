using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        Color rastgele()
        {
            //int red, green, blue;
            return Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.Left = 10 + (i*40);
                btn.Top = 10 + (i * 40);
                btn.Text = "Güle Güle";
                btn.BackColor = rastgele();
                btn.Click += Btn_Click;
                this.Controls.Add(btn);        
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Button seciliBtn = sendes as Button;
            Button seciliBtn = (Button)sender;
            this.BackColor = seciliBtn.BackColor;
        }
    }
}
