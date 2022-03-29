using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Coins
{
    public class TenKurus : Coin
    {
        public TenKurus()
        {
            R_Pow = 18.5M;
            Weight = 3.15M;
            H = 1.65M;
            Amount = 0.10M;
        }
    }
}
