using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SmartPhone : MobilePhone
    {

        public bool FrontCam { get; set; }

        public SmartPhone()
        {
                 
            base._phoneType = "Smart Phone";
            base.HasCam = true;
            FrontCam = true;
        }

        public SmartPhone(bool frontcam, bool hascam, bool istouched, string brand, string connection) : base (hascam,istouched,brand,connection)
        {
            FrontCam = frontcam;
            base._phoneType = "Smart Phone";
        }


        public string VideoCall()
        {
            return "videocall çağrısı yapılıyor..";
        }

        public override string Call()
        {
            return "SmartPhone çalıyor..";
        }

        public override string ConnectionStatus()
        {
            return "kablosuz bağlantı kuruldu..";
        }

        public override string ToString()
        {
            return _phoneType;
        }
    }
}
