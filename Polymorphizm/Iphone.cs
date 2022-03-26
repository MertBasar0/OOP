using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    public class Iphone : BasePhone
    {
        public override void CallSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = @"C:\Users\Lenovo\source\repos\OOP\Polymorphizm\bin\Debug\Sounds\iphone.wav";
            soundPlayer.Play();
        }
    }
}
