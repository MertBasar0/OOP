using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Departmanlar
    {
        Yazilim, InsanKaynaklari, SistemVeAgUzmanligi, GrafikTasarim, Muhasebe, Ingilizce
    }

    public class Personel
    {

        private string _adisoyadi;

        public string AdiSoyadi
        {
            get { return _adisoyadi; }
            set { _adisoyadi = value; }
        }

        private Departmanlar _departman;

        public Departmanlar Departman
        {
            get { return _departman; }
            set { _departman = value; }
        }

    }
}
