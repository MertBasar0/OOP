using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class Defans : IFutbolcu
    {
        public string AdiSoyadi { get ; set ; }
        public string FormaNumarasi { get ; set ; }
        private byte _sutgucu;

        public byte SutGucu
        {
            get { return _sutgucu; }
            set 
            {
                if (value > 70)
                {
                    MessageBox.Show("Defans oyuncusunun şut gücü 70 den büyük olamaz");
                }
                else
                {
                    _sutgucu = value;
                }
                
            }
        }

        public byte Refleks { get ; set ; }
        public byte Dayaniklilik { get ; set ; }
        public byte Agresiflik { get ; set; }
        public bool MilliMi { get ; set ; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return AdiSoyadi;
        }
    }
}
