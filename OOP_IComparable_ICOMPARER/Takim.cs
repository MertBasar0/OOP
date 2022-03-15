using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IComparable_ICOMPARER
{
     class Takim
    {
        public string Adi { get; set; }

        public byte Puani { get; set; }

        public byte Averaji { get; set; }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
