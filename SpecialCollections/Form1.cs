using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*  Öncelikle aşağıda yazmış olduğum bütün tipler özel bir koleksiyondur.
Bu koleksiyonların bu kadar farklı olma nedeni kendi aralarında sistem içerisinde performans farklarına neden olmalarıdır.
Ancak aşağıda bulunan bütün koleksiyonlar ortak noktalarından olan bir durum bizim için çok da performanslı değildir.
Bu durum İçerisinde "object" tipinde değer alması durumudur. Bu ilk etapta avantaj olarak görülsede süreç içerisinde dezavantaj
olarak bizlere döner. Bu durumlardan bir tanesi (type-safety) tip güvenliğinin yok sayılmasıdır. İstenilen tipte bir 
veri koleksiyon içerisine yerleştirilebilir. Bir diğeri ise size söylediğimiz (boxing-unboxing) işlemidir. Böylece
koleksiyon içerisinde veriler üzerinde işlem yapmaya çalıştığımızda sisteme ekstra yük getirme durumunda kalmaz. */




        private void btn_hashTable_Click(object sender, EventArgs e)
        {
            //System.Collections.Hashtable using'e eklemeniz gerekir.
            //Anahtar değer ikiliği mantığı yürütülür. Hashtable veri olarak anahtar ve değer kısmında object veri tipinde veri alır.
            //Genellikle büyük boyutlu koleksiyonlar için kullanılır. ("Örnek : Northwind veri tabanındaki products tablosu")

            //Hashtable, içerisindeki değerleri ram'deki referans değerlerine göre sıralar.
            //Hashtable key mantığı gerçek bir key mantığıdır. Unique olmak zorundadır ve kullanılan değeri bir daha kullanamazsınız.

            Hashtable anahtardegerdizisi = new Hashtable();
            anahtardegerdizisi.Add("isim", "3154 yazilim");
            anahtardegerdizisi.Add("sayi", 15);
            anahtardegerdizisi.Add("form", new Form { Width = 300, Height = 300 });

            ((Form)anahtardegerdizisi["form"]).Show();

            anahtardegerdizisi.Add(7, "James Bond");
            anahtardegerdizisi.Add(10, "Alex");
            anahtardegerdizisi.Remove(7);
            foreach (var item in anahtardegerdizisi.Values)
            {
                listBox1.Items.Add(item);
            }
            MessageBox.Show((string)anahtardegerdizisi[7]);

            if (anahtardegerdizisi.ContainsKey(23))
            {
                MessageBox.Show("zaten var..");
            }
            else
            {
                anahtardegerdizisi.Add(23, "Ali");
            }

            
        }

        private void btn_listDictionary_Click(object sender, EventArgs e)
        {
            //System.Collections.Specialized namespace altından gelir.
            //Bu koleksiyon, Hashtable'dan daha az gelişmiştir. Tıpkı hashtable gibi key-value mantığı ile çalışır.
            //Daha az gelişmiş olmasının nedeni ContainsKey ve ContainsValue gibi metotlar yoktur.

            ListDictionary anahtardegerdizisi = new ListDictionary();
            anahtardegerdizisi.Add(1, "istanbul");
            anahtardegerdizisi.Add(2, "ankara");
            anahtardegerdizisi.Add(3, "izmir");
            anahtardegerdizisi.Add(4, "Bursa");
            anahtardegerdizisi.Add(5, "eskişehir");

            foreach (var item in anahtardegerdizisi.Keys)
            {
                listBox1.Items.Add($"{item}  {anahtardegerdizisi[item]}");
            }


        }

        private void btn_hybridDictionary_Click(object sender, EventArgs e)
        {
            //Hashtable ve listdictionary mantığı gibi key-values mantığı ile çalışır.
            //Ancak msdn'in söylemine göre eğer kolleksiyonuz küçükse (eleman sayısı 10 ve altı ise) listdictionary olarak davranır.
            //Koleksiyonunuz 10'un üzerine çıktığı anda hashtable döner.
            //Koleksiyonunuzun büyüklüğüne göre yapacağınız doğru bir koleksiyon seçimi size performans olarak geri dönecektir.

            HybridDictionary anahtardegerdizisi = new HybridDictionary();
            anahtardegerdizisi.Add(1, "istanbul");
            anahtardegerdizisi.Add(2, "ankara");
            anahtardegerdizisi.Add(3, "izmir");
            anahtardegerdizisi.Add(4, "Bursa");
            anahtardegerdizisi.Add(5, "eskişehir");
            anahtardegerdizisi.Add(6, "istanbul");
            anahtardegerdizisi.Add(7, "ankara");
            anahtardegerdizisi.Add(8, "izmir");
            anahtardegerdizisi.Add(9, "Bursa");
            anahtardegerdizisi.Add(10, "eskişehir");

            foreach (var item in anahtardegerdizisi.Keys)
            {
                listBox1.Items.Add($"{item}  {anahtardegerdizisi[item]}");
            }
        }
    }
}
