using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    //Nesnelerin üyelerine yapılan erişimi kontrol etmek ve kontrolün nesnelerin kendisi tarafından yapılmasını sağlamaktır. Amac field'ları private  yaparak bu alana dışarıdan erişimi
    //kapatıyoruz ve get-set metotlarıyla kontrol sağlamayı hedefliyoruz..

    //Arka planda kodların gizlenmesi : oluşturulan class içerisinde kullanıcının işlemleri daha kolay gerçekleştirmesi için bazı işlemleri birleştirerek (kapsülleyerek)
    //tek işlem gibi gösterir.

    //Örnek : Veri Tabanı Bağlantı İşleminde, sadece bağlantı değişkeninin  open metot ile kullanarak bağlantıyı açarız. Fakat class içerisinde kullanıcıdan aldığı
    //parametreyi kullanarak bağlantı gerçekleştirmenin bir çok yolu mümkündür.

    //Değişkene tam erişimi kapat: Class içersinde oluşturduğunuz global değişkenlere dışarıdan erişmek için public olarak tanımlama yaparız. Fakat bazen bu değişkenlerin değerlerini
    //değiştirmek istemeyebiliriz. Fakat kullanmak isteyebiliriz. Bu durumda değişkeni kapsüllemeniz gerekli.

    //Yani bu değişkeni private olarak tanımlamak ve bir read-only prop'la bu değişkenin yazma iznini ortadan kaldırmak.
    public class Urun
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set 
            {
                if (value%2 == 0)
                {
                    MessageBox.Show("Id tek sayı olmalıdır..");
                }
                else
                {
                    _id = value;
                }
                 
            }
        }


        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        //Dışarıdan girilen fiyat bilgisi 0 altında ise girilen değeri kabul etme ve mesaj vererek "fiyat bilgisi 0 altında olamaz".

        private int _fiyat;

        public int Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value > 0)
                {
                    _fiyat = value;
                }
                else
                {
                    MessageBox.Show("Fiyat 0 veya negatif değer alamaz");
                    _fiyat = -1;
                }
                //public Urun(int id, string ad, int fiyat)
                //{
                //    Id = id;
                //    Ad = ad;
                //    if (fiyat > 0)
                //    {
                //        Fiyat = fiyat;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Fiyat negatif değer alamaz..");
                //    }
                //}

                //public Urun()
                //{

                /////////////////BURADA CTOR İÇİNDE KONTROL YADA PROP İÇİNDE KONTROL ARASINDA NE TÜR BİR FARK DOĞDUĞU SORULMALI.. //////////////////////
            }

        }

    }
}
