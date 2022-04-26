using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerciTekrar
{
    public class Menu
    {
        public int Id { get; set; }

        public string MenuAdi { get; set; }

        public decimal Fiyati { get; set; }


        public override string ToString()
        {
            return MenuAdi + "Menü";
        }
    }
}
