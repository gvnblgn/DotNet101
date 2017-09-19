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
        int counter = 0;
        int BiletSayisi = 0;
        List<Film> Filmler = new List<Film>();
        List<Seans> SeanslariTut = new List<Seans>();
       
        public Form1()
        {
            InitializeComponent();

            dtpBitis.Value.ToString("HH:mm");
            dtpBaslangic.Value.ToString("HH:mm");

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            Seans s = new Seans();
            f.FilmAdi = txtFilm.Text;
            f.FilmNo = counter;
            f.Seans = new Seans()
            {
                BaslangicSaati = dtpBaslangic.Value,
                BitisSaati = dtpBitis.Value  
            };

            Filmler.Add(f); 
            s.BaslangicSaati = dtpBaslangic.Value;
            s.BitisSaati = dtpBitis.Value;
            SeanslariTut.Add(s);
            
            lbFilm.Items.Add(f);
            lbSeanslar.Items.Add(SeanslariTut[counter]); 

   
        }
    }
}
