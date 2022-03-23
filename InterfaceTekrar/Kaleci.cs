using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTekrar
{
    public class Kaleci : IFutbolcu
    {
        public int FormaNo { get ; set ; }
        public string AdiSoyadi { get ; set ; }

        private byte _sutGucu;

        public byte SutGucu 
        {
            get { return _sutGucu; }  
            set 
            {
                if (_sutGucu>3 && _sutGucu<0)
                {
                    MessageBox.Show("Kalecinin şut gücü 2' den fazla ve 0 dan düşük olamaz..");
                }
                else
                {
                    _sutGucu = value;
                }
                
            } 
        }

        public byte Dayaniklilik { get ; set ; }
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
