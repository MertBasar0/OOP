using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Seald
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Struct yapılarda boş yapıcı metot oluşturulamadığından dolayı newlememize gerek yoktur.
        //Değişkenlere başlangış değeri atamadan geçtiğimiz durumlarda runtime esnasında default değerler atanır. int lar için 0, bool değişkenler için false vb.

        Kitap k;
        private void Form1_Load(object sender, EventArgs e)
        {
            k.Adi = "Müptezeller";
            k.Turu = "Roman";
            k.ISBNNo = "23124215";
            k.YazarAdi = "Ali Taş";


            Kitap k2 = new Kitap();
            k2.Adi = "test";
            k2.ISBNNo = "12123123";
            k2.Turu = "polisiye";
            k2.YazarAdi = "ahmet taş";


            Kitap k3 = new Kitap()
            {
                Adi = "sefiller",
                Turu = "roman",
                YazarAdi = "safasf",
                ISBNNo = "12312313"
            };

            Kitap k4 = new Kitap(1,"afsafsa","polisiye","14125152","mert basar");
        }
    }
}
