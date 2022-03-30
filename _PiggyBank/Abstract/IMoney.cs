using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PiggyBank.Abstract
{
    public interface IMoney
    {
        decimal Amount { get; set; }
        decimal Weight { get; set; }
        decimal H { get; set; }
        decimal MinAir { get; set; }
        decimal Air { get; set; }

        decimal CalculateArea();

        decimal CalculateAir();

        IMoney Clone();

    }
}
