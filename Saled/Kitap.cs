using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saled
{
    public class BaseBOOK
    {
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual void GetLog()
        {

        }

        public virtual void GetUser()
        {

        }
    }


    public class Kitap :BaseBOOK
    {
        //Selad anahtar sözcüğü üstüne miras alabilir fakat kendi üstünden miras veremez.

        public int Id { get; set; }

        public string Ad { get; set; }

        public string Turu { get; set; }

        public string YazarAdi { get; set; }

        public int IsbnNo { get; set; }



        public override void GetLog()
        {
            base.GetLog();
        }

        public sealed override void GetUser()
        {
            base.GetUser();
        }
    }


    class CreateBook : Kitap
    {
        public override void GetLog()
        {
            base.GetLog();
        }

        //GetUser() metodu sealed olarak işaretlendiğinden (mühürlendiğinden) dolayı override ile erişime kapalıdır.
        //Proplar da seald olarak işaretlenebilirler.
    }
}
