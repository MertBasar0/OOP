using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Banknot : IMoney
    {
        public decimal Most { get; set; }
        public decimal Size { get; set; }
        public decimal Weight { get ; set ; }
        public decimal H { get ; set ; }
        public decimal Amount { get; set; }



        public Banknot()
        {

        }

        public decimal CalculateArea()
        {
            return Most * Size * H;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
