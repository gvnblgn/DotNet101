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

        public Seans(int _BaslangicSaati , int _BitisSaati)
        {
           BaslangicSaati = _BaslangicSaati;
            BitisSaati = _BitisSaati;
        }
        public int Durum { get; set; }
        public int BaslangicSaati { get; set; } 
        public int BitisSaati { get; set; }
        

        public override string ToString()
        {
            return BaslangicSaati+ ":00<=>" + BitisSaati+":00";
        }
    }
}
