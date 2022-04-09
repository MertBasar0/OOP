using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventHandlerTekrar;

namespace EventHandlerTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  Events (olaylar) kullanıcının fare ile tıklaması olayıdır. Klavyeden bir tuşa basması gibi işletim sistemi
        üzerinden gerçekleştirdiği eylemlerdir. Bir birleşen üzerinde meydana gelen olayları takip eden yapılara event
        denir.


            Event ilgili olay gerçekleştiği anda tetiklenir. Olay gerçekleştikten sonra hangi işlemlerin yapılacağı olay
        yöneticileri için delegeler ile temsil edilir.. Bir kullanıcının fare ile tıklaması (click) olayıdır. Bir tuşa
        basma (keypress), bu olayların sonucunda neler yapılması gerektiğini belirtiyoruz.
        */
        private void btn_calistir_Click(object sender, EventArgs e)
        {

            /*  
                Tıpkı delegete örneklerinde olduğu gibi burada "+=" bir olayı metoda bağlamak için kullanılır. "-="
            ise çıkarmak için kullanılır.
            */


            /*
                Yalnız bu noktada dikkat edilmesi gereken nokta olayların bağlanacağı metların imza yapıları olayın türü
            olan delege ile aynı olmalıdı. Buradan ne çıkarılır; eventları kullanırken muhakkak bir delegete tanımlanmalıdır.
            Event önünde erişim bildirgeci vs tanımlanabilir..
             */


            //Araba araba = new Araba(70, "BMW");
            //araba.HizAsimi += new HizAsimiEventHandler(Hizlimit);
            //for (int i = 0; i < 7; i++)
            //{
            //    araba.Hiz += 10;
            //    lst_sonuc.Items.Add("Arabanın şuanki hızı şudur: " + araba.Hiz);
            //}

            Product product1 = new Product(1,"Bilgisayar",8000,30);
            product1.StokAzaldi += new StokAzaldiEvent(product1UrunAzalmaFonksiyonu);

            for (int i = 0; i < 15; i++)
            {
                product1.UnitInStock -= 1;
                lst_sonuc.Items.Add(product1.Name + product1.UnitInPrice + "stok :" + product1.UnitInStock.ToString());
            }
            
        }

        private void product1UrunAzalmaFonksiyonu()
        {
            lst_sonuc.Items.Add("!!!UYARI stok azaldı..");
        }

        void Hizlimit()
        {
            lst_sonuc.Items.Add("Araç hız limiti aşılmıştır..");
        }
    }
}
