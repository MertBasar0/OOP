using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Forvet : IFutbolcu
    {
        public string AdiSoyadi { get ; set ; }
        public string FormaNumarasi { get ; set ; }
        public byte SutGucu { get ; set ; }
        public byte Refleks { get ; set ; }
        public byte Dayaniklilik { get ; set ; }
        public byte Agresiflik { get ; set ; }
        public bool MilliMi { get ; set ; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return AdiSoyadi;
        }
    }
}
