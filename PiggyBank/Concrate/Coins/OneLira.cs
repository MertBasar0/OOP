using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Coins
{
    public class OneLira : Coin
    {
        public OneLira()
        {
            R_Pow = 16.15M;
            Weight = 8.2M;
            H = 1.9M;
            Amount = 1.00M;
        }
    }
}
