using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace OOP_SpecialCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Öncelikle aşağıda yazmış olduğum bütün tipler özel bir koleksiyondur.
        //Bu koleksiyonların bu kadar farklı olma nedeni kendi aralarında sistem içerisinde performans farklarına neden olmalarıdır.
        //Ancak aşağıda bulunan bütün koleksiyonlar ortak noktalarından olan bir durum bizim için çok da performanslı değildir. Bu durum içerisinde 
        //"object" tipinde değer alması durumudur. Bu ilk etapda avantaj olarak görünsede süreç içerisinde dezavantaj olarak bizlere geri döner.
        //Bu durumlardan bir tanesi (type-safety) tip güvenliğinin yok sayılmasıdır. İstenilen tipte bir veri koleksiyonu içerisinde yerleştirilebilir
        //Bir diğeri ise size söylediğimiz (boxing-unboxing) işlemidir. Böylece koleksiyon içerisinde veriler üzerinde işlem yapmaya çalıştığımızda 
        //sisteme ekstra yük getirme durumuda kalmaz.


        private void btn_HashTable_Click(object sender, EventArgs e)
        {
            //System.Collections.Hashtable

            //Anahtar değer ikiliği mantığı yürütülür. Hashtable veri olarak anahtar ve değer kısmında object veri tipinde veri alır.
            //Genellikle büyük boyutlu koleksiyonlar için kullanılır. (Örneğin: Northwind veri tabanındaki products tablosu)


            //Hashtable, içerisindeki değerleri ram'deki referans değerlerine göre sıralar.
            //Hashtable key mantığı gerçek bir key mantığıdır. Unique olamk zorundadır ve kullanılan değeri bir daha kullanamazsınız.


            Hashtable anahtardegerdizisi = new Hashtable();
            anahtardegerdizisi.Add("isim", "3154 yazilim");
            anahtardegerdizisi.Add("sayi", 15);
            anahtardegerdizisi.Add("form", new Form { Width = 300, Height = 300 });

            //((Form)anahtardegerdizisi["form"]).Show();


            anahtardegerdizisi.Add(7, "James Bond");

            anahtardegerdizisi.Add(10, "Alex");

            anahtardegerdizisi.Add(23, "Sabri");

            MessageBox.Show(anahtardegerdizisi[10].ToString());

            anahtardegerdizisi.Remove(23); //verilen keydeki karşılığı olan value'u siler.


            if (anahtardegerdizisi.ContainsKey(23)) //anahtardegerdizisi.ContainsValue değer üzerinden de varlık kontrolü yapılabilir.
            {
                MessageBox.Show("Mevcut");
            }
            else
            {
                anahtardegerdizisi.Add(23, "Ali");
            }


            foreach (var item in anahtardegerdizisi.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar : {0} - Değer: {1}", item, anahtardegerdizisi[item]));
            }
        }

        private void btn_ListDictionary_Click(object sender, EventArgs e)
        {
           // System.Collections.Specialized namespace altından gelir.
           //Bu koleksiyon, Hashtable'dan daha az gelişmiştir. Tıpkı hashtable gibi key -value mantığı ile çalışır.
           //Daha az gelişmiş olmasının nedeni ContainsKey ve ContainsValue gibi metotlar yoktur.

            ListDictionary anahtardegerdizisi =new ListDictionary();
            anahtardegerdizisi.Add(1, "İstanbul");
            anahtardegerdizisi.Add(2, "Ankara");
            anahtardegerdizisi.Add(3, "İzmir");
            anahtardegerdizisi.Add(4, "Bursa");
            anahtardegerdizisi.Add(5, "Eskişehir");

            foreach (var item in anahtardegerdizisi.Keys)
            {
                listBox1.Items.Add($"{item}  {anahtardegerdizisi[item]}");
            }

        }

        private void btn_HybridDictionary_Click(object sender, EventArgs e)
        {
            //Hashtable ve listdictionary manntığı gibi key-values mantığı ile çalışır.
            //Ancak msdn'in söylemine göre eğer koleksiyonuz küçükse (eleman sayısı 10 altı ise) listdictionary ile oluşturulur.
            //Koleksiyonunuz 10'un üzerine çıktığı anda hashtable döner..
            //Koleksiyonunuzun büyüklüğüne göre yapacağınız doğru bir koeksiyon seçimi size performans olarak geri döner.
            HybridDictionary anahtardegerdizisi =new HybridDictionary();    

            anahtardegerdizisi.Add(1, "İstanbul");
            anahtardegerdizisi.Add(2, "Ankara");
            anahtardegerdizisi.Add(3, "İzmir");
            anahtardegerdizisi.Add(4, "Bursa");
            anahtardegerdizisi.Add(5, "Eskişehir");
            anahtardegerdizisi.Add(6, "İstanbul");
            anahtardegerdizisi.Add(7, "Ankara");
            anahtardegerdizisi.Add(8, "İzmir");
            anahtardegerdizisi.Add(9, "Bursa");
            anahtardegerdizisi.Add(10, "Eskişehir");
            anahtardegerdizisi.Add(11, "İstanbul");
            anahtardegerdizisi.Add(12, "Ankara");
            anahtardegerdizisi.Add(13, "İzmir");
            anahtardegerdizisi.Add(14, "Bursa");
            anahtardegerdizisi.Add(15, "Eskişehir");

            foreach (var item in anahtardegerdizisi)
            {
                listBox1.Items.Add($"{item}  {anahtardegerdizisi}");   
            }
        }
    }
}
