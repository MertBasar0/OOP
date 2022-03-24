using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Seald
{

    //Struct yapısı gereği değer tipli olduğundan dolayı ram'in stack alanında tutulur. Her ne kadar class'a yapı olarak benzesede ayrıldığı özellikler mevcuttur.
    //1) Struct yapılarda boş yapıcı(ctor) tanımlanmaz.
    //2) Yapıcı metot kullanmak istiyorsanız mutlaka parametre almak zorunda olduğunu unutmayın. Çünkü Stack alanında açılan value typelar null geçilemez..
    //3) Parametreli tanımlanan yapıcı metot içerisinde değere başlangıç değeri atama zorunluluğunuz vardır.
    //4) Struct yapılarda boş yapıcı metot tanımlanamadığından dolayı new anahtar kelimesi kullanılmaz diye bir kavram yoktur.. class yapılarında yapı derlenirken eğer default olarak boş
    //bir yapıcı metot oluşturduysanız, yapı derlendiğinde otomatik olarak geri değer döndürmeyen "void ctor" metodunu kendi çalıştıracaktır.
    public struct Kitap
    {

        public int Id { get; set; }

        public string Adi { get; set; }

        public string Turu { get; set; }

        public string ISBNNo { get; set; }

        public string YazarAdi { get; set; }

        public Kitap(int id, string adi, string turu, string isbnNo, string yazarAdi)
        {
            Id = id;
            Adi = adi;
            Turu = turu;
            ISBNNo = isbnNo;
            YazarAdi = yazarAdi;
        }
    }
}
