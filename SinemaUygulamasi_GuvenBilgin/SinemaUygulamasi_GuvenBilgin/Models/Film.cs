using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi_GuvenBilgin.Models
{
    public class Film
    {
        public int FilmNo { get; set; }
        public string FilmAdi { get; set; }

        public Seans Seanslar { get; set; }

        public override string ToString()
        {
            return FilmNo + "-) " + FilmAdi + "----Filmin Seansı:" + Seanslar;
        }
    }
}
                                                                                     