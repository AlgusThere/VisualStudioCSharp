using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethods2
{
    internal class Kimlik
    {
        string ad, soyad, memleket;
        int yas;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToLower(); }

        }
        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            ad = "";
            soyad = "";
            memleket = "New York";
            yas = 24;
            cinsiyet = 'E';
        }
    }
}