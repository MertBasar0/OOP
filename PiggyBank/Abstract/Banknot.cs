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
        public decimal Air { get ; set ; }
        public decimal MinAir { get ; set ; }

        public Banknot()
        {

        }

        public decimal CalculateAir()
        {
            Random rd = new Random();
            decimal min = ((Most * Size * H) * 1/4);
            decimal max = ((Most * Size * H) * 3/4);

            MinAir = min;
            Air = rd.Next(Convert.ToInt32(min) ,Convert.ToInt32(max));
            return Air;
        }

        public decimal CalculateArea()
        {
            return Most * Size * H + Air;
        }


        public override string ToString()
        {
            return GetType().Name;
        }

    }
}
