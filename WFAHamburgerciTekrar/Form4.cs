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
            foreach (var item in Form1.siparisler)
            {
                lstSiparisler.Items.Add(item);  
                toplamTutar += item.ToplamTutar;
            }
            lblCiro.Text = toplamTutar.ToString("C2");
        }

        private void btn_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
