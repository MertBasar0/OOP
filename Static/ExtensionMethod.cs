using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    //Sürekli iş yapması için kullanılacak fonsiyonları barındırabilmek için bir class oluşturmak istiyorsanız static class şeklinde yazabilirsiniz..


    public static class ExtensionMethod //static ketwordü için erişim bildirgecinin sağı ya da solu tercih edilebilir.
    {
        //Eğer class static olarak işaretlenmişse tüm memberları da static olarak işaretlenmelidir.Class static olarak işaretlenmemişse ve bazı memberları static olarak işaretlenmişse,
        //işaretlenen memberlara nokta operatörüyle ulaşılabiliyorken, işaretlenmemiş memberlara newlendikten sonra ulaşılabilir.
        public static int MyProperty { get; set; }

        public static void KarekterTemizle(TextBox txt)
        {
            string metin = txt.Text;
            metin = metin.ToLower().Replace('i', 'ı').Replace('ç', 'c').Replace('ş', 's').Replace('ğ', 'g').Replace('ü', 'u').Replace('ö', 'o');
            MessageBox.Show(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metin)); //kelime başharflerini büyüttü..

            //2. YOL


            //string newMetin = "";
            //List<char> charList = new List<char>() {'i','ş','ö','ğ','ü','ç'};
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    char k = metin[i];
                //switch(k)
                //{
                //    case 'i':
                //        newMetin +='ı';
                //        break;
                //    case 'ö':
                //        newMetin += 'o';
                //        break;
                //    case 'ü':
                //        newMetin += 'u';
                //        break;
                //    case 'ş':
                //        newMetin += 's';
                //        break;
                //    case 'ğ':
                //        newMetin += 'g';
                //        break;
                //    case 'ç':
                //        newMetin += 'c';
                //        break;
                //    default:  
                //        newMetin += k;
                //        break;
                //}
        }
            //MessageBox.Show(newMetin);
    }
        //Türkçe karakterleri temizleyen bir metot yazınız..
}

