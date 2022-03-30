using _PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PiggyBank.Consrate.Coins
{
    public class FiveKurus : Coin
    {
        public FiveKurus()
        {
            R_Pow = 17.5M;
            Weight = 2.9M;
            H = 1.65M;
            Amount = 0.05M;
        }
    }
}
