using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTekrar
{
    public class Forvet : IFutbolcu
    {
        public int FormaNo { get ; set ; }
        public string AdiSoyadi { get ; set ; }
        public byte SutGucu { get ; set ; }
        public byte Dayaniklilik { get ; set ; }
        public byte Agresiflik { get ; set ; }
        public byte Refleks { get ; set ; }
        public bool MilliMi { get ; set ; }

        public void PasVer()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return AdiSoyadi;
        }
    }
}
