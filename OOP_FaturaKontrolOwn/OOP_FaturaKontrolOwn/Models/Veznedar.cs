using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FaturaKontrolOwn.Models
{
    public class Veznedar : Insan
    {
        public int No { get; set; }
        public Veznedar() { }
        public Veznedar( int _no , string _ad, string _soyad)
        {
            No = _no;
            Ad = _ad;
            Soyad = _soyad;
        }
    }
}
