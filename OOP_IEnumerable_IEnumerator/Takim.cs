using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IEnumerable_IEnumerator
{
    public class Takim : IEnumerable
    {
        Futbolcu [] takimOyunculari { get; set; }

        public int FutbolcuSayisi { get { return this.takimOyunculari.Length; } }

        public double FormaNumaraOrtalamasi { get; set; }

      
        public double FormaNumaraOrtalamasi
        {
            get
            {
                double ort = 0;
                IEnumerator sayac = takimOyunculari.GetEnumerator();
                while (sayac.MoveNext())
                {
                    ort += ((Futbolcu)sayac.Current).FormaNumarasi;
                    return ort / FutbolcuSayisi;
                }
            }
        }



        public Takim(params Futbolcu[] Futbolcular) 
        {
            this.takimOyunculari = Futbolcular;
        }


        public IEnumerator GetEnumerator()
        {
            return new FutbolcuEnumerator(this.takimOyunculari);
        }
    }

    class FutbolcuEnumerator : IEnumerator
    {
        //1) Hangi dizi üzerinde dönüleceğini belirtmek için bir değişken oluştur.

        Futbolcu[] donulecek;

        //2)Dönmeye kaçıncı index'den başlayacak ? ilk değer -1 'dir, -1 olmasının nedeni foreach döngüsü çalışmaya arka tarafta moveNext metodu ile başlaması prensibidir.
        //MoveNext metodu içerisinde öncelikle siradaki eleman varmı yok mu diye bakar. Eğer var ise current property'si harekete geçer.

        int index = -1;

        //3)Enumaretor class içerisindeki dönülecek dizisi dışarıdan nasıl gönderilir.

        public FutbolcuEnumerator (Futbolcu[] HangiDiziyeDoneyim)
        {
            this.donulecek = HangiDiziyeDoneyim;
        }

        public object Current 
        { 
            get 
            { 
                return this.donulecek[index]; 
            } 
        }

        public bool MoveNext()
        {
            index++;
            return this.index < this.donulecek.Length;
            //MoveNext Metodu => SIrada bir eleman var mı yok mu diye kontrol eder.. Eğer eleman varsa true döner ve döngü devam eder false dönerse döngü biter.
        
        }

        //Reset => Döngü bittiği anda devreye girer ve Turnilye sıfırlar
        public void Reset()
        {
            this.index = -1;
        }


    }
}
