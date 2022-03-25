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
        protected string _brand;
        protected string _phoneType;
        protected string _connnection;

        public BasePhone()
        {
            _phoneType = "ahizeli normal telefon"; // Burada yazılımcının girdiği string değerin direk private değişken
                                                   // üzerinde gönderilmesinin sebebi prop'un readOnly olarak ayarlanmış
                                                   // olması ve public üzerinden değer gönderilememesidir.
        }

        public BasePhone(string brand, string connnection)
        {
            _phoneType = "ahizeli normal telefon";
            Brand = brand;
            Connection = connnection;
        }


        public string Brand 
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public string PhoneType
        {
            get { return this._phoneType; }
        }


        public string Connection
        {
            get { return this._connnection; }
            set { this._connnection = value; }
        }


        public virtual string  Call()
        {
            return " Base Phone Çalıyor..";
        }

        //Virtual methods (sanal metotlar), base class (temel sınıf) içinde bildirilmiş ve derived(child sınıflarda kullanılması beklenen) ortak 
        //metot virtual keywordüyle işaretlenir. Ardından kullanılacka olan child sınıflarda override ile ezilip rahatlıkla kullanılır..


        public virtual string ConnectionStatus()
        {
            return "kablolu bağlantı mevcut";
        }


        public override string ToString()
        {
            return _phoneType;
        }

        //03.03.2022 2.53
    }
}
