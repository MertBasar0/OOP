using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    //Eğer nesneye bağımlı işlemler gerçekleştiriyorsanız yani amaç sadece belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise ilgili sınıfı
    //static olarak işaretleyebilirsiniz. İçerisindeki tüm öğelere instance'dan (stack alanındaki nesne genel ismi) bağımsız olarak ulaşabilirsiniz.
    //Static sınıflar içerisinde sadece static öğeler barındırılır.(field, prop, metot)
    //Static bir sınıf başka bir classtan kalıtım alamaz. Ancak C# mantığı gereği tüm sınıflar System.object sınıfından kalıtım alırlar. Static sınıflarda bu işleme dahildir.
    //Static sınıflar Math, File sınıflarıdır. Aynı amaca hizmet etmektedirler.(math => matematiksel işlemlerin bir arada tutulmasını, File => Dosya bazlı işlemlerin bir arada
    //tutulmasını) hizmet eden öğelere hızlı erişim önemli olduğu için static tanımlanmış sınıflardır.
    //

    //Ancak her sınıf static olarak işaretlenmemelidir. Tanımlamış olduğunuz her static sınıf performans kaybı olarak dönecektir.


    public static class FizikKütüphanesi
    {
        //58.52
    }
}
