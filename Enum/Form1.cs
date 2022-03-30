using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enum.Properties;

namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Enum
        //Kişilere sabit seçenekler sunmak için kullanılan bir değer tiptir. Seçenekleri kontrol altında tutup uygulamanızın güvenliğini sağlar.
        //Enumlar tamamen geliştiriciye yönelik nesnelerdir.
        //Bir enumun metinsel değerini teslim edecek olan metot Enum.GetName() metodudur.
        //Eğer yazılı bir metinsel ifadeniz var ve buna karşılık gelen bir enumunuz varsa bunu getirmek için Enum.Parse() metodu kullanılır.
        //Bir enum arka planda sayısal değer tutar. Bu değerler varsayılan olarak seçilen değerin index değeridir. Tipleri int dır.
        //Ancak int olarak çok yer tutuğunu düşünürseniz bunu değiştirebilirsiniz.(stbyte,byte,short,ushort,uint) yada istediğiniz değerden başlatmanız mümkündür.
        //ilk index 5 den başlasın şeklinde ayarlanabilir. İstenirse enumların tamamına indexleri atanabilir.

        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.AdiSoyadi = txt_Ad.Text;
            p.Departman =(Departmanlar)Enum.Parse(typeof(Departmanlar), cmb_depart.Text);
        }
    }
}
