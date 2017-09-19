using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi_GuvenBilgin.Models
{
    public class Film
    {
        public Film()
        {
            //Seans = new List<Seans>();
        }

        public int FilmNo { get; set; }
        public string FilmAdi { get; set; }

        public Seans Seans { get; set; }


        public override string ToString()
        {
            return FilmNo + "\t" + FilmAdi;
        }
    }
}
