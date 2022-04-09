using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public delegate void StokAzaldiEvent();

    class Product
    {
        public Product(int id, string name, double unitprice, int unitinstock)
        {
            this.id = id;
            Name = name;
            UnitInPrice = unitprice;
            UnitInStock = unitinstock;
        }

        private int _unitInStock;

        public int id { get; set; }

        public string Name { get; set; }

        public double UnitInPrice { get; set; }

        public event StokAzaldiEvent StokAzaldi;

        public int UnitInStock
        {
            get
            {
                return _unitInStock;
            }
            set
            {
                _unitInStock = value;
                if (value < 20)
                {
                    StokAzaldi();
                }
            }
        }


    }
}
