using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{

    //using içerisinde kullanılarak nesnenin işi biter bitmez garbage collectorler tarafından silinmesini sağlayabiliriz.

    public class BasePhone
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal UnitPrice { get; set; }

        public int BataryaMiliAmper { get; set; }


        public virtual void CallSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation= @"C:\Users\Lenovo\source\repos\OOP\Polymorphizm\bin\Debug\Sounds\default.wav";

            soundPlayer.Play();
        }

    }
}
