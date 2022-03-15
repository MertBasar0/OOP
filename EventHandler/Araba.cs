using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public delegate void HizAsimiEventHandler();
    
    public class Araba
    {
        public Araba(int hiz, string model)
        {
            Hiz = hiz;
            Model = Model;
        }

        //Yeni bir olay tanımlamak için event deyimi kullanılır. Olayları tetiklemek için olayın ismi kullanılır..
        
        public event HizAsimiEventHandler HizAsimi;

        private int _hiz;

        public int Hiz      
        {
            get { return _hiz; }
            set 
            {
                _hiz = value;
                if (value>120)
                {
                    HizAsimi();
                }
            }
        }


        private int _model;

        public int Model
        {
            get { return _model; }
            set { _model = value; }
        }


    }
}
