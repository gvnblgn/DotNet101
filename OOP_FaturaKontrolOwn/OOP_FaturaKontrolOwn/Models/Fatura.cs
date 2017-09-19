using OOP_FaturaKontrolOwn.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FaturaKontrolOwn.Models
{
    public class Fatura
    {
        public DateTime SonOdemeTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public Musteri OdemeyiYapan { get; set; }
        public OdemeTip OdemeTipi { get; set; }
        public int No { get; set; }
        double _tutar;

        public double Tutar
        {
            get
            {
                return _tutar;
            }
            set { _tutar = value; }
        }
    }
}
