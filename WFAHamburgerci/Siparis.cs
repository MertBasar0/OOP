using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    public class Siparis
    {
        public menu SeciliMenu { get; set; }

        public BoyutEnum Boyutu { get; set; }

        public List<Extra> ExtraMalzemeler { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }



        public void  Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;
            switch (Boyutu)
            {
                case BoyutEnum.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.20m;
                    break;
            }

            foreach (Extra item in ExtraMalzemeler)
            {
                ToplamTutar += item.Fiyat;
            }

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (ExtraMalzemeler.Count<1)
            {
                return ($"Menü :{SeciliMenu.MenuAdi}  Adet: {Adet}  Boy : {Boyutu.ToString()} Toplam : {ToplamTutar.ToString("C2")}");
            }
            else
            {
                string exMalzemeler = null;
                foreach (Extra item in ExtraMalzemeler)
                {
                    exMalzemeler += item.ExtraAdi+",";
                }

                exMalzemeler = exMalzemeler.Trim();
                return ($"Menü :{SeciliMenu.MenuAdi}  Adet: {Adet}  Boy : {Boyutu.ToString()} exMalzemeler : {exMalzemeler} Toplam : {ToplamTutar.ToString("C2")}");
            }
            
        }
    }
}
