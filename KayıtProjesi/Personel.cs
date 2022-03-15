using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayıtProjesi
{
    public class Personel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string TCKN { get; set; }

        public DateTime Birtdate { get; set; }

        public string PhoneNo { get; set; }

        public string Mail { get; set; }

        public string Address { get; set; }

        public DateTime IseGirisTarihi { get; set; }

        public Unvan Unvan { get; set; }

        public string PersonelResmi { get; set; }

        public object Tag { get; set; }
    }
}
