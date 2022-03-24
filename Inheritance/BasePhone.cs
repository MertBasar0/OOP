using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Protected proplar sadece miras verilen sınıflarda kullanılabilirler.
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connnection;

        public BasePhone()
        {
            _phoneType = "ahizeli normal telefon";
        }

        public BasePhone(string brand, string connnectionType)
        {
            _phoneType = "ahizeli normal telefon";
            _brand = brand;
            _connnection = connnectionType;
        }


        protected string Brand 
        {
            get { return this._brand; }
            set { this._brand = value; } 
        }

        protected string PhoneType
        {
            get { return this._phoneType; }
        }

        //03.03.2022 2.53
    }
}
