using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IEnumerable_IEnumerator
{
    public enum Mevkiler
    {
        Kaleci,Defans,Ortasaha,Forvet
    }

    
    public class Futbolcu
    {
        public string Adi { get; set; }

        public byte FormaNumarasi { get; set; }

        public Mevkiler Mevkisi { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", this.Adi, this.FormaNumarasi, this.Mevkisi);
        }

    }


}
