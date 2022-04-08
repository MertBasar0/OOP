using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Araba araba = new Araba(70, "BMW");
            araba.HizAsimi += new HizAsimiEventHandler(Hizlimit);
            for (int i = 0; i < 7; i++)
            {
                araba.Hiz += 10;
                lst_sonuc.Items.Add("Arabanın şuanki hızı şudur: " + araba.Hiz);  
            }
            
        }



        void Hizlimit()
        {
            lst_sonuc.Items.Add("Araç hız limiti aşılmıştır..");
        }
    }
}
