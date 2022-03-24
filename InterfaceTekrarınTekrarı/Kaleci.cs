using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTekrarınTekrarı
{
    public class Kaleci : IFutbolcu
    {
        public string AdSoyad { get ; set ; }

        public int FormaNo { get ; set ; }

        private byte _agresiflik;

        public  byte Agresiflik
        {
            get { return _agresiflik; }
            set 
            {
                if (value > 2)
                {
                    MessageBox.Show("Kalecinin agresiflik değeri 2' den büyük olamaz..");
                }
                else
                {
                    _agresiflik = value;
                }
                
            }
        }


        public byte Refleks { get ; set ; }

        public byte Dayanılılık { get ; set ; }

        public byte SutGucu { get ; set ; }
        
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
            return AdSoyad;
        }
    }
}
