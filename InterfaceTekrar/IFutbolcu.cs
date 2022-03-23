using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTekrar
{
    public interface IFutbolcu
    {
         int FormaNo { get; set; }

         string AdiSoyadi { get; set; }

         byte SutGucu { get; set; }

         byte Dayaniklilik { get; set; }

         byte Agresiflik { get; set; }

         byte Refleks { get; set; }

         bool MilliMi { get; set; }

         void SutCek();

         void PasVer();

    }
}
