using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Events (olayları) Kullanıcının fare ile tıklaması olayıdır klavyeden bir tuşa basması gibi işletim sistemleri üzerinden gerçekleştirdiği eylemdir. Bir birleşen
        //üzerinde meydana gelen olayları takip eden yapılara event denir.

        //Event ilgili olay gerçekleştiği anda tetiklenir. Olay gerçekleştikten sonra hangi işlemlerin yapılacağı olay yöneticileri için delegeler ile temsil edilir.
        //Bir kullanıcının fare ile tıklanması click olayıdır. Bir tuşa basma keypress, Bu olayların sonucunda neler yapılması gerektiğini belirtiyoruz..

        private void btn_calistir_Click(object sender, EventArgs e)
        {
            //Tıpkı delegete örneklerinde olduğu gibi  burada "+=" bir olayı metoda bağlamak için kullanılır. "-=" ise çıkarmak için kullanılır.


            //Yalnız bu nokta dikkat etmeniz gereken bir noktada olayların bağlanacağı metotların imza yapıları olayın türü olan delege ile aynı olmalıdır. Buradan ne çıkarılır
            //eventları kullanırken muhakkak bir delegete tanımlanmalıdır. Event önünde erişim bildirgeci vs tanımlanabilir.

            Araba araba = new Araba(100, "bmw");
            araba.HizAsimi += new HizAsimiEventHandler(Hizlimit);
            for (int i = 0; i <= 7; i++)
            {
                araba.Hiz += 10;
                lstSonuc.Items.Add("Arabanın şuanki hizi şudur: " + araba.Hiz);
            }
        }

        void Hizlimit()
        {
            lstSonuc.Items.Add("Araç hız limiti aşıldı");
        }
    }
}
