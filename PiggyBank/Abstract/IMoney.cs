using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public interface IMoney
    {
        decimal Amount { get; set; }
        decimal Weight { get; set; }
        decimal H { get; set; }

        decimal CalculateArea();

    }
}
