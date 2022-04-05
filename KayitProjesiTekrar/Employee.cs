using KayitProjesiTekrar.Constrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayitProjesiTekrar
{
    public class Employee
    {
        public string TCKN { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthdate { get; set; }

        public string Tel { get; set; }

        public string Mail { get; set; }

        public string Adres { get; set; }

        public DateTime WorkStartDate { get; set; }

        public Unvan Title { get; set; }

        public string Pic { get; set; }

    }
}
