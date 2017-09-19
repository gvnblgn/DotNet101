using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30OOP3
{
    class Ucak
    {
        public int KoltukSayisi { get; set; }
        public double Agirlik { get; set; }
        
        public virtual string BilgiVer() //virtual ezmek için kullanıyoruz. abstrack başka yerde türemesin diye kullanıyoruz.
        {
            return string.Format("Base > Koltuk Sayisi: " + KoltukSayisi + " Ağırlık: " + Agirlik);
        }

        public override string ToString()
        {
            return Agirlik + " " + KoltukSayisi; 
        }
    }
}
