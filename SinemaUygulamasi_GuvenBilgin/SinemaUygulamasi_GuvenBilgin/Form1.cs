using SinemaUygulamasi_GuvenBilgin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaUygulamasi_GuvenBilgin
{
    public partial class Form1 : Form
    {
        int hour1 = 0, hour2=0;
        int counter = 1;
        int BiletSayisi = 0;
        List<Film> Filmler = new List<Film>();
        List<Seans> Seanslar = new List<Seans>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButonOlustur();
            SeanslarıOlustur();
        }

        void SeanslarıOlustur()
        {
            int k = 1;
            for (int i = 10; i < 24; i+=2)
            {
                Seans s = new Seans()
                {
                    BaslangicSaati = i,
                    BitisSaati = i + 2,
                    FilmNo = k
                };
                k++;
                Seanslar.Add(s);
            }
            foreach (var item in Seanslar)
            {
                lbSeanslar.Items.Add(item);
            }
        }

        void ButonOlustur()
        {
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Left = gboxSalon.Left + btn.Width * i;
                btn.Top = 250;
                btn.Text = (i + 1).ToString();
                btn.Click += Btn_Click;
                Bilet blt = new Bilet();
                blt.BiletNo = i + 1;
                btn.Tag = blt;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if (lbSeanslar.SelectedIndex != -1)
            {
                hour1 = Seanslar[lbSeanslar.SelectedIndex].BaslangicSaati;
                hour2 = Seanslar[lbSeanslar.SelectedIndex].BitisSaati;
                
                Film f = new Film()
                {
                    FilmAdi = txtFilm.Text.Trim().ToUpper(),
                    FilmNo = counter,
                    Seanslar = new Seans()
                    {
                        BaslangicSaati = hour1,
                        BitisSaati = hour2,
                        FilmNo = counter
                    }
                };
                Filmler.Add(f);
                lbFilm.Items.Add(f);
                counter++;
                txtFilm.Text = " ";
            }
            else
            {
                MessageBox.Show("Lütfen Film İçin Bir Seans Seçiniz!");
            }
            
        }
    }
}

