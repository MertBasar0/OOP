using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class YanFlüt : Enstrüman // Bu bir yarı implementation yarı kalıtım olayıdır.
    {
        public override string Call()
        {
            return "Yan flüt sesi";
        }
    }
}
