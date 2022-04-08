using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTekrar
{
    public delegate void HizAsimiEventHandler();

    public class Araba
    {

        public Araba(int hiz, string model)
        {
            Hiz = hiz;
            Model = model;
        }

        //Yeni bir olay tanımlamak için event deyimi kullanılır. Olayları tetiklemek için olayın ismi kullanılır.

        public event HizAsimiEventHandler HizAsimi;

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set 
            { 
                _hiz = value;
                if (_hiz>=120)
                {
                    HizAsimi();
                }
            }
        }


        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


       
    }
}
