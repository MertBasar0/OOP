using _PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PiggyBank.Consrate.Banknots
{
    public class FiveBanknot : Banknot
    {
        public FiveBanknot()
        {
            Most = 13M;
            Size = 6.4M;
            H = 4M;
            Amount = 5.00M;
        }

    }
}
