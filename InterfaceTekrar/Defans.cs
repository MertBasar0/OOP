using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace InterfaceTekrar
{
    public class Defans : IFutbolcu
    {
        public int FormaNo { get ; set ; }
        public string AdiSoyadi { get ; set ; }
        private byte _sutGucu;

        public byte SutGucu
        {
            get { return _sutGucu; }

            set
            {
                if (_sutGucu > 60)
                {
                    MessageBox.Show("Defans oyuncusunun şut gücü 2' dan düşük olmalıdır..");
                }
                else
                {
                    _sutGucu = value;
                }
            }
        }

        public byte Dayaniklilik { get; set ; }
        public byte Agresiflik { get ; set ; }
        public byte Refleks { get ; set ; }
        public bool MilliMi { get ; set ; }

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
            return AdiSoyadi;
        }
    }
}
