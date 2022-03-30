using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Coins
{
    public class FiftyKurus : Coin
    {
        public FiftyKurus()
        {
            R_Pow = 23.85M;
            Weight = 6.8M;
            H = 1.9M;
            Amount = 0.50M;
        }
    }
}
