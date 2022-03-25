using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MobilePhone :BasePhone
    {
        //* işareti değerin protected olduğu anlamına gelir. Protected nesnelere sadece miras alan sınıflar üzerinden ulaşılabilir.
        private bool _hascam;

        public bool HasCam
        {
            get { return _hascam; }
            set { _hascam = value; }
        }

        public bool isTouched { get; set; }


        public MobilePhone()
        {
            base._phoneType = "Mobile Phone"; 
        }

        public MobilePhone(bool hascam, bool istouched, string brandd, string connnection) : base(brandd, connnection)
        {
            base._phoneType = "Mobile Phone";
            HasCam = hascam ;
            isTouched = istouched;
        }
        // : base() => Miras aldığımız sınıfın ctoruna ulaşmak için kullanılan keyword'dür.



        public string TakePhoto()
        {
            if (HasCam)
            {
                return "You can take photo";
            }
            else
            {
                return "you can not take photo";
            }
        }
        public override string ConnectionStatus()
        {
            return "kablosuz bağlantı kuruldu..";
        }

        public override string Call()
        {
            return "Mobil Phone Çalıyor..";
        }

        //Eğer basedeki fonsiyonun aynısını kullanacaksanız fonsiyonu ezmenize gerek yoktur.



        public override string ToString()
        {
            return _phoneType;
        }
    }
}
