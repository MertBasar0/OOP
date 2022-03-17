using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal exMalzemeGeliri = 0;
            int satisAdedi = 0;
            foreach (Siparis item in Form1.EskiSiparisler)
            {
                ciro += item.ToplamTutar;
                satisAdedi += item.Adet;
                foreach (Extra ex in item.ExtraMalzemeler)
                {
                    exMalzemeGeliri += ex.Fiyat;
                } 
            }

            lblCiro.Text =ciro.ToString();
            lbl_toplamSiparis.Text = lst_siparisler.Items.Count.ToString();
            lbl_ExtraMalzemeler.Text =exMalzemeGeliri.ToString();
            lbl_SatilanURunAdedi.Text =satisAdedi.ToString();

            foreach (Siparis item in Form1.EskiSiparisler)
            {
                lst_siparisler.Items.Add(item);
            }
            
        }
        
    
    }
}
