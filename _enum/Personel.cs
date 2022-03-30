using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _enum
{
    public enum Departmanlar
    {
        Yazilim,GrafikTasarim,InsanKaynaklari,Muhasebe
    }

    public class Personel
    {
        private string _adsoyad;

        public string AdSoyad
        {
            get { return _adsoyad; }
            set { _adsoyad = value; }
        }


        private Departmanlar departmanlar;

        public Departmanlar Departman
        {
            get { return departmanlar; }
            set { departmanlar = value; }
        }


        public override string ToString()
        {
            return $"{AdSoyad} {Departman}";
        }


    }
}
