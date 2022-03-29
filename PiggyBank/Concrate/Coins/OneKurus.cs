using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Coins
{
    public class OneKurus : Coin
    {
        public OneKurus()
        {
            R_Pow = 16.5M;
            Weight = 2.2M;
            H = 1.35M;
            Amount = 0.01M;
        }
    }
}
