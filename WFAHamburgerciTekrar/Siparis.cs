using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerciTekrar
{
    public class Siparis
    {
        public int Id { get; set; }

        public Menu SeciliMenu { get; set; }

        public Boyut Boyutu { get; set; }

        public List<Extra> Extras { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {
            ToplamTutar = 0;

            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta: ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case Boyut.Buyuk: ToplamTutar += ToplamTutar * 0.20m;
                    break;
            }

            foreach (Extra extra in Extras)
            {
                ToplamTutar += extra.Fiyati;
            }


            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (Extras.Count == 0)
            {
                return $"Menü Adı: {SeciliMenu.MenuAdi} Adet: {Adet} Menü Boyutu: {Boyutu.ToString()} Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                return $"Menü Adı: {SeciliMenu.MenuAdi} Adet: {Adet} Menü Boyutu: {Boyutu.ToString()} Toplam: {ToplamTutar.ToString("C2")}";
            }
        }
            
    }
}
