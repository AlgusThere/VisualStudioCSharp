using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethods
{
    internal class Bilgi
    {
        public Bilgi(string isim, string soyisim, string meslek, int yas)
        {
            Console.WriteLine("İsim: " + isim + "\n" + "Soyisim: " + soyisim + "\n" + "Meslek: " + meslek + "\n" + "Yaş: " + yas);
        }
    }
}
