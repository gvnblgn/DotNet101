using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayit
{
    internal class Student
    {
        internal string name;
        internal string surname;
        internal string number;
        internal string department;
        internal DateTime birthday;
        internal DateTime registration;

        public override string ToString()
        {
            return number + "\t" + name + "\t" + surname + "\t" +
                department + "\t" + birthday + "\t" + registration;
        }
    }
}
