using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_ICOMPARER
{
    class Takim:IComparable<Takim>
    {
        //Eğer oluşturmuş olduğunuz class tipindeki değerleri içerisine alan bir liste tanımlasaydınız ve bu liste içerisinde
        //sort metodunu çağırsaydınız sistem size hata verecekti. Hata şudur; Eğer liste içerisinde sıralama yapmak istiyorsanız
        //muhakkak "IComparable" interface'ini implemente etmek gerekir.
        public string Adi { get; set; }

        public byte Puani { get; set; }

        public sbyte Averaji { get; set; }


        public int CompareTo(Takim other) 
        {
            if (this.Puani<other.Puani)
            {
                return 1;
            }
            else if(this.Puani>other.Puani)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        class PuaniKucuktenBuyugeSirala : IComparer<Takim>
        {
            public int Compare(Takim x, Takim y)
            {
                return -x.CompareTo(y);
            }
        }

        class AverajaGoreKucuktenBuyugeSiralama : IComparer<Takim>
        {
            public int Compare(Takim x, Takim y)
            {
                if (x.Averaji<y.Averaji)
                {
                    return 1;
                }
                else if (x.Averaji>y.Averaji)
                {
                    return -1;
                }
                else
                {
                    return 0;
                } 
            }
        }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
