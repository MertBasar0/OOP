using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferansAndValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //.NET frameworkünde uygulama üzerinde geçici olarak kullanılan nesneler ram üzerinde tutulur. Ram teknik yapısı itibari ile nesnelerin iki farklı
        //kullanımda tutulduğu görülmektedir. Bunlardan bir tanesi stack diğeri heap'dir.

        //Stack bölümü "value type" olarak adlandırdığımız değer tipleri tutar.(string hariç tüm değişkenler, enum, struct)

        //Heap bölümünde "reference type" olarak adlandırdığımız tipler bulunuyor.(class, string, array, delegate)

        //Value tipler değerlerini kopyalayabilme özelliğine sahipken, reference tiplerde bu iş taşıma olarak gözlemlenmektedir.

        //Bir değerin null olması reference tipler için, o değerin heap bölümünde bir karşılığı yok demektir.

        //Zaten bundan dolayı reference tipler null geçilebilirken, value tipler null geçilememektedir.

        class Ogrenci
        {

            private string _adi;

            public string Adi
            {
                get { return _adi; }
                set { _adi = value; }
            }

            private string _soyadi;

            public string Soyadi
            {
                get { return _soyadi; }
                set { _soyadi = value; }
            }


        }

        struct Student
        {
            //En basit tanımıyla class'ların value type versiyonudur.
            //Struct ile class arasındaki en büyük farklardan bir tanesi struct'lardan yada class'tan kalıtım alamaz. Ancak interface'ler implemente edilebilirler.
            //Eğer bir gün struct mı kullanılmalı class mı kullanılmalı arasında kalırsanız, value type ya da reference type kullanımı bakımından bir problem olmayacak ise
            //16 kb' dan büyük nesneler için class küçük nesneler için struct kullanımı önerilmektedir.


            private string _firstName;

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }



            private string _lastName;      

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }


        }

        private void btn_referenceType_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Mert";
            ogr.Soyadi = "Basar";


            Ogrenci ogr_2 = new Ogrenci();
            ogr_2.Adi = "test";

            MessageBox.Show(ogr.Adi);
            MessageBox.Show(ogr.GetHashCode() + "\n" + ogr_2.GetHashCode());
            //Hash int tipinde sayısal benzersiz bir değerdir. Int tipinde
            //benzersiz bir değer olmasından dolayı nesnelerimizin anahtarı
            //niteliğindedir.

            //Değişken ve nesneleri Hashcode ile aratabilirsiniz.

            //Web sistemlerinde "hash" yöntemi ile girdiğiniz / gönderdiğiniz
            //yada aldığınız veriler şifrelenir.

            //Bir programın aynısını yeniden kodlasanız bile sabit değişkenler 
            //hariç "hash" kodları farklı olacaktır..

            //Nesnelerimizin hash kodunu bize gethashcode fonsksiyonu getirir.



            int[] sayilar = { 12, 15, 16 };
            int[] sayilar2 = sayilar;
            sayilar2[1] = 25;
            MessageBox.Show(sayilar[1].ToString());
        
        }

        private void btn_valueType_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.FirstName = "Mert";
            st.LastName = "Başar";

            Student st_2 = st;
            st_2.FirstName = "yasin";
            MessageBox.Show(st.FirstName);
            MessageBox.Show(st.GetHashCode() + "\n" + st_2.GetHashCode());

            ///1.46 03.03.2022
        }
    }
}
        