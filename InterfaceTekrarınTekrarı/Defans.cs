using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTekrarınTekrarı
{
    internal class Defans : IFutbolcu
    {
        public string AdSoyad { get; set; }

        public int FormaNo { get ; set ; }

        public byte Agresiflik { get ; set ; }

        public byte Refleks { get ; set ; }

        public byte Dayanılılık { get ; set ; }

        private byte _sutgucu;


        public byte SutGucu
        {
            get { return _sutgucu; }
            set 
            {
                if (value > 2)
                {
                    MessageBox.Show("Defans oyuncusunun şut gücü 2' den fazla olamaz");
                }
                else
                {
                    _sutgucu = value;
                }
                
            }
        }


        public bool MilliMi { get ; set; }

        public void PasVer()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
