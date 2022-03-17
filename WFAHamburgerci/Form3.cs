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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form1.extralar.Add(new Extra { ExtraAdi = txt_ad.Text, Fiyat = nmr_fiyat.Value });
            Temizlik.Temizle(this.Controls);
            MessageBox.Show("Başarılı şekilde eklendi..");
        }
    }
}
