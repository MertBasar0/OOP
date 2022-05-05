using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerciTekrar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int siparisAdet = 0;
            int satilanUrunAdet = 0;
            decimal extraMalzemeGeliri = 0;

            foreach (var item in Form1.siparisler)
            {
                lstSiparisler.Items.Add(item);
                toplamTutar += item.ToplamTutar;
                siparisAdet++;
                satilanUrunAdet += item.Adet;
                foreach (var extra in item.Extras)
                {
                    extraMalzemeGeliri += extra.Fiyati;
                }
            }
            lblCiro.Text = toplamTutar.ToString("C2");
            lblToplamSiparis.Text = siparisAdet.ToString();
            lblSatilanUrunAdet.Text = satilanUrunAdet.ToString();
            lblExtraMalzeme.Text = extraMalzemeGeliri.ToString("C2");

        }

        private void btn_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
