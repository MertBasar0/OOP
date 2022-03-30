using _PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PiggyBank.Consrate.Coins
{
    public class TwentyFiveKurus : Coin
    {
        public TwentyFiveKurus()
        {
            R_Pow = 20.5M;
            Weight = 4M;
            H = 1.65M;
            Amount = 0.25M;
        }

    }
}
