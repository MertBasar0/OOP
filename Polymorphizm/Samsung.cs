using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Environment.CurrentDirectory + "\\Sounds\\samsung.wav"; ;
            soundPlayer.Play();
        }
    }
}
