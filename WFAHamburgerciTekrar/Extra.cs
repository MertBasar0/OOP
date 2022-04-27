using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerciTekrar
{
    public class Extra
    {
        public int Id { get; set; }

        public string ExtraAdi { get; set; }

        public decimal Fiyati { get; set; }

        public override string ToString()
        {
            return ExtraAdi;
        }

    }
}
