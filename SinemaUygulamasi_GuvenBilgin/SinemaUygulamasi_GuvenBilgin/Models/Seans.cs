using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi_GuvenBilgin.Models
{
    public class Seans
    {
        public Seans()
        {

        }

        public Seans(DateTime _BaslangicSaati , DateTime _BitisSaati)
        {
            BaslangicSaati = _BaslangicSaati;
            BitisSaati = _BitisSaati;
        }
        public Film FilmNo { get; set; }
        public DateTime BaslangicSaati { get; set; } 
        public DateTime BitisSaati { get; set; }

        public override string ToString()
        {
            return BaslangicSaati.ToString("HH:mm") + "\t" + BitisSaati;
        }
    }
}
