using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTekrarınTekrarı
{
    internal interface IFutbolcu
    {
        string AdSoyad { get; set; }


        int FormaNo { get; set; }

        byte Agresiflik { get; set; }

        byte Refleks { get; set; }

        byte Dayanılılık { get; set; }

        byte SutGucu { get; set; }

        bool MilliMi { get; set; }


        void SutCek();

        void PasVer();
    }
}
