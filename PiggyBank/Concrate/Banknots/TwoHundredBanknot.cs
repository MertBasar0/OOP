using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Banknots
{
    public class TwoHundredBanknot : Banknot
    {
        public TwoHundredBanknot()
        {
            Most = 16M;
            Size = 7.2M;
            H = 4M;
            Amount = 200.00M;
        }
    }
}
