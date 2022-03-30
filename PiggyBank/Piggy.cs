using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Piggy
    {

        public decimal Capacity { get ; }

        public decimal InstantCapacity { get; set; }

        public decimal TotalMoney { get; set; }

        public int ShakeCount { get; set; }

        public int BreakCount { get; set; }

        public Piggy()
        {
            
        }
    }
}
