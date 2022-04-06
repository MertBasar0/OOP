using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ENUM
        //Kişilere sabit seçenekler sulmak için kullanılan bir değer tiptir. Seçenekleri kontrol altında tutup uygulamanızın güvenliğini sağlar. Uygulamayı kendi
        //kontrolünüzde yürütebilirsiniz. Bu sebeple uygulama içerisinde herhangi bir sürprize yer bırakmadan çok performanslı ve cok daha güvenli bir yapı oluşturmuş olur.

        //Enumlar tamamen geliştiriciye yönelik nesnelerdir.
        //Bir enum 'un yazı değerini teslim etmek için kullanılan metot Enum.GetNames() metodudur.
        //Metinsel ya da sayısal ifade olarak tanımlanan enumu nesne olarak almak için Enum.Parse() metodu kullanılır.

        //Bir enum arka planda sayısal değer tutar. Bu değerler varsayılan olarak secilen değerin index değeridir.ve tipleri int dır.
        //Ancak siz int olarak çok aşırı yer tutuğunu düşünürseniz bunu değiştirebilirsiniz.(stbyte, byte, short, ushort, uint) yada istediğiniz değerden başlatmanız mümkündür.
        //İlk eleman 5. indexden başlasın gerisi otomatik devam etsin diyebilirsiniz. İstersen bütün enumlara manuel olarak tek tek değer atamasıda yapabilirsiniz.

        //Enum.Parse() fonsiyonu çağırılır ve int bir değişkene atanırsa seçili enumun
        //index değerini elde edebilirsiniz.

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_depart.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.AdSoyad = txt_Ad.Text;
            p.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmb_depart.Text);

            int seciliEnumIndex = (int)Enum.Parse(typeof(Departmanlar),cmb_depart.Text);

            Departmanlar Cikacak;
            bool sonuc = Enum.TryParse<Departmanlar>(cmb_depart.Text, out Cikacak);

            if (sonuc)
            {
                switch (p.Departman)
                {
                    case Departmanlar.Yazilim:
                        MessageBox.Show("Hoşgeldin yazılımcı");
                        break;
                    case Departmanlar.GrafikTasarim:
                        MessageBox.Show("Hoşgeldin tasarımcı");
                        break;
                    case Departmanlar.InsanKaynaklari:
                        MessageBox.Show("hoşgeldin ik'cı");
                        break;
                    case Departmanlar.Muhasebe:
                        MessageBox.Show("Hoşgeldin Muhasebeci");
                        break;
                }
                MessageBox.Show("Personel departmani =>"+Cikacak.ToString()+" "+seciliEnumIndex.ToString());
            }
           
        }
    }
}