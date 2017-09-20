using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi_GuvenBilgin.Models
{
    public class Bilet
    {
        public int BiletNo { get; set; }
        public int KoltukNo { get; set; }

        public override string ToString()
        {
            return BiletNo + "" ;
        }
    }
}
