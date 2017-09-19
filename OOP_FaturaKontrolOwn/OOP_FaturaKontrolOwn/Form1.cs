using OOP_FaturaKontrolOwn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FaturaKontrolOwn
{
    public partial class Form1 : Form
    {
        int vezneSayisi = 0;
        List<Vezne> Vezneler = new List<Vezne>();
        int VezneNo = 0;
        public Form1()
        {
            InitializeComponent();
            cboxVezneSayisi.Items.Add(1);
            cboxVezneSayisi.Items.Add(2);
            cboxVezneSayisi.Items.Add(3);
            cboxVezneSayisi.Items.Add(4);
        }

        private void cboxVezneSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            vezneSayisi = cboxVezneSayisi.SelectedIndex + 1;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            cboxVezneSayisi.Items.Add(1); if (vezneSayisi > 0)
            {
                lblBaslikMesaj.Text = $"{vezneSayisi} Adet vezne Hizmete Hazırdır";
                gboxAcilis.Enabled = false;
                VezneOlustur(vezneSayisi);
            }
            else
            {
                MessageBox.Show("Vezne sayısı hatalıdır!");
            }


            void VezneOlustur(int adet)
            {
                for (int i = 0; i < adet; i++)
                {
                    #region
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left = btn.Width * i;
                    btn.Top = 150;
                    btn.BackColor = Color.Aqua;
                    btn.ForeColor = Color.Indigo;
                    btn.Text = (i + 1).ToString();
                    btn.Click += Btn_Click;
                    btn.MouseHover += Btn_MouseHover;
                    btn.MouseLeave += Btn_MouseLeave;
                    this.Controls.Add(btn);
                    #endregion  //button oluşturma

                    Vezne v = new Vezne();
                    v.No = i + 1;
                    Vezneler.Add(v);
                    btn.Tag = v;
                }
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Vezne vezne = btn.Tag as Vezne;
            btn.Text = vezne.No.ToString();
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Vezne vezne = btn.Tag as Vezne;

            if (vezne.Veznedar == null)
            {
                gboxVeznedar.Enabled = true;
                VezneNo = vezne.No;
                Text = VezneNo.ToString();

                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {
                        
                    }
                    else
                    {
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                //gboxVeznedar.Enabled = false;
                btn.Text = vezne.Veznedar.No + " " + vezne.Veznedar.Ad + " " + vezne.Veznedar.Soyad;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnVeznedarKaydet_Click(object sender, EventArgs e)
        {
            if (VezneNo>0)
            {
                Vezneler[VezneNo - 1].Veznedar = new Veznedar()
                {
                    Ad = txtVeznedarAd.Text,
                    Soyad = txtVeznedarSoyad.Text,
                    No = int.Parse(txtVeznedarNo.Text)
                };

                gboxVeznedar.Enabled = false;
                txtVeznedarAd.Clear();
                txtVeznedarNo.Clear();
                txtVeznedarSoyad.Clear();

                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {

                    }
                    else
                    {
                        item.Enabled = true;
                    }
                }
            }
        }
    }
}
