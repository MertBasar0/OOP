using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_ICOMPARER
{
    class Takim
    {
        public string Adi { get; set; }

        public byte Puani { get; set; }

        public sbyte Averaji { get; set; }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
