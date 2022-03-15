using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    //Yapıcı metot ==> Nesne oluşturulurken, proplara değer atama vb işlemlerin gerçekleştirildiği kısımdır. Ctorun tanımlandığı sınıftan bir instance alınırken,
    //bu esnada gerçekleştirilecek işlemleri yapan metotdur. 
    //Bu metotlar tipik void metodu gibi çalışırlar. Geriye herhangi birşey döndürmezler.


    public class araba
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public int Motor { get; set; }


        public araba(string marka, string model, int motor)
        {
            Marka = marka;
            Model = model;
            Motor = motor;
        }
        public araba()
        {

        }
    }
}
