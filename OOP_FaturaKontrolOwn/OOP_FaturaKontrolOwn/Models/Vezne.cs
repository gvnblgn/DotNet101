using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FaturaKontrolOwn.Models
{
    public class Vezne
    {
        public Vezne()
        {
            Faturalar = new List<Fatura>();
        }
        public List<Fatura> Faturalar { get; set; }
        public int No { get; set; }
        public Veznedar Veznedar { get; set; }
        
    }
}
