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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Form1.Menuler.Add(new menu { MenuAdi = txt_menuAdi.Text, Fiyat = nmr_fiyat.Value});
            Temizlik.Temizle(this.Controls);
            MessageBox.Show("Başarılı şekilde eklendi");
        }
    }
}
