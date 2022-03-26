using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //Abstract class'lar sadece base class olarak davranması (yani miras vermesi) ve kendisinden instance çıkartılmasını istemediğimiz (newlenmesini istemediğimiz)
    //durumlarda kullanılırlar.
    
    //Abstract olarak işaretlediğimiz bir yapı varsa mutlaka override edilmelidirler.

    //Abstract classların en büyük olayı içerisinde abstract oalrak işaretlenmiş olan ya da olmayan metotları barındırabilir.

    //Aynı zamanda Abstract olarak işaretlenmemiş bir class Abstract olarak işaretlenmiş bir metot barındıramaz..

    //Abstract olarak işaretlenmiş metotlar, kalıtım aldığı classta implemente edilerek kullanılacak metotlarıdır. Yani tanımladığımız yerde kod bulundurmazlar.
    //implemente edildikleri yerde gövdeleri yazılır. 

    //Abstract olarak işaretlenmiş classlar farklı classlara implemente edilmek istenildiğinde içinde tanımlanan bütün abstract metotların tanımlanmasını zorunlu kılar.
    //Abstract olarak işaretlenmemiş metotlar varsa böyle bir zorunluluk yoktur..

    public abstract class Enstrüman
    {
        public string Marka { get; set; }

        public string Aciklama { get; set; }

        public abstract string Call();

        //Abstract metotlar PRIVATE olarak tanımlanamazlar. Nedeni; Çünkü private metotlar miras alınan classlarda da görülemezler..

        //Abstract metotlar static olarak tanımlanamazlar, static kavramı class ya da metot özelliği olduğu için instance çıkarmaya gerek yoktur..
        //Static olmayan metotlar instance metotlarıdır.



    }
}
