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
        public decimal Air { get ; set ; }
        public decimal MinAir { get ; set ; }

        public Coin()
        {

        }


        public decimal CalculateAir()
        {
            Random rd = new Random();
            decimal min = (PiConsts.Pi * R_Pow * H) * 1/4;
            decimal max = (PiConsts.Pi * R_Pow * H) * 3/4;

            Air = rd.Next(Convert.ToInt32(min),Convert.ToInt32(max));
            MinAir = min;

            return Air;
        }

        public decimal CalculateArea()
        {

            return (PiConsts.Pi * R_Pow * H) + Air;
        }


        public override string ToString()
        {
            return GetType().Name;
        }

    }

}
