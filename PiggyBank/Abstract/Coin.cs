using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiggyBank.Concrate;

namespace PiggyBank
{
    public class Coin : IMoney
    {
        public decimal R_Pow { get ; set ; }
        public decimal Weight { get ; set ; }
        public decimal H { get ; set ; }
        public decimal Amount { get; set; }

        public Coin()
        {
        }

        public decimal CalculateArea()
        {
            return PiConsts.Pi * R_Pow * H;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }

}
