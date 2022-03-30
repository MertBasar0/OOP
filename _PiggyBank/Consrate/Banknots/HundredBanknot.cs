using _PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PiggyBank.Consrate.Banknots
{
    public class HundredBanknot : Banknot
    {

        public HundredBanknot()
        {
            Most = 15.4M;
            Size = 7.2M;
            H = 4M;
            Amount = 100.00M;
        }

    }
}
