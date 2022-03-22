using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IFutbolcu
    {
        string AdiSoyadi { get; set; }

        string FormaNumarasi { get; set; }

        byte SutGucu { get; set; }

        byte Refleks { get; set; }

        byte Dayaniklilik { get; set; }

        byte Agresiflik { get; set; }

        bool MilliMi { get; set; }


        void SutCek();

        void TopKurtar(); 
    }
}
